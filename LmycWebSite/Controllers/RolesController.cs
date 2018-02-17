using LmycDataLib.Models;
using LmycWebSite.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace LmycWebSite.Controllers
{
    public class RolesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        private ApplicationUserManager _userManager;

        public RolesController()
        {
        }

        public RolesController(ApplicationUserManager userManager)
        {
            UserManager = userManager;
        }

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }
        // GET: Roles
        public ActionResult Index()
        {

            var roles = db.Roles.ToList();
            return View(roles);
        }

        // GET: Roles/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Roles/Create
        public ActionResult Create()
        {
            if (ModelState.IsValid)
            {
                var Role = new IdentityRole();
                return View(Role);
            }
            return View();
        }

        // POST: Roles/Create
        [HttpPost]
        public ActionResult Create(IdentityRole identityRole)
        {
            try
            {
                // TODO: Add insert logic here
                db.Roles.Add(identityRole);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                ModelState.AddModelError("", "Role already exist");
                return View();
            }
        }

        // GET: Roles/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IdentityRole role = db.Roles.FirstOrDefault(r => r.Id == id);
            if (role == null)
            {
                return HttpNotFound();
            }
            var users = db.Users.Where(x => x.Roles.Select(y => y.RoleId).Contains(id)).ToList();
            ViewBag.Role = role.Name;
            return View(users);
        }

        //// POST: Roles/Edit/5
        //[HttpPost]
        //public ActionResult Edit(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: Roles/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var role = db.Roles.FirstOrDefault(u => u.Id == id);
            if (role == null)
            {
                return HttpNotFound();
            }
            return View(role);
        }

        // POST: Roles/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(string id)
        {
            try
            {
                // TODO: Add delete logic here
                var role = db.Roles.FirstOrDefault(u => u.Id == id);
                db.Roles.Remove(role);
                
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // POST: Roles/Remove
        [HttpPost]
        public ActionResult Remove(string userId, string roleName)
        {
            if (userId != null)
            {
                Console.WriteLine(userId);
                Console.WriteLine(roleName);
                UserManager.RemoveFromRoles(userId, roleName);
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}
