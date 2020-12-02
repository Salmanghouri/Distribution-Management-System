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
    public partial class Sample2 : Sample
    {
        public Sample2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomeScreen obj = new HomeScreen();
            MainClass.showWindow(obj, this, MDI.ActiveForm);
        }

        public virtual void addbtn_Click(object sender, EventArgs e)
        {

        }

        public virtual void editbtn_Click(object sender, EventArgs e)
        {

        }

        public virtual void upodatebtn_Click(object sender, EventArgs e)
        {

        }

        public virtual void deletebtn_Click(object sender, EventArgs e)
        {

        }

        public virtual void serchbox_TextChanged(object sender, EventArgs e)
        {

        }

        public virtual void Viewbtn_Click(object sender, EventArgs e)
        {

        }

        private void Sample2_Load(object sender, EventArgs e)
        {

        }
    }
}
