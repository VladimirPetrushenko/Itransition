using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;
using ProjectForItransition.Models;
using ProjectForItransition.Repository.Interface;
using ProjectForItransition.ViewModels.Collection;
using ProjectForItransition.Models.Collection;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using ProjectForItransition.Models.Item;

namespace ProjectForItransition.Controllers
{
    [Authorize]
    public class CollectionController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ICollectionRepo _repository;
        private readonly ITagRepo _tagRepo;
        private readonly Cloudinary _cloudinary;

        public CollectionController(ICollectionRepo repository, 
            UserManager<IdentityUser> userManager, 
            ITagRepo tagRepo,
            Cloudinary cloudinary)
        {
            _userManager = userManager;
            _repository = repository;
            _tagRepo = tagRepo;
            _cloudinary = cloudinary;
        }
        
        [AllowAnonymous]
        public IActionResult Index()
        {
            var collections = _repository.GetAllCollections();
            return View(collections);
        }

        [HttpGet]
        public async Task<IActionResult> ShowOwnCollections()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var collections = _repository.GetAllUserCollections(user.Id);
            return View(collections);
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult ShowCollection(int? collectionId)
        {
            var tags = _tagRepo.GetAllDistinctTags();
            var collection = _repository.GetCollectionById((int)collectionId);
            return View(new ShowCollectionViewModel(collection, tags, false));
        }
        
        [AllowAnonymous]
        [HttpPost]
        public IActionResult ShowCollection(FilterItemsViewModel model)
        {
            var tags = _tagRepo.GetAllDistinctTags();
            var collection = _repository.GetCollectionById((int)model.CollectionId);
            model.FilterByNameAndTags(collection);
            SotrItemsAndChangeSortParm(model.Sort, collection);
            return View(new ShowCollectionViewModel(collection, tags, model.NameForFilter, model.TagsForFilter, true));
        }

        [HttpGet]
        public IActionResult CreateCollection(string userName)
        {
            return View(new CreateCollectionViewModel { UserName = userName });
        }

        [HttpPost]
        public async Task<IActionResult> CreateCollection(CreateCollectionViewModel model)
        {
            if (ModelState.IsValid)
            {
                _repository.CreateCollection(await CreateCollectionFromViemModel(model));
                _repository.SaveChange();
                return RedirectToAction("ShowOwnCollections", "Collection");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult UpdateCollection(int collectionId)
        {
            return View(new UpdateCollectionViewModel { Collection = _repository.GetCollectionById(collectionId) });
        }

        [HttpPost]
        public async Task<IActionResult> UpdateCollection(UpdateCollectionViewModel model)
        {
            var updateCollection = _repository.GetCollectionById(model.CollectionId);
            await CopyToWithoutUser(model, updateCollection);
            _repository.UpdateCollection(updateCollection);
            if (_repository.SaveChange())
            {
                return RedirectToAction("ShowOwnCollections", "Collection");
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult DeleteCollection(int? collectionId)
        {
            var collection = _repository.GetCollectionById((int)collectionId);
            _repository.DeleteCollection(collection);
            _repository.SaveChange();

            return RedirectToAction("ShowOwnCollections", "Collection");
        }
        
        private async Task<ContentCollection> CreateCollectionFromViemModel(CreateCollectionViewModel model)
        {
            var collection = new ContentCollection();
            var user = await _userManager.FindByNameAsync(model.UserName);
            collection.Name = model.Name;
            collection.UserId = user.Id;
            collection.UserName = user.UserName;
            collection.Description = model.Description;
            if (model.ImageInput != null)
                collection.Image = new ImageField { PublicId = await UploadImageOnCloud(model.ImageInput) };
            collection.Topic = model.Topic;
            collection.NameElements = model.NameFields == null ?  new List<NameField>()
                    : NameField.CreateListNameFieldWithNamesAndTypes(model.NameFields, model.Types);
            collection.Items = new List<ContentItem>();
            collection.SelectElements = model.SelectField == null ? new List<SelectElement>() 
                    : SelectElement.CreateListSelectElementWithNameAndOption(model.SelectField, model.Options, model.CountSelect) ;
            return collection;
        }
        
        private async Task CopyToWithoutUser(UpdateCollectionViewModel source, ContentCollection collection)
        {
            collection.Name = source.Name;
            collection.Description = source.Description;
            if (source.ImageInput != null)
                collection.Image = new ImageField { PublicId = await UploadImageOnCloud(source.ImageInput) };
            collection.Topic = source.Topic;
            collection.NameElements = source.NameFields == null ? new List<NameField>()
                    : NameField.CreateListNameFieldWithNamesAndTypes(source.NameFields, source.Types);
            collection.SelectElements = source.SelectField.Length == 0 ? new List<SelectElement>()
                    : SelectElement.CreateListSelectElementWithNameAndOption(source.SelectField, source.Options, source.CountSelect);
        }

        private void SotrItemsAndChangeSortParm(SortState sort, ContentCollection collection)
        {
            SortItems(sort, collection);
            ViewBag.NameSortParm = sort == SortState.ItemName ? SortState.ItemName_desc : SortState.ItemName;
            ViewBag.TagSortParm = sort == SortState.Tags ? SortState.Tags_desc : SortState.Tags;
            ViewBag.DateSortParm = sort == SortState.Date ? SortState.Date_desc : SortState.Date;
            ViewBag.IntegerSortParm = sort == SortState.Integer ? SortState.Integer_desc : SortState.Integer;
            ViewBag.StringSortParm = sort == SortState.String ? SortState.String_desc : SortState.String;
            ViewBag.MarkdownSortParm = sort == SortState.Markdown ? SortState.Markdown_desc : SortState.Markdown;
            ViewBag.CheckboxSortParm = sort == SortState.Checkbox ? SortState.Checkbox_desc : SortState.Checkbox;
        }

        private static void SortItems(SortState sort, ContentCollection collection)
        {
            collection.Items = sort switch
            {
                SortState.ItemName => collection.Items.OrderBy(x => x.Name).ToList(),
                SortState.ItemName_desc => collection.Items.OrderByDescending(x => x.Name).ToList(),
                SortState.Tags => collection.Items.OrderBy(x => x.Tags.FirstOrDefault()).ToList(),
                SortState.Tags_desc => collection.Items.OrderByDescending(x => x.Tags.FirstOrDefault()).ToList(),
                SortState.Date => collection.Items.OrderBy(x => x.DateTimeElements.FirstOrDefault()).ToList(),
                SortState.Date_desc => collection.Items.OrderByDescending(x => x.DateTimeElements.FirstOrDefault()).ToList(),
                SortState.Integer => collection.Items.OrderBy(x => x.IntegerElements.FirstOrDefault()).ToList(),
                SortState.Integer_desc => collection.Items.OrderByDescending(x => x.IntegerElements.FirstOrDefault()).ToList(),
                SortState.String => collection.Items.OrderBy(x => x.StringElements.FirstOrDefault()).ToList(),
                SortState.String_desc => collection.Items.OrderByDescending(x => x.StringElements.FirstOrDefault()).ToList(),
                SortState.Markdown => collection.Items.OrderBy(x => x.MarkdownElements.FirstOrDefault()).ToList(),
                SortState.Markdown_desc => collection.Items.OrderByDescending(x => x.MarkdownElements.FirstOrDefault()).ToList(),
                SortState.Checkbox => collection.Items.OrderBy(x => x.CheckboxElements.FirstOrDefault()).ToList(),
                SortState.Checkbox_desc => collection.Items.OrderByDescending(x => x.CheckboxElements.FirstOrDefault()).ToList(),
                _ => collection.Items,
            };
        }

        private async Task<string> UploadImageOnCloud(IFormFile image)
        {
            var result = await _cloudinary.UploadAsync(new ImageUploadParams
            {
                File = new FileDescription(image.FileName,
                    image.OpenReadStream())
            }).ConfigureAwait(false);

            return result.PublicId;
        }

    }
}
