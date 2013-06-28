using System.Web;
using System.Web.Optimization;

namespace DndDev
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery.mobile-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/jquerymobile").Include(
                        "~/Scripts/jquery.mobile-1.2.0.min.js"));

            bundles.Add(new StyleBundle("~/Content/jquerymobile").Include(
                        "~/Content/jquery.mobile-1.2.0.css",
                        "~/Content/jquery.mobile.structure-1.2.0.css",
                        "~/Content/jquery.mobile.theme-1.2.0.css"));

        }

    }
}