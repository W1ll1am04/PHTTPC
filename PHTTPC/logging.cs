using System;
using System.IO;
using System.Collections.Generic;
using PHTTPC.Properties;

namespace PHTTPC
{
    class logging
    {
        StreamWriter logwriter;
        exception_display exp_d = new exception_display();

        #region public
        public void info(string whtl, bool ns=false)
        {
            do_log(whtl, 0, ns);
            return;
        }

        public void warning(string whtl, bool ns=false)
        {
            do_log(whtl, 1, ns);
            return;
        }

        public void error(string whtl, bool ns=false)
        {
            do_log(whtl, 2, ns);
            return;
        }

        public void exception(string whtl, bool ns=false)
        {
            do_log(whtl, 3, ns);
            return;
        }

        public void other(string whtl, bool ns=false)
        {
            do_log(whtl, 4, ns);
            return;
        }
        #endregion
        
        private void do_log(string whtl, int fsel, bool ns=false)
        {
            try
            {
                List<string> formatting = new List<string> { "INFO => ", "WARNING => ", "ERROR => ", "EXCEPTION => ", "OTHER => " };
                DirectoryInfo directory = new DirectoryInfo(Directory.GetCurrentDirectory());
                logwriter = new StreamWriter(Settings.Default.logname, Settings.Default.doappend);

                if (directory.Attributes != FileAttributes.ReadOnly)
                {
                    if (Settings.Default.do_console_log == true)
                        Console.WriteLine(DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]") + " INFO => Trying to write to log.");
                    using (logwriter)
                    {
                        if (ns != true)
                        {
                            logwriter.WriteLine(DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]") + " " + formatting[fsel] + whtl, true);
                        }
                        else
                        {
                            logwriter.WriteLine("----" + whtl + "----", true);
                        }
                    }
                    if (Settings.Default.do_console_log == true)
                        Console.WriteLine(DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]") + " INFO => Sucessfully wrote to log.");
                    return;
                }
                else
                {
                    Console.WriteLine(DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]") + " ERROR => Cannot write log to '" + Directory.GetCurrentDirectory() + "' directory is readonly.");
                    return;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]") + " EXCEPTION => " + ex.Message);
                exp_d.show_exception(ex);
            }
        }

        public bool getState()
        {
            if (logwriter != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Close()
        {
            try
            {
                Console.WriteLine(DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]") + " INFO => Attempting to close logger.");
                if (logwriter != null)
                {
                    logwriter.Close();
                    logwriter = null;
                    Console.WriteLine(DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]") + " INFO => Logger closed.");
                }
                else
                {
                    Console.WriteLine(DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]") + " INFO => Could not close logger because it was already closed.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]") + "EXCEPTION => Could not close logger. Exception: " + ex.Message);
                exp_d.show_exception(ex);
            }
        }
    }
}