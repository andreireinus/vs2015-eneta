using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpFeatures
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                _05.Runner();
            }
            catch (ArgumentNullException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

            Console.ReadKey();
        }
    }

    public class Company
    {
        public string Name { get; set; }

        public Company Parent { get; set; }

        public Person CEO { get; set; }
    }

    public class Person
    {
        public string FullName { get; set; }
    }
}
