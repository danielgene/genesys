using System.Collections.Generic;

namespace InsuranceClaim.Models
{
    public class RoleManagementListViewModel
    {
        public List<Microsoft.AspNet.Identity.EntityFramework.IdentityRole> RoleList { get; set; }

    }

    public class RoleViewModel
    {
        public string Id { get; set; }
        public string RoleName { get; set; }

    }
}
