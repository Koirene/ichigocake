using System.Web;
using System.Web.Optimization;

namespace ichigocake.admin
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
            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui-{version}.js"));

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
            
            bundles.Add(new StyleBundle("~/Content/AdminCss").Include(
                      "~/Content/AdminCss/bootstrap.css",
                      "~/Content/AdminCss/bootstrap-responsive.css",
                      "~/Content/AdminCss/stilearn.css",
                      "~/Content/AdminCss/stilearn-responsive.css",
                      "~/Content/AdminCss/stilearn-helper.css",
                      "~/Content/AdminCss/stilearn-icon.css",
                      "~/Content/AdminCss/font-awesome.css",
                      "~/Content/AdminCss/animate.css",
                      "~/Content/AdminCss/uniform.default.css",
                      "~/Content/AdminCss/fullcalendar.css",
                      "~/Content/AdminCss/select2.css",
                      "~/Content/AdminCss/bootstrap-wysihtml5.css",
                      "~/Content/alertify/alertify.core.css",
                      "~/Content/alertify/alertify.default.css"));


            bundles.Add(new ScriptBundle("~/bundles/AdminScripts").Include(
                      "~/Scripts/jquery-{version}.js",
                      "~/Scripts/jquery-ui-{version}.js",
                      "~/Scripts/jquery.unobtrusive*",
                      "~/Scripts/jquery.validate*",
                      "~/Scripts/AdminScripts/bootstrap.js",
                      "~/Scripts/AdminScripts/uniform/jquery.uniform.js",
                      "~/Scripts/AdminScripts/peity/jquery.peity.js",
                      "~/Scripts/AdminScripts/select2/select2.js",
                      "~/Scripts/AdminScripts/knob/jquery.knob.js",
                      "~/Scripts/AdminScripts/flot/jquery.flot.js",
                      "~/Scripts/AdminScripts/flot/jquery.flot.resize.js",
                      "~/Scripts/AdminScripts/flot/jquery.flot.categories.js",
                      "~/Scripts/AdminScripts/wysihtml5/wysihtml5-0.3.0.js",
                      "~/Scripts/AdminScripts/wysihtml5/bootstrap-wysihtml5.js",
                      "~/Scripts/AdminScripts/calendar/fullcalendar.js",
                      "~/Scripts/AdminScripts/holder.js",
                      "~/Scripts/AdminScripts/wysihtml5/bootstrap-wysihtml5.js",
                      "~/Scripts/AdminScripts/stilearn-base.js",
                      "~/Scripts/alertify/alertify.min.js",
                      "~/Scripts/ichigo_admin.js"));
        }
    }
}
