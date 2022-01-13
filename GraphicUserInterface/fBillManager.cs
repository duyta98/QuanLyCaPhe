using QL_QuanCF.DataAccessObject;
using QL_QuanCF.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace QL_QuanCF.GraphicUserInterface
{
    public partial class fBillManager : Form
    {
        #region object
        private string hint = "Nhập mã hóa đơn, số bàn, nhân viên, ...";
        public int idShift;
        public fMain formParent;
        double amountTemp;
        List<BillCheckOut> list;
        #endregion
        #region Methods
        /// <summary>
        /// Load all bill in special type to listviewBill
        /// </summary>
        /// <param name="idShift">ID Shift Work</param>
        /// <param name="type">Type of Bill</param>
        private void loadListBill(int idShift, int type)
        {
            if (type == 1)
                list = BillDAO.Instance.LoadBillCheckOut(idShift);
            else
                list = BillDAO.Instance.LoadBillCancel(idShift);
            foreach (BillCheckOut item in list)
            {
                ListViewItem lvi = new ListViewItem();

                lvi.Text = item.Pos.ToString();
                lvi.SubItems.Add(item.ID.ToString());
                lvi.SubItems.Add(item.NameTab.ToString());
                lvi.SubItems.Add(item.NameAcc.ToString());
                if (item.PromoPercent != 0)
                    lvi.SubItems.Add(item.PromoPercent.ToString() + "%");
                else
                    lvi.SubItems.Add("");
                lvi.SubItems.Add(item.Amount.ToString("#,#"));
                lvi.Tag = item;
                if (item.Status == 1)
                    lvi.SubItems.Add("Đóng");
                else
                    lvi.SubItems.Add("Hủy");
                lsvBill.Items.Add(lvi);
            }

        }
        /// <summary>
        /// Load all bill by search text 
        /// </summary>
        /// <param name="idShift">ID Shift Work</param>
        /// <param name="txt">Text string for searching</param>
        private void loadListBill(int idShift, string txt)
        {
            list = BillDAO.Instance.LoadBillBySearch(idShift, txt);
            foreach (BillCheckOut item in list)
            {
                ListViewItem lvi = new ListViewItem();

                lvi.Text = item.Pos.ToString();
                lvi.SubItems.Add(item.ID.ToString());
                lvi.SubItems.Add(item.NameTab.ToString());
                lvi.SubItems.Add(item.NameAcc.ToString());
                if (item.PromoPercent != 0)
                    lvi.SubItems.Add(item.PromoPercent.ToString() + "%");
                else
                    lvi.SubItems.Add("");
                lvi.SubItems.Add(item.Amount.ToString("#,#"));
                lvi.Tag = item;
                if (item.Status == 1)
                    lvi.SubItems.Add("Đóng");
                else
                    lvi.SubItems.Add("Hủy");
                lsvBill.Items.Add(lvi);
            }

        }
        private void loadListBillInfo(int idBill)
        {
            List<BillInfoCheckOut> list = new List<BillInfoCheckOut>();
            list = ListBillInfoDAO.Instance.LoadBillInfoCheckOut(idBill);
            amountTemp = 0;
            foreach (BillInfoCheckOut item in list)
            {

                ListViewItem lvi = new ListViewItem();

                lvi.Text = item.Pos.ToString();
                lvi.SubItems.Add(item.Name.ToString());
                lvi.SubItems.Add(item.Quantity.ToString());
                lvi.SubItems.Add(item.Price.ToString("#,#"));
                lvi.SubItems.Add(item.Amount.ToString("#,#"));
                lsvBillInfo.Items.Add(lvi);
                amountTemp += double.Parse(item.Amount.ToString());
            }

        }
        public fBillManager()
        {
            InitializeComponent();
            txtSearch.Text = hint;
        }
        private void PrintBill(int idBill)
        {

        }
        private void cancelBill(int idBill)
        {
            Provider.Instance.ExecuteNonQuery("uspCancelBill @idBill", new object[] { idBill });
        }
        public void ClearBill()
        {
            int idBill = (lsvBill.SelectedItems[0].Tag as BillCheckOut).ID;
            cancelBill(idBill);
            int index = lsvBill.SelectedItems[0].Index;
            lsvBill.Items[index].SubItems[6].Text = "Hủy";
        }
        #endregion
        #region Events
        private void fBillManager_Load(object sender, EventArgs e)
        {
            loadListBill(idShift, 1);//1 -- invoice status has done
            cbbBillType.SelectedIndex = 2;
        }

        private void fBillManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            formParent.Show();
        }

        private void lsvBill_SelectedIndexChanged(object sender, EventArgs e)
        {
            lsvBillInfo.Items.Clear();
            if (lsvBill.SelectedItems.Count > 0)
            {
                BillCheckOut bill = lsvBill.SelectedItems[0].Tag as BillCheckOut;
                int idBill = int.Parse(bill.ID.ToString());
                loadListBillInfo(idBill);
                txtTempAmount.Text = amountTemp.ToString("#,#");
                double dPromo = double.Parse(bill.PromoPercent.ToString()) * amountTemp / 100;
                txtPromo.Text = dPromo.ToString("#,#");
                txtAmount.Text = (amountTemp - dPromo).ToString("#,#");
                txtDateIn.Text = bill.DateIn.Value.ToString("dd'/'MM'/'yyyy hh:mm:ss");
                txtDateOut.Text = bill.DateOut.Value.ToString("dd'/'MM'/'yyyy hh:mm:ss");
                if (bill.Status == 1)
                {
                    btnDel.Enabled = true;
                }
                else
                {
                    btnDel.Enabled = false;
                }
            }
            else
            {
                txtAmount.Text = txtPromo.Text = txtTempAmount.Text = "";
                lsvBillInfo.Items.Clear();
                txtDateIn.Text = txtDateOut.Text = "";
            }
            
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (lsvBill.SelectedItems.Count > 0)
            {
                int idBill = (lsvBill.SelectedItems[0].Tag as BillCheckOut).ID;
                PrintBill(idBill);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (lsvBill.SelectedItems.Count > 0)
            {
                int idBill = (lsvBill.SelectedItems[0].Tag as BillCheckOut).ID;
                fReasonCancel frm = new fReasonCancel();
                frm.parent = this;
                frm.idBill = idBill;
                frm.ShowDialog();
            }
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(sender, e);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lsvBill.Items.Clear();
            loadListBill(idShift, txtSearch.Text);
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == hint)
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim() == "")
            {
                txtSearch.Text = hint;
                txtSearch.ForeColor = Color.DimGray;
            }
        }

        private void cbbBillType_SelectedIndexChanged(object sender, EventArgs e)
        {
            lsvBill.Items.Clear();
            if (cbbBillType.Text == "Hóa đơn đã bán")
            {
                
                loadListBill(idShift, 1);//1 -- invoice status has done
            }
            else if (cbbBillType.Text == "Hóa đơn đã hủy")
            {
                loadListBill(idShift, 2);//2 -- invoice status has been canceled
            }
            else
            {
                loadListBill(idShift, "");//"" -- get all bill
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void lsvBill_DoubleClick(object sender, EventArgs e)
        {
            
        }
        private void thôngTinHóaĐơnHủyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lsvBill.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lsvBill.SelectedItems[0];
                BillCheckOut bill = lvi.Tag as BillCheckOut;
                if (bill.Status == 2)
                {
                    DataTable dt = Provider.Instance.ExecuteQuery("SELECT rc.NOTE, bc.DATECANCEL FROM " +
                        "BILLCANCEL bc INNER JOIN dbo.REASONCANCEL rc " +
                        "ON rc.ID = bc.REASON WHERE bc.ID = @id", new object[] { bill.ID });
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        string reason = dr["NOTE"].ToString();
                        string date = ((DateTime)dr["DATECANCEL"]).ToString("dd'/'MM'/'yyyy hh:mm:ss");
                        MessageBox.Show("Lý do hủy: " + reason + "\nThời gian hủy: " + date, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }




        }
        private void cmsCancelDetail_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (lsvBill.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lsvBill.SelectedItems[0];
                BillCheckOut bill = lvi.Tag as BillCheckOut;
                if (bill.Status == 2)
                {
                    cmsCancelDetail.Enabled = true;
                }
                else
                    cmsCancelDetail.Enabled = false;
            }
            else
            {
                cmsCancelDetail.Enabled = false;
            }

        }
        #endregion


    }
}
