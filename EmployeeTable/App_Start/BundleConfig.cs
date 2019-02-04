using System.Web.Optimization;

namespace EmployeeTable
{
    public class BundleConfig
    {

        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Bundles/scripts").Include(

                // the order is important, because Bootstrap is using Jquery, so i have to Put Jquery before Bootstrap

                "~/Scripts/modernizr-2.6.2.js",
                "~/Scripts/jquery-1.10.2.min.js",
                "~/Scripts/bootstrap.min.js",
                "~/Scripts/jquery.validate.js",
                "~/Scripts/jquery.validate.unobtrusive.js",
            "~/Scripts/jquery.unobtrusive-ajax.min.js"
                ));


        }

    }
}