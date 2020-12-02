using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS_ByG.Forms
{
    public partial class Stocks : Sample2
    {
        public Stocks()
        {
            InitializeComponent();
        }
        int edit = 0; // this zero is indication  to save operation and 1 is an indication update operation
        int StockID; // 6vedio

        Retrival R = new Retrival();
        private void Stocks_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(leftpanel);
        }
        public override void addbtn_Click(object sender, EventArgs e)
        {
            MainClass.enable_reset(leftpanel);
            edit = 0;
            R.getProductList("GetProductlist", ProductnameCB, "products", "ID");
        }

        public override void editbtn_Click(object sender, EventArgs e)
        {
            edit = 1;
            MainClass.enable(leftpanel);
            ProductnameCB.Enabled = false;
           
        }

        public override void upodatebtn_Click(object sender, EventArgs e)
        {
            if (Quantitytxt.Text == "") { StockQTYerrorlbl.Visible = true; } else { StockQTYerrorlbl.Visible = false; }
            if (PerchaseRatetxt.Text == "") { PuchaserateErrorlbl.Visible = true; } else { PuchaserateErrorlbl.Visible = false; }
            if (SalesRatetxt.Text == "") { SalesRateErrorlbl.Visible = true; } else { SalesRateErrorlbl.Visible = false; }

            if (StockQTYerrorlbl.Visible || PuchaserateErrorlbl.Visible || SalesRateErrorlbl.Visible)
            {
                MainClass.ShowMSG("Fields with * are mandatory", "Stop", "Error"); //Error massage with main class
            }
            else
            {


                if (edit == 0) //code for save operation
                {
                    Insertion i = new Insertion();
                    i.InsertStock(Convert.ToInt32(ProductnameCB.SelectedValue), Convert.ToSingle(Quantitytxt.Text), Convert.ToSingle(PerchaseRatetxt.Text), Convert.ToSingle(SalesRatetxt.Text));
                    R.ShowStock(DataGridView1, StockIDGV,SprodIDGV,ProductNamepwGV,PQuantityGV,PurchaseRateGV,PSalesRateGV);
                    MainClass.disable_reset(leftpanel);

                }


                else if (edit == 1) //code for update operation
                {
                    DialogResult dr = MessageBox.Show("Are you sure , you want to update record?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        Updation u = new Updation();
                        u.UpdateStock(StockID,Convert.ToInt32(ProductnameCB.SelectedValue), Convert.ToSingle(Quantitytxt.Text), Convert.ToSingle(PerchaseRatetxt.Text), Convert.ToSingle(SalesRatetxt.Text));
                        R.ShowStock(DataGridView1, StockIDGV, SprodIDGV, ProductNamepwGV, PQuantityGV, PurchaseRateGV, PSalesRateGV);
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
                    d.delete(StockID, "st_stockdeletes", "@stockid");
                    R.ShowStock(DataGridView1, StockIDGV, SprodIDGV, ProductNamepwGV, PQuantityGV, PurchaseRateGV, PSalesRateGV);


                }
            }
        }

        public override void serchbox_TextChanged(object sender, EventArgs e)
        {

        }

        public override void Viewbtn_Click(object sender, EventArgs e)
        {
            R.ShowStock(DataGridView1, StockIDGV, SprodIDGV, ProductNamepwGV, PQuantityGV, PurchaseRateGV, PSalesRateGV);

        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = DataGridView1.Rows[e.RowIndex];
                StockID = Convert.ToInt32(row.Cells["StockIDGV"].Value.ToString());
                ProductnameCB.SelectedItem = row.Cells["ProductNamepwGV"].Value.ToString();
                Quantitytxt.Text = row.Cells["PQuantityGV"].Value.ToString();
                PerchaseRatetxt.Text = row.Cells["PurchaseRateGV"].Value.ToString();
                SalesRatetxt.Text = row.Cells["PSalesRateGV"].Value.ToString();
                
                MainClass.disable(leftpanel);

            }
        }


        private void ViewStockbtn_Click(object sender, EventArgs e)
        {
            DGVPrinter print = new DGVPrinter();
            print.Title = "PROJECT STOCK REPORT (SSUET) STUDETS";
            print.SubTitle = "Print Date:" + DateTime.Now.ToShortDateString();
            print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            print.PageNumbers = true;
            print.PageNumberInHeader = false;
            print.PorportionalColumns = true;
            print.HeaderCellAlignment = StringAlignment.Near;
            print.Footer = "G Developers Copyright @ 2019";
            print.FooterSpacing = 15;
            print.PrintDataGridView(DataGridView1);
        }
    }
}
