using System.Web;
using System.Web.Optimization;

namespace ichigocake.web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
            
            bundles.Add(new StyleBundle("~/Content/WebCss").Include(
                      "~/Content/WebCss/bootstrap.min.css",
                      "~/Content/WebCss/bootstrap-responsive.min.css",
                      "~/Content/WebCss/font-awesome.min.css",
                      "~/Content/WebCss/style.css",
                      "~/Content/WebCss/flexslider.css",
                      "~/Content/WebCss/masonry.css",
                      "~/Content/WebCss/fancybox.css",
                      "~/Content/WebCss/transition.css",
                      "~/Content/WebCss/stickers/round-stickers.css",
                      "~/Content/WebCss/stickers/dark-stickers.css",
                      "~/Content/WebCss/color/pink.css",
                      "~/Content/WebCss/bg/white.css"));


            bundles.Add(new ScriptBundle("~/bundles/WebScripts").Include(
                      "~/Scripts/WebScripts/jquery-1.10.2.min.js",
                      "~/Scripts/WebScripts/bootstrap.min.js",
                      "~/Scripts/WebScripts/jquery.flexslider-min.js",
                      "~/Scripts/WebScripts/jquery.masonry.min.js",
                      "~/Scripts/WebScripts/jquery.fancybox.min.js",
                      "~/Scripts/WebScripts/jquery.nicescroll.min.js",
                      "~/Scripts/WebScripts/mail.ajax.js",
                      "~/Scripts/WebScripts/functions.js",
                       "~/Scripts/ichigo_web.js"));
        }
    }
}
