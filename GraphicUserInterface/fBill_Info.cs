﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QL_QuanCF.DataAccessObject;
using QL_QuanCF.DataTransferObject;

namespace QL_QuanCF
{

    public partial class fBill_Info : Form
    {
        #region Object
        private Control ctrl;
        FoodDTO food;
        public fMain parent { get; set; }
        public Button btParent { get; set; }
        private List<ListBillInfo> listBillInfo;
        List<FoodDTO> foods;
        private TableDTO table;
        private int billID;
        private readonly string user;
        #endregion
        #region Method
        private void SetListBillInfo(List<ListBillInfo> value)
        {
            listBillInfo = value;
        }

        public fBill_Info(TableDTO item, string userName)
        {
            InitializeComponent();
            SetListBillInfo(new List<ListBillInfo>());
            table = item;
            user = userName;

        }
        /// <summary>
        /// Thêm các chi tiết hóa đơn vào listview theo id hóa đơn
        /// </summary>
        /// <param name="id">ID bill</param>
        public void LoadBillInfo(int id)
        {
            lsvBillInfo.Items.Clear();
            billID = Bill.Instance.getIDBillUncheckOutByIDTable(table.ID);
            List<ListBillInfoDTO> list = DataAccessObject.ListBillInfo.Instance.GetAllBillInfo(billID);
            int i = 0;
            foreach (ListBillInfoDTO item in list)
            {
                i++;
                ListViewItem lsvitem = new ListViewItem(i.ToString());
                lsvitem.SubItems.Add(item.Name.ToString());
                lsvitem.SubItems.Add(item.Quantity.ToString());
                lsvitem.SubItems.Add(item.Price.ToString("#,#"));
                lsvitem.Tag = item.Id;
                lsvBillInfo.Items.Add(lsvitem);
            }
        }
        private void LoadCbbCate()
        {
            List<CategoryDTO> cates = Category.Instance.GetCategoryDTOs();
            CategoryDTO allCate = new CategoryDTO();
            allCate.Name = "Tất cả";
            allCate.Id = 0;
            cates.Add(allCate);
            cbbCate.DataSource = cates;
            cbbCate.DisplayMember = "name";
            cbbCate.ValueMember = "id";
            cbbCate.SelectedValue = 0;
        }


        /// <summary>
        /// Tạo control button món ăn
        /// </summary>
        /// <param name="list">Danh sách món ăn <List></param>
        private void CreateButton(List<FoodDTO> list)
        {
            foreach (FoodDTO item in list)
            {
                Button btn = new Button() { Width = Food.Width, Height = Food.Height };
                btn.Text = item.NameFood + Environment.NewLine + item.Price.ToString("#,#");
                btn.Tag = item;
                btn.ContextMenuStrip = cmsFoodFLP;
                btn.FlatStyle = FlatStyle.Standard;
                btn.Margin = new Padding(10);
                btn.Font = new Font("Arial", 12);
                btn.Click += (s, e) =>
                {
                    int i = 0;
                    bool isExist = false;
                    //browse all listviewItem of lsvBillInfo
                    //Compare id food in button with id food in lsvBillInfo
                    //If Find it then update quantity
                    //else add new ListviewItem;
                    while (i < lsvBillInfo.Items.Count)
                    {
                        ListViewItem lsvi = lsvBillInfo.Items[i];

                        if (lsvi.Tag.ToString() == item.IdFood)
                        {
                            int count = int.Parse(lsvi.SubItems[2].Text);
                            lsvi.SubItems[2].Text = (count + 1).ToString();
                            isExist = true;
                            return;
                        }
                        i++;
                    }
                    if (isExist == false)
                    {
                        ListBillInfoDTO billInfo = new ListBillInfoDTO();
                        billInfo.Name = item.NameFood;
                        billInfo.Quantity = 1;
                        billInfo.Price = item.Price;
                        billInfo.Id = int.Parse(item.IdFood);
                        ListViewItem lsvitem = new ListViewItem((lsvBillInfo.Items.Count + 1).ToString());
                        lsvitem.SubItems.Add(billInfo.Name);
                        lsvitem.SubItems.Add(billInfo.Quantity.ToString());
                        lsvitem.SubItems.Add(billInfo.Price.ToString("#,#"));
                        lsvitem.Tag = billInfo.Id;

                        lsvBillInfo.Items.Add(lsvitem);
                    }
                };
                btn.BackColor = Color.White;
                flpViewFood.Controls.Add(btn);
            }
        }
        private bool IsEmpty()
        {
            if (txtTableNumber.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập số bàn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTableNumber.Focus();
                return true;
            }
            if (lsvBillInfo.Items.Count == 0)
            {
                MessageBox.Show("Bàn chưa có thực đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSearch.Focus();
                return true;
            }
            return false;
        }
        private void UpdateBillInfoFromListViewToDataBase()
        {
            foreach (ListViewItem lsvi in lsvBillInfo.Items)
            {

                int idFood = int.Parse(lsvi.Tag.ToString());
                int count = int.Parse(lsvi.SubItems[2].Text.ToString());
                DataAccessObject.ListBillInfo.Instance.insertBillInfo(billID, idFood, count);
            }
        }
        public void AddMoreFoodQuantity(FoodDTO item, int newcount)
        {
            int i = 0;
            bool isExist = false;
            while (i < lsvBillInfo.Items.Count)
            {
                ListViewItem lsvi = lsvBillInfo.Items[i];

                if (lsvi.Tag.ToString() == item.IdFood)
                {
                    int count = int.Parse(lsvi.SubItems[2].ToString());
                    lsvi.SubItems[2].Text = (count + newcount).ToString();
                    isExist = true;
                    return;
                }
                i++;
                
            }
            if (isExist == false)
            {
                ListBillInfoDTO billInfo = new ListBillInfoDTO();
                billInfo.Name = item.NameFood;
                billInfo.Quantity = newcount;
                billInfo.Price = item.Price;
                billInfo.Id = int.Parse(item.IdFood);
                ListViewItem lsvitem = new ListViewItem((lsvBillInfo.Items.Count + 1).ToString());
                lsvitem.SubItems.Add(billInfo.Name);
                lsvitem.SubItems.Add(billInfo.Quantity.ToString());
                lsvitem.SubItems.Add(billInfo.Price.ToString("#,#"));
                lsvitem.Tag = billInfo.Id;
                lsvBillInfo.Items.Add(lsvitem);
            }
        }
        public void ModifyQuantityFood(int newcount)
        {
            if (lsvBillInfo.SelectedItems.Count > 0)
            {
                lsvBillInfo.SelectedItems[0].SubItems[2].Text = newcount.ToString();
            }
        }
        #endregion
        #region Events
        private void fBill_Info_Load(object sender, System.EventArgs e)
        {
            LoadBillInfo(billID);
            LoadCbbCate();
            txtTableNumber.Text = table.TabName;
            txtAmountTab.Text = table.Amount.ToString();
            billID = Bill.Instance.getIDBillUncheckOutByIDTable(table.ID);
            lsvBillInfo.ContextMenuStrip = cmsFoodListview;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (billID == -1)
                return;
            fPayment payment = new fPayment(table);
            payment.frmbi = this;
            payment.ShowDialog();
        }

        private void cbbCate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbCate.SelectedValue == null)
                return;
            int idCate = (cbbCate.SelectedItem as CategoryDTO).Id;

            if (idCate == 0)
            {
                foods = Food.Instance.LoadFoodLists();
            }
            else
            {
                foods = Food.Instance.LoadFoodListsByIDCate(idCate);
            }
            flpViewFood.Controls.Clear();
            CreateButton(foods);
        }

        private void btnSaveBill_Click(object sender, EventArgs e)
        {

            if (billID == -1)//Not exists Bill. InsertBill
            {
                if (IsEmpty())
                {
                    return;
                }

                Bill.Instance.insertBill(table.ID, user);
                billID = Bill.Instance.getIDBillUncheckOutByIDTable(table.ID);//Get new Bill ID
                Table.Instance.updateTableWhenCreateBill(int.Parse(txtAmountTab.Text), table.ID);

            }
            else//Nếu không thì xóa hết các bản ghi để thêm mới lại
            {
                ListBillInfo.Instance.dellAllBillInfo(billID);
            }
            UpdateBillInfoFromListViewToDataBase();//Thêm mới lại các chi tiết hóa đơn
            Bill.Instance.updateAmountQuest(int.Parse(txtAmountTab.Text), table.ID);

            double amount = Bill.Instance.CalAmountBill(billID);
            Bill.Instance.updateAmountBill(amount, billID);
            ChangePropBtnTabToCheckIn();
            Close();
        }
        public void ChangePropBtnTabToCheckIn()
        {
            btParent.Text = table.TabName + Environment.NewLine + "Có người";
            btParent.BackColor = Color.BlueViolet;
        }
        public void ChangePropBtnTabToCheckOut()
        {
            btParent.Text = table.TabName + Environment.NewLine + "Trống";
            btParent.BackColor = Color.White;
        }
        private void txtTableNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(sender, e);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim() == "")
                foods = Food.Instance.LoadFoodLists();
            else
                foods = Food.Instance.LoadFoodListsBySearch(txtSearch.Text.Trim());
            flpViewFood.Controls.Clear();
            CreateButton(foods);
        }

        private void thêmNhiềuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            food = ctrl.Tag as FoodDTO;
            fAddSeveralQuantityFood frm = new fAddSeveralQuantityFood(food);
            frm.parent = this;
            frm.ShowDialog();
        }


        private void cmsFoodFLP_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ctrl = ((ContextMenuStrip)sender).SourceControl;
        }
        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lsvBillInfo.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lsvBillInfo.SelectedItems[0];
                lsvBillInfo.Items.Remove(lvi);
            }
        }

        private void thayĐổiSốLượngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fModifyQuantityFood frm = new fModifyQuantityFood();
            frm.parent = this;
            frm.ShowDialog();
        }
        #endregion


    }
}