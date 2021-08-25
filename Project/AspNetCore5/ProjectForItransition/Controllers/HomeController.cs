using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ProjectForItransition.Models;
using ProjectForItransition.Repository.Interface;
using ProjectForItransition.ViewModels.Collection;
using ProjectForItransition.ViewModels.Roles;
using System.Globalization;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Http;

namespace ProjectForItransition.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITagRepo _tagRepo;
        private readonly ICollectionRepo _collectionRepo;
        private readonly IItemRepo _itemRepo;

        public HomeController(ITagRepo tagRepo, ICollectionRepo collectionRepo, IItemRepo itemRepo)
        {
            _tagRepo = tagRepo;
            _collectionRepo = collectionRepo;
            _itemRepo = itemRepo;
        }

        public IActionResult Index()
        {
            var items = _itemRepo.GetAllItem().OrderByDescending(x => x.Id).TakeLast(10);
            var collections = _collectionRepo.GetAllCollections().OrderByDescending(x => x.Items.Count).Take(4);
            var tagCloun = _tagRepo.GetAllTags().GroupBy(x => x).Select(x => new TagCloudViewModel{ Name = x.Key, Count = x.Count() }).ToList();
            return View(new IndexViewModel { Items = items, Collections = collections, Tags = tagCloun });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
        [HttpPost]
        public IActionResult SetLanguage(string culture, string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1), IsEssential = true }
            );

            return LocalRedirect(returnUrl);
        }

        public ActionResult ChangeTheme(string returnUrl)
        {
            if (Request.Cookies["theme"] == null)
            {
                Response.Cookies.Append("theme", "light", new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1), IsEssential = true });
            }
            else
            {
                if (Request.Cookies["theme"] == "dark")
                {
                    Response.Cookies.Delete("theme");
                    Response.Cookies.Append("theme", "light", new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1), IsEssential = true });
                }
                else if (Request.Cookies["theme"] == "light")
                {
                    Response.Cookies.Delete("theme");
                    Response.Cookies.Append("theme", "dark", new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1), IsEssential = true });
                }
            }

            return LocalRedirect(returnUrl);
        }
    }
}
