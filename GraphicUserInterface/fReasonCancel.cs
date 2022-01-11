using QL_QuanCF.DataAccessObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_QuanCF.GraphicUserInterface
{
    public partial class fReasonCancel : Form
    {
        public fBillManager parent;
        public int idBill;
        public fReasonCancel()
        {
            InitializeComponent();
        }
        private void loadCbbReason()
        {
            DataTable dt = Provider.Instance.ExecuteQuery("SELECT * FROM dbo.REASONCANCEL");
            cbbReason.DataSource = dt;
            cbbReason.DisplayMember = "NOTE";
            cbbReason.ValueMember = "ID";
        }
        private void fReasonCancel_Load(object sender, EventArgs e)
        {
            loadCbbReason();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(cbbReason.SelectedValue != null)
            {
                Provider.Instance.ExecuteNonQuery("uspAddBillCancel @idBill , @idReason", new object[] { idBill, cbbReason.SelectedValue.ToString() });
                parent.ClearBill();
            }
            Dispose();
        }
    }
}
