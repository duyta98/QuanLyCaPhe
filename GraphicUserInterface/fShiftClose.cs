using QL_QuanCF.DataAccessObject;
using QL_QuanCF.DataTransferObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_QuanCF
{
    public partial class FShiftClose : Form
    {
        public int idShift;
        public fMain parent;
        private double deviant;
        private double sumAmount;
        public Shift shift;
        public FShiftClose()
        {
            InitializeComponent();
            
        }
        #region Events
        private void txt5xxk_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt5xxk_Leave(sender, e);
            }
        }
        private void txt2xxk_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt2xxk_Leave(sender, e);
            }
        }

        private void txt1xxk_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt1xxk_Leave(sender, e);
            }
        }

        private void txt5xk_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt5xk_Leave(sender, e);
            }
        }

        private void txt2xk_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt2xk_Leave(sender, e);
            }
        }

        private void txt1xk_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt1xk_Leave(sender, e);
            }
        }

        private void txt5k_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt5k_Leave(sender, e);
            }
        }

        private void txt2k_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt2k_Leave(sender, e);
            }
        }

        private void txt1k_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt1k_Leave(sender, e);
            }
        }
        private void txtSum5xxk_TextChanged(object sender, EventArgs e)
        {
            sumMoney();
        }

        private void txt5xxk_Leave(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txt5xxk.Text))
                txtSum5xxk.Text = (double.Parse(txt5xxk.Text) * 500000).ToString("#,#");
            else
            {
                txt5xxk.Text = "0";
                txtSum5xxk.Text = "0";
            }
            sumQuantity();

        }

        private void txt2xxk_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt2xxk.Text))
                txtSum2xxk.Text = (double.Parse(txt2xxk.Text) * 200000).ToString("#,#");
            else
            {
                txt2xxk.Text = "0";
                txtSum2xxk.Text = "0";
            }
            sumQuantity();
        }

        private void txt1xxk_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt1xxk.Text))
                txtSum1xxk.Text = (double.Parse(txt1xxk.Text) * 100000).ToString("#,#");
            else
            {
                txt1xxk.Text = "0";
                txtSum1xxk.Text = "0";
            }
            sumQuantity();
        }

        private void txt5xk_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt5xk.Text))
                txtSum5xk.Text = (double.Parse(txt5xk.Text) * 50000).ToString("#,#");
            else
            {
                txt5xk.Text = "0";
                txtSum5xk.Text = "0";
            }
            sumQuantity();
        }

        private void txt2xk_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt2xk.Text))
                txtSum2xk.Text = (double.Parse(txt2xk.Text) * 20000).ToString("#,#");
            else
            {
                txt2xk.Text = "0";
                txtSum2xk.Text = "0";
            }
            sumQuantity();
        }

        private void txt1xk_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt1xk.Text))
                txtSum1xk.Text = (double.Parse(txt1xk.Text) * 10000).ToString("#,#");
            else
            {
                txt1xk.Text = "0";
                txtSum1xk.Text = "0";
            }
            sumQuantity();
        }

        private void txt5k_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt5k.Text))
                txtSum5k.Text = (double.Parse(txt5k.Text) * 5000).ToString("#,#");
            else
            {
                txt5k.Text = "0";
                txtSum5k.Text = "0";
            }
            sumQuantity();
        }

        private void txt2k_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt2k.Text))
                txtSum2k.Text = (double.Parse(txt2k.Text) * 2000).ToString("#,#");
            else
            {
                txt2k.Text = "0";
                txtSum2k.Text = "0";
            }
            sumQuantity();
        }

        private void txt1k_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt1k.Text))
                txtSum1k.Text = (double.Parse(txt1k.Text) * 1000).ToString("#,#");
            else
            {
                txt1k.Text = "0";
                txtSum1k.Text = "0";
            }
            sumQuantity();
        }
        private void txt2xxk_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void FShiftClose_Load(object sender, EventArgs e)
        {
            object ob = Provider.Instance.ExecuteScalar("SELECT SUM(AMOUNT) FROM dbo.BILL WHERE IDSHIFT = @idShift", new object[] { idShift });
            if (ob.ToString() != "")
                sumAmount = double.Parse(ob.ToString());
            txtSales.Text = txtCash.Text = sumAmount.ToString("#,#");
            shift = ShiftDAO.Instance.getShift(idShift);
            lbDateIn.Text = ((DateTime)shift.DateIn).ToString("dd'/'MM'/'yyyy hh:mm:ss");
            lbDateout.Text = DateTime.Now.ToString("dd'/'MM'/'yyyy hh:mm:ss");
            txtCountBill.Text = getCountBill(idShift).ToString();
            txtPromotion.Text = (getSalesBeforePromotion(idShift) - sumAmount).ToString("#,#");
            getAllSalesByFood(idShift);

        }
        #endregion
        #region Methods
        private void sumQuantity()
        {
            int sum = 0;
            foreach (var item in pnlQuantity.Controls)
            {
                if (item.GetType() == typeof(TextBox))
                {
                    TextBox txt = (TextBox)item;
                    if (txt.Text != "")
                        sum += int.Parse(txt.Text);
                }    

            }
            txtSumQuantity.Text = sum.ToString("#,#");
        }
        private void sumMoney()
        {
            double sum = 0;
            foreach (var item in pnlSum.Controls)
            {
                if (item.GetType() == typeof(TextBox))
                {
                    TextBox txt = (TextBox)item;
                    if (txt.Text != "")
                        sum += double.Parse(txt.Text);
                }

            }
            txtSumMoney.Text = sum.ToString("#,#");
        }
        private void closeShift(int id)
        {
            Provider.Instance.ExecuteNonQuery("uspCloseShift @id", new object[] { id });
        }
        /// <summary>
        /// Get all sales group by Food in idshift = id
        /// </summary>
        /// <param name="id">IDShift</param>
        private void getAllSalesByFood(int id)
        {
            string query = "SELECT ROW_NUMBER() OVER(ORDER BY f.NAMEFOOD ASC) AS STT," +
                " f.NAMEFOOD, SUM(bi.QUANTITY) AS SUMQUANTITY, f.PRICE, f.PRICE*SUM(bi.QUANTITY)" +
                " AS SUMMONEY FROM dbo.BILL b INNER JOIN dbo.BILLINFO bi ON bi.IDBILL = b.ID " +
                "INNER JOIN dbo.FOOD f ON f.ID = bi.IDFOOD WHERE b.IDSHIFT = @id GROUP BY f.NAMEFOOD, f.PRICE";
            DataTable dt = Provider.Instance.ExecuteQuery(query, new object[] { idShift });
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = dr["STT"].ToString();
                lvi.SubItems.Add(dr["NAMEFOOD"].ToString());
                lvi.SubItems.Add(dr["SUMQUANTITY"].ToString());
                lvi.SubItems.Add(double.Parse(dr["PRICE"].ToString()).ToString("#,#"));
                lvi.SubItems.Add(double.Parse(dr["SUMMONEY"].ToString()).ToString("#,#"));
                lsvFood.Items.Add(lvi);
            }
        }
        /// <summary>
        /// Get count bill by idshift
        /// </summary>
        /// <param name="id">idshift</param>
        /// <returns></returns>
        private int getCountBill(int id)
        {
            int count = 0;
            object ob = Provider.Instance.ExecuteScalar("SELECT COUNT(ID) FROM dbo.BILL WHERE IDSHIFT = @id", new object[] { id });
            count = int.Parse(ob.ToString());
            return count;
        }
        private double getSalesBeforePromotion(int id)
        {
            double sum = 0;
            string query = "SELECT SUM(bi.QUANTITY*f.PRICE) FROM dbo.BILL b INNER JOIN dbo.BILLINFO bi ON bi.IDBILL = b.ID INNER JOIN dbo.FOOD f ON f.ID = bi.IDFOOD WHERE b.IDSHIFT = @id GROUP BY b.IDSHIFT";
            object ob = Provider.Instance.ExecuteScalar(query, new object[] { id });
            if (ob != null)
                sum = double.Parse(ob.ToString());
            return sum;
        }
        #endregion

        private void btnReturn_Click(object sender, EventArgs e)
        {
            
            Close();
        }

        private void btnCloseAndPrint_Click(object sender, EventArgs e)
        {
            btnPrint_Click(sender, e);
            closeShift(shift.IdShift);
            parent.Close();
            Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void txtSumMoney_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(txtCash.Text, out double cash);
            double.TryParse(txtSumMoney.Text,out double sumMoney);
            deviant = sumMoney - cash;
            txtDeviant.Text = deviant.ToString("#,#");

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (btnSave.Text == "Lưu")
            {
                foreach (Control item in pnlQuantity.Controls)
                {
                    item.Enabled = false;
                }
                btnSave.Text = "Sửa";
                btnSave.BackColor = Color.Orange;
            }
            else
            {
                foreach (Control item in pnlQuantity.Controls)
                {
                    item.Enabled = true;
                }
                btnSave.Text = "Lưu";
                btnSave.BackColor = Color.Blue;
            }
            
        }
    }
}
