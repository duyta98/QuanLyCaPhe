using QL_QuanCF.DataAccessObject;
using QL_QuanCF.DataTransferObject;
using QL_QuanCF.GraphicUserInterface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace QL_QuanCF
{
    public partial class fPayment : Form
    {
        public int idShift;
        private Bill bill;
        private Table table;
        public fBill_Info frmbi;
        private double amountTemp;
        private double discount;
        public fPayment(Table item)
        {
            InitializeComponent();
            table = item;
            DataTable dt = Provider.Instance.ExecuteQuery("spGetBillFromIDTable " + table.ID);
            if (dt.Rows.Count > 0)
                bill = new Bill(dt.Rows[0]);
        }

        private void fPayment_Load(object sender, EventArgs e)
        {

            txtTableName.Text = table.TabName.ToString();
            txtAmountTable.Text = table.Amount.ToString();
            object ob = Provider.Instance.ExecuteScalar("SELECT SUM(f.PRICE*bi.QUANTITY) " +
                "FROM dbo.BILLINFO bi JOIN dbo.BILL b ON  b.ID = bi.IDBILL " +
                "JOIN dbo.FOOD f ON f.ID = bi.IDFOOD WHERE b.ID = @id", new object[] { bill.ID });
            amountTemp = double.Parse(ob.ToString());
            lbAllBill.Text = amountTemp.ToString("#,#");
            lbCheckIn.Text = ((DateTime)bill.CheckIn).ToString("dd'/'MM'/'yyyy hh:mm:ss");
            lbCheckOut.Text = DateTime.Now.ToString("dd'/'MM'/'yyyy hh:mm:ss");
            ob = Provider.Instance.ExecuteScalar("SELECT p.DISCOUNT FROM " +
                "dbo.PROMOTION p JOIN dbo.BILL b ON b.IDPROMOTION = p.ID WHERE b.ID = @id", new object[] { bill.ID });
            if (ob == null)
                lbDiscount.Text = "";
            else
            {
                discount = double.Parse(ob.ToString());
                lbDiscount.Text = (discount * amountTemp).ToString("#,#");
            }
            lbAmount.Text = (amountTemp - discount).ToString("#,#");
            loadBillInfo(bill.ID);
        }

        internal void setIDPro(int id)
        {
            bill.IdPromotion = id;
        }

        internal void changeLbPromotion(double discount, double amount)
        {
            lbDiscount.Text = discount.ToString("#,#");
            lbAmount.Text = amount.ToString("#,##0");
        }

        public void loadBillInfo(int billID)
        {
            lsv.Items.Clear();
            List<ListBillInfo> list = ListBillInfoDAO.Instance.GetAllBillInfo(billID);
            int i = 0;
            foreach (ListBillInfo item in list)
            {
                i++;
                ListViewItem lsvitem = new ListViewItem(i.ToString());
                lsvitem.SubItems.Add(item.Name.ToString());
                lsvitem.SubItems.Add(item.Quantity.ToString());
                lsvitem.SubItems.Add(item.Price.ToString("#,#"));
                lsv.Items.Add(lsvitem);
            }
        }
        private void checkOut(int idBill, int idShift)
        {
            string query;

            if (bill.IdPromotion == 0)
            {
                query = "UPDATE dbo.BILL SET DATECHECKOUT = GETDATE(), STATUSBILL = 1, IDPROMOTION = null, IDSHIFT = " + idShift + " WHERE ID = " + idBill;
            }
            else
            {
                query = "UPDATE dbo.BILL SET DATECHECKOUT = GETDATE(), STATUSBILL = 1, IDPROMOTION = " + bill.IdPromotion + ", IDSHIFT = " + idShift + " WHERE ID = " + idBill;
            }

            Provider.Instance.ExecuteNonQuery(query);
        }
        private void btnDone_Click(object sender, EventArgs e)
        {
            checkOut(bill.ID, idShift);
            frmbi.ChangePropBtnTabToCheckOut();
            frmbi.Close();
            Close();
        }

        private void btnDoneAndPrint_Click(object sender, EventArgs e)
        {
            btnDone_Click(sender, e);
            //Hàm in hóa đơn
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmbi.ChangePropBtnTabToCheckIn();
            frmbi.Show();
            Close();
        }

        private void btnChosePromotion_Click(object sender, EventArgs e)
        {
            fPromotions frm = new fPromotions(bill);
            frm.frmPay = this;
            frm.ShowDialog();
            Show();
        }

        private void btnDropPromotion_Click(object sender, EventArgs e)
        {
            Provider.Instance.ExecuteNonQuery("UPDATE dbo.BILL SET IDPROMOTION = NULL, AMOUNT = @amount WHERE ID = @id", new object[] { amountTemp, bill.ID });
            lbDiscount.Text = "";
            lbAmount.Text = amountTemp.ToString("#,#");
        }
    }
}
