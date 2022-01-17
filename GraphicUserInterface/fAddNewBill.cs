using QL_QuanCF.DataAccessObject;
using QL_QuanCF.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace QL_QuanCF
{
    public partial class fAddNewBill : Form
    {
        #region Object
        private List<Food> foods;
        public fMain parentForm;
        private string userName;
        private int IDTable;
        private int IDBill;
        private int IDShift;
        private Table table;
        #endregion
        #region Methods
        public fAddNewBill(string user, int idshift)
        {
            InitializeComponent();
            userName = user;
            IDShift = idshift;
        }
        private void LoadCbbCate()
        {
            List<Category> cates = CategoryDAO.Instance.GetCategory();
            Category allCate = new Category();
            allCate.Name = "Tất cả";
            allCate.Id = 0;
            cates.Add(allCate);
            cbbCate.DataSource = cates;
            cbbCate.DisplayMember = "name";
            cbbCate.ValueMember = "id";
            cbbCate.SelectedValue = 0;
        }
        private bool IsEmpty()
        {
            if (txtTabName.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập số bàn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTabName.Focus();
                return true;
            }
            if (lsvBillInfo.Items.Count == 0)
            {
                MessageBox.Show("Bàn chưa có thực đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                ListBillInfoDAO.Instance.insertBillInfo(IDBill, idFood, count);
            }
        }
        private void Pay()
        {
            IDTable = int.Parse(Provider.Instance.ExecuteScalar("SELECT ID FROM dbo.TAB WHERE NAMETAB = N'" + txtTabName.Text + "'").ToString());
            table = TableDAO.Instance.getTableById(IDTable);
            BillDAO.Instance.insertBill(IDTable, userName);
            
            TableDAO.Instance.updateTableWhenCreateBill(int.Parse(txtAmountPeople.Text), IDTable);
            IDBill = BillDAO.Instance.getIDBillUncheckOutByIDTable(IDTable);//Get new Bill ID
            UpdateBillInfoFromListViewToDataBase();//Thêm mới lại các chi tiết hóa đơn
            BillDAO.Instance.updateAmountQuest(int.Parse(txtAmountPeople.Text), IDTable);
            
            BillDAO.Instance.CalAmountBill(IDBill);
        }
        private void CreateButton(List<Food> list)
        {
            foreach (Food item in list)
            {
                Button btn = new Button() { Width = FoodDAO.Width, Height = FoodDAO.Height };
                btn.Text = item.NameFood + Environment.NewLine + item.Price.ToString("#,#");
                btn.Tag = item;
                btn.ContextMenuStrip = cmsFoodFLP;
                btn.FlatStyle = FlatStyle.Standard;
                btn.Margin = new Padding(12);
                btn.Font = new Font("Arial", 13, FontStyle.Regular);
                btn.ForeColor = Color.Red;
                if (item.AvatarDir != null)
                {
                    btn.BackgroundImage = Image.FromFile(item.AvatarDir);
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                }

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
                        ListViewItem lvi = lsvBillInfo.Items[i];

                        if (lvi.Tag.ToString() == item.IdFood)
                        {
                            int count = int.Parse(lvi.SubItems[2].Text);
                            lvi.SubItems[2].Text = (count + 1).ToString();
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
                btn.BackColor = Color.LightYellow;
                flpViewFood.Controls.Add(btn);
            }
        }
        private void loadMostUsed()
        {
            foods = FoodDAO.Instance.LoadFoodLists("uspGetMostUsedFood");
            flpViewFood.Controls.Clear();
            CreateButton(foods);

        }
        #endregion
        #region Events
        private void fAddNewBill_Load(object sender, System.EventArgs e)
        {
            string queryTab = "SELECT NAMETAB FROM TAB WHERE STATUSTAB = N'Trống'";
            txtTabName.loadDataAutoComplete(Provider.cnnStr, queryTab, "NAMETAB");
            string queryFood = "SELECT NAMEFOOD FROM dbo.FOOD ";
            txtSearchFood.loadDataAutoComplete(Provider.cnnStr, queryFood, "NAMEFOOD");
            txtTabName.Focus();
            LoadCbbCate();
            //Load food list to flpFood
            foods = FoodDAO.Instance.LoadFoodLists("spGetAllFood");
            CreateButton(foods);
        }

        private void txtTabName_Leave(object sender, System.EventArgs e)
        {
            if (!txtTabName.AutoCompleteCustomSource.Contains(txtTabName.Text))
            {
                txtTabName.Clear();
            }
        }
        private void BtnMostUsed_Click(object sender, System.EventArgs e)
        {
            flpViewFood.Controls.Clear();

        }


        private void btnPay_Click(object sender, EventArgs e)
        {
            if (IsEmpty())
                return;
            Pay();
            if (IDBill == -1)
                return;

            fPayment payment = new fPayment(table);
            payment.fNewBill = this;
            payment.idShift = IDShift;
            Hide();
            payment.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsEmpty())
                return;
            Pay();

            parentForm.changeBtnTablePropertiesToCheckIn(table.TabName);
            Close();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            flpViewFood.Controls.Clear();
            foods = FoodDAO.Instance.LoadFoodLists("spGetAllFoodBySearch @text",new object[]{txtSearchFood.Text});
            CreateButton(foods);
        }

        private void fAddNewBill_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Show();

        }

        private void txtSearchFood_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(sender, e);
            }
        }

        private void cbbCate_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int idCate = (cbbCate.SelectedItem as Category).Id;

            if (idCate == 0)
            {
                foods = FoodDAO.Instance.LoadFoodLists("spGetAllFood");
            }
            else
            {
                foods = FoodDAO.Instance.LoadFoodLists("spGetAllFoodByIDCate @id", new object[] { idCate } );
            }
            flpViewFood.Controls.Clear();
            CreateButton(foods);
        }

        private void btnMostUsed_Click(object sender, EventArgs e)
        {
            loadMostUsed();
        }
        #endregion
    }
}
