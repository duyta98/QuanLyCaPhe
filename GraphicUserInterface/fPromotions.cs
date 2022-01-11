using QL_QuanCF.DataAccessObject;
using QL_QuanCF.DataTransferObject;
using System;
using System.Data;
using System.Windows.Forms;

namespace QL_QuanCF.GraphicUserInterface
{
    public partial class fPromotions : Form
    {
        private Bill Bill;
        public fPayment frmPay;
        private float percent;
        public fPromotions(Bill billDTO)
        {
            InitializeComponent();
            Bill = billDTO;
        }

        private void fPromotions_Load(object sender, EventArgs e)
        {
            DataTable dt = Provider.Instance.ExecuteQuery("SELECT * FROM dbo.PROMOTION");
            cbbPromotions.DataSource = dt;
            cbbPromotions.DisplayMember = "NOTE";
            cbbPromotions.ValueMember = "ID";

        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            double discount = Bill.Amount * percent;
            double amount = Bill.Amount - discount;
            frmPay.changeLbPromotion(discount, amount);
            int idPro = int.Parse(cbbPromotions.SelectedValue.ToString());
            frmPay.setIDPro(idPro);
            Close();
        }




        private void cbbPromotions_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int idPro;
            if (int.TryParse(cbbPromotions.SelectedValue.ToString(), out idPro) == false)
                return;
            object ob = Provider.Instance.ExecuteScalar("SELECT DISCOUNT FROM dbo.PROMOTION WHERE ID = @id", new object[] { idPro });
            percent = float.Parse(ob.ToString());
            txtPercent.Text = percent * 100 + "%";
        }
    }
}
