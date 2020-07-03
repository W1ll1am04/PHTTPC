using System;
using System.Net;
using System.Management;
using System.Diagnostics;
using PHTTPC.Properties;

namespace PHTTPC
{
    class function
    {
        /* This class cotains all kinds of functions to small to get their own class. */

        logging logger = new logging();
        exception_display excpd = new exception_display();

        public void displayHelp()
        {
            Console.WriteLine("usage: PHTTPC.exe [OPTION]... [OPTION]... [OPTION]...");
            Console.WriteLine("Python3 HTTP.Server Module configurator with costum directory support.");
            Console.WriteLine("Arguments & usage, and an explanation: ");
            Console.WriteLine();
            Console.WriteLine("-h, --help                       display this message.");
            Console.WriteLine("-n, --no-ip                      dont fetch IP information..");
            Console.WriteLine("-s, --startconfig [OPTION]       Start the default configuration and then start form.");
            Console.WriteLine("\nStartconfig options:\n-u, --no-ui                      Start default config without starting form.");
            Console.ReadKey();
            Environment.Exit(0);
        }

        public void set_default_console()
        {
            try
            {
                Console.Title = "PHTTPC debug console.";
            }
            catch (Exception ex)
            {
                Console.WriteLine(current_time() + "EXCEPTION => Unable to set console title. Exception: " + ex);
                return;
            }
        }

        public IPHostEntry returnip(int selection)
        {
            string hostname = Dns.GetHostName();
            IPHostEntry iphostentry;
            switch (selection)
            {
                case 1:
                    iphostentry = Dns.GetHostEntry(hostname);
                    break;
                case 2:
                    iphostentry = Dns.GetHostByName(hostname); /* ipv4 only */
                    break;
                default:
                    throw new ArgumentException("Invalid argument: '" + selection + "' is not in range of (1,2)");
            }
            return iphostentry;
        }

        public void log_write(string log_info)
        {
            try
            {
                Console.WriteLine(current_time() + log_info);
                logger.info(log_info);
            }
            catch (Exception ex)
            {
                Console.WriteLine(current_time() + " EXCEPTION => " + ex.Message);
                excpd.show_exception(ex);
                logger.exception(ex.Message);
            }
        }

        public string getram()
        {
            /* Fetch ram amount */
            try
            {
                if (Settings.Default.enable_bss == true)
                {
                    log_write(" INFO => trying to fetch total ram.");

                    ManagementClass ram_man = new ManagementClass("Win32_PhysicalMemory");
                    double capacity = 0;
                    ManagementObjectCollection ram_inst = ram_man.GetInstances();

                    foreach (ManagementObject mo1 in ram_inst)
                    {
                        capacity += ((Math.Round(Int64.Parse(mo1.Properties["Capacity"].Value.ToString()) / 1024 / 1024 / 1024.0, 1)));
                    }

                    ram_inst.Dispose();
                    ram_man.Dispose();

                    log_write(" INFO => fetched total ram: " + capacity.ToString() + "GB");
                    return capacity.ToString() + "GB";
                }
                return null;
            }
            catch (Exception ex)
            {
                try
                {
                    log_write("EXCEPTION => While trying to fetch total ram an exception occured: " + ex.Message);
                    logger.exception(ex.Message);
                    excpd.show_exception(ex);
                    return null;
                }
                catch (Exception ex_)
                {
                    Console.WriteLine(current_time() + " EXCEPTION => While handling exception another exception occured: " + ex_.Message);
                    return null;
                }
            }
        }

        public string current_time()
        {
            try
            {
                string time = DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]");
                return time;
            }
            catch (Exception ex)
            {
                Console.WriteLine(current_time() + " EXCEPTION => " + ex.Message);
                excpd.show_exception(ex);
                logger.exception(ex.Message);
                return "[0]";
            }
        }

        Stopwatch uptime_count = new Stopwatch();
        

        public string start_count()
        {
            try
            {
                uptime_count.Start();
                while (true)
                {
                    return (uptime_count.Elapsed.ToString("mm\\:ss\\.ff"));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(current_time() + " EXCEPTION => " + ex.Message);
                logger.exception(ex.Message);
                excpd.show_exception(ex);
                return null;
            }
        }
        public void stop_count()
        {
            try
            {
                uptime_count.Reset();
                uptime_count.Stop();
            }
            catch (Exception ex)
            {
                Console.WriteLine(current_time() + " EXCEPTION => " + ex.Message);
                logger.exception(ex.Message);
                excpd.show_exception(ex);
            }
        }
        public string count_elapsed()
        {
            try
            {
                return uptime_count.Elapsed.ToString("mm\\:ss\\.ff");
            }
            catch (Exception ex)
            {
                Console.WriteLine(current_time() + " EXCEPTION => " + ex.Message);
                logger.exception(ex.Message);
                excpd.show_exception(ex);
                return null;
            }
        }
    }
}
