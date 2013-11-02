using System.Web;
using System.Web.Optimization;

namespace DungeonResource.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/libraries").Include(
                        "~/Scripts/Libs/AngularJS/angular.js",
                        "~/Scripts/Libs/Angular-Ui-Bootstrap/ui-bootstrap-0.6.0.js",
                        "~/Scripts/Libs/Bootstrap/bootstrap.js",
                        "~/Scripts/Libs/JQuery/jquery-1.10.2.js",
                        "~/Scripts/Libs/JQuery/jquery.validate.js",
                        "~/Scripts/App/app.js",
                        "~/Scripts/App/Controllers/CreateSpellController.js",
                        "~/Scripts/App/Controllers/UpdateSpellController.js"
                        ));

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



        }
    }
}
