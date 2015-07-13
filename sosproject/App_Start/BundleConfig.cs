using System.Web;
using System.Web.Optimization;

namespace sosproject
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

            bundles.Add(new StyleBundle("~/Content/front-end/css").Include(
                      "~/Content/front-end/css/font-awesome.min.css",
                      "~/Content/front-end/css/glyphicons-font.css",
                      "~/Content/front-end/css/perfect-scrollbar.min.css",
                      "~/Content/front-end/css/class-style.css",
                      "~/Content/front-end/css/style.css"));

            bundles.Add(new ScriptBundle("~/bundles/front-end").Include(
                        "~/Scripts/front-end/jquery-1.11.3.js",
                        "~/Scripts/front-end/perfect-scrollbar.js",
                        "~/Scripts/front-end/jquery-style.js"));

            bundles.Add(new StyleBundle("~/Content/back-end/css").Include(
                        "~/Content/back-end/css/bootstrap.css",
                        "~/Content/back-end/css/bootstrap-responsive.css",
                        "~/Content/back-end/css/font-awesome.css",
                        "~/Content/back-end/css/ace.css",
                        "~/Content/back-end/css/ace-responsive.css",
                        "~/Content/back-end/css/ace-skins.css",
                        "~/Content/back-end/css/style-custom.css"));

            bundles.Add(new ScriptBundle("~/bundles/back-end").Include(
                        "~/Scripts/back-end/bootstrap.js",
                        "~/Scripts/back-end/jquery-dataTables.js",
                        "~/Scripts/back-end/jquery-dataTables-bootstrap.js",
                        "~/Scripts/back-end/ace-elements.js",
                        "~/Scripts/back-end/ace.js"));

            bundles.Add(new ScriptBundle("~/bundles/back-end/table").Include(
                        "~/Scripts/back-end/jquery-dataTables.js",
                        "~/Scripts/back-end/jquery-dataTables-bootstrap.js"));
        }
    }
}
