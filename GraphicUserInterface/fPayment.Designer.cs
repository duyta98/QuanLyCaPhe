
namespace QL_QuanCF
{
    partial class fPayment
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbCheckOut = new System.Windows.Forms.Label();
            this.lbCheckIn = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAmountTable = new System.Windows.Forms.TextBox();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lsv = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDoneAndPrint = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbAllBill = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnChosePromotion = new System.Windows.Forms.Button();
            this.btnDropPromotion = new System.Windows.Forms.Button();
            this.lbDiscount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbAmount = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbCheckOut);
            this.groupBox1.Controls.Add(this.lbCheckIn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtAmountTable);
            this.groupBox1.Controls.Add(this.txtTableName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 135);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin bàn";
            // 
            // lbCheckOut
            // 
            this.lbCheckOut.AutoSize = true;
            this.lbCheckOut.Location = new System.Drawing.Point(325, 83);
            this.lbCheckOut.Name = "lbCheckOut";
            this.lbCheckOut.Size = new System.Drawing.Size(70, 25);
            this.lbCheckOut.TabIndex = 7;
            this.lbCheckOut.Text = "label6";
            // 
            // lbCheckIn
            // 
            this.lbCheckIn.AutoSize = true;
            this.lbCheckIn.Location = new System.Drawing.Point(325, 36);
            this.lbCheckIn.Name = "lbCheckIn";
            this.lbCheckIn.Size = new System.Drawing.Size(70, 25);
            this.lbCheckIn.TabIndex = 6;
            this.lbCheckIn.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(227, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Giờ ra:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Giờ vào:";
            // 
            // txtAmountTable
            // 
            this.txtAmountTable.Location = new System.Drawing.Point(115, 78);
            this.txtAmountTable.Name = "txtAmountTable";
            this.txtAmountTable.ReadOnly = true;
            this.txtAmountTable.Size = new System.Drawing.Size(106, 31);
            this.txtAmountTable.TabIndex = 3;
            this.txtAmountTable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTableName
            // 
            this.txtTableName.Location = new System.Drawing.Point(115, 33);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.ReadOnly = true;
            this.txtTableName.Size = new System.Drawing.Size(106, 31);
            this.txtTableName.TabIndex = 2;
            this.txtTableName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số người:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số bàn:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lsv);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 153);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(600, 293);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin hóa đơn";
            // 
            // lsv
            // 
            this.lsv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lsv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsv.GridLines = true;
            this.lsv.HideSelection = false;
            this.lsv.Location = new System.Drawing.Point(3, 31);
            this.lsv.Name = "lsv";
            this.lsv.Size = new System.Drawing.Size(594, 259);
            this.lsv.TabIndex = 0;
            this.lsv.UseCompatibleStateImageBehavior = false;
            this.lsv.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "STT";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên món";
            this.columnHeader1.Width = 362;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "SL";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 44;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 124;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Orange;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Location = new System.Drawing.Point(259, 586);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(103, 40);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Trở về";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDoneAndPrint
            // 
            this.btnDoneAndPrint.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDoneAndPrint.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDoneAndPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoneAndPrint.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoneAndPrint.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDoneAndPrint.Location = new System.Drawing.Point(477, 586);
            this.btnDoneAndPrint.Name = "btnDoneAndPrint";
            this.btnDoneAndPrint.Size = new System.Drawing.Size(137, 40);
            this.btnDoneAndPrint.TabIndex = 2;
            this.btnDoneAndPrint.Text = "In và đóng";
            this.btnDoneAndPrint.UseVisualStyleBackColor = false;
            this.btnDoneAndPrint.Click += new System.EventHandler(this.btnDoneAndPrint_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(324, 465);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 27);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tạm tính:";
            // 
            // lbAllBill
            // 
            this.lbAllBill.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAllBill.Location = new System.Drawing.Point(477, 465);
            this.lbAllBill.Name = "lbAllBill";
            this.lbAllBill.Size = new System.Drawing.Size(132, 27);
            this.lbAllBill.TabIndex = 4;
            this.lbAllBill.Text = "all";
            this.lbAllBill.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDone.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDone.Location = new System.Drawing.Point(368, 586);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(103, 40);
            this.btnDone.TabIndex = 1;
            this.btnDone.Text = "Đóng";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnChosePromotion
            // 
            this.btnChosePromotion.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnChosePromotion.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnChosePromotion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChosePromotion.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChosePromotion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnChosePromotion.Location = new System.Drawing.Point(7, 586);
            this.btnChosePromotion.Name = "btnChosePromotion";
            this.btnChosePromotion.Size = new System.Drawing.Size(125, 40);
            this.btnChosePromotion.TabIndex = 5;
            this.btnChosePromotion.Text = "Chọn KM";
            this.btnChosePromotion.UseVisualStyleBackColor = false;
            this.btnChosePromotion.Click += new System.EventHandler(this.btnChosePromotion_Click);
            // 
            // btnDropPromotion
            // 
            this.btnDropPromotion.BackColor = System.Drawing.Color.Orange;
            this.btnDropPromotion.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDropPromotion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDropPromotion.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDropPromotion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDropPromotion.Location = new System.Drawing.Point(138, 586);
            this.btnDropPromotion.Name = "btnDropPromotion";
            this.btnDropPromotion.Size = new System.Drawing.Size(115, 40);
            this.btnDropPromotion.TabIndex = 6;
            this.btnDropPromotion.Text = "Hủy KM";
            this.btnDropPromotion.UseVisualStyleBackColor = false;
            this.btnDropPromotion.Click += new System.EventHandler(this.btnDropPromotion_Click);
            // 
            // lbDiscount
            // 
            this.lbDiscount.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiscount.Location = new System.Drawing.Point(477, 502);
            this.lbDiscount.Name = "lbDiscount";
            this.lbDiscount.Size = new System.Drawing.Size(132, 27);
            this.lbDiscount.TabIndex = 8;
            this.lbDiscount.Text = "discount";
            this.lbDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(324, 502);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 27);
            this.label7.TabIndex = 7;
            this.label7.Text = "Khuyến mãi:";
            // 
            // lbAmount
            // 
            this.lbAmount.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAmount.Location = new System.Drawing.Point(477, 538);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(132, 27);
            this.lbAmount.TabIndex = 10;
            this.lbAmount.Text = "Amount";
            this.lbAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(324, 538);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 27);
            this.label9.TabIndex = 9;
            this.label9.Text = "Thành tiền:";
            // 
            // fPayment
            // 
            this.AcceptButton = this.btnDoneAndPrint;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(626, 638);
            this.Controls.Add(this.lbAmount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbDiscount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnDropPromotion);
            this.Controls.Add(this.btnChosePromotion);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.lbAllBill);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDoneAndPrint);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fPayment";
            this.Load += new System.EventHandler(this.fPayment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAmountTable;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCheckOut;
        private System.Windows.Forms.Label lbCheckIn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lsv;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDoneAndPrint;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbAllBill;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnChosePromotion;
        private System.Windows.Forms.Button btnDropPromotion;
        private System.Windows.Forms.Label lbDiscount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbAmount;
        private System.Windows.Forms.Label label9;
    }
}