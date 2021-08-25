using Microsoft.AspNetCore.Identity;
using ProjectForItransition.Models.Collection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectForItransition.ViewModels.Roles
{
    public class ShowUserViewModel
    {
        public string UserId { get; set; }
        public string UserEmail { get; set; }
        public string UserName { get; set; }
        public IList<string> UserRoles { get; set; }
        public List<ContentCollection> Collections { get; set; }
        public ShowUserViewModel()
        {
            UserRoles = new List<string>();
        }
    }
}
