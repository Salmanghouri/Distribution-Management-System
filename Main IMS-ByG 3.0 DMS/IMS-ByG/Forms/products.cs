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
    public partial class products : Sample2
    {
        int edit = 0; // this zero is indication  to save operation and 1 is an indication update operation
        int prodID; // 6vedio
        
        public products()
        {
            InitializeComponent();
        }
        Retrival R = new Retrival();
        private void products_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(leftpanel);
        }
        public override void addbtn_Click(object sender, EventArgs e)
        {
            MainClass.enable_reset(leftpanel);
            edit = 0;
            R.getCategoriesList("st_getCategoriesList", categoryDD, "category","ID");
        }

        public override void editbtn_Click(object sender, EventArgs e)
        {
            edit = 1;
            MainClass.enable(leftpanel);
            categoryDD.Enabled=false;
            
        }

        public override void upodatebtn_Click(object sender, EventArgs e)
        {
            if (pronamtxtp.Text == "") { pnameerrorlbl.Visible = true; } else { pnameerrorlbl.Visible = false; }
            if (barcodetxtp.Text == "") { barcodeperrorlbl.Visible = true; } else { barcodeperrorlbl.Visible = false; }
            if (Expirypickerp.Value < DateTime.Now) { expiryerrorplbl.Visible = true; expiryerrorplbl.Text = "Invalid Date..."; } else { expiryerrorplbl.Visible = false; }
            if (pptxt.Text == "") { pperrorlbl.Visible = true; } else { pperrorlbl.Visible = false; }
            if (categoryDD.SelectedIndex == -1 || categoryDD.SelectedIndex == 0) { caterrorlbl.Visible = true; } else { caterrorlbl.Visible = false; }
            if (pnameerrorlbl.Visible || barcodeperrorlbl.Visible || expiryerrorplbl.Visible || pperrorlbl.Visible || caterrorlbl.Visible)
            {
                MainClass.ShowMSG("Fields with * are mandatory", "Stop", "Error"); //Error massage with main class
            }
            else
            {


                if (edit == 0) //code for save operation
                {

                    Insertion i = new Insertion();
                    i.InsertProduct(pronamtxtp.Text, barcodetxtp.Text, Convert.ToSingle(pptxt.Text), Expirypickerp.Value, Convert.ToInt32(categoryDD.SelectedValue));
                    R.ShowProducts(dataGridView1, proIDGV, proNameGV, ExpiryGV, CatGV, PriceGV, barcodeGV, CatIDGV);
                    MainClass.disable_reset(leftpanel);
                }


                else if (edit == 1) //code for update operation
                {
                    DialogResult dr = MessageBox.Show("Are you sure , you want to update record?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        
                        Updation u = new Updation();

                        u.updateProduct(prodID, pronamtxtp.Text, barcodetxtp.Text, Convert.ToSingle(pptxt.Text), Expirypickerp.Value, Convert.ToInt32(categoryDD.SelectedValue));
                        R.ShowProducts(dataGridView1, proIDGV, proNameGV, ExpiryGV, CatGV, PriceGV, barcodeGV, CatIDGV);
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
                    d.delete(prodID , "s_ProductDelete", "@proID");
                    R.ShowProducts(dataGridView1, proIDGV, proNameGV, ExpiryGV, CatGV, PriceGV, barcodeGV, CatIDGV);
                }
            }
        }

        public override void serchbox_TextChanged(object sender, EventArgs e)
        {

        }

        public override void Viewbtn_Click(object sender, EventArgs e)
        {
            R.ShowProducts(dataGridView1, proIDGV, proNameGV, ExpiryGV, CatGV, PriceGV, barcodeGV, CatIDGV);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                prodID = Convert.ToInt32(row.Cells["proIDGV"].Value.ToString());
                pronamtxtp.Text = row.Cells["proNameGV"].Value.ToString();
                pptxt.Text = row.Cells["PriceGV"].Value.ToString();
                barcodetxtp.Text = row.Cells["barcodeGV"].Value.ToString();
                Expirypickerp.Value = Convert.ToDateTime(row.Cells["ExpiryGV"].Value.ToString());
                categoryDD.SelectedItem = row.Cells["CatGV"].Value.ToString();
                MainClass.disable(leftpanel);

            }
        }

       
    }
}
