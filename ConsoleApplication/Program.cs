using System;
using System.Xml;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            LocalVariableInlineExample(args[0]);
            LocalVariableInlineExample("20.0");
        }

        #region LocalVariable / Inline
        private static void LocalVariableInlineExample(string arg)
        {
            Console.WriteLine("radius: {0}", Convert.ToDouble(arg));
            var area = Convert.ToDouble(arg) * Convert.ToDouble(arg) * Math.PI;
            Console.WriteLine("area: {0}", area);
        }
        #endregion
    }
}
