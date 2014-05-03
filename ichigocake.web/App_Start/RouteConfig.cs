using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ichigocake.web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            
            routes.MapRoute(
              name: "Hakkimizda",
              url: "Hakkimizda",
              defaults: new { controller = "Home", action = "About", id = UrlParameter.Optional }
           );
            routes.MapRoute(
                name: "Pastalarimiz",
                url: "Pastalarimiz/{id}",
                defaults: new { controller = "Cake", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Kategorilerimiz",
                url: "Kategorilerimiz",
                defaults: new { controller = "Cake", action = "Categories", id = UrlParameter.Optional }
            );
            routes.MapRoute(
               name: "Referanslarimiz",
               url: "Referanslarimiz",
               defaults: new { controller = "Reference", action = "Index", id = UrlParameter.Optional }
           );

            routes.MapRoute(
               name: "Iletisim",
               url: "iletisim",
               defaults: new { controller = "Home", action = "Contact", id = UrlParameter.Optional }
           );
            routes.MapRoute(
               name: "PastaDetay",
               url: "Pasta/Detay/{id}",
               defaults: new { controller = "Cake", action = "CakeDetail", id = UrlParameter.Optional }
           );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
           
        }
    }
}
