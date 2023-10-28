using OnlineStore.Models.EF_data;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineStore.Areas.Admin.Controllers
{
    public class NewsController : Controller
    {
        private Model1 db = new Model1();
        // GET: Admin/News
        public ActionResult Index(string Searchtext, int? page)
        {
            var pageSize = 10;
            if(page == null)
            {
                page = 1;
            }
            IEnumerable<tb_News> items = db.tb_News.OrderByDescending(x => x.Id);
            if(!string.IsNullOrEmpty(Searchtext))
            {
                items = items.Where(x => x.Alias.Contains(Searchtext)||x.Title.Contains(Searchtext));
            }
            var pageIndex = page.HasValue ? Convert.ToInt32(page) : 1;
            items = items.ToPagedList(pageIndex, pageSize);
            ViewBag.PageSize = pageSize;    
            ViewBag.Page = page;    
            return View(items);
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(tb_News model)
        {
            if(ModelState.IsValid)
            {
                model.CreatedDate = DateTime.Now;
                model.CategoryId = 1;
                model.ModifiedDate = DateTime.Now;
                model.Alias = OnlineStore.Models.transko_dau_co_dau.Filters.FilterChar(model.Title);
                db.tb_News.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public ActionResult Edit(int id)
        {
            var item = db.tb_News.Find(id);
            return View(item);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(tb_News model)
        {
            if (ModelState.IsValid)
            {    
                model.ModifiedDate = DateTime.Now;
                model.Alias = OnlineStore.Models.transko_dau_co_dau.Filters.FilterChar(model.Title);
                db.tb_News.Attach(model);
                db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }


        [HttpPost]
        public ActionResult Delete(int id) 
        {
            var item = db.tb_News.Find(id);
            if(item != null)
            {
                db.tb_News.Remove(item);
                db.SaveChanges();
                return Json(new { success = true });
            }
            return Json(new{ success = false}); 
        }

        [HttpPost]
        public ActionResult IsActive(int id)
        {
            var item = db.tb_News.Find(id);
            if (item != null)
            {
                item.IsActive = !item.IsActive;
                db.Entry(item).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return Json(new { success = true , isAcive = item.IsActive });
            }
            return Json(new { success = false });
        }

        [HttpPost]
        public ActionResult DeleteAll(string ids) 
        {
            if (!string.IsNullOrEmpty(ids))
            {
                var items = ids.Split(',');
                if(items != null && items.Any())
                {
                    foreach(var item in items)
                    {
                        var obj = db.tb_News.Find(Convert.ToInt32(item));
                        db.tb_News.Remove(obj);
                        db.SaveChanges();
                    }
                }
                return Json(new { success = true });
            }
            return Json(new { success = false });
        }
    }
}