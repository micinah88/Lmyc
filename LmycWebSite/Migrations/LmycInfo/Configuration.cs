namespace LmycWebSite.Migrations.LmycInfo
{
    using LmycDataLib.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LmycDataLib.Models.ApplicationDbContext>
    {
        string[] roles = { "Admin", "Member" };
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\LmycInfo";
            ContextKey = "LmycdDataLib.Models.ApplicationDbContext";
        }

        protected override void Seed(LmycDataLib.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            var RoleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            for (int i = 0; i < roles.Length; i++)
            {
                if (RoleManager.RoleExists(roles[i]) == false)
                {
                    RoleManager.Create(new IdentityRole(roles[i]));
                }
            }

            //if (!context.Roles.Any(r => r.Name == "Admin"))
            //{
            //    var store = new RoleStore<IdentityRole>(context);
            //    var manager = new RoleManager<IdentityRole>(store);
            //    var role = new IdentityRole { Name = "Admin" };

            //    manager.Create(role);
            //}
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            var PasswordHash = new PasswordHasher();

            if (!context.Users.Any(u => u.UserName == "a"))
            {
                var user = new ApplicationUser
                {
                    UserName = "a",
                    Email = "a@a.a",
                    PasswordHash = PasswordHash.HashPassword("P@$$w0rd"),
                    FirstName = "Admin",
                    LastName = "Admin",
                    Address = "123 Admin St",
                    MobileNumber = "12345678",
                    SailingExperience = "Expert"
                };

                UserManager.Create(user);
                UserManager.AddToRole(user.Id, roles[0]);
            }

            if (!context.Users.Any(u => u.UserName == "b"))
            {
                var user = new ApplicationUser
                {
                    UserName = "b",
                    Email = "b@b.b",
                    PasswordHash = PasswordHash.HashPassword("P@$$w0rd"),
                    FirstName = "Member",
                    LastName = "One",
                    Address = "123 Member St",
                    MobileNumber = "12345678",
                    SailingExperience = "Beginner"
                };

                UserManager.Create(user);
                UserManager.AddToRole(user.Id, roles[1]);
            }
        }
    }
}
