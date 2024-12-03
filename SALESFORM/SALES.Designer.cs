namespace INVENTORYSYSTEM_GROUP2
{
    partial class SALES
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SALES));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabTransactions = new System.Windows.Forms.TabPage();
            this.btn_dsc_trans = new System.Windows.Forms.PictureBox();
            this.btn_asc_trans = new System.Windows.Forms.PictureBox();
            this.cbPRODUCTSORT = new System.Windows.Forms.ComboBox();
            this.lblTRANSNUMBER = new System.Windows.Forms.Label();
            this.lvTRANSACTION = new System.Windows.Forms.ListView();
            this.PRNAME = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CATEGORY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UNITS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PRICE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TOTALPRICE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.btn_dsc_invoice = new System.Windows.Forms.PictureBox();
            this.btn_asc_invoice = new System.Windows.Forms.PictureBox();
            this.lvINVOICE = new System.Windows.Forms.ListView();
            this.TRANSACTION = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NOOFPRODUCT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TOTALUNITS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TOTALAMOUNTPAID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DATEPURCHASED = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbTRANSSORT = new System.Windows.Forms.ComboBox();
            this.cbPRODUCT = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbDATE2 = new System.Windows.Forms.ComboBox();
            this.cbDATE1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabProducts = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.cbPRIORITY = new System.Windows.Forms.ComboBox();
            this.cbPERIOD = new System.Windows.Forms.ComboBox();
            this.lvPRODUCT = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PRONAME = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PROCATEGORY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SOLD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TOTALAMOUNT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PRIORITY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbCATEGORY = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabTransactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_dsc_trans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_asc_trans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_dsc_invoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_asc_invoice)).BeginInit();
            this.tabProducts.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabTransactions);
            this.tabControl1.Controls.Add(this.tabProducts);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(657, 550);
            this.tabControl1.TabIndex = 0;
            // 
            // tabTransactions
            // 
            this.tabTransactions.Controls.Add(this.btn_dsc_trans);
            this.tabTransactions.Controls.Add(this.btn_asc_trans);
            this.tabTransactions.Controls.Add(this.cbPRODUCTSORT);
            this.tabTransactions.Controls.Add(this.lblTRANSNUMBER);
            this.tabTransactions.Controls.Add(this.lvTRANSACTION);
            this.tabTransactions.Controls.Add(this.label3);
            this.tabTransactions.Controls.Add(this.btn_dsc_invoice);
            this.tabTransactions.Controls.Add(this.btn_asc_invoice);
            this.tabTransactions.Controls.Add(this.lvINVOICE);
            this.tabTransactions.Controls.Add(this.cbTRANSSORT);
            this.tabTransactions.Controls.Add(this.cbPRODUCT);
            this.tabTransactions.Controls.Add(this.label2);
            this.tabTransactions.Controls.Add(this.cbDATE2);
            this.tabTransactions.Controls.Add(this.cbDATE1);
            this.tabTransactions.Controls.Add(this.label1);
            this.tabTransactions.Location = new System.Drawing.Point(4, 22);
            this.tabTransactions.Name = "tabTransactions";
            this.tabTransactions.Padding = new System.Windows.Forms.Padding(3);
            this.tabTransactions.Size = new System.Drawing.Size(649, 524);
            this.tabTransactions.TabIndex = 0;
            this.tabTransactions.Text = "TRANSACTIONS";
            this.tabTransactions.UseVisualStyleBackColor = true;
            // 
            // btn_dsc_trans
            // 
            this.btn_dsc_trans.Image = ((System.Drawing.Image)(resources.GetObject("btn_dsc_trans.Image")));
            this.btn_dsc_trans.Location = new System.Drawing.Point(480, 300);
            this.btn_dsc_trans.Margin = new System.Windows.Forms.Padding(2);
            this.btn_dsc_trans.Name = "btn_dsc_trans";
            this.btn_dsc_trans.Size = new System.Drawing.Size(20, 20);
            this.btn_dsc_trans.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_dsc_trans.TabIndex = 27;
            this.btn_dsc_trans.TabStop = false;
            this.btn_dsc_trans.Click += new System.EventHandler(this.btn_dsc_trans_Click);
            // 
            // btn_asc_trans
            // 
            this.btn_asc_trans.Image = ((System.Drawing.Image)(resources.GetObject("btn_asc_trans.Image")));
            this.btn_asc_trans.Location = new System.Drawing.Point(456, 300);
            this.btn_asc_trans.Margin = new System.Windows.Forms.Padding(2);
            this.btn_asc_trans.Name = "btn_asc_trans";
            this.btn_asc_trans.Size = new System.Drawing.Size(20, 20);
            this.btn_asc_trans.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_asc_trans.TabIndex = 26;
            this.btn_asc_trans.TabStop = false;
            this.btn_asc_trans.Click += new System.EventHandler(this.btn_asc_trans_Click);
            // 
            // cbPRODUCTSORT
            // 
            this.cbPRODUCTSORT.FormattingEnabled = true;
            this.cbPRODUCTSORT.Items.AddRange(new object[] {
            "ALL",
            "UNITS",
            "PRICE",
            "TOTAL PRICE"});
            this.cbPRODUCTSORT.Location = new System.Drawing.Point(505, 298);
            this.cbPRODUCTSORT.Name = "cbPRODUCTSORT";
            this.cbPRODUCTSORT.Size = new System.Drawing.Size(82, 21);
            this.cbPRODUCTSORT.TabIndex = 25;
            this.cbPRODUCTSORT.Text = "SORT";
            this.cbPRODUCTSORT.SelectedIndexChanged += new System.EventHandler(this.cbPRODUCTSORT_SelectedIndexChanged);
            // 
            // lblTRANSNUMBER
            // 
            this.lblTRANSNUMBER.AutoSize = true;
            this.lblTRANSNUMBER.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTRANSNUMBER.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTRANSNUMBER.Location = new System.Drawing.Point(188, 304);
            this.lblTRANSNUMBER.Name = "lblTRANSNUMBER";
            this.lblTRANSNUMBER.Size = new System.Drawing.Size(46, 18);
            this.lblTRANSNUMBER.TabIndex = 24;
            this.lblTRANSNUMBER.Text = "label4";
            this.lblTRANSNUMBER.Click += new System.EventHandler(this.lblTRANSNUMBER_Click);
            // 
            // lvTRANSACTION
            // 
            this.lvTRANSACTION.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PRNAME,
            this.CATEGORY,
            this.UNITS,
            this.PRICE,
            this.TOTALPRICE});
            this.lvTRANSACTION.FullRowSelect = true;
            this.lvTRANSACTION.GridLines = true;
            this.lvTRANSACTION.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvTRANSACTION.HideSelection = false;
            this.lvTRANSACTION.Location = new System.Drawing.Point(52, 325);
            this.lvTRANSACTION.Name = "lvTRANSACTION";
            this.lvTRANSACTION.Size = new System.Drawing.Size(535, 157);
            this.lvTRANSACTION.TabIndex = 23;
            this.lvTRANSACTION.UseCompatibleStateImageBehavior = false;
            this.lvTRANSACTION.View = System.Windows.Forms.View.Details;
            this.lvTRANSACTION.SelectedIndexChanged += new System.EventHandler(this.lvTRANSACTION_SelectedIndexChanged);
            // 
            // PRNAME
            // 
            this.PRNAME.Text = "NAME";
            this.PRNAME.Width = 190;
            // 
            // CATEGORY
            // 
            this.CATEGORY.Text = "CATEGORY";
            this.CATEGORY.Width = 90;
            // 
            // UNITS
            // 
            this.UNITS.Text = "UNIT/S";
            this.UNITS.Width = 80;
            // 
            // PRICE
            // 
            this.PRICE.Text = "PRICE";
            this.PRICE.Width = 90;
            // 
            // TOTALPRICE
            // 
            this.TOTALPRICE.Text = "TOTAL PRICE";
            this.TOTALPRICE.Width = 90;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "TRANSACTION NO.:";
            // 
            // btn_dsc_invoice
            // 
            this.btn_dsc_invoice.Image = ((System.Drawing.Image)(resources.GetObject("btn_dsc_invoice.Image")));
            this.btn_dsc_invoice.Location = new System.Drawing.Point(480, 88);
            this.btn_dsc_invoice.Margin = new System.Windows.Forms.Padding(2);
            this.btn_dsc_invoice.Name = "btn_dsc_invoice";
            this.btn_dsc_invoice.Size = new System.Drawing.Size(20, 20);
            this.btn_dsc_invoice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_dsc_invoice.TabIndex = 21;
            this.btn_dsc_invoice.TabStop = false;
            this.btn_dsc_invoice.Click += new System.EventHandler(this.btn_dsc_invoice_Click);
            // 
            // btn_asc_invoice
            // 
            this.btn_asc_invoice.Image = ((System.Drawing.Image)(resources.GetObject("btn_asc_invoice.Image")));
            this.btn_asc_invoice.Location = new System.Drawing.Point(456, 88);
            this.btn_asc_invoice.Margin = new System.Windows.Forms.Padding(2);
            this.btn_asc_invoice.Name = "btn_asc_invoice";
            this.btn_asc_invoice.Size = new System.Drawing.Size(20, 20);
            this.btn_asc_invoice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_asc_invoice.TabIndex = 20;
            this.btn_asc_invoice.TabStop = false;
            this.btn_asc_invoice.Click += new System.EventHandler(this.btn_asc_invoice_Click);
            // 
            // lvINVOICE
            // 
            this.lvINVOICE.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TRANSACTION,
            this.NOOFPRODUCT,
            this.TOTALUNITS,
            this.TOTALAMOUNTPAID,
            this.DATEPURCHASED});
            this.lvINVOICE.FullRowSelect = true;
            this.lvINVOICE.GridLines = true;
            this.lvINVOICE.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvINVOICE.HideSelection = false;
            this.lvINVOICE.Location = new System.Drawing.Point(52, 115);
            this.lvINVOICE.Name = "lvINVOICE";
            this.lvINVOICE.Size = new System.Drawing.Size(535, 157);
            this.lvINVOICE.TabIndex = 6;
            this.lvINVOICE.UseCompatibleStateImageBehavior = false;
            this.lvINVOICE.View = System.Windows.Forms.View.Details;
            // 
            // TRANSACTION
            // 
            this.TRANSACTION.Text = "ID";
            // 
            // NOOFPRODUCT
            // 
            this.NOOFPRODUCT.Text = "NO. OF PRODUCT";
            this.NOOFPRODUCT.Width = 120;
            // 
            // TOTALUNITS
            // 
            this.TOTALUNITS.Text = "TOTAL UNITS";
            this.TOTALUNITS.Width = 100;
            // 
            // TOTALAMOUNTPAID
            // 
            this.TOTALAMOUNTPAID.Text = "TOTAL AMOUNT PAID";
            this.TOTALAMOUNTPAID.Width = 130;
            // 
            // DATEPURCHASED
            // 
            this.DATEPURCHASED.Text = "DATE PURCHASED";
            this.DATEPURCHASED.Width = 120;
            // 
            // cbTRANSSORT
            // 
            this.cbTRANSSORT.FormattingEnabled = true;
            this.cbTRANSSORT.Items.AddRange(new object[] {
            "ALL",
            "NO. OF PRODUCT",
            "UNITS",
            "AMOUNT PAID",
            "DATE PURCHASED"});
            this.cbTRANSSORT.Location = new System.Drawing.Point(505, 88);
            this.cbTRANSSORT.Name = "cbTRANSSORT";
            this.cbTRANSSORT.Size = new System.Drawing.Size(82, 21);
            this.cbTRANSSORT.TabIndex = 5;
            this.cbTRANSSORT.Text = "SORT";
            this.cbTRANSSORT.SelectedIndexChanged += new System.EventHandler(this.cbTRANSSORT_SelectedIndexChanged);
            // 
            // cbPRODUCT
            // 
            this.cbPRODUCT.FormattingEnabled = true;
            this.cbPRODUCT.Location = new System.Drawing.Point(52, 88);
            this.cbPRODUCT.Name = "cbPRODUCT";
            this.cbPRODUCT.Size = new System.Drawing.Size(200, 21);
            this.cbPRODUCT.TabIndex = 4;
            this.cbPRODUCT.Text = "SELECT A PRODUCT TO SEARCH";
            this.cbPRODUCT.SelectedIndexChanged += new System.EventHandler(this.cbPRODUCT_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(312, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "-";
            // 
            // cbDATE2
            // 
            this.cbDATE2.FormattingEnabled = true;
            this.cbDATE2.Location = new System.Drawing.Point(333, 34);
            this.cbDATE2.Name = "cbDATE2";
            this.cbDATE2.Size = new System.Drawing.Size(254, 21);
            this.cbDATE2.TabIndex = 2;
            this.cbDATE2.SelectedIndexChanged += new System.EventHandler(this.cbDATE2_SelectedIndexChanged);
            // 
            // cbDATE1
            // 
            this.cbDATE1.FormattingEnabled = true;
            this.cbDATE1.Location = new System.Drawing.Point(52, 34);
            this.cbDATE1.Name = "cbDATE1";
            this.cbDATE1.Size = new System.Drawing.Size(254, 21);
            this.cbDATE1.TabIndex = 1;
            this.cbDATE1.SelectedIndexChanged += new System.EventHandler(this.cbDATE1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "TRANSACTION PERIOD:";
            // 
            // tabProducts
            // 
            this.tabProducts.Controls.Add(this.label4);
            this.tabProducts.Controls.Add(this.cbPRIORITY);
            this.tabProducts.Controls.Add(this.cbPERIOD);
            this.tabProducts.Controls.Add(this.lvPRODUCT);
            this.tabProducts.Controls.Add(this.cbCATEGORY);
            this.tabProducts.Location = new System.Drawing.Point(4, 22);
            this.tabProducts.Name = "tabProducts";
            this.tabProducts.Padding = new System.Windows.Forms.Padding(3);
            this.tabProducts.Size = new System.Drawing.Size(649, 524);
            this.tabProducts.TabIndex = 1;
            this.tabProducts.Text = "PRODUCTS";
            this.tabProducts.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(357, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "VIEW:";
            // 
            // cbPRIORITY
            // 
            this.cbPRIORITY.FormattingEnabled = true;
            this.cbPRIORITY.Items.AddRange(new object[] {
            "HIGH PRIORITY",
            "LOW PRIORITY"});
            this.cbPRIORITY.Location = new System.Drawing.Point(407, 25);
            this.cbPRIORITY.Name = "cbPRIORITY";
            this.cbPRIORITY.Size = new System.Drawing.Size(116, 21);
            this.cbPRIORITY.TabIndex = 3;
            this.cbPRIORITY.Text = "PRIORITY";
            // 
            // cbPERIOD
            // 
            this.cbPERIOD.FormattingEnabled = true;
            this.cbPERIOD.Items.AddRange(new object[] {
            "DAILY",
            "WEEKLY",
            "MONTHLY",
            "ANNUALLY"});
            this.cbPERIOD.Location = new System.Drawing.Point(529, 25);
            this.cbPERIOD.Name = "cbPERIOD";
            this.cbPERIOD.Size = new System.Drawing.Size(90, 21);
            this.cbPERIOD.TabIndex = 2;
            this.cbPERIOD.Text = "PERIOD";
            this.cbPERIOD.SelectedIndexChanged += new System.EventHandler(this.cbPERIOD_SelectedIndexChanged);
            // 
            // lvPRODUCT
            // 
            this.lvPRODUCT.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.PRONAME,
            this.PROCATEGORY,
            this.SOLD,
            this.TOTALAMOUNT,
            this.PRIORITY});
            this.lvPRODUCT.FullRowSelect = true;
            this.lvPRODUCT.GridLines = true;
            this.lvPRODUCT.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvPRODUCT.HideSelection = false;
            this.lvPRODUCT.Location = new System.Drawing.Point(27, 52);
            this.lvPRODUCT.Name = "lvPRODUCT";
            this.lvPRODUCT.Size = new System.Drawing.Size(592, 445);
            this.lvPRODUCT.TabIndex = 1;
            this.lvPRODUCT.UseCompatibleStateImageBehavior = false;
            this.lvPRODUCT.View = System.Windows.Forms.View.Details;
            this.lvPRODUCT.SelectedIndexChanged += new System.EventHandler(this.lvPRODUCT_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // PRONAME
            // 
            this.PRONAME.Text = "PRODUCT NAME";
            this.PRONAME.Width = 190;
            // 
            // PROCATEGORY
            // 
            this.PROCATEGORY.Text = "CATEGORY";
            this.PROCATEGORY.Width = 90;
            // 
            // SOLD
            // 
            this.SOLD.Text = "SOLD";
            // 
            // TOTALAMOUNT
            // 
            this.TOTALAMOUNT.Text = "TOTAL AMOUNT";
            this.TOTALAMOUNT.Width = 110;
            // 
            // PRIORITY
            // 
            this.PRIORITY.Text = "PRIORITY";
            this.PRIORITY.Width = 80;
            // 
            // cbCATEGORY
            // 
            this.cbCATEGORY.FormattingEnabled = true;
            this.cbCATEGORY.Items.AddRange(new object[] {
            "ALL",
            "CPU",
            "GPU",
            "MOTHERBOARD",
            "RAM"});
            this.cbCATEGORY.Location = new System.Drawing.Point(27, 25);
            this.cbCATEGORY.Name = "cbCATEGORY";
            this.cbCATEGORY.Size = new System.Drawing.Size(138, 21);
            this.cbCATEGORY.TabIndex = 0;
            this.cbCATEGORY.Text = "CATEGORY";
            this.cbCATEGORY.SelectedIndexChanged += new System.EventHandler(this.cbCATEGORY_SelectedIndexChanged);
            // 
            // SALES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(681, 574);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SALES";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.SALES_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabTransactions.ResumeLayout(false);
            this.tabTransactions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_dsc_trans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_asc_trans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_dsc_invoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_asc_invoice)).EndInit();
            this.tabProducts.ResumeLayout(false);
            this.tabProducts.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabTransactions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabProducts;
        private System.Windows.Forms.ComboBox cbTRANSSORT;
        private System.Windows.Forms.ComboBox cbPRODUCT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbDATE2;
        private System.Windows.Forms.ComboBox cbDATE1;
        private System.Windows.Forms.PictureBox btn_asc_invoice;
        private System.Windows.Forms.ListView lvINVOICE;
        private System.Windows.Forms.PictureBox btn_dsc_invoice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lvTRANSACTION;
        private System.Windows.Forms.PictureBox btn_dsc_trans;
        private System.Windows.Forms.PictureBox btn_asc_trans;
        private System.Windows.Forms.ComboBox cbPRODUCTSORT;
        private System.Windows.Forms.Label lblTRANSNUMBER;
        private System.Windows.Forms.ListView lvPRODUCT;
        private System.Windows.Forms.ComboBox cbCATEGORY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbPRIORITY;
        private System.Windows.Forms.ComboBox cbPERIOD;
        private System.Windows.Forms.ColumnHeader TRANSACTION;
        private System.Windows.Forms.ColumnHeader NOOFPRODUCT;
        private System.Windows.Forms.ColumnHeader TOTALUNITS;
        private System.Windows.Forms.ColumnHeader TOTALAMOUNTPAID;
        private System.Windows.Forms.ColumnHeader DATEPURCHASED;
        private System.Windows.Forms.ColumnHeader PRNAME;
        private System.Windows.Forms.ColumnHeader CATEGORY;
        private System.Windows.Forms.ColumnHeader UNITS;
        private System.Windows.Forms.ColumnHeader PRICE;
        private System.Windows.Forms.ColumnHeader TOTALPRICE;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader PRONAME;
        private System.Windows.Forms.ColumnHeader PROCATEGORY;
        private System.Windows.Forms.ColumnHeader SOLD;
        private System.Windows.Forms.ColumnHeader TOTALAMOUNT;
        private System.Windows.Forms.ColumnHeader PRIORITY;
    }
}