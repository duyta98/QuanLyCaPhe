
namespace QL_QuanCF
{
    partial class fBill_Info
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
            this.flpViewFood = new System.Windows.Forms.FlowLayoutPanel();
            this.panelBill = new System.Windows.Forms.Panel();
            this.txtAmountTab = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTableNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lsvBillInfo = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveBill = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnDropTable = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearch = new QL_QuanCF.TextBoxAutoComplete();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbCate = new System.Windows.Forms.ComboBox();
            this.cmsFoodFLP = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.thêmNhiềuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsFoodListview = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thayĐổiSốLượngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelBill.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.cmsFoodFLP.SuspendLayout();
            this.cmsFoodListview.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpViewFood
            // 
            this.flpViewFood.BackColor = System.Drawing.Color.LightSkyBlue;
            this.flpViewFood.Location = new System.Drawing.Point(1, 83);
            this.flpViewFood.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flpViewFood.Name = "flpViewFood";
            this.flpViewFood.Size = new System.Drawing.Size(726, 570);
            this.flpViewFood.TabIndex = 0;
            // 
            // panelBill
            // 
            this.panelBill.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelBill.Controls.Add(this.txtAmountTab);
            this.panelBill.Controls.Add(this.label2);
            this.panelBill.Controls.Add(this.txtTableNumber);
            this.panelBill.Controls.Add(this.label1);
            this.panelBill.Location = new System.Drawing.Point(726, -2);
            this.panelBill.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelBill.Name = "panelBill";
            this.panelBill.Size = new System.Drawing.Size(448, 85);
            this.panelBill.TabIndex = 2;
            // 
            // txtAmountTab
            // 
            this.txtAmountTab.Font = new System.Drawing.Font("Arial", 16F);
            this.txtAmountTab.Location = new System.Drawing.Point(386, 27);
            this.txtAmountTab.Name = "txtAmountTab";
            this.txtAmountTab.Size = new System.Drawing.Size(52, 32);
            this.txtAmountTab.TabIndex = 3;
            this.txtAmountTab.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAmountTab.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTableNumber_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 16F);
            this.label2.Location = new System.Drawing.Point(277, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số người";
            // 
            // txtTableNumber
            // 
            this.txtTableNumber.Font = new System.Drawing.Font("Arial", 16F);
            this.txtTableNumber.Location = new System.Drawing.Point(94, 27);
            this.txtTableNumber.Name = "txtTableNumber";
            this.txtTableNumber.ReadOnly = true;
            this.txtTableNumber.Size = new System.Drawing.Size(100, 32);
            this.txtTableNumber.TabIndex = 2;
            this.txtTableNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTableNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTableNumber_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16F);
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số bàn";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.GhostWhite;
            this.panel3.Controls.Add(this.lsvBillInfo);
            this.panel3.Location = new System.Drawing.Point(726, 83);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(448, 448);
            this.panel3.TabIndex = 3;
            // 
            // lsvBillInfo
            // 
            this.lsvBillInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsvBillInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lsvBillInfo.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvBillInfo.FullRowSelect = true;
            this.lsvBillInfo.GridLines = true;
            this.lsvBillInfo.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lsvBillInfo.HideSelection = false;
            this.lsvBillInfo.Location = new System.Drawing.Point(0, 0);
            this.lsvBillInfo.MultiSelect = false;
            this.lsvBillInfo.Name = "lsvBillInfo";
            this.lsvBillInfo.Size = new System.Drawing.Size(448, 441);
            this.lsvBillInfo.TabIndex = 0;
            this.lsvBillInfo.UseCompatibleStateImageBehavior = false;
            this.lsvBillInfo.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "STT";
            this.columnHeader4.Width = 47;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên món";
            this.columnHeader1.Width = 196;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "SL";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 46;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 110;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel4.Controls.Add(this.btnCancel);
            this.panel4.Controls.Add(this.btnSaveBill);
            this.panel4.Controls.Add(this.btnPay);
            this.panel4.Controls.Add(this.btnPrint);
            this.panel4.Controls.Add(this.btnDropTable);
            this.panel4.Location = new System.Drawing.Point(726, 523);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(448, 130);
            this.panel4.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Orange;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Location = new System.Drawing.Point(167, 71);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(103, 36);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Trở về";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveBill
            // 
            this.btnSaveBill.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSaveBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveBill.Font = new System.Drawing.Font("Arial", 16F);
            this.btnSaveBill.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSaveBill.Location = new System.Drawing.Point(12, 16);
            this.btnSaveBill.Name = "btnSaveBill";
            this.btnSaveBill.Size = new System.Drawing.Size(126, 35);
            this.btnSaveBill.TabIndex = 5;
            this.btnSaveBill.Text = "Lưu HĐ";
            this.btnSaveBill.UseVisualStyleBackColor = false;
            this.btnSaveBill.Click += new System.EventHandler(this.btnSaveBill_Click);
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPay.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Arial", 16F);
            this.btnPay.Location = new System.Drawing.Point(295, 71);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(143, 36);
            this.btnPay.TabIndex = 8;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Arial", 16F);
            this.btnPrint.Location = new System.Drawing.Point(12, 71);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(126, 36);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "In HĐ";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnDropTable
            // 
            this.btnDropTable.BackColor = System.Drawing.Color.Coral;
            this.btnDropTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDropTable.Font = new System.Drawing.Font("Arial", 16F);
            this.btnDropTable.Location = new System.Drawing.Point(293, 15);
            this.btnDropTable.Name = "btnDropTable";
            this.btnDropTable.Size = new System.Drawing.Size(145, 36);
            this.btnDropTable.TabIndex = 6;
            this.btnDropTable.Text = "Hủy Bàn";
            this.btnDropTable.UseVisualStyleBackColor = false;
            this.btnDropTable.Click += new System.EventHandler(this.btnDropTable_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.GreenYellow;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 18F);
            this.btnSearch.Location = new System.Drawing.Point(502, 5);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(1);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(121, 35);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbbCate);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Location = new System.Drawing.Point(1, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(726, 85);
            this.panel1.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Arial", 18F);
            this.txtSearch.Location = new System.Drawing.Point(167, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(340, 35);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(3, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Danh mục món ăn";
            // 
            // cbbCate
            // 
            this.cbbCate.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCate.FormattingEnabled = true;
            this.cbbCate.Location = new System.Drawing.Point(220, 50);
            this.cbbCate.Name = "cbbCate";
            this.cbbCate.Size = new System.Drawing.Size(200, 35);
            this.cbbCate.TabIndex = 2;
            this.cbbCate.SelectionChangeCommitted += new System.EventHandler(this.cbbCate_SelectionChangeCommitted);
            // 
            // cmsFoodFLP
            // 
            this.cmsFoodFLP.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmNhiềuToolStripMenuItem});
            this.cmsFoodFLP.Name = "cmsFoodFLP";
            this.cmsFoodFLP.Size = new System.Drawing.Size(138, 26);
            this.cmsFoodFLP.Opening += new System.ComponentModel.CancelEventHandler(this.cmsFoodFLP_Opening);
            // 
            // thêmNhiềuToolStripMenuItem
            // 
            this.thêmNhiềuToolStripMenuItem.Name = "thêmNhiềuToolStripMenuItem";
            this.thêmNhiềuToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.thêmNhiềuToolStripMenuItem.Text = "Thêm nhiều";
            this.thêmNhiềuToolStripMenuItem.Click += new System.EventHandler(this.thêmNhiềuToolStripMenuItem_Click);
            // 
            // cmsFoodListview
            // 
            this.cmsFoodListview.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaToolStripMenuItem,
            this.thayĐổiSốLượngToolStripMenuItem});
            this.cmsFoodListview.Name = "contextMenuStrip1";
            this.cmsFoodListview.Size = new System.Drawing.Size(169, 48);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.xóaToolStripMenuItem.Text = "Xóa";
            this.xóaToolStripMenuItem.Click += new System.EventHandler(this.xóaToolStripMenuItem_Click);
            // 
            // thayĐổiSốLượngToolStripMenuItem
            // 
            this.thayĐổiSốLượngToolStripMenuItem.Name = "thayĐổiSốLượngToolStripMenuItem";
            this.thayĐổiSốLượngToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.thayĐổiSốLượngToolStripMenuItem.Text = "Thay đổi số lượng";
            this.thayĐổiSốLượngToolStripMenuItem.Click += new System.EventHandler(this.thayĐổiSốLượngToolStripMenuItem_Click);
            // 
            // fBill_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(1176, 661);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelBill);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flpViewFood);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "fBill_Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fBill_Info";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fBill_Info_FormClosed);
            this.Load += new System.EventHandler(this.fBill_Info_Load);
            this.panelBill.ResumeLayout(false);
            this.panelBill.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.cmsFoodFLP.ResumeLayout(false);
            this.cmsFoodListview.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpViewFood;
        private System.Windows.Forms.Panel panelBill;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lsvBillInfo;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox txtAmountTab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTableNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnDropTable;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnSaveBill;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbCate;
        private System.Windows.Forms.ContextMenuStrip cmsFoodFLP;
        private System.Windows.Forms.ToolStripMenuItem thêmNhiềuToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsFoodListview;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thayĐổiSốLượngToolStripMenuItem;
        private System.Windows.Forms.Button btnCancel;
        private TextBoxAutoComplete txtSearch;
    }
}