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

namespace ProjectForItransition.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly ITagRepo _tagRepo;
        private readonly ICollectionRepo _collectionRepo;
        private readonly IItemRepo _itemRepo;

        public HomeController(
            UserManager<IdentityUser> userManager, 
            SignInManager<IdentityUser> signInManager,
            ITagRepo tagRepo,
            ICollectionRepo collectionRepo,
            IItemRepo itemRepo)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _tagRepo = tagRepo;
            _collectionRepo = collectionRepo;
            _itemRepo = itemRepo;
        }

        public IActionResult Index()
        {
            var items = _itemRepo.GetAllItem().OrderByDescending(x => x.Id).TakeLast(10);
            var collections = _collectionRepo.GetAllCollections().OrderBy(x => x.Items.Count()).Take(4);
            var tagCloun = _tagRepo.GetAllTags().GroupBy(x => x).Select(x => new TagCloudViewModel{ Name = x.Key, Count = x.Count() }).ToList();
            return View(new IndexViewModel { Items = items, Collections = collections, Tags = tagCloun });
        }

        public IActionResult Privacy()
        {
            return RedirectToAction("ShowOwnCollections", "Collection");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public async Task<IActionResult> Admin()
        {
            List<ChangeRoleViewModel> models = new List<ChangeRoleViewModel>();
            foreach (var user in _userManager.Users)
            {
                var userRoles = await _userManager.GetRolesAsync(user);
                models.Add( new ChangeRoleViewModel
                {
                    UserId = user.Id,
                    UserEmail = user.Email,
                    UserRoles = userRoles,
                    IsEnable = user.LockoutEnd == null ? true : user.LockoutEnd < DateTimeOffset.Now
                });
            }
            
            return View(models);
        }

        public async Task<IActionResult> Show(string id)
        {
            IdentityUser user = await _userManager.FindByIdAsync(id);
            if (user != null)
            {
                var userRoles = await _userManager.GetRolesAsync(user);

                ShowViewModel model = new ShowViewModel
                {
                    UserId = user.Id,
                    UserEmail = user.Email,
                    UserName = user.UserName,
                    UserRoles = userRoles,
                };
                return View(model);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Delete(string id)
        {
            IdentityUser user = await _userManager.FindByIdAsync(id);
            if (user != null)
            {
                IdentityResult result = await _userManager.DeleteAsync(user);
            }
            return RedirectToAction("Admin");
        }
        
        [HttpPost]
        public async Task<IActionResult> Block(string id)
        {
            IdentityUser user = await _userManager.FindByIdAsync(id);
            if (user != null)
            {
                user.LockoutEnd = DateTime.Now.AddYears(200);

                var result = await _userManager.UpdateAsync(user);
                if (result.Succeeded)
                {
                    if (_userManager.GetUserId(User) == user.Id)
                    {
                        await _signInManager.SignOutAsync();
                    }
                }
            }
            return RedirectToAction("Admin");
        }

        [HttpPost]
        public async Task<IActionResult> Unblock(string id)
        {
            IdentityUser user = await _userManager.FindByIdAsync(id);
            if (user != null)
            {
                user.LockoutEnd = DateTime.Now;

                await _userManager.UpdateAsync(user);
            }
            return RedirectToAction("Admin");
        }

        [HttpPost]
        public async Task<IActionResult> ChangeRole(string id)
        {
            IdentityUser user = await _userManager.FindByIdAsync(id);
            if (user != null)
            {
                var userRoles = await _userManager.GetRolesAsync(user);
                if (userRoles.Contains("admin"))
                    await _userManager.RemoveFromRoleAsync(user, "admin");
                else
                    await _userManager.AddToRoleAsync(user, "admin");
                if (User.Identity.Name == user.UserName)
                    await _signInManager.SignInAsync(user, true);
            }
            return RedirectToAction("Admin");
        }
    }
}
