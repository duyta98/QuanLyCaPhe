using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QL_QuanCF
{
    public partial class FLogin : Form
    {
        public FLogin()
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
            UserName = getUser(txbUser.Text, txbPassword.Text);
            if (UserName != "")
            {

                FMain f = new FMain();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu.","Thông báo",MessageBoxButtons.OK);
        }

        
        public static string UserName = "";
        private string getUser(string username, string pass)
        {
            String cnnStr = "Data Source =.; Initial Catalog = QuanLyQuanCaPhe; Integrated Security = True";
            SqlConnection sqlConnection = new SqlConnection(cnnStr);
            string user = "";
            try
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM ACCOUNT WHERE USERNAME = N'" + username + "' and PASSWORD = N'" + pass + "'", sqlConnection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        user = dr["USERNAME"].ToString();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi xảy ra khi truy vấn dữ liệu hoặc kết nối với server thất bại !");
            }
            finally
            {
                sqlConnection.Close();
            }
            return user;
        }

    }
}
