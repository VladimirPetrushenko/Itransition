using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Task4.Models;

namespace Task4.Controllers
{
    public class HomeController : Controller
    {
        UserManager<User> _userManager;
        SignInManager<User> _signInManager;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _logger = logger;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View(_userManager.Users.ToList());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public async Task<IActionResult> Delete(string[] userIds)
        {
            foreach (var id in userIds)
            {
                User user = await _userManager.FindByIdAsync(id);
                if (user != null)
                {
                    await _userManager.DeleteAsync(user);
                }
            }
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Block(string[] userIds)
        {
            var self = false;
            foreach (var id in userIds)
            {
                User user = await _userManager.FindByIdAsync(id);
                if (user != null)
                {
                    user.LockoutEnd = DateTime.Now.AddYears(200);
                    user.IsEnable = false;

                    var result = await _userManager.UpdateAsync(user);
                    if (result.Succeeded)
                    {
                        if (_userManager.GetUserId(User) == user.Id)
                        {
                            await _signInManager.SignOutAsync();
                            self = true;
                        }
                    }
                }
            }
            return self ? RedirectToAction("Index", "Home") : RedirectToAction("Index");
        }

        public async Task<IActionResult> Unblock(string[] userIds)
        {
            foreach (var id in userIds)
            {
                User user = await _userManager.FindByIdAsync(id);
                if (user != null)
                {
                    user.LockoutEnd = DateTime.Now;
                    user.IsEnable = true;

                    var result = await _userManager.UpdateAsync(user);
                }
            }
            return RedirectToAction("Index");
        }
    }
}
