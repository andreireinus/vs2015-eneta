using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpFeatures
{
    internal class _04
    {
        public static void Runner()
        {
            try
            {
                var result = JoinTwoStrings(null, null);
                Console.WriteLine(result);
            }
            catch (ArgumentNullException exception)
            {
                if (exception.ParamName == "a")
                {
                    // Tee ühte asja
                }
                else if (exception.ParamName == "b")
                {
                    // Käitu teisiti
                }
            }
            catch
            {
                throw;
            }

            #region CS6
            try
            {
                var result = JoinTwoStrings(null, null);
                Console.WriteLine(result);
            }
            catch (ArgumentNullException exception) if (exception.ParamName == "a")
            {
                // Tee ühte asja
            }
            catch (ArgumentNullException exception) if (exception.ParamName == "b")
            {
                // Käitu teisiti
            }
            catch
            {
                throw;
            }
            #endregion
        }

        internal static string JoinTwoStrings(string a, string b)
        {
            a.AssertNotNull(nameof(a));
            b.AssertNotNull(nameof(b));

            return a + b;
        }
    }
}
