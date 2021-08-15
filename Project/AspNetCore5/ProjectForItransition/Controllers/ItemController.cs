using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using ProjectForItransition.Repository.Interface;
using ProjectForItransition.ViewModels.Items;
using ProjectForItransition.ViewModels.Collection;
using ProjectForItransition.Models.Item;

namespace ProjectForItransition.Controllers
{
    [Authorize]
    public class ItemController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ICollectionRepo _collectionRepo;
        private readonly IItemRepo _itemRepo;
        private readonly ITagRepo _tagRepo;

        public ItemController(ICollectionRepo collectionRepo, 
            UserManager<IdentityUser> userManager, 
            IItemRepo itemRepo,
            ITagRepo tagRepo)
        {
            _userManager = userManager;
            _collectionRepo = collectionRepo;
            _itemRepo = itemRepo;
            _tagRepo = tagRepo;
        }

        public IActionResult Index(int? collectionId, int itemId)
        {
            if (collectionId == null)
                return View();
            var collection = _collectionRepo.GetCollectionById((int)collectionId);
            var item = collection.Items.Where(item => item.Id == itemId).FirstOrDefault();
            ShowItemModel model = new ShowItemModel { Item = item, Fields = collection.NameElements, CollectionId = collection.Id };
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(int? collectionId, int itemId, Like like)
        {
            if (collectionId == null)
                return View();
            var collection = _collectionRepo.GetCollectionById((int)collectionId);
            var item = collection.Items.Where(item => item.Id == itemId).FirstOrDefault();
            ShowItemModel model = new ShowItemModel { Item = item, Fields = collection.NameElements, CollectionId = collection.Id };
            return View(model);
        }
        [HttpGet]
        public IActionResult CreateItem(int? collectionId)
        {
            var tags = _tagRepo.GetAllDistinctTags();
            if (collectionId == null)
                return RedirectToAction("Index", "Collection");
            var model = _collectionRepo.GetCollectionById((int)collectionId);
            return View(new ShowCollectionViewModel(model, tags));
        }

        [HttpPost]
        public IActionResult CreateItem(CreateItemViewModel model)
        {
            if (model.CollectionId == null)
                return RedirectToAction("Index", "Collection");

            _itemRepo.CreateItem(model.CreateContentItem(), (int)model.CollectionId);
            _itemRepo.SaveChange();
            return RedirectToAction("ShowCollection", "Collection", new { CollectionId = model.CollectionId });
        }

        [HttpGet]
        public IActionResult DeleteItem(int? itemId, int? collectionId)
        {
            var item = _itemRepo.GetItemById((int)itemId);
            _itemRepo.DeleteItem(item);
            _itemRepo.SaveChange();
            return RedirectToAction("ShowCollection", "Collection", new { CollectionId = collectionId });
        }

        [HttpGet]
        public IActionResult UpdateItem(int? itemId, int? collectionId)
        {
            var tags = _tagRepo.GetAllDistinctTags();
            if (collectionId == null)
                return View();
            var collection = _collectionRepo.GetCollectionById((int)collectionId);
            var item = _itemRepo.GetItemById((int)itemId);
            return View(new ShowItemModel { Item = item, Fields = collection.NameElements, CollectionId = collection.Id, AllTags = tags });
        }

        [HttpPost]
        public IActionResult UpdateItem(UpdateItemViewModel model)
        {
            var updateItem = _itemRepo.GetItemById((int)model.ItemId);
            model.CreateContentItem().CopyTo(updateItem);
            _itemRepo.UpdateItem(updateItem);
            if (_itemRepo.SaveChange())
            {
                return RedirectToAction("Index", "Item", new { collectionId = model.CollectionId, itemId = model.ItemId });
            }
            return View();
        }
    }
}
