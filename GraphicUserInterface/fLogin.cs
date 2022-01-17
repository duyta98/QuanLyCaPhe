using QL_QuanCF.DataAccessObject;
using QL_QuanCF.GraphicUserInterface;
using System;
using System.Data;
using System.Windows.Forms;

namespace QL_QuanCF
{

    public partial class fLogin : Form
    {

        public fLogin()
        {
            InitializeComponent();

        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát hay không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
                e.Cancel = true;
        }

        private void BtnDangNhap_Click(object sender, EventArgs e)
        {
            if (IsCorrectAccount(txbUser.Text, txbPassword.Text))
            {
                fMain f = new fMain(txbUser.Text);
                int IDShift = getIDShiftFromUser(txbUser.Text);
                while (IDShift == -1)
                {
                    ShiftDAO.Instance.insertShift(txbUser.Text);
                    IDShift = getIDShiftFromUser(txbUser.Text);
                }
                f.idShift = IDShift;
                Hide();
                f.parent = this;
                f.Show();

            }
            else
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu.", "Thông báo", MessageBoxButtons.OK);
        }

        private int getIDShiftFromUser(string user)
        {
            return ShiftDAO.Instance.getIDShiftFromUser(user);
        }

        private bool IsCorrectAccount(string pID, string pPass)
        {
            string query = "spLogin @username , @password";
            DataTable dt = Provider.Instance.ExecuteQuery(query, new object[] { pID, pPass });
            return dt.Rows.Count > 0;

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            fSignUp frm = new fSignUp();
            frm.parentForm = this;
            Hide();
            frm.Show();
        }
    }
}
