using QL_QuanCF.DataAccessObject;
using QL_QuanCF.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace QL_QuanCF
{
    public partial class fFoodManager : Form
    {                  
        private string hint = "Nhập tên món ...";

        

        public fFoodManager()
        {
            InitializeComponent();
        }
        private void LoadCbbCate()
        {
            List<Category> cates = CategoryDAO.Instance.GetCategory();
            cbbFoodCate.DataSource = cates;
            Category cate = new Category();
            cate.Name = "Tất cả";
            cate.Id = 0;
            cates.Add(cate);
            cbbCate.DataSource = cates;
            cbbCate.DisplayMember =  "name";
            cbbCate.ValueMember = cbbFoodCate.ValueMember = "id";
            cbbCate.SelectedValue = 0;
        }
        private void LoadCbbFoodCate()
        {
            List<Category> cates = CategoryDAO.Instance.GetCategory();
            cbbFoodCate.DataSource = cates;
            cbbFoodCate.ValueMember = "id";
            cbbFoodCate.DisplayMember = "name";
        }

        private void fFoodManager_Load(object sender, EventArgs e)
        {
            LoadCbbCate();
            LoadCbbFoodCate();
            txtSearch.Text = hint;
            txtSearch.ForeColor = Color.Gray;
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim() == "")
            {
                txtSearch.Text = hint;
                txtSearch.ForeColor = Color.Gray;
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == hint)
            {
                txtSearch.Clear();
                txtSearch.ForeColor = Color.Black;
            }    
                
        }

       
    }
}