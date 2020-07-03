using System;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using PHTTPC.Properties;

namespace PHTTPC
{
    public partial class tweaks : Form
    {
        public tweaks()
        {
            InitializeComponent();
        }

        exception_display excpd = new exception_display();
        logging logger = new logging();
        function func = new function();

        private void tweaks_load(object sender, EventArgs e)
        {
            try
            {
                switch (Settings.Default.int_value)
                {
                    case 0:
                        trackBar1.Value = 0;
                        break;
                    case 1:
                        trackBar1.Value = 1;
                        break;
                    case 2:
                        trackBar1.Value = 2;
                        break;
                    case 3:
                        trackBar1.Value = 3;
                        break;
                    case 4:
                        trackBar1.Value = 4;
                        break;
                    default:
                        func.log_write(" INFO => Default ram_counter interval was not in range of 1,4 to it was reset to 4.");
                        Settings.Default.int_value = 4;
                        trackBar1.Value = 4;
                        break;
                }
                func.log_write(" INFO => New form 'tweaks' sucessfully created.");

                this.Icon = Resources.PHTTPC_ICON;
                load_settings();
            }
            catch (Exception ex)
            {
                func.log_write(" EXCEPTION => " + ex.Message);
                logger.exception(ex.Message);
                excpd.show_exception(ex);
            }
        }

        private void save_settings()
        {
            try
            {
                func.log_write(" INFO => Attempting to save tweaks..");
                if (checkBox1.Checked) { Settings.Default.enable_bss = true; }
                else { Settings.Default.enable_bss = false; }
                if (checkBox2.Checked) { Settings.Default.do_console_log = true; }
                else { Settings.Default.do_console_log = false; }
                Settings.Default.Save();
                func.log_write(" INFO => Sucessfully saved configuration.");
            }
            catch (Exception ex)
            {
                func.log_write(" EXCEPTION => While saving an exception occured: " + ex.Message + ", therefore some things may not be saved.");
                logger.exception(ex.Message);
                excpd.show_exception(ex);
            }

        }

        private void tweaks_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (checkBox1.Checked != Settings.Default.enable_bss || checkBox2.Checked != Settings.Default.do_console_log)
                {
                    DialogResult sfbc = MessageBox.Show("Save before closing-tweaks?", "Confirm close.", MessageBoxButtons.YesNoCancel);
                    if (sfbc == DialogResult.Yes)
                    {
                        try
                        {
                            save_settings();
                        }
                        catch (Exception ex)
                        {
                            func.log_write("EXCEPTION => " + ex.Message);
                            excpd.show_exception(ex);
                        }

                        logger.Close();
                    }
                    e.Cancel = (sfbc == DialogResult.Cancel);
                }
                else
                {
                    logger.Close();
                }
            }
            catch (Exception ex)
            {
                func.log_write(" EXCEPTION => " + ex.Message);
                logger.exception(ex.Message);
                excpd.show_exception(ex);
            }
        }
        private void load_settings()
        {
            try
            {
                if (Settings.Default.enable_bss) { checkBox1.Checked = true; }
                else { checkBox1.Checked = false; }
                if (Settings.Default.do_console_log) { checkBox2.Checked = true; }
                else { checkBox2.Checked = false; }
                func.log_write(" INFO => sucessfully loaded tweaks-settings.");
            }
            catch (Exception ex)
            {
                func.log_write(" EXCEPTION => an exception occured while loading settings: " + ex.Message);
                logger.exception(ex.Message);
                excpd.show_exception(ex);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string file = "phttpc.log";
                func.log_write(" INFO => Clearing log. reason: manual request.");
                if (File.Exists(file))
                {
                    File.Delete(file);
                    File.Create(file).Close();
                }
                logger.info("Clearing log. Reason: Manual request.");
            }
            catch (Exception ex) {
                Console.WriteLine(func.current_time() + " EXCEPTION => an exception occured while setting console title: " + ex.Message);
                logger.exception(ex.Message);
                excpd.show_exception(ex);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(Directory.GetCurrentDirectory());
            }
            catch (Exception ex)
            {
                Console.WriteLine(func.current_time() + " EXCEPTION => an exception occured while setting console title: " + ex.Message);
                logger.exception(ex.Message);
                excpd.show_exception(ex);
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            try
            {
                switch (trackBar1.Value)
                {
                    case 0:
                        Settings.Default.int_value = 0;
                        break;
                    case 1:
                        Settings.Default.int_value = 1;
                        break;
                    case 2:
                        Settings.Default.int_value = 2;
                        break;
                    case 3:
                        Settings.Default.int_value = 3;
                        break;
                    case 4:
                        Settings.Default.int_value = 4;
                        break;
                    default:
                        Settings.Default.int_value = 4;
                        break;
                }
                Settings.Default.Save();
            }
            catch (Exception ex)
            {
                Console.WriteLine(func.current_time() + " EXCEPTION => an exception occured while setting console title: " + ex.Message);
                logger.exception(ex.Message);
                excpd.show_exception(ex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Adjust the ram usage performance-counter internval, from 0.1 to 0.5 secounds.", "Timer interval help.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(func.current_time() + " EXCEPTION => an exception occured while setting console title: " + ex.Message);
                logger.exception(ex.Message);
                excpd.show_exception(ex);
            }
        }
    }
}
