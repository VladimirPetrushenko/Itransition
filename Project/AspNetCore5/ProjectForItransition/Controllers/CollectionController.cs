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
        public IActionResult CreateCollection()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateCollection(ContentCollection collection, CreateCollectionViewModel model)
        {
            if (collection == null)
                return View(collection);
            await FillingCollection(collection, model);
            _repository.CreateCollection(collection);
            _repository.SaveChange();
            return RedirectToAction("ShowOwnCollections", "Collection");
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
        public IActionResult ShowCollection(int? collectionId, SortState sort)
        {
            var tags = _tagRepo.GetAllDistinctTags();
            if (collectionId == null)
                throw new ArgumentException();
            var collection = _repository.GetCollectionById((int)collectionId);
            return View(new ShowCollectionViewModel(collection, tags));
        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult ShowCollection(FilterItemsViewModel model)
        {
            var tags = _tagRepo.GetAllDistinctTags();
            if (model.CollectionId == null)
                throw new ArgumentException();
            var collection = _repository.GetCollectionById((int)model.CollectionId);
            model.FilterByNameAndTags(collection);
            SotrItemsAndChangeSortParm(model.sort, collection);
            return View(new ShowCollectionViewModel(collection, tags, model.NameForFilter, model.TagsForFilter));
        }

        [HttpGet]
        public IActionResult UpdateCollection(int? collectionId)
        {
            if (collectionId == null)
                throw new ArgumentException();
            var collection = _repository.GetCollectionById((int)collectionId);
            return View(collection);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateCollection(ContentCollection collection, CreateCollectionViewModel model)
        {
            var updateCollection = _repository.GetCollectionById(collection.Id);
            await FillingCollection(collection, model);
            CollectionCopyToUpdateColection(collection, updateCollection);
            _repository.UpdateCollection(updateCollection);
            if (_repository.SaveChange())
            {
                return RedirectToAction("Index", "Collection");
            }
            return View(model);
        }

        private static void CollectionCopyToUpdateColection(ContentCollection sourceCollection, ContentCollection updateCollection)
        {
            updateCollection.Name = sourceCollection.Name;
            updateCollection.Description = sourceCollection.Description;
            updateCollection.Topic = sourceCollection.Topic;
            updateCollection.NameElements = sourceCollection.NameElements;
            if (sourceCollection.Image != null)
                updateCollection.Image = sourceCollection.Image;
        }

        [HttpPost]
        public IActionResult DeleteCollection(int? collectionId)
        {
            if (collectionId == null)
                throw new ArgumentException();
            var collection = _repository.GetCollectionById((int)collectionId);
            _repository.DeleteCollection(collection);
            _repository.SaveChange();

            return RedirectToAction("ShowOwnCollections", "Collection");
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

        private async Task FillingCollection(ContentCollection collection, CreateCollectionViewModel model)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            if(model.ImageInput!=null)
                collection.Image = new ImageField { PublicId = await UploadImageOnCloud(model.ImageInput) };
            collection.UserId = user.Id;
            collection.UserName = User.Identity.Name;
            collection.NameElements = NameField.CreateListNameFieldWithNamesAndTypes(model.Names, model.Types);
        }
    }
}
