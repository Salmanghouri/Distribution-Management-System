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

namespace IMS_ByG
{
    public partial class HomeScreen : Sample
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Users u = new Users();
            MainClass.showWindow(u, this, MDI.ActiveForm);  
        }

        private void catbtn_Click(object sender, EventArgs e)
        {
            Categories u = new Categories();
            MainClass.showWindow(u, this, MDI.ActiveForm);
        }

        private void proDD_Click(object sender, EventArgs e)
        {
            products u = new products();
            MainClass.showWindow(u, this, MDI.ActiveForm);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            MainClass.showWindow(log, this, MDI.ActiveForm);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Stocks sd = new Stocks();
            MainClass.showWindow(sd, this, MDI.ActiveForm);
        }
    }
}
