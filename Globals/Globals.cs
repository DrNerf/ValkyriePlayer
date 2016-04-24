using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public static class Globals
    {
        public const string DefaultTitle = "Valkyrie Player";

        public static IEnumerable<string> GetAvailableResolutions()
        {
            var scope = new ManagementScope();

            var query = new ObjectQuery("SELECT * FROM CIM_VideoControllerResolution");

            using (var searcher = new ManagementObjectSearcher(scope, query))
            {
                var results = searcher.Get();

                foreach (var result in results)
                {
                    //yield return string.Format(
                    //    "caption={0}, description={1} resolution={2}x{3} " +
                    //    "colors={4} refresh rate={5}|{6}|{7} scan mode={8}",
                    //    result["Caption"], result["Description"],
                    //    result["HorizontalResolution"],
                    //    result["VerticalResolution"],
                    //    result["NumberOfColors"],
                    //    result["MinRefreshRate"],
                    //    result["RefreshRate"],
                    //    result["MaxRefreshRate"],
                    //    result["ScanMode"]);
                    yield return string.Format(
                                        "{0}x{1}", 
                                        result["HorizontalResolution"], 
                                        result["VerticalResolution"]);
                }
            }
        }
    }
}
