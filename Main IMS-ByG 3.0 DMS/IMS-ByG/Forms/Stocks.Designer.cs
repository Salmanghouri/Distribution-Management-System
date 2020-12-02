namespace IMS_ByG.Forms
{
    partial class Stocks
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
            this.Quantitytxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ProductnameCB = new System.Windows.Forms.ComboBox();
            this.PerchaseRatetxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SalesRatetxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ViewStockbtn = new System.Windows.Forms.Button();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.StockIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SprodIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductNamepwGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PQuantityGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseRateGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PSalesRateGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockQTYerrorlbl = new System.Windows.Forms.Label();
            this.PuchaserateErrorlbl = new System.Windows.Forms.Label();
            this.SalesRateErrorlbl = new System.Windows.Forms.Label();
            this.leftpanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // leftpanel
            // 
            this.leftpanel.Controls.Add(this.ViewStockbtn);
            this.leftpanel.Controls.Add(this.SalesRatetxt);
            this.leftpanel.Controls.Add(this.label6);
            this.leftpanel.Controls.Add(this.PerchaseRatetxt);
            this.leftpanel.Controls.Add(this.label5);
            this.leftpanel.Controls.Add(this.ProductnameCB);
            this.leftpanel.Controls.Add(this.Quantitytxt);
            this.leftpanel.Controls.Add(this.label4);
            this.leftpanel.Controls.Add(this.label3);
            this.leftpanel.Controls.Add(this.SalesRateErrorlbl);
            this.leftpanel.Controls.Add(this.PuchaserateErrorlbl);
            this.leftpanel.Controls.Add(this.StockQTYerrorlbl);
            this.leftpanel.Size = new System.Drawing.Size(271, 798);
            this.leftpanel.Controls.SetChildIndex(this.StockQTYerrorlbl, 0);
            this.leftpanel.Controls.SetChildIndex(this.PuchaserateErrorlbl, 0);
            this.leftpanel.Controls.SetChildIndex(this.SalesRateErrorlbl, 0);
            this.leftpanel.Controls.SetChildIndex(this.label3, 0);
            this.leftpanel.Controls.SetChildIndex(this.label4, 0);
            this.leftpanel.Controls.SetChildIndex(this.Quantitytxt, 0);
            this.leftpanel.Controls.SetChildIndex(this.ProductnameCB, 0);
            this.leftpanel.Controls.SetChildIndex(this.label5, 0);
            this.leftpanel.Controls.SetChildIndex(this.PerchaseRatetxt, 0);
            this.leftpanel.Controls.SetChildIndex(this.label6, 0);
            this.leftpanel.Controls.SetChildIndex(this.SalesRatetxt, 0);
            this.leftpanel.Controls.SetChildIndex(this.ViewStockbtn, 0);
            this.leftpanel.Controls.SetChildIndex(this.panel2, 0);
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(271, 48);
            // 
            // rightpanel
            // 
            this.rightpanel.Controls.Add(this.DataGridView1);
            this.rightpanel.Location = new System.Drawing.Point(271, 0);
            this.rightpanel.Size = new System.Drawing.Size(1192, 798);
            this.rightpanel.Controls.SetChildIndex(this.panel1, 0);
            this.rightpanel.Controls.SetChildIndex(this.DataGridView1, 0);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 60);
            this.panel1.Size = new System.Drawing.Size(1192, 54);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(123, 0);
            // 
            // label2
            // 
            this.label2.Size = new System.Drawing.Size(1192, 54);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Product Name";
            // 
            // Quantitytxt
            // 
            this.Quantitytxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantitytxt.Location = new System.Drawing.Point(25, 312);
            this.Quantitytxt.Name = "Quantitytxt";
            this.Quantitytxt.Size = new System.Drawing.Size(212, 29);
            this.Quantitytxt.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantity";
            // 
            // ProductnameCB
            // 
            this.ProductnameCB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductnameCB.FormattingEnabled = true;
            this.ProductnameCB.Location = new System.Drawing.Point(25, 263);
            this.ProductnameCB.Name = "ProductnameCB";
            this.ProductnameCB.Size = new System.Drawing.Size(212, 29);
            this.ProductnameCB.TabIndex = 5;
            // 
            // PerchaseRatetxt
            // 
            this.PerchaseRatetxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PerchaseRatetxt.Location = new System.Drawing.Point(25, 367);
            this.PerchaseRatetxt.Name = "PerchaseRatetxt";
            this.PerchaseRatetxt.Size = new System.Drawing.Size(212, 29);
            this.PerchaseRatetxt.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Purchase Rate";
            // 
            // SalesRatetxt
            // 
            this.SalesRatetxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesRatetxt.Location = new System.Drawing.Point(25, 424);
            this.SalesRatetxt.Name = "SalesRatetxt";
            this.SalesRatetxt.Size = new System.Drawing.Size(212, 29);
            this.SalesRatetxt.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 401);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "SaleRate";
            // 
            // ViewStockbtn
            // 
            this.ViewStockbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewStockbtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewStockbtn.Location = new System.Drawing.Point(25, 459);
            this.ViewStockbtn.Name = "ViewStockbtn";
            this.ViewStockbtn.Size = new System.Drawing.Size(212, 67);
            this.ViewStockbtn.TabIndex = 10;
            this.ViewStockbtn.Text = "View Stock Report";
            this.ViewStockbtn.UseVisualStyleBackColor = true;
            this.ViewStockbtn.Click += new System.EventHandler(this.ViewStockbtn_Click);
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StockIDGV,
            this.SprodIDGV,
            this.ProductNamepwGV,
            this.PQuantityGV,
            this.PurchaseRateGV,
            this.PSalesRateGV});
            this.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView1.Location = new System.Drawing.Point(0, 114);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.RowHeadersVisible = false;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size = new System.Drawing.Size(1192, 684);
            this.DataGridView1.TabIndex = 2;
            this.DataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // StockIDGV
            // 
            this.StockIDGV.HeaderText = "StockID";
            this.StockIDGV.Name = "StockIDGV";
            this.StockIDGV.ReadOnly = true;
            this.StockIDGV.Visible = false;
            // 
            // SprodIDGV
            // 
            this.SprodIDGV.HeaderText = "ProductID";
            this.SprodIDGV.Name = "SprodIDGV";
            this.SprodIDGV.ReadOnly = true;
            this.SprodIDGV.Visible = false;
            // 
            // ProductNamepwGV
            // 
            this.ProductNamepwGV.HeaderText = "ProductName";
            this.ProductNamepwGV.Name = "ProductNamepwGV";
            this.ProductNamepwGV.ReadOnly = true;
            // 
            // PQuantityGV
            // 
            this.PQuantityGV.HeaderText = "PQuantity";
            this.PQuantityGV.Name = "PQuantityGV";
            this.PQuantityGV.ReadOnly = true;
            // 
            // PurchaseRateGV
            // 
            this.PurchaseRateGV.HeaderText = "Purchase Rate";
            this.PurchaseRateGV.Name = "PurchaseRateGV";
            this.PurchaseRateGV.ReadOnly = true;
            // 
            // PSalesRateGV
            // 
            this.PSalesRateGV.HeaderText = "Sales Rate";
            this.PSalesRateGV.Name = "PSalesRateGV";
            this.PSalesRateGV.ReadOnly = true;
            // 
            // StockQTYerrorlbl
            // 
            this.StockQTYerrorlbl.AutoSize = true;
            this.StockQTYerrorlbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StockQTYerrorlbl.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockQTYerrorlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.StockQTYerrorlbl.Location = new System.Drawing.Point(213, 288);
            this.StockQTYerrorlbl.Name = "StockQTYerrorlbl";
            this.StockQTYerrorlbl.Size = new System.Drawing.Size(24, 31);
            this.StockQTYerrorlbl.TabIndex = 11;
            this.StockQTYerrorlbl.Text = "*";
            this.StockQTYerrorlbl.Visible = false;
            // 
            // PuchaserateErrorlbl
            // 
            this.PuchaserateErrorlbl.AutoSize = true;
            this.PuchaserateErrorlbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PuchaserateErrorlbl.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PuchaserateErrorlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.PuchaserateErrorlbl.Location = new System.Drawing.Point(213, 344);
            this.PuchaserateErrorlbl.Name = "PuchaserateErrorlbl";
            this.PuchaserateErrorlbl.Size = new System.Drawing.Size(24, 31);
            this.PuchaserateErrorlbl.TabIndex = 11;
            this.PuchaserateErrorlbl.Text = "*";
            this.PuchaserateErrorlbl.Visible = false;
            // 
            // SalesRateErrorlbl
            // 
            this.SalesRateErrorlbl.AutoSize = true;
            this.SalesRateErrorlbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalesRateErrorlbl.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesRateErrorlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SalesRateErrorlbl.Location = new System.Drawing.Point(213, 401);
            this.SalesRateErrorlbl.Name = "SalesRateErrorlbl";
            this.SalesRateErrorlbl.Size = new System.Drawing.Size(24, 31);
            this.SalesRateErrorlbl.TabIndex = 11;
            this.SalesRateErrorlbl.Text = "*";
            this.SalesRateErrorlbl.Visible = false;
            // 
            // Stocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1463, 798);
            this.Name = "Stocks";
            this.Text = "Stocks";
            this.Load += new System.EventHandler(this.Stocks_Load);
            this.leftpanel.ResumeLayout(false);
            this.leftpanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.rightpanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ViewStockbtn;
        private System.Windows.Forms.TextBox SalesRatetxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PerchaseRatetxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ProductnameCB;
        private System.Windows.Forms.TextBox Quantitytxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.Label PuchaserateErrorlbl;
        private System.Windows.Forms.Label StockQTYerrorlbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SprodIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductNamepwGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PQuantityGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseRateGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PSalesRateGV;
        private System.Windows.Forms.Label SalesRateErrorlbl;
    }
}