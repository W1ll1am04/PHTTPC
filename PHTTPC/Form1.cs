using System;
using System.Net;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using PHTTPC.Properties;

namespace PHTTPC
{

    public partial class Form1 : Form {

        /*
            w1ll1am04.github.io/repositories/
                                                */

        public Form1() {
            InitializeComponent();
        }
        
        PerformanceCounter ramCounter;
        exception_display excpd = new exception_display();
        logging logger = new logging();
        tweaks tweaks = new tweaks();
        function func = new function();
        args_handler arg_handler = new args_handler();
        static Process process;

        bool has_exited = false;

        private void Form1_Load(object sender, EventArgs e){
            try
            {
                Settings.Default.do_ip = true;
                Settings.Default.trg_arg_IP = false;
                Settings.Default.Save();
                
                arg_handler.handle();
            }
            catch (Exception ex)
            {
                func.log_write(" EXCEPTION => " + ex.Message);
                logger.exception(ex.Message);
                excpd.show_exception(ex);
            }
            try
            {
                if (Settings.Default.debug == true)
                    Console.WriteLine(func.current_time() + " DEBUG => value: "+Settings.Default.int_value);

                logger.info("New logger session started", true);
                func.log_write(" INFO => Setting logger to log to: '" + Settings.Default.logname + "'.");
            }
            catch (Exception ex) {
                func.log_write("EXCEPTION => - add some explain here - an exception occured: " + ex.Message);
                logger.exception(ex.Message);
                excpd.show_exception(ex);
            }
            try
            {
                ram_total.Text = func.getram();
            }
            catch (Exception ex)
            {
                func.log_write("EXCEPTION => " + ex.Message);
                logger.exception(ex.Message);
                excpd.show_exception(ex);
            }
            try
            {
                /* convert Int_value from tweaks to interval.*/
                switch (Settings.Default.int_value)
                {
                    case 0:
                        ram_counter.Interval = 100;
                        break;
                    case 1:
                        ram_counter.Interval = 200;
                        break;
                    case 2:
                        ram_counter.Interval = 300;
                        break;
                    case 3:
                        ram_counter.Interval = 400;
                        break;
                    case 4:
                        ram_counter.Interval = 500;
                        break;
                    default:
                        Console.WriteLine(func.current_time() + " INFO => Int_value was not in range of '100 - 500', so it was reset to 500.");
                        Settings.Default.int_value = 500;
                        ram_counter.Interval = 500;
                        break;
                }
            }
            catch (Exception ex)
            {
                func.log_write("EXCEPTION => " + ex.Message);
                logger.exception(ex.Message);
                excpd.show_exception(ex);
            }

            /* Set debug console title*/
            try
            {
                func.set_default_console();
                func.log_write(" INFO => sucessfully sat console title.");
            }
            catch (Exception ex1){
                Console.WriteLine(func.current_time() + " EXCEPTION => an exception occured while setting console title: " + ex1.Message);
                logger.exception(ex1.Message);
                excpd.show_exception(ex1);
            }
            /* Trigger load_settings() function */
            try
            {
                load_settings();
            }
            catch (Exception ex2){
                Console.WriteLine(func.current_time() + " EXCEPTION => an exception occured while loading settings: " + ex2.Message);
                logger.exception(ex2.Message);
                excpd.show_exception(ex2);
            }
        }

        /* save settings. */

        private void save_settings(){
            try
            {
                func.log_write(" INFO => Attempting save..");
                Properties.Settings.Default.port = port_in.Text;
                Properties.Settings.Default.ip = ip_in.Text;
                Properties.Settings.Default.directory = directory_in.Text;
                Properties.Settings.Default.pypath = pypath_in.Text;
                if (checkBox1.Checked){Properties.Settings.Default.sphp = true;}
                else{Properties.Settings.Default.sphp = false;}
                if (checkBox2.Checked) {Properties.Settings.Default.useipv6 = true;}
                else { Properties.Settings.Default.useipv6 = false; }
                Properties.Settings.Default.Save();
                Console.WriteLine(func.current_time() + " INFO => Sucessfully saved configuration.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(func.current_time() + " EXCEPTION => While saving an exception occured: " + ex.Message + ", therefore some things may not be saved.");
                logger.exception(ex.Message);
                excpd.show_exception(ex);
            }

        }

        /* load settings */

        private void load_settings(){
            try
            {
                if (Settings.Default.enable_bss == true)
                {
                    func.log_write(" INFO => Enabling statusbar..");
                    status.Visible = true;
                    label8.Visible = false;
                    process_ram_alt.Visible = false;
                    this.MaximumSize = new System.Drawing.Size(978, 536);
                    this.Size = new System.Drawing.Size(978, 536);
                    func.log_write(" INFO => Statusbar enabled.");
                }
                else
                {
                    func.log_write(" INFO => Disabling statusbar..");
                    status.Visible = false;
                    label8.Visible = true;
                    process_ram_alt.Visible = true;
                    this.MaximumSize = new System.Drawing.Size(978, 512);
                    func.log_write(" INFO => Statusbar disabled.");
                }
                func.log_write(" INFO => Trying to load ipadresses.");
                
                /*Get IPAdresses into listbox (ipbox).*/
                if (Settings.Default.do_ip == false) { ipbox.Items.Add("Disabled"); ipbox.Enabled = false; } else
                {
                    int i;
                    if (Properties.Settings.Default.useipv6 == true) { i = 1; } else{ i = 2; }
                    if (i==1) {func.log_write(" INFO => Using DNS.GetHostEntry."); func.log_write(" INFO => Sucessfully loaded DNS.GetHostEntry.");}
                    if (i==2) {func.log_write(" INFO => Using DNS.GetHostByName."); func.log_write(" INFO => Sucessfully loaded DNS.GetHostByName.");}
                    foreach (IPAddress ipaddress in func.returnip(i).AddressList)
                    {
                        ipbox.Items.Add(ipaddress);
                    }
                    ipbox.Items.Add("127.0.0.1");
                }
                func.log_write(" INFO => Trying loaded settings.");
                pyfind.InitialDirectory = Directory.GetCurrentDirectory();
                port_in.Text = Settings.Default["port"].ToString();
                ip_in.Text = Settings.Default["ip"].ToString();
                directory_in.Text = Settings.Default["directory"].ToString();
                pypath_in.Text = Settings.Default["pypath"].ToString();
                if (Settings.Default.sphp) { checkBox1.Checked = true; }
                else { checkBox1.Checked = false; }
                if (Settings.Default.useipv6) { checkBox2.Checked = true; }
                else { checkBox2.Checked = false; }
                func.log_write(" INFO => sucessfully loaded settings.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(func.current_time() + " INFO => an exception occured while loading settings: " + ex.Message);
                logger.exception(ex.Message);
                excpd.show_exception(ex);
            }
        }

        /* reset settings. */

        private void reset_settings(string reason){
            try
            {
                func.log_write(" INFO => Resetting settings.. reason: " + reason);
                Properties.Settings.Default.port = string.Empty;
                Properties.Settings.Default.ip = string.Empty;
                Properties.Settings.Default.directory = string.Empty;
                Properties.Settings.Default.pypath = string.Empty;
                Properties.Settings.Default.sphp = false;
                Properties.Settings.Default.useipv6 = false;
                Properties.Settings.Default.Save();
                port_in.Text = string.Empty;
                ip_in.Text = string.Empty;
                directory_in.Text = string.Empty;
                pypath_in.Text = string.Empty;
            }
            catch (Exception ex)
            {
                func.log_write(" INFO => While resetting settings, some exception occured: '" + ex.Message + "', Settings may not be properly reset due to this.");
                logger.exception(ex.Message);
                excpd.show_exception(ex);
            }
        }

        private void button1_Click(object sender, EventArgs e){
            about about = new about();
            func.log_write(" INFO => New form 'about' sucessfully created.");
            about.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            try
            {
                if (port_in.Text != Settings.Default.port || ip_in.Text != Settings.Default.ip || directory_in.Text != Settings.Default.directory || pypath_in.Text != Settings.Default.pypath || checkBox1.Checked != Settings.Default.sphp || checkBox2.Checked != Settings.Default.useipv6) {
                    DialogResult sfbc = MessageBox.Show("Save before closing?", "Confirm close.", MessageBoxButtons.YesNoCancel);
                    if (sfbc == DialogResult.Yes){
                        save_settings();
                        logger.Close();
                        ram_counter.Stop();
                        if (checkBox1.Checked == true)
                        {
                            if (process != null)
                            {
                                if (process.HasExited == true) { }
                                else { process.Kill(); }
                            }
                        }
                    }
                    e.Cancel = (sfbc == DialogResult.Cancel);
                }
                else{
                    DialogResult exit_box = MessageBox.Show("Are you sure you want to close?", "Confirm close.", MessageBoxButtons.YesNo);
                    e.Cancel = (exit_box == DialogResult.No);
                    if (exit_box == DialogResult.Yes)
                    {
                        logger.Close();
                        ram_counter.Stop();
                        if (checkBox1.Checked == true)
                        {
                            if (process != null)
                            {
                                if (process.HasExited == true) { }
                                else { process.Kill(); }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(func.current_time() + " EXCEPTION => " + ex.Message);
                logger.exception(ex.Message);
                excpd.show_exception(ex);
            }
        }

        private void button2_Click(object sender, EventArgs e){
            save_settings();
        }

        private void button5_Click(object sender, EventArgs e){
            DialogResult clear_config = MessageBox.Show("Are you sure you want to clear the current configuration?", "Are you sure?", MessageBoxButtons.YesNo);
            if (clear_config == DialogResult.Yes){
                reset_settings("Manual reset.");
                func.log_write(" INFO => reset all settings to standard values, due to request by user.");
            }
        }

        /* Checked change event*/

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            ipbox.Items.Clear();
            if (Settings.Default.do_ip == false) { ipbox.Items.Add("Disabled"); ipbox.Enabled = false; }
            else {
                int i;
                if (Settings.Default.trg_arg_IP == true) { if (Properties.Settings.Default.useipv6 == true) { i = 1; } else { i = 2; } }
                else { if (checkBox2.Checked == true) { i = 1; } else { i = 2; }  }
                if (i == 1) { func.log_write(" INFO => Using DNS.GetHostEntry."); func.log_write(" INFO => Sucessfully loaded DNS.GetHostEntry."); }
                if (i == 2) { func.log_write(" INFO => Using DNS.GetHostByName."); func.log_write(" INFO => Sucessfully loaded DNS.GetHostByName."); }
                foreach (IPAddress ipaddress in func.returnip(i).AddressList)
                {
                    ipbox.Items.Add(ipaddress);
                }

                ipbox.Items.Add("127.0.0.1");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            start_process(2);
        }

        /* Start process */

        public void start_process(int sorf_data)
        {
            try
            {
                has_exited = false;
                switch (sorf_data)
                {
                    case 1:
                        if (!string.IsNullOrEmpty(Settings.Default.pypath) && !string.IsNullOrEmpty(Settings.Default.port) && !string.IsNullOrEmpty(Settings.Default.directory) && !string.IsNullOrEmpty(Settings.Default.ip))
                        {
                            func.log_write(" INFO => Attempting to start python from '" + Settings.Default.pypath);
                            process = Process.Start(Settings.Default.pypath, " -m http.server " + Settings.Default.port + " --bind " + Settings.Default.ip + " --directory " + Settings.Default.directory);
                            do_rest();
                        }
                        else
                        {
                            MessageBox.Show("Invalid configuration: Path to python is null.", "Invalid configuration.");
                        }
                        break;
                    case 2:
                        if (!string.IsNullOrEmpty(pypath_in.Text) && !string.IsNullOrEmpty(port_in.Text) && !string.IsNullOrEmpty(directory_in.Text) && !string.IsNullOrEmpty(ip_in.Text))
                        {
                            func.log_write(" INFO => Attempting to start python from '" + pypath_in.Text);
                            process = Process.Start(pypath_in.Text, " -m http.server " + port_in.Text + " --bind " + ip_in.Text + " --directory " + directory_in.Text);
                            func.log_write(" INFO => Started performancecounter on process.");
                            do_rest();
                        }
                        else
                        {
                            MessageBox.Show("Invalid configuration: Path to python is null.", "Invalid configuration.");
                        }
                        break;
                    default:
                        throw new ArgumentException("Invalid argument: '" + sorf_data + "' is out of range of (1,2)");
                        #pragma warning disable CS0162 // Unreachable code detected
                        Environment.Exit(0); /* Just in case something goes horribly wrong. */
                        #pragma warning restore CS0162 // Unreachable code detected
                }
                void do_rest()
                {
                    process.EnableRaisingEvents = true;
                    process.Exited += new EventHandler(process_exit);
                    
                    uptime_refresh.Start();
                    ram_counter.Start();

                    button4.Enabled = true;
                    button3.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(func.current_time() + " EXCEPTION => " + ex.Message);
                logger.exception(ex.Message);
                excpd.show_exception(ex);
            }
        }

        /*At process exit*/

        private async void process_exit(object sender, System.EventArgs e)
        {
            try
            {
                func.log_write(" INFO => Detected process exit. Uptime was: " + func.count_elapsed());
                uptime_refresh.Stop();
                func.stop_count();
                has_exited = true;
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine(func.current_time() + " EXCEPTION => " + ex.Message);
                logger.exception(ex.Message);
                excpd.show_exception(ex);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult result = dir_select.ShowDialog();
            if (result == DialogResult.OK)
            {
                directory_in.Text = dir_select.SelectedPath;
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                func.log_write(" INFO => Showing selection directory dialog.");
                if (pyfind.ShowDialog() == DialogResult.OK)
                {
                    func.log_write(" INFO => setting Python to selected location: " + pyfind.FileName);
                    pypath_in.Text = pyfind.FileName;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(func.current_time() + " EXCEPTION => " + ex.Message);
                logger.exception(ex.Message);
                excpd.show_exception(ex);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Settings.Default.enable_bss) { process_ram_label.Text = "not started."; } else { process_ram_alt.Text = "not started."; }
            try
            {
                if (process != null)
                {
                    if (process.HasExited == true)
                    {
                        func.log_write(" INFO => Process had already exited.");
                        button3.Enabled = true;
                        button4.Enabled = false;
                    }
                    else
                    {
                        try { process.Kill(); func.log_write(" INFO => Process was killed."); }
                        catch (Exception ex) { Console.WriteLine(func.current_time() + " EXCEPTION => An exception occured while killing process: " + ex.Message); }
                        button3.Enabled = true;
                        button4.Enabled = false;
                    }
                }
                else
                {
                    Console.WriteLine(func.current_time() + " WARNING => Process is already dead. continuing...");
                    button3.Enabled = true;
                    button4.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(func.current_time() + "EXCEPTION => " + ex.Message);
                logger.exception(ex.Message);
                excpd.show_exception(ex);
            }
        }

        private void clock_Tick(object sender, EventArgs e)
        {
            try
            {
                if (has_exited != false)
                {
                    button4.Enabled = false;
                    button3.Enabled = true;
                    if (Settings.Default.enable_bss) { process_ram_label.Text = "not started."; } else { process_ram_alt.Text = "not started."; }
                    ram_counter.Stop();
                }
                else
                {
                    if (process != null)
                    {
                        if (process.HasExited == true)
                        {
                            process = null;
                        }
                    }
                    double ram = 0;
                    if (process != null)
                    {
                        ramCounter = new PerformanceCounter("Process", "Working Set", process.ProcessName);
                        if (process != null)
                        {
                            ram = ramCounter.NextValue();
                        }
                        else
                        {
                            ram_counter.Stop();
                        }
                        if (Settings.Default.enable_bss) { process_ram_label.Text = ((ram / 1024 / 1024) + " MB"); } else { process_ram_alt.Text = ((ram / 1024 / 1024) + " MB"); }
                    }
                    else
                    {
                        Console.WriteLine(func.current_time() + " ERROR => Detected that process is null. therefore process ram count has been stopped.");
                        ram_counter.Stop();
                        button4.Enabled = false;
                        button3.Enabled = true;
                    }
                }

            }
            catch (InvalidOperationException ex) 
            {
                Console.WriteLine(func.current_time() + " EXCEPTION => " + ex.Message + " Ignoring...");
                logger.warning(ex.Message + ", Ignoring...");
            }
            catch (Exception ex1)
            {
                Console.WriteLine(func.current_time() + " EXCEPTION => " + ex1.Message);
                logger.exception(ex1.Message);
                excpd.show_exception(ex1);
                Console.WriteLine(func.current_time() + " INFO => ");
                ram_counter.Stop();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                if (ram_counter.Enabled == true)
                {
                    ram_counter.Stop();
                }
                else
                {
                    func.log_write(" INFO => User requested to stop the process ram counter, but its not running.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(func.current_time() + " EXCEPTION => An exception occured whiile trying to stop clock interval, process ram count will therefore not be stopped, you can try to stop it via the GUI. Exception: " + ex.Message);
                logger.exception(ex.Message);
                excpd.show_exception(ex);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ram_counter.Enabled)
                {
                    ram_counter.Start();
                }
                else
                {
                    Console.WriteLine(func.current_time() +  " INFO => User requested to start the process ram counter, but its already running.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(func.current_time() +  " EXCEPTION => An exception occured while trying to start the process ram counter. Exception: " + ex.Message);
                logger.exception(ex.Message);
                excpd.show_exception(ex);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                Console.WriteLine(func.current_time() + " INFO => Attempting to restart process ram counter.");
                if (process != null)
                {
                    ram_counter.Stop();
                    ram_counter.Start();
                }
                else { Console.WriteLine(func.current_time() + " INFO => Cannot restart process ram counter. Process is null."); }

            }
            catch (Exception ex)
            {
                Console.WriteLine(func.current_time() +  "EXCEPTION => " + ex.Message);
                logger.exception(ex.Message);
                excpd.show_exception(ex);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                tweaks.ShowDialog();
                if (Settings.Default.enable_bss == true)
                {
                    func.log_write(" INFO => Resizing and enabling statusbar..");
                    status.Visible = true;
                    label8.Visible = false;
                    process_ram_alt.Visible = false;
                    this.MaximumSize = new System.Drawing.Size(978, 536);
                    this.Size = new System.Drawing.Size(978, 536);
                }
                else
                {
                    func.log_write(" INFO => Resizing and disabling statusbar..");
                    status.Visible = false;
                    label8.Visible = true;
                    process_ram_alt.Visible = true;
                    this.MaximumSize = new System.Drawing.Size(978, 512);
                }
            }
            catch (Exception ex)
            {
                try
                {
                    Console.WriteLine(func.current_time() + " EXCEPTION => " + ex.Message);
                    excpd.show_exception(ex);
                    logger.exception(ex.Message);
                }
                catch (Exception ex_)
                {
                    Console.WriteLine(func.current_time() + " EXCEPTION => " + ex_.Message);
                }
            }
            try
            {
                /* convert Int_value from tweaks to interval.*/

                switch (Settings.Default.int_value)
                {
                    case 0:
                        ram_counter.Interval = 100;
                        func.log_write(" INFO => Set ran counter interval to " + ram_counter.Interval);
                        break;
                    case 1:
                        ram_counter.Interval = 200;
                        func.log_write(" INFO => Set ran counter interval to " + ram_counter.Interval);
                        break;
                    case 2:
                        ram_counter.Interval = 300;
                        func.log_write(" INFO => Set ran counter interval to " + ram_counter.Interval);
                        break;
                    case 3:
                        ram_counter.Interval = 400;
                        func.log_write(" INFO => Set ran counter interval to " + ram_counter.Interval);
                        break;
                    case 4:
                        ram_counter.Interval = 500;
                        func.log_write(" INFO => Set ran counter interval to " + ram_counter.Interval);
                        break;
                    default:
                        func.log_write(" INFO => Int_value was not in range of '100 - 500', so it was reset to 500.");
                        Settings.Default.int_value = 500;
                        ram_counter.Interval = 500;
                        func.log_write(" INFO => Set ran counter interval to " + ram_counter.Interval);
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(func.current_time() + " EXCEPTION => " + ex.Message);
                excpd.show_exception(ex);
                logger.exception(ex.Message);
            }
        }

        private void ipbox_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                DialogResult value = MessageBox.Show("Copy '"+ipbox.SelectedItem.ToString()+"' to clipboard?", "Copy selected item to clipboard?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (value == DialogResult.Yes) { Clipboard.SetText(ipbox.SelectedItem.ToString()); }
            }
            catch (Exception ex) 
            {
                Console.WriteLine(func.current_time() + " EXCEPTION => " + ex.Message);
                excpd.show_exception(ex);
                logger.exception(ex.Message);
            }
        }

        private void uptime_refresh_Tick(object sender, EventArgs e)
        {
            uptime_display.Text = func.start_count();
        }
    }
}