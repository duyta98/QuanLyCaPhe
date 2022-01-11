using QL_QuanCF.DataTransferObject;
using System;
using System.Windows.Forms;

namespace QL_QuanCF
{

    public partial class fAddSeveralQuantityFood : Form
    {

        public fBill_Info parent { get; set; }
        private Food food;
        public fAddSeveralQuantityFood(Food foodDTO)
        {
            InitializeComponent();
            food = foodDTO;
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtQuantity_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (int.Parse(txtQuantity.Text) == 0)
                    return;
                parent.AddMoreFoodQuantity(food, int.Parse(txtQuantity.Text));
                Close();
            }
        }

        private void fAddEditMoreFood_Load(object sender, EventArgs e)
        {
            txtQuantity.Focus();
        }
    }
}
