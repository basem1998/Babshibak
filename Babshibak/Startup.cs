using Babshibak.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using System;

[assembly: OwinStartupAttribute(typeof(Babshibak.Startup))]
namespace Babshibak
{
    public partial class Startup
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            CreateRolesAndUser();
        }
        public void CreateRolesAndUser()
        {
            var rolemanger = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(db));
            var usermanger = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
            IdentityRole role = new IdentityRole();
            if (!rolemanger.RoleExists("Admins"))
            {
                role.Name = "Admins";
                rolemanger.Create(role);
                ApplicationUser user = new ApplicationUser();
                user.UserName = "Basem";
                user.Email = "basem.m100@hotmail.com";
                var Check = usermanger.Create(user, "B@sem123");
                if(Check.Succeeded)
                {
                    usermanger.AddToRole(user.Id,"Admins");
                }

            }
        }
    }
}
