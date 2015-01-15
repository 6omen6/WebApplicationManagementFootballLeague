using System.Web;
using System.Web.Optimization;

namespace WebApplicationManagementFootballLeague
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery-1.11.2.js",
                        "~/Scripts/Facebook.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*",
                        "~/Scripts/jquery.jgrowl.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                        "~/Scripts/bootstrap.js",
                        "~/Scripts/bootstrap-datepicker.js",
                        "~/Scripts/locales/bootstrap-datepicker.pl.js",
                        "~/Scripts/locales/bootstrap-select.min.js",
                        "~/Scripts/jquery.bootstrap-growl.min.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.

            bundles.Add(new StyleBundle("~/Content/css").Include(
                        "~/Content/BootstrapCss/bootstrap.css",
                        "~/Content/BootstrapCss/bootstrap-select.css",
                        "~/Content/BootstrapCss/bootstrap-theme.css",
                        "~/Content/site.css"));
            bundles.Add(new StyleBundle("~/Content/bootstrap").Include(
                        "~/Content/BootstrapCss/bootstrap.css",
                        "~/Content/BootstrapCss/bootstrap-select.css",
                        "~/Content/BootstrapCss/bootstrap-theme.css",
                        "~/Content/LoginLayout.css"));
        }
    }
}