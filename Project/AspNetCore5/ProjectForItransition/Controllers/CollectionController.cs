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

namespace ProjectForItransition.Controllers
{
    [Authorize]
    public class CollectionController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ICollectionRepo _repository;
        private readonly ITagRepo _tagRepo;

        public CollectionController(ICollectionRepo repository, UserManager<IdentityUser> userManager, ITagRepo tagRepo)
        {
            _userManager = userManager;
            _repository = repository;
            _tagRepo = tagRepo;
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
        public async Task<IActionResult> CreateCollection(ContentCollection model, string[] names, TypeField[] types)
        {
            if (model == null)
                return View(model);
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            model.UserId = user.Id;
            model.Name = User.Identity.Name;
            model.NameElements = NameField.CreateListNameFieldWithNamesAndTypes(names, types); 
            _repository.CreateCollection(model);
            _repository.SaveChange();
            return RedirectToAction("Index", "Collection");
        }

        [HttpGet]
        public async Task<IActionResult> ShowOwnCollections()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var collections = _repository.GetAllUserCollections(user.Id);
            return View(collections);
        }

        [HttpGet]
        public IActionResult ShowCollection(int? collectionId, SortState sort)
        {
            ViewBag.Tags = _tagRepo.GetAllDistinctTags();
            if (collectionId == null)
                throw new ArgumentException();
            var collection = _repository.GetCollectionById((int)collectionId);
            SotrItemsAndChangeSortParm(sort, collection);
            return View(collection);
        }

        [HttpPost]
        public IActionResult ShowCollection(FilterItemsViewModel model)
        {
            ViewBag.Tags = _tagRepo.GetAllDistinctTags();
            if (model.CollectionId == null)
                throw new ArgumentException();
            var collection = _repository.GetCollectionById((int)model.CollectionId);
            FilterView(model.Name, model.TagsForFilter);
            model.FilterByNameAndTags(collection);
            SotrItemsAndChangeSortParm(model.sort, collection);
            return View(collection);
        }

        [HttpGet]
        public IActionResult UpdateCollection(int? id)
        {
            if (id == null)
                throw new ArgumentException();
            var collection = _repository.GetCollectionById((int)id);
            return View(collection);
        }

        [HttpPost]
        public IActionResult UpdateCollection(ContentCollection model, string[] names, TypeField[] types)
        {
            
            var updateCollection = _repository.GetCollectionById(model.Id);
            updateCollection.NameElements = NameField.CreateListNameFieldWithNamesAndTypes(names, types);
            _repository.UpdateCollection(updateCollection);
            if (_repository.SaveChange())
            {
                return RedirectToAction("Index", "Collection");
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult DeleteCollection(int? id)
        {
            if (id == null)
                throw new ArgumentException();
            var collection = _repository.GetCollectionById((int)id);
            _repository.DeleteCollection(collection);
            _repository.SaveChange();

            return RedirectToAction("ShowOwnCollections", "Collection");
        }

        private void FilterView(string name, string[] tags)
        {
            ViewBag.NameForFilter = name;
            ViewBag.TagsForFilter = tags;
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
    }
}
