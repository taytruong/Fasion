using OnlineStore.Models.EF_data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineStore.Areas.Admin.Controllers
{
    public class RoleController : Controller
    {
        private Model1 db = new Model1();
        // GET: Admin/Role
        public ActionResult Index()
        {
            var items = db.AspNetRoles.ToList();
            return View(items);
        }

        public ActionResult Create()
        {
            return View();
        }
    }
}