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
        private readonly ICollectionRepo _collectionRepo;
        private readonly IItemRepo _itemRepo;
        private readonly ITagRepo _tagRepo;
        private readonly IOptionRepo _optionRepo;

        public ItemController(ICollectionRepo collectionRepo, IItemRepo itemRepo, ITagRepo tagRepo, IOptionRepo optionRepo)
        {
            _collectionRepo = collectionRepo;
            _itemRepo = itemRepo;
            _tagRepo = tagRepo;
            _optionRepo = optionRepo;
        }
        
        [AllowAnonymous]
        public IActionResult Index(int collectionId, int itemId)
        {
            var collection = _collectionRepo.GetCollectionById(collectionId);
            var item = _itemRepo.GetItemById(itemId);
            ShowItemModel model = new() { 
                Item = item,
                Fields = collection.NameElements,
                CollectionId = collection.Id,
                OptionElements = item.OptionElements,
                NameSelect = collection.SelectElements.Select(x => x.Name).ToArray(),
            };
            return View(model);
        }

        [HttpGet]
        public IActionResult CreateItem(int collectionId)
        {
            var tags = _tagRepo.GetAllDistinctTags();
            var collection = _collectionRepo.GetCollectionById(collectionId);
            return View(new CreateItemViewModel { Collection = collection, AllTags = tags });
        }

        [HttpPost]
        public IActionResult CreateItem(CreateItemViewModel model)
        {
            var item = model.CreateContentItem();
            item.OptionElements = ListOptionElements(model.Options);
            _itemRepo.CreateItem(item, model.CollectionId);
            _itemRepo.SaveChange();
            return RedirectToAction("ShowCollection", "Collection", new { model.CollectionId });
        }

        private List<OptionElement> ListOptionElements(int[] optionId)
        {
            var Options = new List<OptionElement>();
            foreach (var id in optionId)
            {
                Options.Add(_optionRepo.GetOptionElementById(id));
            }
            return Options;
        }

        [HttpGet]
        public IActionResult DeleteItem(int itemId, int collectionId)
        {
            var item = _itemRepo.GetItemById(itemId);
            _itemRepo.DeleteItem(item);
            _itemRepo.SaveChange();
            return RedirectToAction("ShowCollection", "Collection", new { CollectionId = collectionId });
        }

        [HttpGet]
        public IActionResult UpdateItem(int itemId, int collectionId)
        {
            var tags = _tagRepo.GetAllDistinctTags();
            var collection = _collectionRepo.GetCollectionById(collectionId);
            var item = _itemRepo.GetItemById(itemId);
            return View(new UpdateItemViewModel { Item = item, 
                Fields = collection.NameElements, 
                CollectionId = collection.Id, 
                AllTags = tags, 
                Collection = collection });
        }

        [HttpPost]
        public IActionResult UpdateItem(UpdateItemViewModel model)
        {
            var updateItem = _itemRepo.GetItemById((int)model.ItemId);
            model.CreateContentItem().CopyTo(updateItem);
            updateItem.OptionElements = ListOptionElements(model.Options);
            _itemRepo.UpdateItem(updateItem);
            if (_itemRepo.SaveChange())
            {
                return RedirectToAction("Index", "Item", new { collectionId = model.CollectionId, itemId = model.ItemId });
            }
            return View();
        }
    }
}
