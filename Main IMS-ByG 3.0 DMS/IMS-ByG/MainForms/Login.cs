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
    public partial class Login : Sample
    {
        public Login()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Usernametext.Text == "") { usernameerroelbl.Visible = true; } else { usernameerroelbl.Visible = false; }
            if (Passwordtext.Text == "") { passworderrorlbl.Visible = true; } else { passworderrorlbl.Visible = false; }
            if (usernameerroelbl.Visible || passworderrorlbl.Visible)
            {
                MainClass.ShowMSG("Fields with * are mandatory", "Stop", "Error"); //Error massage with main class


            }
            else
            {
            
                    if (Retrival.getUserDetail(Usernametext.Text, Passwordtext.Text))
                    {
                        HomeScreen obj = new HomeScreen();
                        MainClass.showWindow(obj, this, MDI.ActiveForm);
                    }
                    else
                    {

                    }
                
            }
            


            
        }

        private void Login_Load(object sender, EventArgs e)
        {
            timer1.Start();
            livedate.Text = DateTime.Now.ToLongDateString();
            Livetime.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Livetime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void Usernametext_TextChanged(object sender, EventArgs e)
        {
            if (Usernametext.Text == "") { usernameerroelbl.Visible = true; } else { usernameerroelbl.Visible = false; }
            
        }

        private void Passwordtext_TextChanged(object sender, EventArgs e)
        {
            if (Passwordtext.Text == "") { passworderrorlbl.Visible = true; } else { passworderrorlbl.Visible = false; }
 
        }
    }
}
