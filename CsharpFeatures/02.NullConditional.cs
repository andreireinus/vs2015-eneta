using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpFeatures
{
    internal class _02
    {
        public static void Runner()
        {
            var company = new Company();

            #region CS5 - Get Parent - Parent - CEO Name

            var name = (company != null && company.Parent != null && company.Parent.Parent != null && company.Parent.Parent.CEO != null && company.Parent.Parent.CEO.FullName != null)
                       ? company.Parent.Parent.CEO.FullName
                       : "Unknown";

            #endregion CS5 - Get Parent - Parent - CEO Name

            #region CS6
            //var name = company?.Parent?.Parent?.CEO?.FullName ?? "Unknown";
            #endregion
        }
    }
}