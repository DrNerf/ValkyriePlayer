using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace Common.Classes
{
    public static class Globals
    {
        public static IEnumerable<string> GetAvailableResolutions()
        {
            var scope = new ManagementScope();

            var query = new ObjectQuery("SELECT * FROM CIM_VideoControllerResolution");

            using (var searcher = new ManagementObjectSearcher(scope, query))
            {
                var results = searcher.Get();

                foreach (var result in results)
                {
                    yield return string.Format(
                                        "{0}x{1}",
                                        result["HorizontalResolution"],
                                        result["VerticalResolution"]);
                }
            }
        }
    }
}
