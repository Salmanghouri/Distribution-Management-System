namespace IMS_ByG
{
    partial class Sample2
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.deletebtn = new System.Windows.Forms.Button();
            this.upodatebtn = new System.Windows.Forms.Button();
            this.editbtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.serchbox = new System.Windows.Forms.TextBox();
            this.Viewbtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.leftpanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftpanel
            // 
            this.leftpanel.Size = new System.Drawing.Size(250, 682);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.backbtn);
            this.panel2.Size = new System.Drawing.Size(250, 48);
            this.panel2.Controls.SetChildIndex(this.backbtn, 0);
            this.panel2.Controls.SetChildIndex(this.label1, 0);
            // 
            // rightpanel
            // 
            this.rightpanel.Controls.Add(this.panel3);
            this.rightpanel.Size = new System.Drawing.Size(1078, 682);
            this.rightpanel.Controls.SetChildIndex(this.panel1, 0);
            this.rightpanel.Controls.SetChildIndex(this.panel3, 0);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(1078, 54);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(102, 0);
            this.label1.Size = new System.Drawing.Size(148, 48);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Size = new System.Drawing.Size(1078, 54);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 54);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1078, 60);
            this.panel3.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.deletebtn, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.upodatebtn, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.editbtn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.addbtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.Viewbtn, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1078, 60);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // deletebtn
            // 
            this.deletebtn.BackgroundImage = global::IMS_ByG.Properties.Resources.delete;
            this.deletebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.deletebtn.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.deletebtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deletebtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.deletebtn.FlatAppearance.BorderSize = 2;
            this.deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletebtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.ForeColor = System.Drawing.Color.Maroon;
            this.deletebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deletebtn.Location = new System.Drawing.Point(540, 3);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.deletebtn.Size = new System.Drawing.Size(173, 54);
            this.deletebtn.TabIndex = 3;
            this.deletebtn.Text = "DELETE";
            this.deletebtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // upodatebtn
            // 
            this.upodatebtn.BackgroundImage = global::IMS_ByG.Properties.Resources.save;
            this.upodatebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.upodatebtn.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.upodatebtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.upodatebtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.upodatebtn.FlatAppearance.BorderSize = 2;
            this.upodatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upodatebtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upodatebtn.ForeColor = System.Drawing.Color.Maroon;
            this.upodatebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.upodatebtn.Location = new System.Drawing.Point(361, 3);
            this.upodatebtn.Name = "upodatebtn";
            this.upodatebtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.upodatebtn.Size = new System.Drawing.Size(173, 54);
            this.upodatebtn.TabIndex = 2;
            this.upodatebtn.Text = "SAVE";
            this.upodatebtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.upodatebtn.UseVisualStyleBackColor = true;
            this.upodatebtn.Click += new System.EventHandler(this.upodatebtn_Click);
            // 
            // editbtn
            // 
            this.editbtn.BackgroundImage = global::IMS_ByG.Properties.Resources.edit_video;
            this.editbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.editbtn.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.editbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editbtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.editbtn.FlatAppearance.BorderSize = 2;
            this.editbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editbtn.ForeColor = System.Drawing.Color.Maroon;
            this.editbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.editbtn.Location = new System.Drawing.Point(182, 3);
            this.editbtn.Name = "editbtn";
            this.editbtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.editbtn.Size = new System.Drawing.Size(173, 54);
            this.editbtn.TabIndex = 1;
            this.editbtn.Text = "EDIT";
            this.editbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editbtn.UseVisualStyleBackColor = true;
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // addbtn
            // 
            this.addbtn.BackgroundImage = global::IMS_ByG.Properties.Resources.add_files;
            this.addbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addbtn.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.addbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addbtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.addbtn.FlatAppearance.BorderSize = 2;
            this.addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.ForeColor = System.Drawing.Color.Maroon;
            this.addbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addbtn.Location = new System.Drawing.Point(3, 3);
            this.addbtn.Name = "addbtn";
            this.addbtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addbtn.Size = new System.Drawing.Size(173, 54);
            this.addbtn.TabIndex = 0;
            this.addbtn.Text = "ADD";
            this.addbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.serchbox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(898, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 54);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // serchbox
            // 
            this.serchbox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serchbox.Location = new System.Drawing.Point(6, 25);
            this.serchbox.MaxLength = 100;
            this.serchbox.Name = "serchbox";
            this.serchbox.Size = new System.Drawing.Size(148, 25);
            this.serchbox.TabIndex = 0;
            this.serchbox.TextChanged += new System.EventHandler(this.serchbox_TextChanged);
            // 
            // Viewbtn
            // 
            this.Viewbtn.BackgroundImage = global::IMS_ByG.Properties.Resources.arrow;
            this.Viewbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Viewbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Viewbtn.FlatAppearance.BorderSize = 2;
            this.Viewbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Viewbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Viewbtn.ForeColor = System.Drawing.Color.Maroon;
            this.Viewbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Viewbtn.Location = new System.Drawing.Point(719, 3);
            this.Viewbtn.Name = "Viewbtn";
            this.Viewbtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Viewbtn.Size = new System.Drawing.Size(173, 54);
            this.Viewbtn.TabIndex = 5;
            this.Viewbtn.Text = "VIEW";
            this.Viewbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Viewbtn.UseVisualStyleBackColor = true;
            this.Viewbtn.Click += new System.EventHandler(this.Viewbtn_Click);
            // 
            // backbtn
            // 
            this.backbtn.BackgroundImage = global::IMS_ByG.Properties.Resources.back_button;
            this.backbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backbtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.backbtn.FlatAppearance.BorderSize = 0;
            this.backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbtn.Location = new System.Drawing.Point(0, 0);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(60, 48);
            this.backbtn.TabIndex = 0;
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Sample2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 682);
            this.Name = "Sample2";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Sample2_Load);
            this.leftpanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.rightpanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button upodatebtn;
        private System.Windows.Forms.Button editbtn;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        protected System.Windows.Forms.TextBox serchbox;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button Viewbtn;
    }
}