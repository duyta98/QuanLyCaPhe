namespace QL_QuanCF
{
    partial class fFoodManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fFoodManager));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvMon = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbbFoodCate = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.ptbAvatar = new System.Windows.Forms.PictureBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbbUnit = new System.Windows.Forms.ComboBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbCost = new System.Windows.Forms.TextBox();
            this.txbIDFood = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dtgvMon);
            this.panel1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.panel1.Location = new System.Drawing.Point(1, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 442);
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
            this.dtgvMon.Size = new System.Drawing.Size(606, 440);
            this.dtgvMon.TabIndex = 0;
            this.dtgvMon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgvMon_CellClick);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cbbFoodCate);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.ptbAvatar);
            this.panel2.Controls.Add(this.txtPrice);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.BtnSave);
            this.panel2.Controls.Add(this.btnModify);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.cbbUnit);
            this.panel2.Controls.Add(this.txbName);
            this.panel2.Controls.Add(this.txbCost);
            this.panel2.Controls.Add(this.txbIDFood);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.panel2.Location = new System.Drawing.Point(614, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(341, 442);
            this.panel2.TabIndex = 1;
            // 
            // cbbFoodCate
            // 
            this.cbbFoodCate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbFoodCate.FormattingEnabled = true;
            this.cbbFoodCate.Location = new System.Drawing.Point(107, 18);
            this.cbbFoodCate.Name = "cbbFoodCate";
            this.cbbFoodCate.Size = new System.Drawing.Size(216, 23);
            this.cbbFoodCate.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Loại món";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(260, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 26);
            this.button1.TabIndex = 15;
            this.button1.Text = "Mở";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 322);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "Ảnh";
            // 
            // ptbAvatar
            // 
            this.ptbAvatar.Location = new System.Drawing.Point(125, 262);
            this.ptbAvatar.Name = "ptbAvatar";
            this.ptbAvatar.Size = new System.Drawing.Size(120, 120);
            this.ptbAvatar.TabIndex = 13;
            this.ptbAvatar.TabStop = false;
            // 
            // txtPrice
            // 
            this.txtPrice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtPrice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtPrice.Location = new System.Drawing.Point(107, 235);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(216, 21);
            this.txtPrice.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Giá bán";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(96, 404);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(67, 26);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.BtnSave.Image = ((System.Drawing.Image)(resources.GetObject("BtnSave.Image")));
            this.BtnSave.Location = new System.Drawing.Point(260, 404);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(67, 26);
            this.BtnSave.TabIndex = 10;
            this.BtnSave.Text = "Lưu";
            this.BtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnXem_Click);
            // 
            // btnModify
            // 
            this.btnModify.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnModify.Image = ((System.Drawing.Image)(resources.GetObject("btnModify.Image")));
            this.btnModify.Location = new System.Drawing.Point(178, 404);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(67, 26);
            this.btnModify.TabIndex = 8;
            this.btnModify.Text = "Sửa";
            this.btnModify.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.BtnSua_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(13, 404);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(67, 26);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // cbbUnit
            // 
            this.cbbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbUnit.FormattingEnabled = true;
            this.cbbUnit.Location = new System.Drawing.Point(107, 144);
            this.cbbUnit.Name = "cbbUnit";
            this.cbbUnit.Size = new System.Drawing.Size(216, 23);
            this.cbbUnit.TabIndex = 3;
            // 
            // txbName
            // 
            this.txbName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txbName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txbName.Location = new System.Drawing.Point(107, 100);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(216, 21);
            this.txbName.TabIndex = 2;
            // 
            // txbCost
            // 
            this.txbCost.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txbCost.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txbCost.Location = new System.Drawing.Point(107, 192);
            this.txbCost.Name = "txbCost";
            this.txbCost.Size = new System.Drawing.Size(216, 21);
            this.txbCost.TabIndex = 4;
            // 
            // txbIDFood
            // 
            this.txbIDFood.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txbIDFood.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txbIDFood.Location = new System.Drawing.Point(107, 59);
            this.txbIDFood.Name = "txbIDFood";
            this.txbIDFood.Size = new System.Drawing.Size(216, 21);
            this.txbIDFood.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mã món";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên món";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Đơn vị tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giá nhập";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txbTimkiem);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.cbbDanhmuc);
            this.panel3.Location = new System.Drawing.Point(1, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(954, 45);
            this.panel3.TabIndex = 2;
            // 
            // txbTimkiem
            // 
            this.txbTimkiem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txbTimkiem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txbTimkiem.BackColor = System.Drawing.Color.White;
            this.txbTimkiem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTimkiem.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txbTimkiem.Location = new System.Drawing.Point(692, 13);
            this.txbTimkiem.Name = "txbTimkiem";
            this.txbTimkiem.Size = new System.Drawing.Size(245, 22);
            this.txbTimkiem.TabIndex = 6;
            this.txbTimkiem.Text = "Nhập tên món ăn, đồ uống,...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(609, 14);
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
            // fFoodManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(955, 496);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "fFoodManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý thực đơn";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).EndInit();
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
        private System.Windows.Forms.ComboBox cbbUnit;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbCost;
        private System.Windows.Forms.TextBox txbIDFood;
        private System.Windows.Forms.DataGridView dtgvMon;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbbFoodCate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox ptbAvatar;
    }
}