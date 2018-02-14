using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Shitty_Server_Stopper
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://steamcommunity.com/id/wally-official/");
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://discord.gg/FkpqBYF");
        }

        private void About_Load(object sender, EventArgs e)
        {
            string insLoc = Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFilesX86) + "\\ShittyServerStopper\\";
            if (File.Exists(insLoc + "theme_white.dat"))
            {
                this.BackColor = Color.White;
                panel1.BackColor = Color.FromArgb(224, 224, 224);
                label1.ForeColor = SystemColors.MenuHighlight;
                label1.BackColor = Color.White;

                label2.ForeColor = Color.Black;
                label2.BackColor = Color.FromArgb(224, 224, 224);

                label3.ForeColor = Color.Black;
                label3.BackColor = Color.FromArgb(224, 224, 224);

                label5.ForeColor = Color.Black;
                label5.BackColor = Color.FromArgb(224, 224, 224);

                label4.BackColor = Color.FromArgb(224, 224, 224);

                steamLabel.BackColor = Color.FromArgb(224, 224, 224);

                linkLabel1.BackColor = Color.FromArgb(224, 224, 224);
                linkLabel5.BackColor = Color.FromArgb(224, 224, 224);
                linkLabel6.BackColor = Color.FromArgb(224, 224, 224);
                linkLabel7.BackColor = Color.FromArgb(224, 224, 224);
                linkLabel8.BackColor = Color.FromArgb(224, 224, 224);
                linkLabel9.BackColor = Color.FromArgb(224, 224, 224);
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!File.Exists(Properties.Settings.Default.InstallLocation + "\\ChangeLog.txt"))
            {
                File.WriteAllText(Properties.Settings.Default.InstallLocation + "\\ChangeLog.txt", Properties.Resources.ChangeLog);
            }
            else
            {
                try
                {
                    File.Delete(Properties.Settings.Default.InstallLocation + "\\ChangeLog.txt");
                    File.WriteAllText(Properties.Settings.Default.InstallLocation + "\\ChangeLog.txt", Properties.Resources.ChangeLog);
                } 
                catch { }
            }
            Process.Start(Properties.Settings.Default.InstallLocation + "\\ChangeLog.txt");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://steamcommunity.com/profiles/76561198246509174/");
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://steamcommunity.com/profiles/76561198096875197/");
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://steamcommunity.com/profiles/76561198098477111/");
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://steamcommunity.com/profiles/76561198022663213/");
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://steamcommunity.com/profiles/76561198145268525/");
        }

        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
            Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFilesX86) + @"\shitty_server_stopper_uninstaller.exe");
        }
    }
}
