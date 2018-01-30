using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace Shitty_Server_Stopper
{
    public partial class NewUpdate : Form
    {
        public NewUpdate()
        {
            InitializeComponent();
        }

        private void NewUpdate_Load(object sender, EventArgs e)
        {
            string contents;
            using (var wc = new System.Net.WebClient())
                contents = wc.DownloadString("http://wallymodz.weebly.com/uploads/5/3/7/8/53782675/new_changes.txt");

            newChanges.Text = contents;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string space = @"
";
            File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFilesX86) + @"\ShittyServerStopper\update.dat", Properties.Settings.Default.NumCIPS + space + Properties.Settings.Default.HRBlocked + space + Properties.Settings.Default.L4DBlocked + space + Properties.Settings.Default.MiscBlocked + space + Properties.Settings.Default.YABlocked);
            File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFilesX86) + @"\ShittyServerStopper\cips_temp.dat", File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFilesX86) + @"\ShittyServerStopper\blocked_ips.dat"));
           
            try
            {
                using (var client = new WebClient())
                {
                    client.DownloadFile("http://wallymodz.weebly.com/uploads/5/3/7/8/53782675/sss_update.exe", Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFilesX86) + @"\ShittyServerStopper\sss_update.exe");
                    System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFilesX86) + @"\ShittyServerStopper\sss_update.exe");
                    File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFilesX86) + "\\ShittyServerStopper\\plocation.dat", System.Reflection.Assembly.GetExecutingAssembly().Location);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }


            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {         
            this.Close();
        }
    }
}
