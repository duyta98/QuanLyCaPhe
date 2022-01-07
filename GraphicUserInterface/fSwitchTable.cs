using QL_QuanCF.DataAccessObject;
using QL_QuanCF.DataTransferObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_QuanCF.GraphicUserInterface
{
    public partial class fSwitchTable : Form
    {
        public fMain parent;
        private int methodID;
        public fSwitchTable(int MethodID)
        {
            InitializeComponent();
            methodID = MethodID;
        }
        public void loadTable(int tabType)//tabType = 1: tại chỗ, 2: Mang về, 3: Đặt chỗ, 4: Giao hàng
        {
            flpTable.Controls.Clear();
            List<Table> DSBan = TableDAO.Instance.LoadTable(tabType);

            foreach (Table item in DSBan)
            {
                
                Button btn = new Button() { Width = TableDAO.BanWidth, Height = TableDAO.BanWidth };
                btn.Text = item.TabName + Environment.NewLine + item.Status;
                btn.Tag = item;
                btn.Name = item.ID.ToString();
                btn.Font = new Font("Arial", 18);
                btn.FlatStyle = FlatStyle.Standard;
                btn.Margin = new Padding(20);
                btn.MouseHover += (s, e) =>
                {
                    btn.BackColor = Color.Yellow;
                };
                btn.MouseLeave += (s, e) =>
                {
                    if (item.Status == "Trống")
                        btn.BackColor = Color.White;
                    else
                        btn.BackColor = Color.BlueViolet;
                };
                btn.Click += (s, e) =>
                {
                    parent.btn2 = btn;
                    Close();
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
                if (btn.Text.Contains(parent.btn1.Text))
                    flpTable.Controls.Remove(btn);
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
                
                btn.MouseHover += (s, e) =>
                {
                    btn.BackColor = Color.Yellow;
                };
                btn.MouseLeave += (s, e) =>
                {
                    if (item.Status == "Trống")
                        btn.BackColor = Color.White;
                    else
                        btn.BackColor = Color.BlueViolet;
                };
                btn.Click += (s, e) =>
                {
                    parent.btn2 = btn;
                    Close();
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
                if (btn.Text.Contains(parent.btn1.Text))
                    flpTable.Controls.Remove(btn);
            }
            
        }
        public void LoadCheckInTable()
        {
            List<Table> DSBan = TableDAO.Instance.LoadTableUnCheckOut();

            foreach (Table item in DSBan)
            {
                Button btn = new Button() { Width = TableDAO.BanWidth, Height = TableDAO.BanWidth };
                btn.Text = item.TabName + Environment.NewLine + item.Status;
                btn.Tag = item;
                btn.Name = item.ID.ToString();
                btn.Font = new Font("Arial", 18);
                btn.FlatStyle = FlatStyle.Standard;
                btn.Margin = new Padding(20);

                btn.MouseHover += (s, e) =>
                {
                    btn.BackColor = Color.Yellow;
                };
                btn.MouseLeave += (s, e) =>
                {
                    if (item.Status == "Trống")
                        btn.BackColor = Color.White;
                    else
                        btn.BackColor = Color.BlueViolet;
                };
                btn.Click += (s, e) =>
                {
                    parent.btn2 = btn;
                    Close();
                };
                switch (item.Status)
                {
                    case "Có người":
                        btn.BackColor = Color.BlueViolet;
                        flpTable.Controls.Add(btn);
                        break;
                    default:
                        btn.BackColor = Color.White;
                        break;
                }
                if (btn.Text.Contains(parent.btn1.Text))
                    flpTable.Controls.Remove(btn);
            }

        }
        private void loadccbTabType()
        {
            DataTable dt = Provider.Instance.ExecuteQuery("SELECT * FROM dbo.TABTYPE");
            cbbTabType.DataSource = dt;
            cbbTabType.DisplayMember = "NAMETYPE";
            cbbTabType.ValueMember = "ID";
        }
        private void fSwitchTable_Load(object sender, EventArgs e)
        {
            switch (methodID)//1: chuyển bàn, 2: Gộp bàn
            {
                case 1:
                    loadTable(1);
                    break;
                case 2:
                    LoadCheckInTable();
                    break;
                default:
                    break;
            }
            
            loadccbTabType();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            loadTable(txtSearch.Text.Trim());
        }

        private void btnSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(sender, e);
            }    
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbbTabType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            loadTable(int.Parse(cbbTabType.SelectedValue.ToString()));
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loadTable(txtSearch.Text.Trim());
            }
        }
    }
}
