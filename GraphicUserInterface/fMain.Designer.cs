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
            this.btnThemban = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flpBan = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnTakeAway = new System.Windows.Forms.Button();
            this.btnReser = new System.Windows.Forms.Button();
            this.btnShip = new System.Windows.Forms.Button();
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
            this.txbTimkiem.Text = "Nhập số bàn, món ăn, nước uống,...";
            this.txbTimkiem.Enter += new System.EventHandler(this.txbTimkiem_Enter);
            this.txbTimkiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbTimkiem_KeyDown);
            this.txbTimkiem.Leave += new System.EventHandler(this.txbTimkiem_Leave);
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
            this.chuyểnTàiKhoảnToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
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
            // chuyểnTàiKhoảnToolStripMenuItem
            // 
            this.chuyểnTàiKhoảnToolStripMenuItem.Name = "chuyểnTàiKhoảnToolStripMenuItem";
            this.chuyểnTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.chuyểnTàiKhoảnToolStripMenuItem.Text = "Chuyển tài khoản";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.ĐăngXuấtToolStripMenuItem_Click);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.btnThemban);
            this.panel1.Location = new System.Drawing.Point(1060, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 42);
            this.panel1.TabIndex = 9;
            // 
            // btnBar
            // 
            this.btnBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBar.BackColor = System.Drawing.Color.Indigo;
            this.btnBar.FlatAppearance.BorderSize = 0;
            this.btnBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnBar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBar.Location = new System.Drawing.Point(1, 0);
            this.btnBar.Margin = new System.Windows.Forms.Padding(0);
            this.btnBar.Name = "btnBar";
            this.btnBar.Size = new System.Drawing.Size(141, 33);
            this.btnBar.TabIndex = 10;
            this.btnBar.Text = "Tại bàn";
            this.btnBar.UseVisualStyleBackColor = false;
            this.btnBar.Click += new System.EventHandler(this.btnBar_Click);
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
            this.panel2.Size = new System.Drawing.Size(1349, 569);
            this.panel2.TabIndex = 13;
            // 
            // flpBan
            // 
            this.flpBan.AutoScroll = true;
            this.flpBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpBan.Location = new System.Drawing.Point(0, 0);
            this.flpBan.Name = "flpBan";
            this.flpBan.Size = new System.Drawing.Size(1349, 569);
            this.flpBan.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnTakeAway);
            this.panel3.Controls.Add(this.btnReser);
            this.panel3.Controls.Add(this.btnShip);
            this.panel3.Controls.Add(this.btnBar);
            this.panel3.Location = new System.Drawing.Point(0, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1349, 33);
            this.panel3.TabIndex = 14;
            // 
            // btnTakeAway
            // 
            this.btnTakeAway.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTakeAway.BackColor = System.Drawing.Color.Indigo;
            this.btnTakeAway.FlatAppearance.BorderSize = 0;
            this.btnTakeAway.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTakeAway.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnTakeAway.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTakeAway.Location = new System.Drawing.Point(145, 0);
            this.btnTakeAway.Margin = new System.Windows.Forms.Padding(0);
            this.btnTakeAway.Name = "btnTakeAway";
            this.btnTakeAway.Size = new System.Drawing.Size(141, 33);
            this.btnTakeAway.TabIndex = 13;
            this.btnTakeAway.Text = "Mang về";
            this.btnTakeAway.UseVisualStyleBackColor = false;
            this.btnTakeAway.Click += new System.EventHandler(this.btnTakeAway_Click);
            // 
            // btnReser
            // 
            this.btnReser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReser.BackColor = System.Drawing.Color.Indigo;
            this.btnReser.FlatAppearance.BorderSize = 0;
            this.btnReser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnReser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReser.Location = new System.Drawing.Point(289, 0);
            this.btnReser.Margin = new System.Windows.Forms.Padding(0);
            this.btnReser.Name = "btnReser";
            this.btnReser.Size = new System.Drawing.Size(141, 33);
            this.btnReser.TabIndex = 12;
            this.btnReser.Text = "Đặt chỗ";
            this.btnReser.UseVisualStyleBackColor = false;
            this.btnReser.Click += new System.EventHandler(this.btnReser_Click);
            // 
            // btnShip
            // 
            this.btnShip.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShip.BackColor = System.Drawing.Color.Indigo;
            this.btnShip.FlatAppearance.BorderSize = 0;
            this.btnShip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShip.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnShip.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnShip.Location = new System.Drawing.Point(433, 0);
            this.btnShip.Margin = new System.Windows.Forms.Padding(0);
            this.btnShip.Name = "btnShip";
            this.btnShip.Size = new System.Drawing.Size(141, 33);
            this.btnShip.TabIndex = 11;
            this.btnShip.Text = "Giao hàng";
            this.btnShip.UseVisualStyleBackColor = false;
            this.btnShip.Click += new System.EventHandler(this.btnShip_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(12, 654);
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
            // fMain
            // 
            this.AccessibleName = "flpBan";
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1350, 681);
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
            this.Name = "fMain";
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnTakeAway;
        private System.Windows.Forms.Button btnReser;
        private System.Windows.Forms.Button btnShip;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbTimkiem;
        private System.Windows.Forms.FlowLayoutPanel flpBan;
    }
}