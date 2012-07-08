using System.Web;
using System.Web.Optimization;

namespace BootstrappingMvc
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/Scripts/Bootstrap").Include(
                        "~/Scripts/jquery-1.*",
                        "~/Scripts/Bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/Bootstrap").Include(
                        "~/Content/Bootstrap.min.css",
                        "~/Content/Bootstrap-responsive.css"
                        ));

        }
    }
}