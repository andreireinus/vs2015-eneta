using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AwaitCatchFinally
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private static string JoinTwoStrings(string a, string b)
        {
            if (a == null)
            {
                throw new ArgumentNullException("a");
            }

            if (b == null)
            {
                throw new ArgumentNullException("b");
            }

            return a + b;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                await Log("Start");

                JoinTwoStrings("a", null);
            }
            catch (Exception exception)
            {
                Log(exception.Message).Wait();
            }
            finally
            {
                Log("Done").Wait();
            }

            #region Working-ish
            //try
            //{
            //    await Log("Start");

            //    JoinTwoStrings("a", null);
            //}
            //catch (Exception exception)
            //{
            //    Task.Factory.StartNew(() =>
            //    {
            //        Log(exception.Message).Wait();
            //    });
            //}
            //finally
            //{
            //    Task.Factory.StartNew(() =>
            //    {
            //        Log("Done").Wait();
            //    });
            //}
            #endregion

            #region CS6
            //try
            //{
            //    await Log("Start");

            //    JoinTwoStrings("a", null);
            //}
            //catch (Exception exception)
            //{
            //    await Log(exception.Message);
            //}
            //finally
            //{
            //    await Log("Done");
            //}
            #endregion
        }

        private async Task Log(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(async () =>
                {
                    await Log(message);
                }));
                return;
            }
            await Task.Delay(1000);

            tbLog.Text += message + Environment.NewLine;
        }
    }
}
