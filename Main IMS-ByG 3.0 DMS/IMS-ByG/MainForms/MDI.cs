using IMS_ByG.Forms;
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

namespace IMS_ByG
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void exiyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MDI_Load(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (File.Exists(path+ "\\dbconnect"))
            {
                Login log = new Login();
                MainClass.showWindow(log, this);
            }
            else
            {
                Settings set = new Settings();
                MainClass.showWindow(set, this); 
            }
            
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Settings set = new Settings();
            MainClass.showWindow(set, this);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About ab = new About();
            MainClass.showWindow(ab, this);

        }
    }
}
