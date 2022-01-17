using QL_QuanCF.DataAccessObject;
using QL_QuanCF.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace QL_QuanCF
{
    public partial class fStaffManager : Form
    {
        #region Object
        public fMain parentForm;
        private List<Staff> listStaff;
        private string hint = "Nhập tên nhân viên, tài khoản, ...";
        #endregion
        public fStaffManager()
        {
            InitializeComponent();

        }
        private void loadStaff(string query, object[] parameter = null)
        {
            listStaff = StaffDAO.Instance.loadAllStaff(query,parameter);
            addStaff(listStaff);
        }
        private void addStaff(List<Staff> list)
        {
            int i = 0;
            foreach (Staff item in list)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = (++i).ToString();
                lvi.SubItems.Add(item.Name);
                lvi.SubItems.Add(((DateTime)item.Birth).ToString("dd'/'MM'/'yyyy"));
                lvi.SubItems.Add(item.Sex);
                lvi.SubItems.Add(item.Address);
                lvi.SubItems.Add(item.User);
                if (item.AvatarDir != null)
                    lvi.SubItems.Add(item.AvatarDir);
                else
                    lvi.SubItems.Add("");
                if (item.Email != null)
                    lvi.SubItems.Add(item.Email);
                else
                    lvi.SubItems.Add("");
                lvi.SubItems.Add(item.Phone);
                lvi.Tag = item;
                lsvStaff.Items.Add(lvi);
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

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim() == "")
            {
                txtSearch.Text = hint;
                txtSearch.ForeColor = Color.Gray;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lsvStaff.Items.Clear();
            loadStaff("uspGetAllStaffBySearch @txt", new object[] { txtSearch.Text });
            
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(sender, e);
            }
            
        }

        private void fStaffManager_Load(object sender, EventArgs e)
        {
            loadStaff("uspGetAllStaff");
            changePropertiesPnlDetailsUnEnabled();
            btnDelete.Enabled = btnModify.Enabled = btnSave.Enabled = false;
        }
        private void changePropertiesPnlDetailsUnEnabled()
        {

            foreach (Control item in pnlDetaill.Controls)
            {
                item.Enabled = false;
            }
        }
        private void changePropertiesPnlDetailsEnabled()
        {

            foreach (Control item in pnlDetaill.Controls)
            {
                item.Enabled = true;
            }
        }

        private void txtPhoneNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        bool IsValidEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false;
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (IsValidEmail(txtAddress.Text))
            {
                DialogResult dr = MessageBox.Show("Email is not valid.\n Do you want to re-enter?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                    txtEmail.Focus();
                else
                    txtEmail.Clear();
            }
        }

        private void lsvStaff_Click(object sender, EventArgs e)
        {
            if (lsvStaff.SelectedItems.Count > 0)
            {
                btnModify.Enabled = btnDelete.Enabled = true;

                Staff st = lsvStaff.SelectedItems[0].Tag as Staff;
                txtNameStaff.Text = st.Name;
                dtpBirth.Value = st.Birth.Value;
                if (st.Sex == "Nam")
                {
                    rdbMale.Checked = true;
                    rdbFemale .Checked = false;
                }
                else
                {
                    rdbFemale.Checked = true;
                    rdbMale.Checked = false;
                }
                txtAddress.Text = st.Address;
                txtPhoneNo.Text = st.Phone;
                txtEmail.Text = st.Email;
                if (st.AvatarDir != null)
                {
                    try
                    {
                        if (Directory.Exists(st.AvatarDir))
                            ptbAvatar.Image = Image.FromFile(st.AvatarDir);
                        else
                            MessageBox.Show("Image file not found", "Error");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
            }
            else
            {
                btnSave.Enabled = btnDelete.Enabled = btnModify.Enabled = false;
                changePropertiesPnlDetailsUnEnabled();
            }
        }

        private void fStaffManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            changePropertiesPnlDetailsEnabled();
            btnSave.Enabled = true;
            btnDelete.Enabled = btnModify.Enabled = false;
            txtNameStaff.Text = txtAddress.Text = txtEmail.Text = txtPhoneNo.Text = "";
        }
        private void save()
        {

        }
        private void delete()
        {

        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            btnDelete.Enabled = btnModify.Enabled = btnSave.Enabled = false;
            changePropertiesPnlDetailsUnEnabled();
            save();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to delete it?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                delete();
                btnDelete.Enabled = btnModify.Enabled = btnSave.Enabled = false;
                changePropertiesPnlDetailsUnEnabled();
            }
        }
        private void btnModify_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            btnModify.Enabled = false;
            changePropertiesPnlDetailsEnabled();
        }
    }
}
