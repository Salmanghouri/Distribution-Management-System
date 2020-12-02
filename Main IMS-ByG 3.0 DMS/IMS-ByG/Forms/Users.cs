using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS_ByG
{
    public partial class Users : Sample2
    {
        int edit=0; // this zero is indication  to save operation and 1 is an indication update operation
        int UserID; // 4vedio
        short stat; // status variable active /inactive

        public Users()
        {
            InitializeComponent();
        }
        Retrival R = new Retrival();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Users_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(leftpanel);
            
           
        }
        public override void addbtn_Click(object sender, EventArgs e)
        {
            MainClass.enable_reset(leftpanel);
            edit = 0;
        }

        public override void editbtn_Click(object sender, EventArgs e)
        {
            edit = 1;
            MainClass.enable(leftpanel);
        }

        public override void upodatebtn_Click(object sender, EventArgs e)
        {
            if (nametxtusr.Text == "") { nameerrorlabl.Visible = true; } else { nameerrorlabl.Visible = false; }
            if (usernametxtusr.Text == "") { usrnameerrorlbl.Visible = true; } else { usrnameerrorlbl.Visible = false; }
            if (pswttxtusr.Text == "") { pswerrorlbl.Visible = true; } else { pswerrorlbl.Visible = false; }
            if (phonetxtusr.Text == "") { phoneerroelbl.Visible = true; } else { phoneerroelbl.Visible = false; }
            if (emailtxtusr.Text == "") { emailerroelbl.Visible = true; } else { emailerroelbl.Visible = false; }
            if (Statuscombousr.SelectedIndex == -1) { statuseror.Visible = true; } else { statuseror.Visible = false; }


            if (nameerrorlabl.Visible || usrnameerrorlbl.Visible || pswerrorlbl.Visible || phoneerroelbl.Visible || emailerroelbl.Visible || statuseror.Visible)
            {
                MainClass.ShowMSG("Fields with * are mandatory", "Stop", "Error"); //Error massage with main class
            }
            else
            {
                
                if (Statuscombousr.SelectedIndex == 0)
                {
                    stat = 1;
                }

                else if (Statuscombousr.SelectedIndex == 1)
                {
                    stat = 0;
                }
                if (edit == 0) //code for save operation
                {
                    
                    Insertion i = new Insertion();
                    
                    i.InsertUser(nametxtusr.Text, usernametxtusr.Text, pswttxtusr.Text, emailtxtusr.Text, phonetxtusr.Text, stat);
                    R.ShowUsers(dataGridView1, userIDGV, NameGV, UserNameGV, PasswordGV, PhoneGV, EmailGV, StatusGV);
                    MainClass.disable_reset(leftpanel);
                }


                else if (edit == 1) //code for update operation
                {
                    DialogResult dr = MessageBox.Show("Are you sure , you want to update record?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(dr == DialogResult.Yes)
                    {
                        Updation u = new Updation();

                        u.updateUser(UserID, nametxtusr.Text, usernametxtusr.Text, pswttxtusr.Text, emailtxtusr.Text, phonetxtusr.Text, stat);
                        R.ShowUsers(dataGridView1, userIDGV, NameGV, UserNameGV, PasswordGV, PhoneGV, EmailGV, StatusGV);
                        MainClass.disable_reset(leftpanel);

                    }

                }
            
        }
    }

             public override void deletebtn_Click(object sender, EventArgs e)
           {
            if(edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure , you want to delete record?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Deletion d = new Deletion();
                    d.delete(UserID, "st_deleteUser", "@id");
                    R.ShowUsers(dataGridView1, userIDGV, NameGV, UserNameGV, PasswordGV, PhoneGV, EmailGV, StatusGV);
                }
            }

           }
  
          public override void serchbox_TextChanged(object sender, EventArgs e)
          {
            if(serchbox.Text != "")
            {
                R.ShowUsers(dataGridView1, userIDGV, NameGV, UserNameGV, PasswordGV, PhoneGV, EmailGV, StatusGV,serchbox.Text);
            }
            else
            {
                R.ShowUsers(dataGridView1, userIDGV, NameGV, UserNameGV, PasswordGV, PhoneGV, EmailGV, StatusGV);
            }
           }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public override void Viewbtn_Click(object sender, EventArgs e)
        {
            R.ShowUsers(dataGridView1, userIDGV, NameGV, UserNameGV, PasswordGV, PhoneGV, EmailGV, StatusGV);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                UserID = Convert.ToInt32(row.Cells["userIDGV"].Value.ToString());
                nametxtusr.Text= row.Cells["NameGV"].Value.ToString();
                usernametxtusr.Text = row.Cells["UserNameGV"].Value.ToString();
                pswttxtusr.Text = row.Cells["PasswordGV"].Value.ToString();
          phonetxtusr.Text = row.Cells["PhoneGV"].Value.ToString();
                emailtxtusr.Text = row.Cells["EmailGV"].Value.ToString();
                Statuscombousr.SelectedItem= row.Cells["StatusGV"].Value.ToString();
                MainClass.disable(leftpanel);

            }
        }

        private void serchbox_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
