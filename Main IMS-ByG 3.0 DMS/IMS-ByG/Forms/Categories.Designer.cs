namespace IMS_ByG
{
    partial class Categories
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Categrytxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Activeerrorlbl = new System.Windows.Forms.Label();
            this.Caterrorlbl = new System.Windows.Forms.Label();
            this.ActiveDD = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.catIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftpanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // serchbox
            // 
            this.serchbox.TextChanged += new System.EventHandler(this.serchbox_TextChanged_1);
            // 
            // leftpanel
            // 
            this.leftpanel.Controls.Add(this.ActiveDD);
            this.leftpanel.Controls.Add(this.Categrytxt);
            this.leftpanel.Controls.Add(this.label5);
            this.leftpanel.Controls.Add(this.label3);
            this.leftpanel.Controls.Add(this.Activeerrorlbl);
            this.leftpanel.Controls.Add(this.Caterrorlbl);
            this.leftpanel.Size = new System.Drawing.Size(250, 701);
            this.leftpanel.Controls.SetChildIndex(this.panel2, 0);
            this.leftpanel.Controls.SetChildIndex(this.Caterrorlbl, 0);
            this.leftpanel.Controls.SetChildIndex(this.Activeerrorlbl, 0);
            this.leftpanel.Controls.SetChildIndex(this.label3, 0);
            this.leftpanel.Controls.SetChildIndex(this.label5, 0);
            this.leftpanel.Controls.SetChildIndex(this.Categrytxt, 0);
            this.leftpanel.Controls.SetChildIndex(this.ActiveDD, 0);
            // 
            // rightpanel
            // 
            this.rightpanel.Controls.Add(this.dataGridView1);
            this.rightpanel.Size = new System.Drawing.Size(1127, 701);
            this.rightpanel.Controls.SetChildIndex(this.panel1, 0);
            this.rightpanel.Controls.SetChildIndex(this.dataGridView1, 0);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 60);
            this.panel1.Size = new System.Drawing.Size(1127, 54);
            // 
            // Categrytxt
            // 
            this.Categrytxt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Categrytxt.Location = new System.Drawing.Point(6, 139);
            this.Categrytxt.Name = "Categrytxt";
            this.Categrytxt.Size = new System.Drawing.Size(229, 25);
            this.Categrytxt.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Is Active";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Category Name";
            // 
            // Activeerrorlbl
            // 
            this.Activeerrorlbl.AutoSize = true;
            this.Activeerrorlbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Activeerrorlbl.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Activeerrorlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Activeerrorlbl.Location = new System.Drawing.Point(109, 168);
            this.Activeerrorlbl.Name = "Activeerrorlbl";
            this.Activeerrorlbl.Size = new System.Drawing.Size(24, 31);
            this.Activeerrorlbl.TabIndex = 13;
            this.Activeerrorlbl.Text = "*";
            this.Activeerrorlbl.Visible = false;
            // 
            // Caterrorlbl
            // 
            this.Caterrorlbl.AutoSize = true;
            this.Caterrorlbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Caterrorlbl.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Caterrorlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Caterrorlbl.Location = new System.Drawing.Point(105, 115);
            this.Caterrorlbl.Name = "Caterrorlbl";
            this.Caterrorlbl.Size = new System.Drawing.Size(24, 31);
            this.Caterrorlbl.TabIndex = 14;
            this.Caterrorlbl.Text = "*";
            this.Caterrorlbl.Visible = false;
            // 
            // ActiveDD
            // 
            this.ActiveDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ActiveDD.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActiveDD.FormattingEnabled = true;
            this.ActiveDD.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.ActiveDD.Location = new System.Drawing.Point(10, 196);
            this.ActiveDD.Name = "ActiveDD";
            this.ActiveDD.Size = new System.Drawing.Size(227, 25);
            this.ActiveDD.TabIndex = 15;
            this.ActiveDD.SelectedIndexChanged += new System.EventHandler(this.ActiveDD_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.catIDGV,
            this.catNameGV,
            this.StatusGV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1127, 587);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // catIDGV
            // 
            this.catIDGV.HeaderText = "CatID";
            this.catIDGV.Name = "catIDGV";
            this.catIDGV.ReadOnly = true;
            this.catIDGV.Visible = false;
            // 
            // catNameGV
            // 
            this.catNameGV.HeaderText = "Name";
            this.catNameGV.Name = "catNameGV";
            this.catNameGV.ReadOnly = true;
            // 
            // StatusGV
            // 
            this.StatusGV.HeaderText = "Status";
            this.StatusGV.Name = "StatusGV";
            this.StatusGV.ReadOnly = true;
            // 
            // Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1377, 701);
            this.Name = "Categories";
            this.Text = "Categories";
            this.Load += new System.EventHandler(this.Categories_Load);
            this.leftpanel.ResumeLayout(false);
            this.leftpanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.rightpanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ActiveDD;
        private System.Windows.Forms.TextBox Categrytxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Activeerrorlbl;
        private System.Windows.Forms.Label Caterrorlbl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn catIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn catNameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusGV;
    }
}