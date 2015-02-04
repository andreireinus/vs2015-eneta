using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpFeatures
{
    public static class _01
    {
        public static void Runner()
        {
            var company = new Company();
            Console.WriteLine(nameof(company));
        }

		public static void Runner2()
        {
            PrintCompany(new Company { Name = "OÜ Mees & Koer" });
            //PrintCompany(null);
        }

		private static void PrintCompany(Company company)
        {
			if (company == null)
            {
                throw new ArgumentNullException("company");
            }
            Console.WriteLine(company.Name);
        }

    }

    #region Extension
	public static class ObjectExtensions
    {
        public static void AssertNotNull(this object obj, string argumentName)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(argumentName);
            }
        }
    }
    #endregion
}
