using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace ProjectForItransition.ViewModels.Roles
{
    public class ChangeRoleViewModel
    {
        public string UserId { get; set; }
        public string UserEmail { get; set; }
        public IList<string> UserRoles { get; set; }
        public List<IdentityRole> AllRoles { get; set; }
        public bool IsEnable { get; set; }
        public ChangeRoleViewModel()
        {
            UserRoles = new List<string>();
        }
    }
}
