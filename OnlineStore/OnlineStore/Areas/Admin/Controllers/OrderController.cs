using OnlineStore.Models.EF_data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;

namespace OnlineStore.Areas.Admin.Controllers
{
    public class OrderController : Controller
    {
        private Model1 db = new Model1();
        // GET: Admin/Order
        public ActionResult Index(int? page)
        {
            var items = db.tb_Order.OrderByDescending(x => x.CreatedDate).ToList();
            if (page == null)
            {
                page = 1;
            }
            var pageNumber = page ?? 1;
            var pageSize = 15;
            ViewBag.PageSize = pageSize;
            ViewBag.Page = pageNumber;
            return View(items.ToPagedList(pageNumber, pageSize));
        }

        public ActionResult View(int id)
        {
            var item = db.tb_Order.Find(id);
            return View(item);
        }

        public ActionResult Partial_SanPham(int id)
        {
            var item = db.tb_OrderDetail.Where(x => x.OrderId == id).ToList();
            return PartialView(item);
        }

        [HttpPost]
        public ActionResult UpdateTT(int id, int trangthai)
        {
            var item = db.tb_Order.Find(id);
            if(item != null) 
            {
                db.tb_Order.Attach(item);
                item.TypePayment=trangthai;
                db.Entry(item).Property(x=>x.TypePayment).IsModified=true;
                db.SaveChanges();
                return Json(new { message = "Success", Success = true });
            }
            return Json(new { message = "Unsuccess", Success = false });
        }
    }
}