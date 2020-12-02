namespace IMS_ByG
{
    partial class Settings
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
            this.label3 = new System.Windows.Forms.Label();
            this.Servertxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Databasetxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Usertxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Passwordtxt = new System.Windows.Forms.TextBox();
            this.Intrgraradbtn = new System.Windows.Forms.CheckBox();
            this.Savebtn = new System.Windows.Forms.Button();
            this.leftpanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftpanel
            // 
            this.leftpanel.Controls.Add(this.Savebtn);
            this.leftpanel.Controls.Add(this.Intrgraradbtn);
            this.leftpanel.Controls.Add(this.Passwordtxt);
            this.leftpanel.Controls.Add(this.label6);
            this.leftpanel.Controls.Add(this.Usertxt);
            this.leftpanel.Controls.Add(this.label5);
            this.leftpanel.Controls.Add(this.Databasetxt);
            this.leftpanel.Controls.Add(this.label4);
            this.leftpanel.Controls.Add(this.Servertxt);
            this.leftpanel.Controls.Add(this.label3);
            this.leftpanel.Size = new System.Drawing.Size(250, 542);
            this.leftpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.leftpanel_Paint);
            this.leftpanel.Controls.SetChildIndex(this.panel2, 0);
            this.leftpanel.Controls.SetChildIndex(this.label3, 0);
            this.leftpanel.Controls.SetChildIndex(this.Servertxt, 0);
            this.leftpanel.Controls.SetChildIndex(this.label4, 0);
            this.leftpanel.Controls.SetChildIndex(this.Databasetxt, 0);
            this.leftpanel.Controls.SetChildIndex(this.label5, 0);
            this.leftpanel.Controls.SetChildIndex(this.Usertxt, 0);
            this.leftpanel.Controls.SetChildIndex(this.label6, 0);
            this.leftpanel.Controls.SetChildIndex(this.Passwordtxt, 0);
            this.leftpanel.Controls.SetChildIndex(this.Intrgraradbtn, 0);
            this.leftpanel.Controls.SetChildIndex(this.Savebtn, 0);
            // 
            // rightpanel
            // 
            this.rightpanel.Size = new System.Drawing.Size(723, 542);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Server";
            // 
            // Servertxt
            // 
            this.Servertxt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Servertxt.Location = new System.Drawing.Point(12, 183);
            this.Servertxt.MaxLength = 50;
            this.Servertxt.Name = "Servertxt";
            this.Servertxt.Size = new System.Drawing.Size(206, 25);
            this.Servertxt.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Database";
            // 
            // Databasetxt
            // 
            this.Databasetxt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Databasetxt.Location = new System.Drawing.Point(12, 233);
            this.Databasetxt.MaxLength = 50;
            this.Databasetxt.Name = "Databasetxt";
            this.Databasetxt.Size = new System.Drawing.Size(206, 25);
            this.Databasetxt.TabIndex = 2;
            this.Databasetxt.TextChanged += new System.EventHandler(this.Databasetxt_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "User ID";
            // 
            // Usertxt
            // 
            this.Usertxt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usertxt.Location = new System.Drawing.Point(11, 283);
            this.Usertxt.MaxLength = 30;
            this.Usertxt.Name = "Usertxt";
            this.Usertxt.Size = new System.Drawing.Size(206, 25);
            this.Usertxt.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Password";
            // 
            // Passwordtxt
            // 
            this.Passwordtxt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passwordtxt.Location = new System.Drawing.Point(12, 333);
            this.Passwordtxt.MaxLength = 30;
            this.Passwordtxt.Name = "Passwordtxt";
            this.Passwordtxt.Size = new System.Drawing.Size(206, 25);
            this.Passwordtxt.TabIndex = 4;
            this.Passwordtxt.UseSystemPasswordChar = true;
            // 
            // Intrgraradbtn
            // 
            this.Intrgraradbtn.AutoSize = true;
            this.Intrgraradbtn.Location = new System.Drawing.Point(11, 364);
            this.Intrgraradbtn.Name = "Intrgraradbtn";
            this.Intrgraradbtn.Size = new System.Drawing.Size(129, 19);
            this.Intrgraradbtn.TabIndex = 5;
            this.Intrgraradbtn.Text = "Intergrated Security";
            this.Intrgraradbtn.UseVisualStyleBackColor = true;
            this.Intrgraradbtn.CheckedChanged += new System.EventHandler(this.Intrgraradbtn_CheckedChanged);
            // 
            // Savebtn
            // 
            this.Savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Savebtn.Location = new System.Drawing.Point(12, 390);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(205, 34);
            this.Savebtn.TabIndex = 6;
            this.Savebtn.Text = "SAVE";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.ClientSize = new System.Drawing.Size(973, 542);
            this.Name = "Settings";
            this.leftpanel.ResumeLayout(false);
            this.leftpanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.rightpanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Passwordtxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Usertxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Databasetxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Servertxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.CheckBox Intrgraradbtn;
    }
}