using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_QuanCF.DataTransferObject;
using QL_QuanCF.DataAccessObject;

namespace QL_QuanCF
{
    public partial class fPayment : Form
    {
        
        private BillDTO bill;
        private TableDTO table;
        public fBill_Info frmbi;
        public fPayment(TableDTO item)
        {
            InitializeComponent();
            table = item;
            DataTable dt = Provider.Instance.ExecuteQuery("spGetBillFromIDTable " + table.ID);
            if(dt.Rows.Count > 0)
                bill = new BillDTO(dt.Rows[0]);
        }

        private void fPayment_Load(object sender, EventArgs e)
        {
            
            txtTableName.Text = table.TabName.ToString();
            txtAmountTable.Text = table.Amount.ToString();
            lbAmountBill.Text = bill.Amount.ToString("#,#");
            lbCheckIn.Text = ((DateTime)bill.CheckIn).ToString("dd'/'MM'/'yyyy hh:mm:ss");
            lbCheckOut.Text = DateTime.Now.ToString("dd'/'MM'/'yyyy hh:mm:ss");

            loadBillInfo(bill.ID);
        }
        public void loadBillInfo(int billID)
        {
            lsv.Items.Clear();
            List<ListBillInfoDTO> list = ListBillInfo.Instance.GetAllBillInfo(billID);
            int i = 0;
            foreach (ListBillInfoDTO item in list)
            {
                i++;
                ListViewItem lsvitem = new ListViewItem(i.ToString());
                lsvitem.SubItems.Add(item.Name.ToString());
                lsvitem.SubItems.Add(item.Quantity.ToString());
                lsvitem.SubItems.Add(item.Price.ToString("#,#"));
                lsv.Items.Add(lsvitem);
            }
        }
        private void checkOut(int idBill)
        {
            string query = "UPDATE dbo.BILL SET DATECHECKOUT = GETDATE(), STATUSBILL = 1 WHERE ID = " + idBill;
            Provider.Instance.ExecuteNonQuery(query);
        }
        private void btnDone_Click(object sender, EventArgs e)
        {
            checkOut(bill.ID);
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

        }
    }
}
