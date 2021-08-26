using Microsoft.AspNetCore.Mvc;
using ProjectForItransition.Models.Item;
using ProjectForItransition.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectForItransition.Controllers
{
    public class SearchController : Controller
    {
        private readonly ICollectionRepo _collectionRepo;
        private readonly IItemRepo _itemRepo;
        private readonly ITagRepo _tagRepo;

        public SearchController(ICollectionRepo collectionRepo, IItemRepo itemRepo, ITagRepo tagRepo)
        {
            _collectionRepo = collectionRepo;
            _itemRepo = itemRepo;
            _tagRepo = tagRepo;
        }

        public IActionResult Index(string searchText, string tag)
        {
            if (string.IsNullOrEmpty(tag))
            {
                return string.IsNullOrEmpty(searchText) ? View(new List<ContentItem>()) : View(SearchItems(searchText));
            }
            return View(_tagRepo.FreeTextOnNameTags(tag));
        }

        private IEnumerable<ContentItem> SearchItems(string search)
        {
            List<ContentItem> items = new();
            items.AddRange(_collectionRepo.FreeTextOnDescription(search));
            items.AddRange(_collectionRepo.FreeTextOnNameCollection(search));
            items.AddRange(_itemRepo.FreeTextOnNameItem(search));
            items.AddRange(_itemRepo.FreeTextOnComment(search));
            items.AddRange(_itemRepo.FreeTextOnMarkdown(search));
            items.AddRange(_itemRepo.FreeTextOnString(search));
            items.AddRange(_tagRepo.FreeTextOnNameTags(search));
            return items.Distinct();
        }
    }
}
