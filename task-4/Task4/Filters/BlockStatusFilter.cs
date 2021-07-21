using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Threading.Tasks;
using Task4.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using Task4.ViewModels;

namespace Task4.Filters
{
    public class BlockStatusFilter : IAsyncResultFilter
    {
        UserManager<User> _userManager;
        SignInManager<User> _signInManager;

        public BlockStatusFilter(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task OnResultExecutionAsync(ResultExecutingContext context, ResultExecutionDelegate next)
        {
            var result = await _userManager.FindByIdAsync(_userManager.GetUserId(context.HttpContext.User));
            var currentUrl = context.HttpContext.Request.Path; 
            if (result != null)
            {
                if (result.IsEnable == false && currentUrl!="/Account/Login")
                {
                    context.Result = new LocalRedirectResult("~/Account/Login");
                }
            }

            await next();
        }
    }
}
