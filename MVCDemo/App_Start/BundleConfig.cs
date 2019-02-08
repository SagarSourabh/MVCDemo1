using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace MVCDemo.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/css").Include(
                                                        "~/Content/CSS/bootstrap.min.css",
                                                        "~/Content/CSS/prettyphoto.css", "~/Content/CSS/font-awesome.min.css", "~/Content/CSS/font-awesome.min.css", "~/Content/CSS/style.css"
                                                    ));
            // add ScriptBundle here..  

        }
    }
}