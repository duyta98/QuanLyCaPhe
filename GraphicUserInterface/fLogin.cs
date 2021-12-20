using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using QL_QuanCF.DataAccessObject;
using QL_QuanCF.DataTransferObject;

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
            if (MessageBox.Show("Bạn có muốn thoát hay không?", "Thông báo", MessageBoxButtons.OKCancel,MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
                e.Cancel = true;
        }

        private void BtnDangNhap_Click(object sender, EventArgs e)
        {
            if (IsCorrectAccount(txbUser.Text, txbPassword.Text))
            {
                fMain f = new fMain(txbUser.Text);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu.","Thông báo",MessageBoxButtons.OK);
        }

        
        
        private bool IsCorrectAccount(string pID, string pPass)
        {
            string query = "spLogin @username , @password";
            DataTable dt = Provider.Instance.ExecuteQuery(query, new object[] { pID, pPass });
            return dt.Rows.Count > 0;
            
        }

    }
}
