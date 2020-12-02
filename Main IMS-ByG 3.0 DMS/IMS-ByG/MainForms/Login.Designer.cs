namespace IMS_ByG
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.Usernametext = new System.Windows.Forms.TextBox();
            this.Passwordtext = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Loginbtn = new System.Windows.Forms.Button();
            this.Livetime = new System.Windows.Forms.Label();
            this.livedate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.usernameerroelbl = new System.Windows.Forms.Label();
            this.passworderrorlbl = new System.Windows.Forms.Label();
            this.leftpanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftpanel
            // 
            this.leftpanel.Controls.Add(this.panel5);
            this.leftpanel.Controls.Add(this.Loginbtn);
            this.leftpanel.Controls.Add(this.Passwordtext);
            this.leftpanel.Controls.Add(this.label4);
            this.leftpanel.Controls.Add(this.Usernametext);
            this.leftpanel.Controls.Add(this.label3);
            this.leftpanel.Controls.Add(this.passworderrorlbl);
            this.leftpanel.Controls.Add(this.usernameerroelbl);
            this.leftpanel.Size = new System.Drawing.Size(244, 517);
            this.leftpanel.Controls.SetChildIndex(this.usernameerroelbl, 0);
            this.leftpanel.Controls.SetChildIndex(this.passworderrorlbl, 0);
            this.leftpanel.Controls.SetChildIndex(this.label3, 0);
            this.leftpanel.Controls.SetChildIndex(this.Usernametext, 0);
            this.leftpanel.Controls.SetChildIndex(this.label4, 0);
            this.leftpanel.Controls.SetChildIndex(this.Passwordtext, 0);
            this.leftpanel.Controls.SetChildIndex(this.Loginbtn, 0);
            this.leftpanel.Controls.SetChildIndex(this.panel2, 0);
            this.leftpanel.Controls.SetChildIndex(this.panel5, 0);
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(244, 44);
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // rightpanel
            // 
            this.rightpanel.BackgroundImage = global::IMS_ByG.Properties.Resources.call_center_isometric_vector_26072858__2__removebg_preview;
            this.rightpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rightpanel.Controls.Add(this.panel4);
            this.rightpanel.Controls.Add(this.panel3);
            this.rightpanel.Location = new System.Drawing.Point(244, 0);
            this.rightpanel.Size = new System.Drawing.Size(1014, 517);
            this.rightpanel.Controls.SetChildIndex(this.panel1, 0);
            this.rightpanel.Controls.SetChildIndex(this.panel3, 0);
            this.rightpanel.Controls.SetChildIndex(this.panel4, 0);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(1014, 44);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(53, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "User Name";
            // 
            // Usernametext
            // 
            this.Usernametext.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usernametext.Location = new System.Drawing.Point(13, 252);
            this.Usernametext.MaxLength = 30;
            this.Usernametext.Name = "Usernametext";
            this.Usernametext.Size = new System.Drawing.Size(211, 29);
            this.Usernametext.TabIndex = 2;
            this.Usernametext.TextChanged += new System.EventHandler(this.Usernametext_TextChanged);
            // 
            // Passwordtext
            // 
            this.Passwordtext.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passwordtext.Location = new System.Drawing.Point(13, 308);
            this.Passwordtext.MaxLength = 30;
            this.Passwordtext.Name = "Passwordtext";
            this.Passwordtext.Size = new System.Drawing.Size(211, 29);
            this.Passwordtext.TabIndex = 4;
            this.Passwordtext.UseSystemPasswordChar = true;
            this.Passwordtext.TextChanged += new System.EventHandler(this.Passwordtext_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // Loginbtn
            // 
            this.Loginbtn.FlatAppearance.BorderSize = 2;
            this.Loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Loginbtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginbtn.Location = new System.Drawing.Point(13, 352);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(211, 53);
            this.Loginbtn.TabIndex = 5;
            this.Loginbtn.Text = "LOGIN";
            this.Loginbtn.UseVisualStyleBackColor = true;
            this.Loginbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Livetime
            // 
            this.Livetime.AutoSize = true;
            this.Livetime.BackColor = System.Drawing.Color.White;
            this.Livetime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Livetime.Cursor = System.Windows.Forms.Cursors.No;
            this.Livetime.Dock = System.Windows.Forms.DockStyle.Right;
            this.Livetime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Livetime.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Livetime.ForeColor = System.Drawing.Color.Maroon;
            this.Livetime.Location = new System.Drawing.Point(961, 0);
            this.Livetime.Name = "Livetime";
            this.Livetime.Size = new System.Drawing.Size(53, 27);
            this.Livetime.TabIndex = 1;
            this.Livetime.Text = "time";
            // 
            // livedate
            // 
            this.livedate.AutoSize = true;
            this.livedate.BackColor = System.Drawing.Color.White;
            this.livedate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.livedate.Cursor = System.Windows.Forms.Cursors.No;
            this.livedate.Dock = System.Windows.Forms.DockStyle.Right;
            this.livedate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.livedate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.livedate.ForeColor = System.Drawing.Color.Maroon;
            this.livedate.Location = new System.Drawing.Point(959, 0);
            this.livedate.Name = "livedate";
            this.livedate.Size = new System.Drawing.Size(55, 27);
            this.livedate.TabIndex = 1;
            this.livedate.Text = "Date";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.livedate);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 487);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1014, 30);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.Livetime);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 457);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1014, 30);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label5);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 503);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(244, 14);
            this.panel5.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Copyright © 2020 SSUET Group Project";
            // 
            // usernameerroelbl
            // 
            this.usernameerroelbl.AutoSize = true;
            this.usernameerroelbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usernameerroelbl.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameerroelbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.usernameerroelbl.Location = new System.Drawing.Point(196, 228);
            this.usernameerroelbl.Name = "usernameerroelbl";
            this.usernameerroelbl.Size = new System.Drawing.Size(24, 31);
            this.usernameerroelbl.TabIndex = 9;
            this.usernameerroelbl.Text = "*";
            this.usernameerroelbl.Visible = false;
            // 
            // passworderrorlbl
            // 
            this.passworderrorlbl.AutoSize = true;
            this.passworderrorlbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.passworderrorlbl.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passworderrorlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.passworderrorlbl.Location = new System.Drawing.Point(199, 284);
            this.passworderrorlbl.Name = "passworderrorlbl";
            this.passworderrorlbl.Size = new System.Drawing.Size(24, 31);
            this.passworderrorlbl.TabIndex = 9;
            this.passworderrorlbl.Text = "*";
            this.passworderrorlbl.Visible = false;
            // 
            // Login
            // 
            this.AcceptButton = this.Loginbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 517);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.leftpanel.ResumeLayout(false);
            this.leftpanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.rightpanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Passwordtext;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Usernametext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Loginbtn;
        private System.Windows.Forms.Label livedate;
        private System.Windows.Forms.Label Livetime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label passworderrorlbl;
        private System.Windows.Forms.Label usernameerroelbl;
    }
}