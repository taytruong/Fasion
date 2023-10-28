using OnlineStore.Models.EF_data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineStore.Areas.Admin.Controllers
{
    public class ProductImageController : Controller
    {
        // GET: Admin/ProductImage
        private Model1 db = new Model1();
        public ActionResult Index(int id)
        {
            ViewBag.ProductId = id;
            var items = db.tb_ProductImage.Where(x => x.ProductId == id).ToList();
            return View(items);
        }

        [HttpPost]
        public ActionResult AddImage(int productId, string url)
        {
            db.tb_ProductImage.Add(new tb_ProductImage
            {
                ProductId = productId,
                Image = url,
                IsDefault = false
            });
            db.SaveChanges();
            return Json(new { Success = true });
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            var item = db.tb_ProductImage.Find(id);
            db.tb_ProductImage.Remove(item);
            db.SaveChanges();
            return Json(new { success = true });
        }
    }
}