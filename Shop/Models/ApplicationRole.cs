using Microsoft.AspNet.Identity.EntityFramework;

namespace Shop.Models.Northwind
{
    public class ApplicationRole : IdentityRole
    {
        public ApplicationRole() : base() { }
        public ApplicationRole(string name) : base(name) { }

    }
}