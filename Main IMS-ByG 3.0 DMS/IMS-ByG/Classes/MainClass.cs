using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace IMS_ByG
{
    class MainClass
    {

         private static string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        private static string s = File.ReadAllText(path + "\\dbconnect");
        public static SqlConnection con = new SqlConnection(s);

        //this is for message box
        public static DialogResult ShowMSG(string msg, string heading, string type)
        {
            if (type == "Sucess")
            {
                return MessageBox.Show(msg, heading, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                return MessageBox.Show(msg, heading, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //this is for windows 1.1 Exercise.
        public static void showWindow(Form openwin,Form clswin,Form MDIwin)
        {
            clswin.Close();
            openwin.MdiParent = MDIwin;
            openwin.WindowState = FormWindowState.Maximized;
            openwin.Show();
        }
        public static void showWindow(Form openwin, Form MDIwin)
        {
            openwin.MdiParent = MDIwin;
            openwin.WindowState = FormWindowState.Maximized;
            openwin.Show();
        }
        public static void disable_reset(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    t.Enabled = false;
                    t.Text = "";
                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = false;
                    cb.SelectedIndex = -1;
                }
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Enabled = false;
                    rb.Checked = false;
                }
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    cb.Enabled = false;
                    cb.Checked = false;
                }
                if (c is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)c;
                    dtp.Enabled = false;
                    dtp.Text = "";
                }

            }
        }
        public static void disable(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    t.Enabled = false;
                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = false;
                }
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Enabled = false;
                }
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    cb.Enabled = false;
                }
                if (c is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)c;
                    dtp.Enabled = false;
                    
                }

            }
        }
        public static void enable_reset(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    t.Enabled = true;
                    t.Text = "";
                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = true;
                    cb.SelectedIndex = -1;
                }
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Enabled = true;
                    rb.Checked = false;
                }
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    cb.Enabled = true;
                    cb.Checked = false;
                }
                if (c is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)c;
                    dtp.Enabled = true;
                    dtp.Checked = false;
                }

            }
        }
        public static void enable(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    t.Enabled = true;
                  
                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = true;
                   
                }
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Enabled = true;
                   
                }
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    cb.Enabled = true;
                  
                }
                if (c is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)c;
                    dtp.Enabled = true;
                    
                }

            }
        }

    }
}
