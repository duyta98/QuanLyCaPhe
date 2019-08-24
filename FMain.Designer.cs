using System;

namespace QL_QuanCF
{
    partial class FMain
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
            this.txbTimkiem = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doanhThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thựcĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TaikhoanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chuyểnTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.côngCụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnThemban = new System.Windows.Forms.Button();
            this.cbbLoaiBan = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTaiban = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flpBan = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnMangve = new System.Windows.Forms.Button();
            this.btnGiaohang = new System.Windows.Forms.Button();
            this.btnDatcho = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbTimkiem
            // 
            this.txbTimkiem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txbTimkiem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txbTimkiem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txbTimkiem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTimkiem.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txbTimkiem.Location = new System.Drawing.Point(754, 8);
            this.txbTimkiem.Name = "txbTimkiem";
            this.txbTimkiem.Size = new System.Drawing.Size(289, 26);
            this.txbTimkiem.TabIndex = 17;
            this.txbTimkiem.Text = "Nhập số bàn";
            this.txbTimkiem.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxbTimkiem_MouseClick);

            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowDrop = true;
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.BackColor = System.Drawing.Color.MintCream;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýToolStripMenuItem,
            this.TaikhoanToolStripMenuItem,
            this.côngCụToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(276, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "Menu";
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doanhThuToolStripMenuItem,
            this.nhânViênToolStripMenuItem,
            this.hóaĐơnToolStripMenuItem,
            this.thựcĐơnToolStripMenuItem});
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(85, 23);
            this.quảnLýToolStripMenuItem.Text = "Quản Lý";
            // 
            // doanhThuToolStripMenuItem
            // 
            this.doanhThuToolStripMenuItem.Name = "doanhThuToolStripMenuItem";
            this.doanhThuToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.doanhThuToolStripMenuItem.Text = "Doanh thu";
            // 
            // nhânViênToolStripMenuItem
            // 
            this.nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            this.nhânViênToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.nhânViênToolStripMenuItem.Text = "Nhân viên";
            this.nhânViênToolStripMenuItem.Click += new System.EventHandler(this.NhânViênToolStripMenuItem_Click);
            // 
            // hóaĐơnToolStripMenuItem
            // 
            this.hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            this.hóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.hóaĐơnToolStripMenuItem.Text = "Hóa đơn";
            // 
            // thựcĐơnToolStripMenuItem
            // 
            this.thựcĐơnToolStripMenuItem.Name = "thựcĐơnToolStripMenuItem";
            this.thựcĐơnToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.thựcĐơnToolStripMenuItem.Text = "Thực đơn";
            this.thựcĐơnToolStripMenuItem.Click += new System.EventHandler(this.ThựcĐơnToolStripMenuItem_Click);
            // 
            // TaikhoanToolStripMenuItem
            // 
            this.TaikhoanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinTàiKhoảnToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem,
            this.chuyểnTàiKhoảnToolStripMenuItem});
            this.TaikhoanToolStripMenuItem.Name = "TaikhoanToolStripMenuItem";
            this.TaikhoanToolStripMenuItem.Size = new System.Drawing.Size(99, 23);
            this.TaikhoanToolStripMenuItem.Text = "Tài Khoản";
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            this.thôngTinTàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.ThôngTinTàiKhoảnToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.ĐăngXuấtToolStripMenuItem_Click);
            // 
            // chuyểnTàiKhoảnToolStripMenuItem
            // 
            this.chuyểnTàiKhoảnToolStripMenuItem.Name = "chuyểnTàiKhoảnToolStripMenuItem";
            this.chuyểnTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.chuyểnTàiKhoảnToolStripMenuItem.Text = "Chuyển tài khoản";
            // 
            // côngCụToolStripMenuItem
            // 
            this.côngCụToolStripMenuItem.Name = "côngCụToolStripMenuItem";
            this.côngCụToolStripMenuItem.Size = new System.Drawing.Size(86, 23);
            this.côngCụToolStripMenuItem.Text = "Công cụ";
            // 
            // btnThemban
            // 
            this.btnThemban.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemban.BackColor = System.Drawing.Color.Blue;
            this.btnThemban.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThemban.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnThemban.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemban.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnThemban.ForeColor = System.Drawing.Color.White;
            this.btnThemban.Location = new System.Drawing.Point(0, 0);
            this.btnThemban.Name = "btnThemban";
            this.btnThemban.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnThemban.Size = new System.Drawing.Size(144, 42);
            this.btnThemban.TabIndex = 4;
            this.btnThemban.Text = "Thêm";
            this.btnThemban.UseVisualStyleBackColor = false;
            this.btnThemban.Click += new System.EventHandler(this.BtnThemban_Click);
            // 
            // cbbLoaiBan
            // 
            this.cbbLoaiBan.AllowDrop = true;
            this.cbbLoaiBan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbbLoaiBan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbLoaiBan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbLoaiBan.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbbLoaiBan.DropDownHeight = 100;
            this.cbbLoaiBan.DropDownWidth = 96;
            this.cbbLoaiBan.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbLoaiBan.ForeColor = System.Drawing.Color.Black;
            this.cbbLoaiBan.FormattingEnabled = true;
            this.cbbLoaiBan.IntegralHeight = false;
            this.cbbLoaiBan.ItemHeight = 18;
            this.cbbLoaiBan.Items.AddRange(new object[] {
            "Tại bàn",
            "Mang về",
            "Giao hàng",
            "Đặt chỗ"});
            this.cbbLoaiBan.Location = new System.Drawing.Point(145, 8);
            this.cbbLoaiBan.Name = "cbbLoaiBan";
            this.cbbLoaiBan.Size = new System.Drawing.Size(133, 26);
            this.cbbLoaiBan.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnThemban);
            this.panel1.Controls.Add(this.cbbLoaiBan);
            this.panel1.Location = new System.Drawing.Point(1060, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 42);
            this.panel1.TabIndex = 9;
            // 
            // btnTaiban
            // 
            this.btnTaiban.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTaiban.BackColor = System.Drawing.Color.Indigo;
            this.btnTaiban.FlatAppearance.BorderSize = 0;
            this.btnTaiban.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaiban.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnTaiban.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTaiban.Location = new System.Drawing.Point(1, 0);
            this.btnTaiban.Margin = new System.Windows.Forms.Padding(0);
            this.btnTaiban.Name = "btnTaiban";
            this.btnTaiban.Size = new System.Drawing.Size(141, 33);
            this.btnTaiban.TabIndex = 10;
            this.btnTaiban.Text = "Tại bàn";
            this.btnTaiban.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel2.Controls.Add(this.flpBan);
            this.panel2.Location = new System.Drawing.Point(0, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1349, 584);
            this.panel2.TabIndex = 13;
            // 
            // flpBan
            // 
            this.flpBan.AutoScroll = true;
            this.flpBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpBan.Location = new System.Drawing.Point(0, 0);
            this.flpBan.Name = "flpBan";
            this.flpBan.Size = new System.Drawing.Size(1349, 584);
            this.flpBan.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnMangve);
            this.panel3.Controls.Add(this.btnGiaohang);
            this.panel3.Controls.Add(this.btnDatcho);
            this.panel3.Controls.Add(this.btnTaiban);
            this.panel3.Location = new System.Drawing.Point(0, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1349, 33);
            this.panel3.TabIndex = 14;
            // 
            // btnMangve
            // 
            this.btnMangve.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMangve.BackColor = System.Drawing.Color.Indigo;
            this.btnMangve.FlatAppearance.BorderSize = 0;
            this.btnMangve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMangve.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnMangve.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMangve.Location = new System.Drawing.Point(145, 0);
            this.btnMangve.Margin = new System.Windows.Forms.Padding(0);
            this.btnMangve.Name = "btnMangve";
            this.btnMangve.Size = new System.Drawing.Size(141, 33);
            this.btnMangve.TabIndex = 13;
            this.btnMangve.Text = "Mang về";
            this.btnMangve.UseVisualStyleBackColor = false;
            // 
            // btnGiaohang
            // 
            this.btnGiaohang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGiaohang.BackColor = System.Drawing.Color.Indigo;
            this.btnGiaohang.FlatAppearance.BorderSize = 0;
            this.btnGiaohang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiaohang.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnGiaohang.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGiaohang.Location = new System.Drawing.Point(289, 0);
            this.btnGiaohang.Margin = new System.Windows.Forms.Padding(0);
            this.btnGiaohang.Name = "btnGiaohang";
            this.btnGiaohang.Size = new System.Drawing.Size(141, 33);
            this.btnGiaohang.TabIndex = 12;
            this.btnGiaohang.Text = "Giao hàng";
            this.btnGiaohang.UseVisualStyleBackColor = false;
            // 
            // btnDatcho
            // 
            this.btnDatcho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDatcho.BackColor = System.Drawing.Color.Indigo;
            this.btnDatcho.FlatAppearance.BorderSize = 0;
            this.btnDatcho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatcho.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnDatcho.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDatcho.Location = new System.Drawing.Point(433, 0);
            this.btnDatcho.Margin = new System.Windows.Forms.Padding(0);
            this.btnDatcho.Name = "btnDatcho";
            this.btnDatcho.Size = new System.Drawing.Size(141, 33);
            this.btnDatcho.TabIndex = 11;
            this.btnDatcho.Text = "Đặt chỗ";
            this.btnDatcho.UseVisualStyleBackColor = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(12, 669);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(61, 18);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Liên hệ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(671, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tìm kiếm";
            // 
            // FMain
            // 
            this.AccessibleName = "flpBan";
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1350, 696);
            this.Controls.Add(this.txbTimkiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý quán cà phê";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
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
        private System.Windows.Forms.ComboBox cbbLoaiBan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTaiban;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnMangve;
        private System.Windows.Forms.Button btnGiaohang;
        private System.Windows.Forms.Button btnDatcho;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbTimkiem;
        private System.Windows.Forms.FlowLayoutPanel flpBan;
    }
}