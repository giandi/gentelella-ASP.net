using System.Web;
using System.Web.Optimization;

namespace Beheer
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/scripts/global").Include(
                        "~/vendors/jquery/dist/jquery.min.js",
                        "~/vendors/bootstrap/dist/js/bootstrap.min.js",
                        "~/vendors/fastclick/lib/fastclick.js",
                        "~/vendors/nprogress/nprogress.js",
                        "~/vendors/Chart.js/dist/Chart.min.js",
                        "~/vendors/gauge.js/dist/gauge.min.js",
                        "~/vendors/bootstrap-progressbar/bootstrap-progressbar.min.js",
                        "~/vendors/iCheck/icheck.min.js",
                        "~/vendors/skycons/skycons.js",
                        "~/vendors/Flot/jquery.flot.js",
                        "~/vendors/Flot/jquery.flot.pie.js",
                        "~/vendors/Flot/jquery.flot.time.js",
                        "~/vendors/Flot/jquery.flot.stack.js",
                        "~/vendors/Flot/jquery.flot.resize.js",
                        "~/vendors/flot.orderbars/js/jquery.flot.orderBars.js",
                        "~/vendors/flot-spline/js/jquery.flot.spline.min.js",
                        "~/vendors/flot.curvedlines/curvedLines.js",
                        "~/vendors/DateJS/build/date.js",
                        "~/vendors/jqvmap/dist/jquery.vmap.js",
                        "~/vendors/jqvmap/dist/maps/jquery.vmap.world.js",
                        "~/vendors/jqvmap/examples/js/jquery.vmap.sampledata.js",
                        "~/vendors/moment/min/moment.min.js",
                        "~/vendors/bootstrap-daterangepicker/daterangepicker.js",
                        "~/vendors/fullcalendar/dist/fullcalendar.min.js",
                        "~/vendors/raphael/raphael.min.js",
                        "~/vendors/morris/morris.min.js",
                        "~/vendors/echarts/dist/echarts.min.js",
                        "~/vendors/echarts/map/js/world.js",
                        "~/vendors/jqvmap/dist/jquery.vmap.js",
                        "~/vendors/jqvmap/dist/maps/jquery.vmap.world.js",
                        "~/vendors/jqvmap/dist/maps/jquery.vmap.usa.js",
                        "~/vendors/jqvmap/examples/js/jquery.vmap.sampledata.js",
                        "~/vendors/jquery.easy-pie-chart/dist/jquery.easypiechart.min.js",
                        "~/vendors/switchery/dist/switchery.min.js",
                        "~/vendors/select2/dist/js/select2.full.min.js",
                        "~/vendors/parsleyjs/dist/parsley.min.js",
                        "~/vendors/autosize/dist/autosize.min.js",
                        "~/vendors/devbridge-autocomplete/dist/jquery.autocomplete.min.js",
                        "~/vendors/starrr/dist/starrr.js",
                        "~/scripts/js/custom.min.js"));


            //css
            bundles.Add(new StyleBundle("~/styles/global").Include(
                        "~/vendors/bootstrap/dist/css/bootstrap.min.css",
                        "~/vendors/font-awesome/css/font-awesome.min.css",
                        "~/vendors/nprogress/nprogress.css",
                        "~/vendors/iCheck/skins/flat/green.css",
                        "~/vendors/bootstrap-progressbar/css/bootstrap-progressbar-3.3.4.min.css",
                        "~/vendors/jqvmap/dist/jqvmap.min.css",
                        "~/vendors/bootstrap-daterangepicker/daterangepicker.css",
                        "~/vendors/fullcalendar/dist/fullcalendar.min.css",
                        "~/vendors/fullcalendar/dist/fullcalendar.print.css",
                        "~/css/custom.min.css"));
        }
    }
}



