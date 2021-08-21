using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using ProjectForItransition.Repository.Interface;
using ProjectForItransition.ViewModels.Items;
using ProjectForItransition.ViewModels.Collection;
using ProjectForItransition.Models.Item;
using System.Collections.Generic;

namespace ProjectForItransition.Controllers
{
    [Authorize]
    public class ItemController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ICollectionRepo _collectionRepo;
        private readonly IItemRepo _itemRepo;
        private readonly ITagRepo _tagRepo;
        private readonly ILikeRepo _likeRepo;

        public ItemController(ICollectionRepo collectionRepo, 
            UserManager<IdentityUser> userManager, 
            IItemRepo itemRepo,
            ITagRepo tagRepo,
            ILikeRepo likeRepo)
        {
            _userManager = userManager;
            _collectionRepo = collectionRepo;
            _itemRepo = itemRepo;
            _tagRepo = tagRepo;
            _likeRepo = likeRepo;
        }
        [AllowAnonymous]
        public IActionResult Index(int? collectionId, int itemId)
        {
            if (collectionId == null)
                return NotFound();
            var collection = _collectionRepo.GetCollectionById((int)collectionId);
            var item = _itemRepo.GetItemById(itemId);
            ShowItemModel model = new ShowItemModel { Item = item, Fields = collection.NameElements, CollectionId = collection.Id };
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(int? collectionId, int itemId, Like like, string comment)
        {
            if (collectionId == null)
                return View();
            var collection = _collectionRepo.GetCollectionById((int)collectionId);
            var item = _itemRepo.GetItemById(itemId);
            CheckLikes(like, item);
            if (comment != null)
            {
                item.Comments.Add(new Comment { Date = DateTime.Now, UserName = like.UserName, Value = comment });
            }
                
            _itemRepo.UpdateItem(item);
            _itemRepo.SaveChange();
            ShowItemModel model = new ShowItemModel { Item = item, Fields = collection.NameElements, CollectionId = collection.Id };
            return View(model);
        }

        private void CheckLikes(Like like, ContentItem item)
        {
            if (item.Likes != null)
            {
                if (item.Likes.Where(x => x.UserName == like.UserName).Count() == 0)
                {
                    item.Likes.Add(like);
                }
                else
                {
                    _likeRepo.RemoveLike(item.Likes.Where(x => x.UserName == like.UserName).First());
                }
            }
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
