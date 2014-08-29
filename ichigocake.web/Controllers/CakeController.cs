using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ichigocake.domain;
using ichigocake.persistenceEF.Context;
using ichigocake.web.Models;
using ichigocake.web.Models.MailModels;
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
        
        public ActionResult SendOrder()
        {
            try
            {
                var orderModel = new OrderMailModel();
                if (Request["cakeid"] != null)
                {
                    orderModel.Order.Cake = db.Cakes.FirstOrDefault(c => c.Id == Convert.ToInt32(Request["cakeid"]));
                }
                orderModel.Order.Email = Request["Email"];
                orderModel.Order.FullName = Request["FullName"];
                orderModel.Order.Address = Request["Address"];
                orderModel.Order.Description = Request["Description"];
                orderModel.Order.Phone = Request["Phone"];
                orderModel.Order.RequestedDate = Request["RequestedDate"];
                orderModel.Order.RequestedTime = Request["RequestedTime"];
                orderModel.Order.TotalAmount = Convert.ToInt32(Request["PersonAmount"]);

                new MailController().OrderMail(orderModel).Deliver();
                new MailController().CustomerOrderNotificationMail(orderModel).Deliver();
                var message = "Mesajınız başarıyla iletilmiştir.";

                return Json(String.Format("'Başarı':'{0}'", message));

            }
            catch (Exception error)
            {
                const string errormessage = "Bir Hata Oluştu. Daha sonra tekrar deneyiniz";
                return Json(String.Format("'Hata':'{0}'", errormessage));
            }
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
         
    }
}