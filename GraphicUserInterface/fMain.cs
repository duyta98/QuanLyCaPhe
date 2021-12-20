using QL_QuanCF.DataAccessObject;
using QL_QuanCF.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace QL_QuanCF
{
    public partial class fMain : Form
    {

        private string userName;
        public fMain(string user)
        {
            InitializeComponent();
            loadTable(1);
            userName = user;
        }


        #region Events
        private void btnReser_Click(object sender, EventArgs e)
        {
            flpBan.Controls.Clear();
            loadTable(4);
        }
        private void btnBar_Click(object sender, EventArgs e)
        {
            flpBan.Controls.Clear();
            loadTable(1);//1: Tại chỗ
        }

        private void btnTakeAway_Click(object sender, EventArgs e)
        {
            flpBan.Controls.Clear();
            loadTable(2);//2: Mang về
        }

        private void btnShip_Click(object sender, EventArgs e)
        {
            flpBan.Controls.Clear();
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
                    flpBan.Controls.Clear();
                    loadTable(txbTimkiem.Text);
                }
                else
                {
                    flpBan.Controls.Clear();
                    loadTable(1);//1: tại chỗ
                }
            }
        }

        private void ĐăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn đóng ca làm việc hay không?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                fShiftClose f = new fShiftClose();
                f.ShowDialog();
            }
            else if (dlr == DialogResult.No)
            {
                this.Close();
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
        #endregion
        
        #region Method
        public void loadTable(int tabType)//tabType = 1: tại chỗ, 2: Mang về, 3: Đặt chỗ, 4: Giao hàng
        {
            flpBan.Controls.Clear();
            List<TableDTO> DSBan = Table.Instance.LoadTable(tabType);
            
            foreach (TableDTO item in DSBan)
            {
                Button btn = new Button() { Width = Table.BanWidth, Height = Table.BanWidth };
                btn.Text = item.TabName + Environment.NewLine + item.Status;
                btn.Tag = item;
                btn.Font = new Font("Arial", 18);
                btn.FlatStyle = FlatStyle.Standard;
                btn.Margin = new Padding(20);
                btn.MouseHover += (s, e) =>
                {
                    btn.BackColor = Color.Yellow;
                };
                btn.MouseLeave += (s, e) =>
                {
                    if(item.Status == "Trống")
                        btn.BackColor = Color.White;
                    else
                        btn.BackColor = Color.BlueViolet;
                };
                btn.Click += (s, e) =>
                
                {
                    fBill_Info f = new fBill_Info(item,userName);
                    f.parent = this;//Thiết lập ràng buộc với form con
                    f.btParent = btn;//Thiết lập ràng buộc với form con
                    f.Text = item.TabName;
                    f.ShowDialog();
                    
                };
                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.White;
                        flpBan.Controls.Add(btn);
                        break;
                    default:
                        btn.BackColor = Color.BlueViolet;
                        flpBan.Controls.Add(btn);
                        break;
                }

            }  
        }
        private void loadTable(string text)
        {
            List<TableDTO> DSBan = Table.Instance.LoadTable(text);

            foreach (TableDTO item in DSBan)
            {
                Button btn = new Button() { Width = Table.BanWidth, Height = Table.BanWidth };
                btn.Text = item.TabName + Environment.NewLine + item.Status;

                btn.Tag = item;

                btn.FlatStyle = FlatStyle.Standard;
                btn.Margin = new Padding(20);
                btn.Font = new Font("Arial", 18);
                btn.Click += (s, e) =>
                {
                    fBill_Info f = new fBill_Info(item,userName);
                    f.ShowDialog();
                };
                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.White;
                        flpBan.Controls.Add(btn);
                        break;
                    default:
                        btn.BackColor = Color.BlueViolet;
                        flpBan.Controls.Add(btn);
                        break;
                }

            }
        }
        #endregion
    }
}
