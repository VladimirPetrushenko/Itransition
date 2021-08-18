using Microsoft.AspNetCore.Mvc;
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

        public SearchController(
            ICollectionRepo collectionRepo)
        {
            _collectionRepo = collectionRepo;
        }

        public IActionResult Index(string searchText)
        {
            return View();
        }
    }
}
