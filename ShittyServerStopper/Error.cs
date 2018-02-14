using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shitty_Server_Stopper
{
    public partial class Error : Form
    {
        public Error()
        {
            InitializeComponent();
        }            

        public string Title
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        public string Message
        {
            get { return label2.Text; }
            set { label2.Text = value; }
        }

        public string Help
        {
            get { return label3.Text; }
            set { label3.Text = value; }
        }

        private void Error_Load(object sender, EventArgs e)
        {
            string insLoc = Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFilesX86) + "\\ShittyServerStopper\\";
            if (File.Exists(insLoc + "theme_white.dat"))
            {
                this.BackColor = Color.White;
                button3.ForeColor = Color.Black;
                button3.BackColor = Color.LightGray;
                button3.FlatAppearance.MouseOverBackColor = Color.Silver;
                pictureBox1.BackColor = Color.White;
                panel2.BackColor = Color.FromArgb(224, 224, 224);
                label3.ForeColor = Color.Black;
            }        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
