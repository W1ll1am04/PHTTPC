using System;
using System.Text;
using System.Windows.Forms;

namespace PHTTPC
{
    /* This class builds and displays exceptions. */

    public partial class exception_display : Form
    {
        public static string exv;
        public static string exd_t;

        public exception_display()
        {
            InitializeComponent();
        }

        public void show_exception(Exception ex)
        {
            try
            {
                if (ex != null)
                {
                    /* build stacktrace safely. */
                    var sb = new StringBuilder();
                    sb.AppendLine(ex.Message);
                    sb.AppendLine(ex.StackTrace);

                    exv = sb.ToString();
                    exd_t = ex.Message;
                    this.ShowDialog();
                }
                else
                {
                    Console.WriteLine(DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]") + " ERROR => While handling an exception: Exception to show's exception information is null.");
                }
            }
            catch (Exception ex_)
            {
                Console.WriteLine(DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]") + " EXCEPTION => While trying to display exception: An exception occured while getting exception information. Exception: " + ex_.Message);
                return;
            }
            return;
        }

        private void exception_display_getexception(object sender, EventArgs e)
        {
            try
            {
                this.Icon = Properties.Resources.PHTTPC_ICON;

                Console.WriteLine(DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]") + " INFO => Trying to set exception information.");
                exception.Text = exd_t;
                stacktrace.Text = exv;
            }
            catch (Exception ex)
            {
                Console.WriteLine("EXCEPTION => While trying to display exception: An exception occured while getting exception information. Exception: " + ex.Message);
            }
        }    
    }
}
