using System;

namespace QL_QuanCF
{
    partial class fMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.txbTimkiem = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doanhThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thựcĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TaikhoanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chuyểnTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.côngCụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giúpĐỡToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnThemban = new System.Windows.Forms.Button();
            this.btnBar = new System.Windows.Forms.Button();
            this.pnlTable = new System.Windows.Forms.Panel();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnTakeAway = new System.Windows.Forms.Button();
            this.btnShip = new System.Windows.Forms.Button();
            this.btnReser = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.cmsTable = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.chuyểnBànToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gộpBànToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hủyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thanhToánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.pnlTable.SuspendLayout();
            this.panel3.SuspendLayout();
            this.cmsTable.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbTimkiem
            // 
            this.txbTimkiem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txbTimkiem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txbTimkiem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txbTimkiem.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTimkiem.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txbTimkiem.Location = new System.Drawing.Point(118, 0);
            this.txbTimkiem.Name = "txbTimkiem";
            this.txbTimkiem.Size = new System.Drawing.Size(400, 35);
            this.txbTimkiem.TabIndex = 17;
            this.txbTimkiem.Text = "Nhập số bàn, món ăn, nước uống,...";
            this.txbTimkiem.Enter += new System.EventHandler(this.txbTimkiem_Enter);
            this.txbTimkiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbTimkiem_KeyDown);
            this.txbTimkiem.Leave += new System.EventHandler(this.txbTimkiem_Leave);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýToolStripMenuItem,
            this.TaikhoanToolStripMenuItem,
            this.côngCụToolStripMenuItem,
            this.giúpĐỡToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(454, 30);
            this.menuStrip1.TabIndex = 0;
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doanhThuToolStripMenuItem,
            this.nhânViênToolStripMenuItem,
            this.hóaĐơnToolStripMenuItem,
            this.thựcĐơnToolStripMenuItem});
            this.quảnLýToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quảnLýToolStripMenuItem.Image")));
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(108, 26);
            this.quảnLýToolStripMenuItem.Text = "Quản Lý";
            // 
            // doanhThuToolStripMenuItem
            // 
            this.doanhThuToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("doanhThuToolStripMenuItem.Image")));
            this.doanhThuToolStripMenuItem.Name = "doanhThuToolStripMenuItem";
            this.doanhThuToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.doanhThuToolStripMenuItem.Text = "Doanh thu";
            // 
            // nhânViênToolStripMenuItem
            // 
            this.nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            this.nhânViênToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.nhânViênToolStripMenuItem.Text = "Nhân viên";
            this.nhânViênToolStripMenuItem.Click += new System.EventHandler(this.NhânViênToolStripMenuItem_Click);
            // 
            // hóaĐơnToolStripMenuItem
            // 
            this.hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            this.hóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.hóaĐơnToolStripMenuItem.Text = "Hóa đơn";
            // 
            // thựcĐơnToolStripMenuItem
            // 
            this.thựcĐơnToolStripMenuItem.Name = "thựcĐơnToolStripMenuItem";
            this.thựcĐơnToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.thựcĐơnToolStripMenuItem.Text = "Thực đơn";
            this.thựcĐơnToolStripMenuItem.Click += new System.EventHandler(this.ThựcĐơnToolStripMenuItem_Click);
            // 
            // TaikhoanToolStripMenuItem
            // 
            this.TaikhoanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinTàiKhoảnToolStripMenuItem,
            this.chuyểnTàiKhoảnToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.TaikhoanToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("TaikhoanToolStripMenuItem.Image")));
            this.TaikhoanToolStripMenuItem.Name = "TaikhoanToolStripMenuItem";
            this.TaikhoanToolStripMenuItem.Size = new System.Drawing.Size(123, 26);
            this.TaikhoanToolStripMenuItem.Text = "Tài Khoản";
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            this.thôngTinTàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.ThôngTinTàiKhoảnToolStripMenuItem_Click);
            // 
            // chuyểnTàiKhoảnToolStripMenuItem
            // 
            this.chuyểnTàiKhoảnToolStripMenuItem.Name = "chuyểnTàiKhoảnToolStripMenuItem";
            this.chuyểnTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.chuyểnTàiKhoảnToolStripMenuItem.Text = "Chuyển tài khoản";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.ĐăngXuấtToolStripMenuItem_Click);
            // 
            // côngCụToolStripMenuItem
            // 
            this.côngCụToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("côngCụToolStripMenuItem.Image")));
            this.côngCụToolStripMenuItem.Name = "côngCụToolStripMenuItem";
            this.côngCụToolStripMenuItem.Size = new System.Drawing.Size(109, 26);
            this.côngCụToolStripMenuItem.Text = "Công cụ";
            // 
            // giúpĐỡToolStripMenuItem
            // 
            this.giúpĐỡToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("giúpĐỡToolStripMenuItem.Image")));
            this.giúpĐỡToolStripMenuItem.Name = "giúpĐỡToolStripMenuItem";
            this.giúpĐỡToolStripMenuItem.Size = new System.Drawing.Size(106, 26);
            this.giúpĐỡToolStripMenuItem.Text = "Giúp đỡ";
            // 
            // btnThemban
            // 
            this.btnThemban.BackColor = System.Drawing.Color.Blue;
            this.btnThemban.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThemban.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnThemban.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemban.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemban.ForeColor = System.Drawing.Color.White;
            this.btnThemban.Location = new System.Drawing.Point(1133, 35);
            this.btnThemban.Name = "btnThemban";
            this.btnThemban.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnThemban.Size = new System.Drawing.Size(83, 38);
            this.btnThemban.TabIndex = 4;
            this.btnThemban.Text = "Thêm";
            this.btnThemban.UseVisualStyleBackColor = false;
            this.btnThemban.Click += new System.EventHandler(this.BtnThemban_Click);
            // 
            // btnBar
            // 
            this.btnBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBar.BackColor = System.Drawing.Color.Indigo;
            this.btnBar.FlatAppearance.BorderSize = 0;
            this.btnBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnBar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBar.Location = new System.Drawing.Point(0, 0);
            this.btnBar.Margin = new System.Windows.Forms.Padding(0);
            this.btnBar.Name = "btnBar";
            this.btnBar.Size = new System.Drawing.Size(141, 33);
            this.btnBar.TabIndex = 10;
            this.btnBar.Text = "Tại bàn";
            this.btnBar.UseVisualStyleBackColor = false;
            this.btnBar.Click += new System.EventHandler(this.btnBar_Click);
            // 
            // pnlTable
            // 
            this.pnlTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTable.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pnlTable.Controls.Add(this.flpTable);
            this.pnlTable.Location = new System.Drawing.Point(0, 75);
            this.pnlTable.Name = "pnlTable";
            this.pnlTable.Size = new System.Drawing.Size(1350, 583);
            this.pnlTable.TabIndex = 13;
            // 
            // flpTable
            // 
            this.flpTable.AutoScroll = true;
            this.flpTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpTable.Location = new System.Drawing.Point(0, 0);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(1350, 583);
            this.flpTable.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnTakeAway);
            this.panel3.Controls.Add(this.btnShip);
            this.panel3.Controls.Add(this.btnReser);
            this.panel3.Controls.Add(this.btnBar);
            this.panel3.Location = new System.Drawing.Point(7, 39);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(573, 33);
            this.panel3.TabIndex = 14;
            // 
            // btnTakeAway
            // 
            this.btnTakeAway.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTakeAway.BackColor = System.Drawing.Color.Indigo;
            this.btnTakeAway.FlatAppearance.BorderSize = 0;
            this.btnTakeAway.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTakeAway.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnTakeAway.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTakeAway.Location = new System.Drawing.Point(144, 0);
            this.btnTakeAway.Margin = new System.Windows.Forms.Padding(0);
            this.btnTakeAway.Name = "btnTakeAway";
            this.btnTakeAway.Size = new System.Drawing.Size(141, 33);
            this.btnTakeAway.TabIndex = 13;
            this.btnTakeAway.Text = "Mang về";
            this.btnTakeAway.UseVisualStyleBackColor = false;
            this.btnTakeAway.Click += new System.EventHandler(this.btnTakeAway_Click);
            // 
            // btnShip
            // 
            this.btnShip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnShip.BackColor = System.Drawing.Color.Indigo;
            this.btnShip.FlatAppearance.BorderSize = 0;
            this.btnShip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShip.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnShip.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnShip.Location = new System.Drawing.Point(432, 0);
            this.btnShip.Margin = new System.Windows.Forms.Padding(0);
            this.btnShip.Name = "btnShip";
            this.btnShip.Size = new System.Drawing.Size(141, 33);
            this.btnShip.TabIndex = 11;
            this.btnShip.Text = "Giao hàng";
            this.btnShip.UseVisualStyleBackColor = false;
            this.btnShip.Click += new System.EventHandler(this.btnShip_Click);
            // 
            // btnReser
            // 
            this.btnReser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReser.BackColor = System.Drawing.Color.Indigo;
            this.btnReser.FlatAppearance.BorderSize = 0;
            this.btnReser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnReser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReser.Location = new System.Drawing.Point(288, 0);
            this.btnReser.Margin = new System.Windows.Forms.Padding(0);
            this.btnReser.Name = "btnReser";
            this.btnReser.Size = new System.Drawing.Size(141, 33);
            this.btnReser.TabIndex = 12;
            this.btnReser.Text = "Đặt chỗ";
            this.btnReser.UseVisualStyleBackColor = false;
            this.btnReser.Click += new System.EventHandler(this.btnReser_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(4, 7);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(61, 18);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Liên hệ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 27);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tìm kiếm";
            // 
            // cmsTable
            // 
            this.cmsTable.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chuyểnBànToolStripMenuItem,
            this.gộpBànToolStripMenuItem,
            this.inHóaĐơnToolStripMenuItem,
            this.hủyToolStripMenuItem,
            this.thanhToánToolStripMenuItem});
            this.cmsTable.Name = "cmsTable";
            this.cmsTable.Size = new System.Drawing.Size(139, 114);
            this.cmsTable.Opening += new System.ComponentModel.CancelEventHandler(this.cmsTable_Opening);
            // 
            // chuyểnBànToolStripMenuItem
            // 
            this.chuyểnBànToolStripMenuItem.Name = "chuyểnBànToolStripMenuItem";
            this.chuyểnBànToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.chuyểnBànToolStripMenuItem.Text = "Chuyển bàn";
            this.chuyểnBànToolStripMenuItem.Click += new System.EventHandler(this.chuyểnBànToolStripMenuItem_Click);
            // 
            // gộpBànToolStripMenuItem
            // 
            this.gộpBànToolStripMenuItem.Name = "gộpBànToolStripMenuItem";
            this.gộpBànToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.gộpBànToolStripMenuItem.Text = "Gộp bàn";
            this.gộpBànToolStripMenuItem.Click += new System.EventHandler(this.gộpBànToolStripMenuItem_Click);
            // 
            // inHóaĐơnToolStripMenuItem
            // 
            this.inHóaĐơnToolStripMenuItem.Name = "inHóaĐơnToolStripMenuItem";
            this.inHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.inHóaĐơnToolStripMenuItem.Text = "In hóa đơn";
            // 
            // hủyToolStripMenuItem
            // 
            this.hủyToolStripMenuItem.Name = "hủyToolStripMenuItem";
            this.hủyToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.hủyToolStripMenuItem.Text = "Hủy";
            // 
            // thanhToánToolStripMenuItem
            // 
            this.thanhToánToolStripMenuItem.Name = "thanhToánToolStripMenuItem";
            this.thanhToánToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.thanhToánToolStripMenuItem.Text = "Thanh toán";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txbTimkiem);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(608, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(519, 37);
            this.panel1.TabIndex = 19;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.linkLabel1);
            this.panel4.Location = new System.Drawing.Point(0, 657);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1350, 33);
            this.panel4.TabIndex = 20;
            // 
            // fMain
            // 
            this.AccessibleName = "flpBan";
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1350, 691);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnThemban);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlTable);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý quán cà phê";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fMain_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlTable.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.cmsTable.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TaikhoanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem côngCụToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doanhThuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thựcĐơnToolStripMenuItem;
        private System.Windows.Forms.Button btnThemban;
        private System.Windows.Forms.ToolStripMenuItem chuyểnTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.Button btnBar;
        private System.Windows.Forms.Panel pnlTable;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnTakeAway;
        private System.Windows.Forms.Button btnReser;
        private System.Windows.Forms.Button btnShip;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbTimkiem;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.ContextMenuStrip cmsTable;
        private System.Windows.Forms.ToolStripMenuItem chuyểnBànToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gộpBànToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hủyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thanhToánToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ToolStripMenuItem giúpĐỡToolStripMenuItem;
    }
}