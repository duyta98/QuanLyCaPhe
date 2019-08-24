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
    public partial class FThucDon : Form
    {

        #region Events
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string strThem = "INSERT INTO dbo.MON (ID,TENMON,DVT,GiA,IDLOAIMON)" + "VALUES(@id, @ten, @dvt, @gia, @idLoai)";
                string cnnStr = "Data Source = DUYPC; Initial Catalog = QLCF; Integrated Security = True";
                SqlConnection sqlConnection = new SqlConnection(cnnStr);
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlCommand sqlCommand = new SqlCommand(strThem, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@id", txbMamon.Text);
                sqlCommand.Parameters.AddWithValue("@ten", txbTenmon.Text);
                sqlCommand.Parameters.AddWithValue("@dvt", cbbDvt.SelectedItem.ToString());
                sqlCommand.Parameters.AddWithValue("@gia", txbGia.Text);
                sqlCommand.Parameters.AddWithValue("@idLoai", cbbMaloai.SelectedItem.ToString());
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                FThucDon_Load();
                MessageBox.Show("Thực hiện hành công", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnXem_Click(object sender, EventArgs e)
        {
            FThucDon_Load();
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string strSua = "UPDATE dbo.MON SET ID = @id, TENMON = @ten, DVT = @dvt, GIA = @gia, IDLOAIMON = @idloai WHERE ID = @id";
                string cnnStr = "Data Source = DUYPC; Initial Catalog = QLCF; Integrated Security = True";
                SqlConnection sqlConnection = new SqlConnection(cnnStr);
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlCommand sqlCommand = new SqlCommand(strSua, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@id", txbMamon.Text);
                sqlCommand.Parameters.AddWithValue("@ten", txbTenmon.Text);
                sqlCommand.Parameters.AddWithValue("@dvt", cbbDvt.SelectedItem.ToString());
                sqlCommand.Parameters.AddWithValue("@gia", txbGia.Text);
                sqlCommand.Parameters.AddWithValue("@idLoai", cbbMaloai.SelectedItem.ToString());

                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                FThucDon_Load();
                MessageBox.Show("Thực hiện hành công", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string strXoa = "DELETE dbo.MON WHERE ID = @id";
                string cnnStr = "Data Source = DUYPC; Initial Catalog = QLCF; Integrated Security = True";
                SqlConnection sqlConnection = new SqlConnection(cnnStr);
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlCommand sqlCommand = new SqlCommand(strXoa, sqlConnection);

                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                FThucDon_Load();
                MessageBox.Show("Thực hiện hành công", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void DtgvMon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbMamon.Text = dtgvMon.CurrentRow.Cells[0].Value.ToString();
            txbTenmon.Text = dtgvMon.CurrentRow.Cells[1].Value.ToString();
            cbbDvt.Text = dtgvMon.CurrentRow.Cells[2].Value.ToString();
            txbGia.Text = dtgvMon.CurrentRow.Cells[3].Value.ToString();
            cbbMaloai.Text = dtgvMon.CurrentRow.Cells[4].Value.ToString();
        }
        #endregion

        #region Method

        public FThucDon()
        {
            InitializeComponent();
            FThucDon_Load();
            load();
        }

        private void FThucDon_Load()
        {
            string sqlString = "SELECT ID AS [Mã món], TENMON AS [Tên món], DVT AS [Đơn vị tính], GIA AS [Giá], IDLOAIMON AS [Mã loại] FROM dbo.MON";

            dtgvMon.DataSource = Provider.Instance.ExecuteQuery(sqlString);


        }
        private void load()
        {
            cbbDVT_Load();
            cbbIDLoai_Load();
            cbbDanhmuc_Load();
        }

        private void cbbDVT_Load()
        {
            string sqlString = "SELECT DISTINCT DVT FROM dbo.MON";
            cbbDvt.DataSource = Provider.Instance.ExecuteQuery(sqlString);
            cbbDvt.DisplayMember = "DVT";
        }
        private void cbbIDLoai_Load()
        {
            string sqlString = "SELECT DISTINCT IDLOAIMON FROM dbo.MON";
            cbbMaloai.DataSource = Provider.Instance.ExecuteQuery(sqlString);
            cbbMaloai.DisplayMember = "IDLOAIMON";
        }

        private void cbbDanhmuc_Load()
        {
            string sqlString = "SELECT TENLOAI FROM dbo.LOAIMON";
            cbbDanhmuc.DataSource = Provider.Instance.ExecuteQuery(sqlString);
            cbbDanhmuc.DisplayMember = "TENLOAI";
        }
        #endregion

    }
}