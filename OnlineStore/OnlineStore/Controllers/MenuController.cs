using OnlineStore.Models.EF_data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineStore.Controllers
{
    public class MenuController : Controller
    {
        private Model1 db = new Model1();
        // GET: Menu
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MenuTop()
        {
            var items = db.tb_Category.OrderBy(x => x.Position).ToList();
            return PartialView("_MenuTop", items);
        }

        public ActionResult MenuProductCategory()
        {
            var items = db.tb_ProductCategory.ToList();
            return PartialView("_MenuProductCategory", items);
        }
        public ActionResult MenuLeft(int? id)
        {
            if(id != null)
            {
                ViewBag.CateId = id;
            }
            var items = db.tb_ProductCategory.ToList();
            return PartialView("_MenuLeft", items);
        }

        public ActionResult MenuArrivals()
        {
            var items = db.tb_ProductCategory.ToList();
            return PartialView("_MenuArrivals", items);
        }
    }
}