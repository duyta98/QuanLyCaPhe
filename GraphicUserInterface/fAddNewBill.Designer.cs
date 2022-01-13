namespace QL_QuanCF
{
    partial class fAddNewBill
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlID = new System.Windows.Forms.Panel();
            this.txtTabName = new QL_QuanCF.TextBoxAutoComplete();
            this.lbIDBan = new System.Windows.Forms.Label();
            this.txbSoNguoi = new System.Windows.Forms.TextBox();
            this.lbSoNguoi = new System.Windows.Forms.Label();
            this.lbSoBan = new System.Windows.Forms.Label();
            this.lsvBillInfo = new System.Windows.Forms.ListView();
            this.pos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearchFood = new QL_QuanCF.TextBoxAutoComplete();
            this.btnSearch = new System.Windows.Forms.Button();
            this.flpViewFood = new System.Windows.Forms.FlowLayoutPanel();
            this.btnEtc = new System.Windows.Forms.Button();
            this.btnDrink = new System.Windows.Forms.Button();
            this.btnFood = new System.Windows.Forms.Button();
            this.btnMostUsed = new System.Windows.Forms.Button();
            this.cmsFoodFLP = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.thêmNhiềuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2.SuspendLayout();
            this.pnlButton.SuspendLayout();
            this.pnlID.SuspendLayout();
            this.panel1.SuspendLayout();
            this.cmsFoodFLP.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.pnlButton);
            this.panel2.Controls.Add(this.pnlID);
            this.panel2.Controls.Add(this.lsvBillInfo);
            this.panel2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(875, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(475, 694);
            this.panel2.TabIndex = 3;
            // 
            // pnlButton
            // 
            this.pnlButton.Controls.Add(this.btnReturn);
            this.pnlButton.Controls.Add(this.btnPay);
            this.pnlButton.Controls.Add(this.btnSave);
            this.pnlButton.Location = new System.Drawing.Point(0, 632);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(475, 62);
            this.pnlButton.TabIndex = 1;
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(130, 9);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(99, 43);
            this.btnReturn.TabIndex = 0;
            this.btnReturn.Text = "Trở về";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPay.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(340, 9);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(123, 43);
            this.btnPay.TabIndex = 2;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(235, 8);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 43);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Lưu bàn";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // pnlID
            // 
            this.pnlID.Controls.Add(this.txtTabName);
            this.pnlID.Controls.Add(this.lbIDBan);
            this.pnlID.Controls.Add(this.txbSoNguoi);
            this.pnlID.Controls.Add(this.lbSoNguoi);
            this.pnlID.Controls.Add(this.lbSoBan);
            this.pnlID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlID.Location = new System.Drawing.Point(0, 0);
            this.pnlID.Name = "pnlID";
            this.pnlID.Size = new System.Drawing.Size(475, 45);
            this.pnlID.TabIndex = 0;
            // 
            // txtTabName
            // 
            this.txtTabName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTabName.Location = new System.Drawing.Point(62, 6);
            this.txtTabName.Name = "txtTabName";
            this.txtTabName.Size = new System.Drawing.Size(136, 32);
            this.txtTabName.TabIndex = 0;
            this.txtTabName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTabName.Leave += new System.EventHandler(this.txtTabName_Leave);
            // 
            // lbIDBan
            // 
            this.lbIDBan.AutoSize = true;
            this.lbIDBan.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDBan.Location = new System.Drawing.Point(3, 13);
            this.lbIDBan.Name = "lbIDBan";
            this.lbIDBan.Size = new System.Drawing.Size(0, 20);
            this.lbIDBan.TabIndex = 3;
            this.lbIDBan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbSoNguoi
            // 
            this.txbSoNguoi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbSoNguoi.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSoNguoi.Location = new System.Drawing.Point(356, 6);
            this.txbSoNguoi.Name = "txbSoNguoi";
            this.txbSoNguoi.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txbSoNguoi.Size = new System.Drawing.Size(49, 32);
            this.txbSoNguoi.TabIndex = 1;
            this.txbSoNguoi.Text = "0";
            this.txbSoNguoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbSoNguoi
            // 
            this.lbSoNguoi.AutoSize = true;
            this.lbSoNguoi.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoNguoi.Location = new System.Drawing.Point(247, 9);
            this.lbSoNguoi.Name = "lbSoNguoi";
            this.lbSoNguoi.Size = new System.Drawing.Size(103, 24);
            this.lbSoNguoi.TabIndex = 1;
            this.lbSoNguoi.Text = "Số người:";
            // 
            // lbSoBan
            // 
            this.lbSoBan.AutoSize = true;
            this.lbSoBan.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoBan.Location = new System.Drawing.Point(3, 9);
            this.lbSoBan.Name = "lbSoBan";
            this.lbSoBan.Size = new System.Drawing.Size(53, 24);
            this.lbSoBan.TabIndex = 0;
            this.lbSoBan.Text = "Bàn:";
            // 
            // lsvBillInfo
            // 
            this.lsvBillInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.pos,
            this.name,
            this.quantity,
            this.Price});
            this.lsvBillInfo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvBillInfo.GridLines = true;
            this.lsvBillInfo.HideSelection = false;
            this.lsvBillInfo.Location = new System.Drawing.Point(0, 49);
            this.lsvBillInfo.MultiSelect = false;
            this.lsvBillInfo.Name = "lsvBillInfo";
            this.lsvBillInfo.Size = new System.Drawing.Size(475, 585);
            this.lsvBillInfo.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lsvBillInfo.TabIndex = 0;
            this.lsvBillInfo.UseCompatibleStateImageBehavior = false;
            this.lsvBillInfo.View = System.Windows.Forms.View.Details;
            // 
            // pos
            // 
            this.pos.Text = "STT";
            this.pos.Width = 52;
            // 
            // name
            // 
            this.name.Text = "Tên món";
            this.name.Width = 221;
            // 
            // quantity
            // 
            this.quantity.Text = "SL";
            this.quantity.Width = 43;
            // 
            // Price
            // 
            this.Price.Text = "Đơn giá";
            this.Price.Width = 150;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.txtSearchFood);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.flpViewFood);
            this.panel1.Controls.Add(this.btnEtc);
            this.panel1.Controls.Add(this.btnDrink);
            this.panel1.Controls.Add(this.btnFood);
            this.panel1.Controls.Add(this.btnMostUsed);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(876, 694);
            this.panel1.TabIndex = 4;
            // 
            // txtSearchFood
            // 
            this.txtSearchFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchFood.Location = new System.Drawing.Point(550, 10);
            this.txtSearchFood.Name = "txtSearchFood";
            this.txtSearchFood.Size = new System.Drawing.Size(199, 31);
            this.txtSearchFood.TabIndex = 10;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(746, 8);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(126, 36);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // flpViewFood
            // 
            this.flpViewFood.AutoScroll = true;
            this.flpViewFood.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flpViewFood.Location = new System.Drawing.Point(0, 49);
            this.flpViewFood.Name = "flpViewFood";
            this.flpViewFood.Size = new System.Drawing.Size(876, 645);
            this.flpViewFood.TabIndex = 8;
            // 
            // btnEtc
            // 
            this.btnEtc.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEtc.Location = new System.Drawing.Point(401, 8);
            this.btnEtc.Name = "btnEtc";
            this.btnEtc.Size = new System.Drawing.Size(126, 35);
            this.btnEtc.TabIndex = 7;
            this.btnEtc.Text = "Khác";
            this.btnEtc.UseVisualStyleBackColor = true;
            // 
            // btnDrink
            // 
            this.btnDrink.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrink.Location = new System.Drawing.Point(137, 8);
            this.btnDrink.Name = "btnDrink";
            this.btnDrink.Size = new System.Drawing.Size(126, 35);
            this.btnDrink.TabIndex = 6;
            this.btnDrink.Text = "Đồ uống";
            this.btnDrink.UseVisualStyleBackColor = true;
            // 
            // btnFood
            // 
            this.btnFood.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFood.Location = new System.Drawing.Point(269, 8);
            this.btnFood.Name = "btnFood";
            this.btnFood.Size = new System.Drawing.Size(126, 35);
            this.btnFood.TabIndex = 5;
            this.btnFood.Text = "Món ăn";
            this.btnFood.UseVisualStyleBackColor = true;
            // 
            // btnMostUsed
            // 
            this.btnMostUsed.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostUsed.Location = new System.Drawing.Point(5, 8);
            this.btnMostUsed.Name = "btnMostUsed";
            this.btnMostUsed.Size = new System.Drawing.Size(126, 35);
            this.btnMostUsed.TabIndex = 4;
            this.btnMostUsed.Text = "Hay dùng";
            this.btnMostUsed.UseVisualStyleBackColor = true;
            this.btnMostUsed.Click += new System.EventHandler(this.btnMostUsed_Click);
            // 
            // cmsFoodFLP
            // 
            this.cmsFoodFLP.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmNhiềuToolStripMenuItem});
            this.cmsFoodFLP.Name = "cmsFoodFLP";
            this.cmsFoodFLP.Size = new System.Drawing.Size(138, 26);
            // 
            // thêmNhiềuToolStripMenuItem
            // 
            this.thêmNhiềuToolStripMenuItem.Name = "thêmNhiềuToolStripMenuItem";
            this.thêmNhiềuToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.thêmNhiềuToolStripMenuItem.Text = "Thêm nhiều";
            // 
            // fAddNewBill
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1350, 696);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fAddNewBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm bàn";
            this.Load += new System.EventHandler(this.fAddNewBill_Load);
            this.panel2.ResumeLayout(false);
            this.pnlButton.ResumeLayout(false);
            this.pnlID.ResumeLayout(false);
            this.pnlID.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.cmsFoodFLP.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel pnlID;
        private System.Windows.Forms.TextBox txbSoNguoi;
        private System.Windows.Forms.Label lbSoNguoi;
        private System.Windows.Forms.Label lbSoBan;
        private System.Windows.Forms.ListView lsvBillInfo;
        private System.Windows.Forms.Label lbIDBan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEtc;
        private System.Windows.Forms.Button btnDrink;
        private System.Windows.Forms.Button btnFood;
        private System.Windows.Forms.Button btnMostUsed;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.FlowLayoutPanel flpViewFood;
        private System.Windows.Forms.Button btnSearch;
        private TextBoxAutoComplete txtTabName;
        private TextBoxAutoComplete txtSearchFood;
        private System.Windows.Forms.ColumnHeader pos;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader quantity;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ContextMenuStrip cmsFoodFLP;
        private System.Windows.Forms.ToolStripMenuItem thêmNhiềuToolStripMenuItem;
    }
}