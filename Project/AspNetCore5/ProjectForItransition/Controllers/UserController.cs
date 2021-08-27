using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ProjectForItransition.Repository.Interface;
using ProjectForItransition.ViewModels.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectForItransition.Controllers
{
    //[Authorize(Roles = "admin")]
    public class UserController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly ICollectionRepo _repository;

        public UserController(UserManager<IdentityUser> userManager, 
            SignInManager<IdentityUser> signInManager,
            ICollectionRepo repository)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _repository = repository;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Admin()
        {
            List<ChangeRoleViewModel> models = new();
            var users = _userManager.Users.ToList();
            foreach (var user in users)
            {
                var userRoles = await _userManager.GetRolesAsync(user);
                models.Add(new ChangeRoleViewModel
                {
                    UserId = user.Id,
                    UserEmail = user.Email,
                    UserRoles = userRoles,
                    IsEnable = user.LockoutEnd == null || user.LockoutEnd < DateTimeOffset.Now
                });
            }

            return View(models);
        }

        public async Task<IActionResult> ShowUser(string id)
        {
            IdentityUser user = await _userManager.FindByIdAsync(id);
            if (user != null)
            {
                var userRoles = await _userManager.GetRolesAsync(user);
                var collections = _repository.GetAllUserCollections(user.Id);

                ShowUserViewModel showUserViewModel = new()
                {
                    UserId = user.Id,
                    UserEmail = user.Email,
                    UserName = user.UserName,
                    UserRoles = userRoles,
                    Collections = collections,
                };
                return View(showUserViewModel);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Delete(string id)
        {
            IdentityUser user = await _userManager.FindByIdAsync(id);
            if (user != null)
            {
                await _userManager.DeleteAsync(user);
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
