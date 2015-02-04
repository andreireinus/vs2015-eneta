using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpFeatures
{
    internal class _03
    {
        public static void Runner()
        {
            var companies = new Dictionary<int, Company> {
                { 11, new Company { Name = "AS Sindrinahk & Pojad" } },
                { 42, new Company { Name = "Kalew" } }
            };

            #region CS6
            //companies = new Dictionary<int, Company>
            //{
            //    [11] = new Company { Name = "AS Sindrinahk & Pojad" },
            //    [42] = new Company { Name = "Kalew" }
            //};
            #endregion CS6
        }
    }
}