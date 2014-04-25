using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HtmlHelper = ichigocake.common.Helpers.ImageHelper;

namespace ichigocake.admin.Controllers
{
    public class CakeController : Controller
    {
        //
        // GET: /Cake/
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult CategoryCreate()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UploadImages(string qqfile, double? width, double? height)
        {
            string imageName = string.Empty;
            var originalFileName = string.Empty;
            var stream = Request.InputStream;

            if (Request.UserAgent.Contains("MSIE"))
            {
                // IE
                HttpPostedFileBase postedFile = Request.Files[0];
                stream = postedFile.InputStream;
                originalFileName = System.IO.Path.GetFileName(Request.Files[0].FileName);
            }
            else
            {
                //Webkit, Mozilla
                originalFileName = qqfile;
            }

            try
            {
                var extension = originalFileName.Substring(originalFileName.Length - 4, 4);
                imageName = Guid.NewGuid().ToString() + extension;
                var directory = Server.MapPath("~/Content/CakeImages/CakeTemp");
                var path = directory + "\\" + imageName;
                //var path = Path.Combine(Server.MapPath("~/" + ConfigurationManager.AppSettings["UploadTempDirectory"]),
                //    imageName);

                HtmlHelper.SaveImage(stream, path, 870, 580, false);

                return new JsonResult()
                {
                    Data = new { success = true, Status = "ok", ImageName = imageName },
                    ContentType = "text/plain"
                };
            }
            catch (Exception ex)
            {
                return new JsonResult()
                {
                    Data = new { success = false, Status = "err", Message = ex.Message },
                    ContentType = "text/plain"
                };
            }
        }
        
	}
}