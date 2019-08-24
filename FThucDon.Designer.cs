namespace QL_QuanCF
{
    partial class FThucDon
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvMon = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.BtnXem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cbbMaloai = new System.Windows.Forms.ComboBox();
            this.cbbDvt = new System.Windows.Forms.ComboBox();
            this.txbTenmon = new System.Windows.Forms.TextBox();
            this.txbGia = new System.Windows.Forms.TextBox();
            this.txbMamon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbTimkiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbDanhmuc = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMon)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dtgvMon);
            this.panel1.Location = new System.Drawing.Point(1, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(861, 643);
            this.panel1.TabIndex = 0;
            // 
            // dtgvMon
            // 
            this.dtgvMon.AllowUserToAddRows = false;
            this.dtgvMon.AllowUserToDeleteRows = false;
            this.dtgvMon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvMon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvMon.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvMon.Location = new System.Drawing.Point(0, 0);
            this.dtgvMon.Name = "dtgvMon";
            this.dtgvMon.ReadOnly = true;
            this.dtgvMon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvMon.Size = new System.Drawing.Size(861, 643);
            this.dtgvMon.TabIndex = 0;
            this.dtgvMon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgvMon_CellClick);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.BtnXem);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.cbbMaloai);
            this.panel2.Controls.Add(this.cbbDvt);
            this.panel2.Controls.Add(this.txbTenmon);
            this.panel2.Controls.Add(this.txbGia);
            this.panel2.Controls.Add(this.txbMamon);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(865, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(483, 643);
            this.panel2.TabIndex = 1;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(32, 383);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(110, 46);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // BtnXem
            // 
            this.BtnXem.Location = new System.Drawing.Point(326, 383);
            this.BtnXem.Name = "BtnXem";
            this.BtnXem.Size = new System.Drawing.Size(110, 46);
            this.BtnXem.TabIndex = 10;
            this.BtnXem.Text = "Xem";
            this.BtnXem.UseVisualStyleBackColor = true;
            this.BtnXem.Click += new System.EventHandler(this.BtnXem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(326, 295);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(110, 46);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.BtnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(32, 295);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(110, 46);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // cbbMaloai
            // 
            this.cbbMaloai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMaloai.FormattingEnabled = true;
            this.cbbMaloai.Location = new System.Drawing.Point(159, 238);
            this.cbbMaloai.Name = "cbbMaloai";
            this.cbbMaloai.Size = new System.Drawing.Size(289, 27);
            this.cbbMaloai.TabIndex = 5;
            // 
            // cbbDvt
            // 
            this.cbbDvt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDvt.FormattingEnabled = true;
            this.cbbDvt.Location = new System.Drawing.Point(159, 126);
            this.cbbDvt.Name = "cbbDvt";
            this.cbbDvt.Size = new System.Drawing.Size(289, 27);
            this.cbbDvt.TabIndex = 3;
            // 
            // txbTenmon
            // 
            this.txbTenmon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txbTenmon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txbTenmon.Location = new System.Drawing.Point(159, 73);
            this.txbTenmon.Name = "txbTenmon";
            this.txbTenmon.Size = new System.Drawing.Size(289, 26);
            this.txbTenmon.TabIndex = 2;
            // 
            // txbGia
            // 
            this.txbGia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txbGia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txbGia.Location = new System.Drawing.Point(159, 180);
            this.txbGia.Name = "txbGia";
            this.txbGia.Size = new System.Drawing.Size(289, 26);
            this.txbGia.TabIndex = 4;
            // 
            // txbMamon
            // 
            this.txbMamon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txbMamon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txbMamon.Location = new System.Drawing.Point(159, 20);
            this.txbMamon.Name = "txbMamon";
            this.txbMamon.Size = new System.Drawing.Size(289, 26);
            this.txbMamon.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Mã loại món";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mã món";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên món";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Đơn vị tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giá";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.txbTimkiem);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.cbbDanhmuc);
            this.panel3.Location = new System.Drawing.Point(1, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1347, 45);
            this.panel3.TabIndex = 2;
            // 
            // txbTimkiem
            // 
            this.txbTimkiem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txbTimkiem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txbTimkiem.BackColor = System.Drawing.Color.LightPink;
            this.txbTimkiem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTimkiem.ForeColor = System.Drawing.SystemColors.Window;
            this.txbTimkiem.Location = new System.Drawing.Point(1023, 13);
            this.txbTimkiem.Name = "txbTimkiem";
            this.txbTimkiem.Size = new System.Drawing.Size(289, 22);
            this.txbTimkiem.TabIndex = 6;
            this.txbTimkiem.Text = "Nhập tên món ăn, đồ uống,...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(929, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tìm kiếm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh mục thực đơn";
            // 
            // cbbDanhmuc
            // 
            this.cbbDanhmuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDanhmuc.FormattingEnabled = true;
            this.cbbDanhmuc.Location = new System.Drawing.Point(179, 11);
            this.cbbDanhmuc.Name = "cbbDanhmuc";
            this.cbbDanhmuc.Size = new System.Drawing.Size(274, 27);
            this.cbbDanhmuc.TabIndex = 0;
            // 
            // FThucDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1350, 696);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "FThucDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý thực đơn";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txbTimkiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbDanhmuc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbDvt;
        private System.Windows.Forms.TextBox txbTenmon;
        private System.Windows.Forms.TextBox txbGia;
        private System.Windows.Forms.TextBox txbMamon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dtgvMon;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button BtnXem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cbbMaloai;
    }
}