using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectForItransition.ViewModels.Roles
{
    public class ShowViewModel
    {
        public string UserId { get; set; }
        public string UserEmail { get; set; }
        public string UserName { get; set; }
        public IList<string> UserRoles { get; set; }
        public ShowViewModel()
        {
            UserRoles = new List<string>();
        }
    }
}
