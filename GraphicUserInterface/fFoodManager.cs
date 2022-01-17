﻿using QL_QuanCF.DataAccessObject;
using QL_QuanCF.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace QL_QuanCF
{
    public partial class fFoodManager : Form
    {
        #region Object
        private string hint = "Nhập tên món ...";
        private List<FoodManagerObject> foods;
        private bool eitherAddOrModify;//True: add, false: Modify
        FoodManagerObject food;
        private string avatarPath;
        #endregion
        #region Methods
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
        private void LoadCbbUnit()
        {
            DataTable dataTable = Provider.Instance.ExecuteQuery("SELECT * FROM UNIT");
            cbbUnit.DataSource = dataTable;
            cbbUnit.ValueMember = "ID";
            cbbUnit.DisplayMember = "NAME";
        }
        private void loadData(List<FoodManagerObject> list)
        {
            int i = 1;
            foreach (var item in foods)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = i.ToString();
                lvi.SubItems.Add(item.NameFood);
                lvi.SubItems.Add(item.NameUnit);
                lvi.SubItems.Add(double.Parse(item.Cost.ToString()).ToString("#,#"));
                lvi.SubItems.Add(double.Parse(item.Price.ToString()).ToString("#,#"));
                lvi.SubItems.Add(item.AvatarDir);
                lvi.Tag = item;
                lsvFood.Items.Add(lvi);
                i++;
            }
        }
        private void loadAllFood()
        {
            foods = FoodDAO.Instance.LoadFoodListForManager("uspGetAllFoodForManager");
            loadData(foods);
        }
        private void fFoodManager_Load(object sender, EventArgs e)
        {
            LoadCbbCate();
            LoadCbbFoodCate();
            LoadCbbUnit();
            txtSearch.Text = hint;
            txtSearch.ForeColor = Color.Gray;
            loadAllFood();
            changePropertiesPnlDetailsUnEnabled();
            btnDelete.Enabled = btnModify.Enabled = BtnSave.Enabled = false;
        }
        private void changePropertiesPnlDetailsUnEnabled()
        {

            foreach (Control item in pnlDetails.Controls)
            {
                item.Enabled = false;
            }
        }
        private void changePropertiesPnlDetailsEnabled()
        {

            foreach (Control item in pnlDetails.Controls)
            {
                item.Enabled = true;
            }
        }
        private void Execute(string query, object[] parameter = null)
        {
            Provider.Instance.ExecuteQuery(query, parameter);
        }
        private void refresh()
        {
            lsvFood.Items.Clear();
            loadAllFood();

        }
        #endregion
        #region Events
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

        private void cbbCate_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (int.Parse(cbbCate.SelectedValue.ToString()) == 0)
            {
                foods = FoodDAO.Instance.LoadFoodListForManager("uspGetAllFoodForManager");
            }
            else
            {
                foods = FoodDAO.Instance.LoadFoodListForManager("uspGetFoodForManagerByIDCate @id", new object[] { cbbCate.SelectedValue.ToString() });
            }
            lsvFood.Items.Clear();

            loadData(foods);
        }


        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lsvFood.Items.Clear();

                foods = FoodDAO.Instance.LoadFoodListForManager("uspGetFoodForManagerByText @text", new object[] { txtSearch.Text });
                loadData(foods);
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            eitherAddOrModify = false;
            changePropertiesPnlDetailsEnabled();
            BtnSave.Enabled = true;
            btnModify.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa món trên không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                Execute("",new object[] {});
                btnDelete.Enabled = btnModify.Enabled = BtnSave.Enabled = false;
                refresh();
            }

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string query;
            if (eitherAddOrModify)
            {
                query = "uspInsertFood @name , @idcate , @cost , @price , @unit , @avatar";
                Execute(query, new object[] { txtName.Text, cbbFoodCate.SelectedValue.ToString(), txtCost.Text, txtPrice.Text, cbbUnit.SelectedValue.ToString(), avatarPath });
                
            }    
                
            else
            {
                query = "uspUpdateFood @name , @idcate , @cost , @price , @unit , @avatar , @id";
                Execute(query, new object[] { txtName.Text, cbbFoodCate.SelectedValue.ToString(), txtCost.Text, txtPrice.Text, cbbUnit.SelectedValue.ToString(), avatarPath, food.IdFood });
            }
            refresh();
            btnDelete.Enabled = btnModify.Enabled = BtnSave.Enabled = false;
            changePropertiesPnlDetailsUnEnabled();

        }
        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            eitherAddOrModify = true;
            BtnSave.Enabled = true;
            changePropertiesPnlDetailsEnabled();
            txtName.Text = txtCost.Text = txtPrice.Text = "";
            ptbAvatar.Image = null;
            btnModify.Enabled = btnDelete.Enabled = false;
        }
        private void lsvFood_MouseClick(object sender, MouseEventArgs e)
        {
            if (lsvFood.SelectedItems.Count > 0)
            {
                avatarPath = "";

                food = lsvFood.SelectedItems[0].Tag as FoodManagerObject;
                txtName.Text = food.NameFood;
                cbbFoodCate.SelectedValue = food.IdCate;
                cbbUnit.Text = food.NameUnit;
                txtCost.Text = food.Cost.ToString("#,#");
                txtPrice.Text = food.Price.ToString("#,#");
                if (food.AvatarDir != null)
                {
                    ptbAvatar.Image = Image.FromFile(food.AvatarDir);
                }
                else
                {
                    ptbAvatar.Image = null;
                }
                changePropertiesPnlDetailsUnEnabled();
                btnDelete.Enabled = btnModify.Enabled = true;
                BtnSave.Enabled = false;
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            string appPath = Path.GetDirectoryName(projectDirectory) + @"\Data\Image\";
            if (Directory.Exists(appPath) == false)
            {
                Directory.CreateDirectory(appPath);
            }
            if (ofdImage.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string iName = ofdImage.SafeFileName;
                    string filepath = ofdImage.FileName;
                    
                    Image img = null;
                    FileStream fs = null;
                    try
                    {
                        FileInfo fi = new FileInfo(filepath);
                        if (fi.Extension == ".webp")//If extension is webp then change to jpg
                        {
                            File.Move(filepath, Path.ChangeExtension(filepath, ".jpg"));
                            filepath = Path.ChangeExtension(filepath, ".jpg");
                        }
                        fs = new FileStream(filepath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                        img = Image.FromStream(fs);
                        ptbAvatar.Image = img;
                    }
                    finally
                    {
                        fs.Close();
                    }
                    avatarPath = appPath + iName;
                    File.Copy(filepath, appPath + iName);
                }
                catch (Exception exp)
                {
                    MessageBox.Show("Unable to open file.\n" + exp.Message);
                }

            }
            else
            {
                ofdImage.Dispose();
            }
        }

        #endregion

        private void cmsAvatar_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ptbAvatar.Image = null;
            avatarPath = "";
        }
    }
}