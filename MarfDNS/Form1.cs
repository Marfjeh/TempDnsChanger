using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarfDNS
{
    public partial class Form1 : Form
    {
        string version     = "1.0";
        int    build       = 1;
        string build_date = "25-5-2017";
        string server_list = "http://www.github.com/marfjeh/tempDNS/serverlist.mdns";    //List to download the serverlist, if the user desires to download it.
        string update_url  = "https://www.marfprojects.nl/projects/tempDNS/tempDNS.exe"; //This is for making updating to the latest version more easly, if the user desires.



        public Form1()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Temporay DNS changer by Marf. A simple program to temporay change your dns server to a diffrent ip and easly restore it back. \n"
                          + "version: " + version
                          + "\nBuild: " + build.ToString()
                          + "\nBuild-Date: " + build_date
                          + "\nSource code: http://www.github.com/");

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
