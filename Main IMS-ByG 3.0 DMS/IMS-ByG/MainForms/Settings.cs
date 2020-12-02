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

namespace IMS_ByG
{
    public partial class Settings : Sample
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void leftpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Savebtn_Click(object sender, EventArgs e)
        {

            string s;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (Intrgraradbtn.Checked)
            {
                if (Servertxt.Text != "" && Databasetxt.Text != "")
                {
                    s = "Data Source=" + Servertxt.Text + ";Initial Catalog=" + Databasetxt.Text + ";Integrated Security=true;";
                    File.WriteAllText(path+ "\\dbconnect", s);
                    DialogResult dr = MessageBox.Show("settings Save Sucessfully....", "Information....", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        Login log = new Login();
                        MainClass.showWindow(log, this, MDI.ActiveForm);
                    }

                }
                else
                {
                    MessageBox.Show("please give complete data to continue..");
                }

            }
            else
            {
                if (Servertxt.Text != "" && Databasetxt.Text != "" && Usertxt.Text != "" && Passwordtxt.Text != "")
                {
                    s = "Data Source=" + Servertxt.Text + ";Initial Catalog=" + Databasetxt.Text + ";User ID=" + Usertxt.Text + ";password=" + Passwordtxt.Text + ";";
                    File.WriteAllText(path + "\\dbconnect", s);
                    DialogResult dr = MessageBox.Show("settings Save Sucessfully....", "Information....", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        Login log = new Login();
                        MainClass.showWindow(log, this, MDI.ActiveForm);
                    }
                }
                else
                {
                    MessageBox.Show("please give complete data to continue..");
                }
            }
            
        }

        private void Intrgraradbtn_CheckedChanged(object sender, EventArgs e)
        {
            

            if (Intrgraradbtn.Checked)
            {
                Usertxt.Enabled = false;
                Passwordtxt.Enabled = false;
                Usertxt.Text = "";
                Passwordtxt.Text = "";  
            }
            else
            {
                Usertxt.Enabled = true;
                Passwordtxt.Enabled = true;
            }
        }

        private void Databasetxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
