using QL_QuanCF.DataAccessObject;
using QL_QuanCF.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace QL_QuanCF
{

    public partial class fBill_Info : Form
    {
        #region Object
        private Control ctrl;
        Food food;
        public fMain parent { get; set; }
        public Button btParent { get; set; }
        List<Food> foods;
        private Table table;
        private int billID;
        private readonly string user;
        public int idShift;

        #endregion
        #region Method

        public fBill_Info(Table tb, string userName)
        {
            InitializeComponent();
            table = TableDAO.Instance.GetTable(tb.ID);
            user = userName;

        }
        /// <summary>
        /// Thêm các chi tiết hóa đơn vào listview theo id hóa đơn
        /// </summary>
        /// <param name="id">ID bill</param>
        public void LoadBillInfo(int id)
        {
            lsvBillInfo.Items.Clear();
            billID = BillDAO.Instance.getIDBillUncheckOutByIDTable(table.ID);
            List<ListBillInfo> list = ListBillInfoDAO.Instance.GetAllBillInfo(billID);
            int i = 0;
            foreach (ListBillInfo item in list)
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
            List<Category> cates = CategoryDAO.Instance.GetCategoryDTOs();
            Category allCate = new Category();
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
        private void CreateButton(List<Food> list)
        {
            foreach (Food item in list)
            {
                Button btn = new Button() { Width = FoodDAO.Width, Height = FoodDAO.Height };
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
                        ListBillInfo billInfo = new ListBillInfo();
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
                ListBillInfoDAO.Instance.insertBillInfo(billID, idFood, count);
            }
        }
        public void AddMoreFoodQuantity(Food item, int newcount)
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
                ListBillInfo billInfo = new ListBillInfo();
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
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F8)
            {
                Pay();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Pay()
        {
            if (billID == -1)//Thêm mới bill
            {
                if (IsEmpty())
                {
                    return;
                }

                BillDAO.Instance.insertBill(table.ID, user);
                billID = BillDAO.Instance.getIDBillUncheckOutByIDTable(table.ID);//Get new Bill ID
                TableDAO.Instance.updateTableWhenCreateBill(int.Parse(txtAmountTab.Text), table.ID);
            }
            else//Nếu không thì xóa hết các bản ghi để thêm mới lại
            {
                ListBillInfoDAO.Instance.dellAllBillInfo(billID);
            }
            UpdateBillInfoFromListViewToDataBase();//Thêm mới lại các chi tiết hóa đơn
            BillDAO.Instance.updateAmountQuest(int.Parse(txtAmountTab.Text), table.ID);

            BillDAO.Instance.CalAmountBill(billID);

            ChangePropBtnTabToCheckIn();

        }
        private void fBill_Info_Load(object sender, System.EventArgs e)
        {
            LoadBillInfo(billID);
            LoadCbbCate();
            txtTableNumber.Text = table.TabName;
            txtAmountTab.Text = table.Amount.ToString();
            billID = BillDAO.Instance.getIDBillUncheckOutByIDTable(table.ID);
            lsvBillInfo.ContextMenuStrip = cmsFoodListview;
        }

        #endregion
        #region Events

        private void btnPay_Click(object sender, EventArgs e)
        {

            if (IsEmpty())
                return;
            Pay();
            if (billID == -1)
                return;

            fPayment payment = new fPayment(table);
            payment.frmbi = this;
            payment.idShift = idShift;
            Hide();
            payment.Show();
        }

        private void cbbCate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbCate.SelectedValue == null)
                return;
            int idCate = (cbbCate.SelectedItem as Category).Id;

            if (idCate == 0)
            {
                foods = FoodDAO.Instance.LoadFoodLists();
            }
            else
            {
                foods = FoodDAO.Instance.LoadFoodListsByIDCate(idCate);
            }
            flpViewFood.Controls.Clear();
            CreateButton(foods);
        }

        private void btnSaveBill_Click(object sender, EventArgs e)
        {
            if (IsEmpty())
                return;
            Pay();

            Close();
        }
        public void ChangePropBtnTabToCheckIn()
        {
            table.Status = "Có người";
            btParent.Text = table.TabName + Environment.NewLine + table.Status;
            btParent.BackColor = Color.BlueViolet;
        }
        public void ChangePropBtnTabToCheckOut()
        {
            table.Status = "Trống";
            btParent.Text = table.TabName + Environment.NewLine + table.Status;
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
                foods = FoodDAO.Instance.LoadFoodLists();
            else
                foods = FoodDAO.Instance.LoadFoodListsBySearch(txtSearch.Text.Trim());
            flpViewFood.Controls.Clear();
            CreateButton(foods);
        }

        private void thêmNhiềuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            food = ctrl.Tag as Food;
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
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (billID != -1)
            {
                ChangePropBtnTabToCheckIn();
            }
            else
            {
                ChangePropBtnTabToCheckOut();
            }
            Close();
        }

        private void fBill_Info_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }

        #endregion

    }
}
