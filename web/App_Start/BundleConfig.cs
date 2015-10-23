using System.Web.Optimization;

namespace SevenH.MMCSB.Atm.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/Core/jquery-{version}.js",
                        "~/Content/frontend/js/jquery-ui.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/Core/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/Core/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/Core/bootstrap.js",
                      "~/Scripts/Core/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css"));

            bundles.Add(new StyleBundle("~/bundles/bootstrapcss").Include(
                      "~/Content/bootstrap.css"));

            bundles.Add(new ScriptBundle("~/bundles/datepicker").Include(
                      "~/Scripts/Core/moment.min.js",
                      "~/Scripts/Core/bootstrap-datetimepicker.min.js"));

            bundles.Add(new StyleBundle("~/bundles/datepickercss").Include(
                      "~/Content/bootstrap-datetimepicker.css"));

            // frontend template

            bundles.Add(new StyleBundle("~/bundles/frontendcss").Include(
                            "~/Content/frontend/css/animate.min.css",
                            "~/Content/frontend/css/font-awesome.min.css",            
                            "~/Content/frontend/css/form.css",
                            "~/Content/frontend/css/style.css",
                            "~/Content/frontend/css/animate.css",
                            "~/Content/frontend/css/generics.css",
                            "~/Content/frontend/css/icons.css",
                            "~/Content/frontend/css/generics.css"));


            bundles.Add(new StyleBundle("~/bundles/frontendscript").Include(
                            "~/Content/frontend/js/functions.js"));

        }
    }
}
