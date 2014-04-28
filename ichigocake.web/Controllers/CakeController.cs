using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ichigocake.persistenceEF.Context;
using ichigocake.web.Models;
using PagedList;

namespace ichigocake.web.Controllers
{
    public class CakeController : Controller
    {
        private IchigocakeDbContext db = new IchigocakeDbContext();
        public ActionResult Index(int id)
        {
            var model = new CakeViewModel
                        {
                            Filter = new CakeFilter {CatId = id}
                        };
            var pageIndex = model.Filter.PageNumber ?? 1;
            var pageSize = model.Filter.PageSize ?? 6;
            var cakes = db.Cakes.Where(c => c.Category.Id == id).OrderBy(c=> c.Id).ToPagedList(pageIndex, pageSize);
            model.CakeResults = cakes;
            if (Request.IsAjaxRequest())
            {
                return PartialView("_CakeList", model);
            }
            return View(model);
        }
       
        [HttpPost]
        public ActionResult CakeList(CakeFilter filter)
        {
            var pageIndex = filter.PageNumber ?? 1;
            const int pageSize = 6;
            var cakes=db.Cakes.Where(c => c.Category.Id == filter.CatId).OrderBy(c=> c.Id).ToPagedList(pageIndex, pageSize);
            var model = new CakeViewModel { Filter = filter, CakeResults = cakes };

            return PartialView("_CakeList", model);
        }
        public ActionResult Categories()
        {
            var model = new CategoryViewModel
                        {
                            Categories = db.Categories.ToList()
                        };
            return View(model);
        }

        public ActionResult CakeDetail(int id)
        {
            var model = new CakeDetailViewModel
                        {
                            Cake = db.Cakes.FirstOrDefault(c => c.Id == id)
                        };
            return View(model);
        }
        
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult CakeDetail(CakeDetailViewModel model)
        //{
        //    if (ModelState.IsValid)
        //    {

        //    } 
        //    return View();
        //}

        public ActionResult SendOrder(int id)
        {
            if (ModelState.IsValid)
            {
                
            } 
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
         
    }
}