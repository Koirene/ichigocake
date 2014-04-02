using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ichigocake.admin.Controllers
{
    public class MenuController : Controller
    {
        //
        // GET: /Menu/
        public ActionResult SideBar()
        {
            return PartialView("_MenuPartial");
        }
	}
}