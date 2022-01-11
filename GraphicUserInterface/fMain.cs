using QL_QuanCF.DataAccessObject;
using QL_QuanCF.DataTransferObject;
using QL_QuanCF.GraphicUserInterface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QL_QuanCF
{
    public partial class fMain : Form
    {
        public fLogin parent;
        public Control btn1;
        public Control btn2;
        private string userName;
        private Table tab1;
        private Table tab2;
        private int idfirstBill;
        public int idShift;
        public fMain(string user)
        {
            InitializeComponent();
            loadTable(1);
            userName = user;
        }


        #region Events
        private void btnReser_Click(object sender, EventArgs e)
        {
            flpTable.Controls.Clear();
            loadTable(4);
        }
        private void btnBar_Click(object sender, EventArgs e)
        {
            flpTable.Controls.Clear();
            loadTable(1);//1: Tại chỗ
        }

        private void btnTakeAway_Click(object sender, EventArgs e)
        {
            flpTable.Controls.Clear();
            loadTable(2);//2: Mang về
        }

        private void btnShip_Click(object sender, EventArgs e)
        {
            flpTable.Controls.Clear();
            loadTable(3);
        }
        private void txbTimkiem_Leave(object sender, EventArgs e)
        {
            if (txbTimkiem.Text.Trim() == "")
                txbTimkiem.Text = "Nhập số bàn, món ăn, nước uống,...";
        }

        private void txbTimkiem_Enter(object sender, EventArgs e)
        {
            txbTimkiem.Text = null;
        }

        private void txbTimkiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txbTimkiem.Text.Trim() != "")
                {
                    flpTable.Controls.Clear();
                    loadTable(txbTimkiem.Text);
                }
                else
                {
                    flpTable.Controls.Clear();
                    loadTable(1);//1: tại chỗ
                }
            }
        }

        private void ĐăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isCloseShift(userName))
            {
                DialogResult dr = MessageBox.Show("Chưa đóng ca làm việc, Bạn có muốn đóng không?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    FShiftClose frm = new FShiftClose();
                    frm.idShift = idShift;
                    frm.parent = this;
                    frm.ShowDialog();
                }
                else if (dr == DialogResult.No)
                {
                    Close();
                }
            }
        }

        private void BtnThemban_Click(object sender, EventArgs e)
        {
            fAddNewBill fThem = new fAddNewBill();
            fThem.ShowDialog();
        }

        private void ThôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FThongTinTK f = new FThongTinTK();
            f.ShowDialog();
        }

        private void NhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fStaffManager f = new fStaffManager();
            Hide();
            f.ShowDialog();
            Show();
        }

        private void ThựcĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fFoodManager f = new fFoodManager();
            f.ShowDialog();
        }
        private void chuyểnBànToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (idfirstBill == -1)
            {
                MessageBox.Show("Bàn trống!");
                return;
            }
            else
            {
                fSwitchTable frm = new fSwitchTable(1);
                frm.parent = this;
                frm.ShowDialog();
                if (btn2 == null)
                    return;
                tab2 = btn2.Tag as Table;
                int idsecondBill = BillDAO.Instance.getIDBillUncheckOutByIDTable(tab2.ID);
                if (idsecondBill == -1)
                {
                    swapTable(tab1.ID, tab2.ID);
                    string name = btn2.Name;
                    var btn = flpTable.Controls.OfType<Button>().Where(x => x.Name == name).FirstOrDefault();
                    btn.BackColor = Color.BlueViolet;
                    tab2 = btn.Tag as Table;
                    tab2.Status = "Có người";
                    tab1.Status = "Trống";
                    btn1.BackColor = Color.White;
                    btn1.Text = tab1.TabName + Environment.NewLine + tab1.Status;
                    btn.Text = tab2.TabName + Environment.NewLine + tab2.Status;
                }
                else if (idsecondBill != -1)
                {
                    swapTable(tab1.ID, tab2.ID);
                }
            }


        }

        private void cmsTable_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            btn1 = ((ContextMenuStrip)sender).SourceControl;
            tab1 = btn1.Tag as Table;
            idfirstBill = BillDAO.Instance.getIDBillUncheckOutByIDTable(tab1.ID);

            foreach (var item in cmsTable.Items)
            {
                ToolStripMenuItem tsmi = (ToolStripMenuItem)item;
                if (idfirstBill == -1)
                {
                    tsmi.Enabled = false;
                }
                else
                {
                    tsmi.Enabled = true;
                }
            }
        }

        private void gộpBànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tab1 = btn1.Tag as Table;
            int idfirstBill = BillDAO.Instance.getIDBillUncheckOutByIDTable(tab1.ID);
            if (idfirstBill == -1)
            {
                MessageBox.Show("Bàn trống!");
                return;
            }
            else
            {
                fSwitchTable frm = new fSwitchTable(2);
                frm.parent = this;
                frm.ShowDialog();

                if (btn2 == null)
                    return;

                string name = btn2.Name;
                var btn = flpTable.Controls.OfType<Button>().Where(x => x.Name == name).FirstOrDefault();
                btn.BackColor = Color.BlueViolet;
                tab2 = btn.Tag as Table;
                tab2.Status = "Trống";
                btn.Text = tab2.TabName + Environment.NewLine + tab2.Status;
                MergeTable(tab1.ID, tab2.ID);

            }

        }

        private void fMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn thoát chứ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                    e.Cancel = true;
            }
        }
        private void fMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }
        #endregion

        #region Method
        public void loadTable(int tabType)//tabType = 1: tại chỗ, 2: Mang về, 3: Đặt chỗ, 4: Giao hàng
        {
            flpTable.Controls.Clear();
            List<Table> ListTables = TableDAO.Instance.LoadTable(tabType);

            foreach (Table item in ListTables)
            {
                Button btn = new Button() { Width = TableDAO.BanWidth, Height = TableDAO.BanWidth };
                btn.Text = item.TabName + Environment.NewLine + item.Status;
                btn.Tag = item;
                btn.Name = item.ID.ToString();
                btn.Font = new Font("Arial", 18);
                btn.FlatStyle = FlatStyle.Standard;
                btn.Margin = new Padding(20);
                btn.ContextMenuStrip = cmsTable;
                btn.MouseHover += (s, e) =>
                {
                    btn.BackColor = Color.Orange;
                };
                btn.MouseLeave += (s, e) =>
                {
                    Table tb = TableDAO.Instance.GetTable(item.ID);
                    if (tb.Status == "Trống")
                        btn.BackColor = Color.White;
                    else
                        btn.BackColor = Color.BlueViolet;
                };
                btn.Click += (s, e) =>
                {
                    fBill_Info f = new fBill_Info(item, userName);
                    f.idShift = idShift;
                    f.parent = this;//Thiết lập ràng buộc với form con
                    f.btParent = btn;//Thiết lập ràng buộc với form con
                    f.Text = item.TabName;
                    Hide();
                    f.Show();
                };
                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.White;
                        flpTable.Controls.Add(btn);
                        break;
                    default:
                        btn.BackColor = Color.BlueViolet;
                        flpTable.Controls.Add(btn);
                        break;
                }

            }
        }
        private void loadTable(string text)
        {
            List<Table> ListTables = TableDAO.Instance.LoadTable(text);

            foreach (Table item in ListTables)
            {
                Button btn = new Button() { Width = TableDAO.BanWidth, Height = TableDAO.BanWidth };
                btn.Text = item.TabName + Environment.NewLine + item.Status;
                btn.Tag = item;
                btn.Name = item.ID.ToString();
                btn.Font = new Font("Arial", 18);
                btn.FlatStyle = FlatStyle.Standard;
                btn.Margin = new Padding(20);
                btn.ContextMenuStrip = cmsTable;
                btn.MouseHover += (s, e) =>
                {
                    btn.BackColor = Color.Orange;
                };
                btn.MouseLeave += (s, e) =>
                {
                    Table tb = TableDAO.Instance.GetTable(item.ID);
                    if (tb.Status == "Trống")
                        btn.BackColor = Color.White;
                    else
                        btn.BackColor = Color.BlueViolet;
                };
                btn.Click += (s, e) =>
                {
                    fBill_Info f = new fBill_Info(item, userName);
                    f.idShift = idShift;
                    f.parent = this;//Thiết lập ràng buộc với form con
                    f.btParent = btn;//Thiết lập ràng buộc với form con
                    f.Text = item.TabName;

                    f.ShowDialog();

                };
                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.White;
                        flpTable.Controls.Add(btn);
                        break;
                    default:
                        btn.BackColor = Color.BlueViolet;
                        flpTable.Controls.Add(btn);
                        break;
                }
            }
        }
        private void swapTable(int idTab1, int idTab2)
        {
            ListBillInfoDAO.Instance.switchTable(idTab1, idTab2);
        }

        private void MergeTable(int idTab1, int idTab2)
        {
            ListBillInfoDAO.Instance.MergeTable(idTab1, idTab2);
        }

        private bool isCloseShift(string user)
        {
            object ob = Provider.Instance.ExecuteScalar("SELECT COUNT(ID) FROM dbo.SHIFTWORK WHERE STATUSSHIFT = 0 AND USERNAMEOFSHIFT = @user ", new object[] { user });
            int count = int.Parse(ob.ToString());
            if (count > 0)
            {
                return false;
            }
            return true;
        }


        #endregion

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fBillManager frm = new fBillManager();
            frm.idShift = idShift;
            frm.formParent = this;
            Hide();
            frm.Show();

        }
    }
}
