using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpFeatures
{
    internal class _05
    {
        private static readonly AsyncLogger logger = new AsyncLogger();

        internal static async void Runner()
        {
            try
            {
                await logger.Log("Start");

                _04.JoinTwoStrings("a", null);
            }
            catch (Exception exception)
            {
                logger.Log(exception.Message).Wait();
            }
            finally
            {
                logger.Log("Done").Wait();
            }

            #region CS6
            try
            {
                await logger.Log("Start");

                _04.JoinTwoStrings("a", null);
            }
            catch (Exception exception)
            {
                await logger.Log(exception.Message);
            }
            finally
            {
                await logger.Log("Done");
            }
            #endregion
        }

        internal class AsyncLogger
        {
            internal async Task Log(string message)
            {
                // do async logging
                await Task.Delay(1000);

                Console.WriteLine(message);

                return;
            }
        }
    }
}
