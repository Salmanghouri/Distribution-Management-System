using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS_ByG
{
    public partial class Categories : Sample2   
    {
        int edit = 0; // this zero is indication  to save operation and 1 is an indication update operation
        int catID; // 4vedio
        short stat; // status variable active /inactive
        Retrival R = new Retrival();
        public Categories()
        {
            InitializeComponent();
        }


        private void Categories_Load(object sender, EventArgs e)
        {
            MainClass.disable(leftpanel);
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
            if (Categrytxt.Text == "") { Caterrorlbl.Visible = true; } else { Caterrorlbl.Visible = false; }
            if (ActiveDD.SelectedIndex == -1) { Activeerrorlbl.Visible = true; } else { Activeerrorlbl.Visible = false; }


            if (Caterrorlbl.Visible || Activeerrorlbl.Visible)
            {
                MainClass.ShowMSG("Fields with * are mandatory", "Stop", "Error"); //Error massage with main class
            }
            else
            {

                if (ActiveDD.SelectedIndex == 0)
                {
                    stat = 1;
                }

                else if (ActiveDD.SelectedIndex == 1)
                {
                    stat = 0;
                }
                if (edit == 0) //code for save operation
                {

                    Insertion i = new Insertion();

                    i.InsertCat(Categrytxt.Text,  stat);
                    R.ShowCategories(dataGridView1, catIDGV, catNameGV, StatusGV);
                    MainClass.disable_reset(leftpanel);
                }


                else if (edit == 1) //code for update operation
                {
                    DialogResult dr = MessageBox.Show("Are you sure , you want to update record?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        Updation u = new Updation();

                        u.updateCat(catID, Categrytxt.Text, stat);
                        R.ShowCategories(dataGridView1, catIDGV, catNameGV, StatusGV);
                        MainClass.disable_reset(leftpanel);

                    }

                }

            }
        }

        public override void deletebtn_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure , you want to delete record?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Deletion d = new Deletion();
                    d.delete(catID, "st_deleteCategory", "@id");
                    R.ShowCategories(dataGridView1, catIDGV, catNameGV, StatusGV);
                }
            }
        }

        public override void serchbox_TextChanged(object sender, EventArgs e)
        {
            if (serchbox.Text != "")
            {
                R.ShowCategories(dataGridView1, catIDGV, catNameGV, StatusGV);
            }
            else
            {
                R.ShowCategories(dataGridView1, catIDGV, catNameGV, StatusGV);
            }
        }

        public override void Viewbtn_Click(object sender, EventArgs e)
        {
            R.ShowCategories(dataGridView1, catIDGV, catNameGV, StatusGV);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                catID  = Convert.ToInt32(row.Cells["catIDGV"].Value.ToString());
                Categrytxt.Text = row.Cells["catNameGV"].Value.ToString();
              ActiveDD.SelectedItem = row.Cells["StatusGV"].Value.ToString();
                MainClass.disable(leftpanel);

            }
        }

        private void ActiveDD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void serchbox_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
