using LmycDataLib.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using System;
using System.Threading.Tasks;

[assembly: OwinStartupAttribute(typeof(LmycWebSite.Startup))]
namespace LmycWebSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            //CreateRoles(serviceProvider).Wait();
        }

        //private async Task CreateRoles(IServiceProvider serviceProvider)
        //{
        //    //initializing custom roles 
        //    var RoleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
        //    var UserManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
        //    string[] roleNames = { "Admin", "Store-Manager", "Member" };
        //    IdentityResult roleResult;

        //    foreach (var roleName in roleNames)
        //    {
        //        var roleExist = await RoleManager.RoleExistsAsync(roleName);
        //        // ensure that the role does not exist
        //        if (!roleExist)
        //        {
        //            //create the roles and seed them to the database: 
        //            roleResult = await RoleManager.CreateAsync(new IdentityRole(roleName));
        //        }
        //    }

        //    // find the user with the admin email 
        //    var _user = await UserManager.FindByEmailAsync("a@a.a");

        //    // check if the user exists
        //    if (_user == null)
        //    {
        //        //Here you could create the super admin who will maintain the web app
        //        var poweruser = new ApplicationUser
        //        {
        //            UserName = "a",
        //            Email = "a@a.a",
        //        };
        //        string adminPassword = "P@$$w0rd";

        //        var createPowerUser = await UserManager.CreateAsync(poweruser, adminPassword);
        //        if (createPowerUser.Succeeded)
        //        {
        //            //here we tie the new user to the role
        //            await UserManager.AddToRoleAsync(poweruser, "Admin");

        //        }
        //    }
        //}
    }
}
