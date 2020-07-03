using System;
using PHTTPC.Properties;

namespace PHTTPC
{
    class args_handler
    {
        /* This class handles commad-line arguments. */

        public void handle()
        {
            try
            {
                Form1 main = new Form1(); /* If it were to define these globally in this class, it would throw an StackOverflow exception */
                function func = new function();
                logging logger = new logging();
                exception_display excpd = new exception_display();

                string[] args = Environment.GetCommandLineArgs();
                int al = args.Length - 1;
                if (args.Length > 1)
                {
                    int i = 1;
                    for (int y = 0; y < al; y++)
                    {
                        if (args[i] == "--startconfig" || args[i] == "-s")
                        {
                            if (al > i)
                                i++;
                            main.start_process(1);
                            if (args[i] == "--no-ui" || args[i] == "-u")
                            {
                                Environment.Exit(0);
                                break;
                            }
                        }

                        if (args[i] == "--no-ip" || args[i] == "-n")
                        {
                            if (al > i)
                                i++;
                            Settings.Default.do_ip = false;
                            Settings.Default.trg_arg_IP = true;
                            Settings.Default.Save();
                        }

                        if (args[i] == "--help" || args[i] == "-h")
                        {
                            if (al > i)
                                i++;
                            func.set_default_console();
                            func.displayHelp();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                function func = new function();
                logging logger = new logging();
                exception_display excpd = new exception_display();

                func.log_write("EXCEPTION => " + ex.Message);
                logger.exception(ex.Message);
                excpd.show_exception(ex);
            }
        }
    }
}
