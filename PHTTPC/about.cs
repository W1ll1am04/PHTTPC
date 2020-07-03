using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace PHTTPC
{
    public partial class about : Form
    {
        public about()
        {
            InitializeComponent();

            //This is the about form source, what did you expect?
        }

        private void label3_Click(object sender, EventArgs e){}

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo web = new ProcessStartInfo("https://www.gnu.org/licenses/gpl-3.0.html");
            Process.Start(web);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo web2 = new ProcessStartInfo("https://w1ll1am04.github.io");
            Process.Start(web2);
        }

        private void about_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.PHTTPC_ICON;
        }
    }
}
