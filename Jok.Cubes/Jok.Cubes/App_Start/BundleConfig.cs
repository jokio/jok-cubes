using System.Web;
using System.Web.Optimization;

namespace Jok.Cubes
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/css/v1").Include(
                      "~/Content/V1/Jok.Cubes.css"));
        }
    }
}
