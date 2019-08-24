using QL_QuanCF.Connections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_QuanCF
{
    public partial class FNhanVien : Form
    {
        public FNhanVien()
        {
            InitializeComponent();
            FNhanVien_Load();
        }

        private void FNhanVien_Load()
        {
            string sqlString = "SELECT ID AS [Mã số], NAME AS [Họ và tên], BIRTHDAY AS [Ngày sinh], ADDRESS AS [Địa chỉ], TEL AS [Số điện thoại], EMAIL AS[Email] FROM dbo.STAFF";
            
            dtgvNhanVien.DataSource = Provider.Instance.ExecuteQuery(sqlString);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (KT_maNV(textBox1.Text))
                {
                    string strThem = "INSERT INTO dbo.NHANVIEN (TEN,NGAYSINH,DIACHI,SDT)" + "VALUES(@ten, @ngaysinh, @diachi, @sdt)";
                    string cnnStr = "Data Source = DUYPC; Initial Catalog = QLCF; Integrated Security = True";
                    SqlConnection sqlConnection = new SqlConnection(cnnStr);
                    if (sqlConnection.State == ConnectionState.Closed)
                    {
                        sqlConnection.Open();
                    }

                    SqlCommand sqlCommand = new SqlCommand(strThem, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@ten", textBox2.Text);
                    sqlCommand.Parameters.AddWithValue("@ngaysinh", dateTimePicker1.Value);
                    sqlCommand.Parameters.AddWithValue("@diachi", textBox3.Text);
                    sqlCommand.Parameters.AddWithValue("@sdt", textBox4.Text);
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
            FNhanVien_Load();
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
                sqlCommand.Parameters.AddWithValue("@id", textBox1.Text);
                sqlCommand.Parameters.AddWithValue("@ten", textBox2.Text);
                sqlCommand.Parameters.AddWithValue("@ngaysinh", dateTimePicker1.Value);
                sqlCommand.Parameters.AddWithValue("@diachi", textBox3.Text);
                sqlCommand.Parameters.AddWithValue("@sdt", textBox4.Text);
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
                textBox1.Text = dtgvNhanVien.CurrentRow.Cells[0].Value.ToString();
                sqlCommand.Parameters.AddWithValue("@id", textBox1.Text);
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
            textBox1.Text = dtgvNhanVien.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dtgvNhanVien.CurrentRow.Cells[1].Value.ToString();
            dateTimePicker1.Text = dtgvNhanVien.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dtgvNhanVien.CurrentRow.Cells[3].Value.ToString();
            textBox4.Text = dtgvNhanVien.CurrentRow.Cells[4].Value.ToString();
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

    }
}
