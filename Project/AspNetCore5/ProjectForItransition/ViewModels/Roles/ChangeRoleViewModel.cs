using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectForItransition.ViewModels.Roles
{
    public class ChangeRoleViewModel
    {
        public string UserId { get; set; }
        public string UserEmail { get; set; }
        public IList<string> UserRoles { get; set; }
        public bool IsEnable { get; set; }
        public ChangeRoleViewModel()
        {
            UserRoles = new List<string>();
        }
    }
}
