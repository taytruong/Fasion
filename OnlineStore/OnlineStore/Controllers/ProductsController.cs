using OnlineStore.Models.EF_data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineStore.Controllers
{
    public class ProductsController : Controller
    {
        private Model1 db = new Model1();
        // GET: Products
        public ActionResult Index(int? id)
        {
            var items = db.tb_Product.ToList();
            if (id != null)
            {
                items = items.Where(x => x.ProductCategoryId == id).ToList();
            }
            return View(items);
        }
        
        public ActionResult Detail(string alias,int id)
        {
            var item = db.tb_Product.Find(id);
            if (item != null)
            {
                db.tb_Product.Attach(item);
                item.ViewCount = item.ViewCount + 1;
                db.Entry(item).Property(x => x.ViewCount).IsModified = true;
                db.SaveChanges();
            }
            
            return View(item);
        }
        public ActionResult ProductCategory(string alias, int id)
        {
            var items = db.tb_Product.ToList();
            if (id > 0)
            {
                items = items.Where(x => x.ProductCategoryId == id).ToList();
            }
            var cate = db.tb_ProductCategory.Find(id);
            if (cate != null)
            {
                ViewBag.CateName = cate.Title;
            }
            ViewBag.CateId = id;
            return View(items);
        }

        public ActionResult Partial_ItemByCateId()
        {
            var items = db.tb_Product.Where(x => x.IsHome && x.IsActive).Take(12).ToList();
            return PartialView(items);
        }

        public ActionResult Partial_ProductSale()
        {
            var items = db.tb_Product.Where(x => x.IsSale && x.IsActive).Take(12).ToList();
            return PartialView(items);
        }
    }
}