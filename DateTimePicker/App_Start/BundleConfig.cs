using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace DateTimePicker.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
        //    bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
        //"~/Scripts/jquery-{version}.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));


            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //  "~/Scripts/bootstrap.js"));

                bundles.Add(new StyleBundle("~/Content/css").Include(
                           "~/Content/bootstrap.css",
                          "~/Content/bootstrap-datetimepicker.css",
                          "~/Content/Site.css"
                          ));

            bundles.Add(new ScriptBundle("~/bundles/myscripts").Include(
                   "~/Scripts/jquery-3.3.1.js",
                   "~/Scripts/moment.js",
                   "~/Scripts/bootstrap.js",
                   "~/Scripts/bootstrap-datetimepicker.js",
                   "~/Scripts/Site.js"
                   ));
        }
    }
}