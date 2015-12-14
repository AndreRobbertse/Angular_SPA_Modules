using Cassette;
using Cassette.Scripts;
using Cassette.Stylesheets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xtreme.Reports.App_Start
{
    public class CassetteConfiguration : IConfiguration<BundleCollection>
    {
        public void Configure(BundleCollection bundles)
        {
            AddStylesheetBundles(bundles);
            AddScriptBundles(bundles);
        }

        private static void AddScriptBundles(BundleCollection bundles)
        {
            // A bundle of the core scripts
            bundles.Add<ScriptBundle>("~/bundles/core", new[] {
                    "~/scripts/jquery-1.10.2.js",
                    "~/scripts/bootstrap.js",
                    "~/scripts/respond.js",
                    "~/scripts/modernizr-2.6.2.js",
            });

            // A bundle of the angular scripts
            bundles.Add<ScriptBundle>("~/bundles/angular", new[] {
                    "~/scripts/angular.js",
                    "~/scripts/angular-route.js",
                    "~/scripts/angular-resource.js",
                    "~/scripts/angular-loader.js",
            });

            // A bundle of the angular scripts
            bundles.Add<ScriptBundle>("~/bundles/angularui", new[] {
                    "~/scripts/angular-ui/ui-bootstrap.js"
            });

            // A bundle of the angular scripts
            bundles.Add<ScriptBundle>("~/bundles/grid", new[] {
                    "~/scripts/ui-grid.js",
            });

            bundles.Add<ScriptBundle>("~/client/");

        } //AddScriptBundles

        private static void AddStylesheetBundles(BundleCollection bundles)
        {
            bundles.Add<StylesheetBundle>("~/bundles/css", new[] {
                      "~/styles/bootstrap.min.css",
                      "~/styles/site.css",
                      "~/styles/font-awesome.min.css",
                      "~/Content/ui-grid.min.css"
            });

        } //AddStylesheetBundles

    }
}
