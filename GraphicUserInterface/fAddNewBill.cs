using QL_QuanCF.DataAccessObject;
using QL_QuanCF.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace QL_QuanCF
{
    public partial class fAddNewBill : Form
    {
        private List<Food> foods;

        public fAddNewBill()
        {
            InitializeComponent();
        }
        #region Methods

        #endregion
        #region Events
        private void fAddNewBill_Load(object sender, System.EventArgs e)
        {
            string queryTab = "SELECT NAMETAB FROM TAB WHERE STATUSTAB = N'Trống'";
            txtTabName.loadDataAutoComplete(Provider.cnnStr, queryTab, "NAMETAB");
            string queryFood = "SELECT NAMEFOOD FROM dbo.FOOD ";
            txtSearchFood.loadDataAutoComplete(Provider.cnnStr, queryFood, "NAMEFOOD");
            txtTabName.Focus();
        }

        private void txtTabName_Leave(object sender, System.EventArgs e)
        {
            if (!txtTabName.AutoCompleteCustomSource.Contains(txtTabName.Text))
            {
                txtTabName.Clear();
            }
        }
        #endregion

        private void btnMostUsed_Click(object sender, System.EventArgs e)
        {
            //flpViewFood.Controls.Clear();
            foods = FoodDAO.Instance.LoadFoodLists();
            CreateButton(foods);
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

        private void btnPay_Click(object sender, EventArgs e)
        {

        }
    }
}
