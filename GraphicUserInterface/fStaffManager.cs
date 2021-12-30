using QL_QuanCF.DataAccessObject;
using QL_QuanCF.DataTransferObject;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QL_QuanCF
{
    public partial class fStaffManager : Form
    {
        public fStaffManager()
        {
            InitializeComponent();
            
        }

        private void FNhanVien_Load()
        {
            dtgvNhanVien.DataSource = Provider.Instance.ExecuteQuery("spGetListEmployee");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (KT_maNV(txtIDStaff.Text))
                {
                    string strThem = "INSERT INTO dbo.NHANVIEN (TEN,NGAYSINH,DIACHI,SDT)" + "VALUES(@ten, @ngaysinh, @diachi, @sdt)";
                    string cnnStr = "Data Source = DUYPC; Initial Catalog = QLCF; Integrated Security = True";
                    SqlConnection sqlConnection = new SqlConnection(cnnStr);
                    if (sqlConnection.State == ConnectionState.Closed)
                    {
                        sqlConnection.Open();
                    }

                    SqlCommand sqlCommand = new SqlCommand(strThem, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@ten", txtNameStaff.Text);
                    sqlCommand.Parameters.AddWithValue("@ngaysinh", dtpBirth.Value);
                    sqlCommand.Parameters.AddWithValue("@diachi", txtAddress.Text);
                    sqlCommand.Parameters.AddWithValue("@sdt", txtPhoneNo.Text);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                    FNhanVien_Load();
                    MessageBox.Show("Thực hiện hành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Trùng mã nhân viên");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
           
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                string strSua = "UPDATE dbo.NHANVIEN SET TEN = @ten, NGAYSINH = @ngaysinh, DIACHI = @diachi, SDT = @sdt WHERE id = @id";
                string cnnStr = "Data Source = DUYPC; Initial Catalog = QLCF; Integrated Security = True";
                SqlConnection sqlConnection = new SqlConnection(cnnStr);
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlCommand sqlCommand = new SqlCommand(strSua, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@id", txtIDStaff.Text);
                sqlCommand.Parameters.AddWithValue("@ten", txtNameStaff.Text);
                sqlCommand.Parameters.AddWithValue("@ngaysinh", dtpBirth.Value);
                sqlCommand.Parameters.AddWithValue("@diachi", txtAddress.Text);
                sqlCommand.Parameters.AddWithValue("@sdt", txtPhoneNo.Text);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                FNhanVien_Load();
                MessageBox.Show("Thực hiện hành công","Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                string strXoa = "DELETE dbo.NHANVIEN WHERE ID = @id";
                string cnnStr = "Data Source = DUYPC; Initial Catalog = QLCF; Integrated Security = True";
                SqlConnection sqlConnection = new SqlConnection(cnnStr);
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlCommand sqlCommand = new SqlCommand(strXoa, sqlConnection);
                txtIDStaff.Text = dtgvNhanVien.CurrentRow.Cells[0].Value.ToString();
                sqlCommand.Parameters.AddWithValue("@id", txtIDStaff.Text);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                FNhanVien_Load();
                MessageBox.Show("Thực hiện hành công", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DtgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDStaff.Text = dtgvNhanVien.CurrentRow.Cells[0].Value.ToString();
            txtNameStaff.Text = dtgvNhanVien.CurrentRow.Cells[1].Value.ToString();
            dtpBirth.Text = dtgvNhanVien.CurrentRow.Cells[2].Value.ToString();
            txtAddress.Text = dtgvNhanVien.CurrentRow.Cells[3].Value.ToString();
            txtPhoneNo.Text = dtgvNhanVien.CurrentRow.Cells[4].Value.ToString();
        }
        public bool KT_maNV(string idNV)
        {
            string cnnStr = "Data Source = DUYPC; Initial Catalog = QLCF; Integrated Security = True";
            SqlConnection sqlConnection = new SqlConnection(cnnStr);
            if(sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            string sqlString = "SELECT * FROM NHANVIEN WHERE ID = '" + idNV + "'";
            SqlCommand sqlCommand = new SqlCommand(sqlString, sqlConnection);
            SqlDataReader rd = sqlCommand.ExecuteReader();
            if(rd.HasRows)
            {
                rd.Close();
                sqlConnection.Close();
                return false;
            }
            else
            {
                rd.Close();
                sqlConnection.Close();
                return true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void fStaffManager_Load(object sender, EventArgs e)
        {

        }
    }
}
