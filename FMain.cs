using QL_QuanCF.Connections;
using QL_QuanCF.DataObject;
using QL_QuanCF.DuLieu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_QuanCF
{
    public partial class FMain : Form
    {
        public object DataTable { get; private set; }

        public FMain()
        {
            InitializeComponent();
            loadTable();
        }


        #region Events
        //private void TxbTimkiem_Enter(object sender, EventArgs e)
        //{
        //    string sqlString = "SELECT * FROM	dbo.BAN  WHERE SOBAN = @soban ";
        //    DataTable dt = Provider.Instance.ExecuteQuery(sqlString,new object[] { txbTimkiem.Text});

        //}




        private void ĐăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn đóng ca làm việc hay không?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                FKetca f = new FKetca();
                f.ShowDialog();
            }
            else if (dlr == DialogResult.No)
            {
                this.Close();
            }
        }

        private void BtnThemban_Click(object sender, EventArgs e)
        {
            FThemBan fThem = new FThemBan();
            fThem.ShowDialog();
        }

        private void ThôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FThongTinTK f = new FThongTinTK();
            f.ShowDialog();
        }

        private void NhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FNhanVien f = new FNhanVien();
            f.ShowDialog();
        }

        private void ThựcĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FThucDon f = new FThucDon();
            f.ShowDialog();
        }
        #endregion
        #region Method
        void loadTable()
        {
            List<Ban> DSBan = new List<Ban>();
            DSBan = BanDTO.Instance.LoadDanhSachBan();
            foreach (Ban item in DSBan)
            {
                Button btn = new Button() { Width = BanDTO.BanWidth, Height = BanDTO.BanWidth };
                btn.Text = item.SoBan + Environment.NewLine + item.TrangThai;
                
                btn.FlatStyle = FlatStyle.Flat;
                btn.Margin = new Padding(7,7,7,7);
                switch (item.TrangThai)
                {
                    case "Trống":
                        btn.BackColor = Color.White;
                        break;
                    default:
                        btn.BackColor = Color.Chocolate;
                        flpBan.Controls.Add(btn);
                        break;
                }
                 
            }
        }
        void loadTable(int soban)
        {
            List<Ban> DSBan = new List<Ban>();
            DSBan = BanDTO.Instance.LoadDanhSachBan();
            int i = 0;
            foreach (Ban item in DSBan)
            {
                Button btn = new Button() { Width = BanDTO.BanWidth, Height = BanDTO.BanWidth };
                btn.Text = item.SoBan + Environment.NewLine + item.TrangThai;

                btn.FlatStyle = FlatStyle.Flat;
                btn.Margin = new Padding(7, 7, 7, 7);
                
                if (item.SoBan == soban)
                {
                        btn.BackColor = Color.Chocolate;
                        flpBan.Controls.Add(btn);
                        i++;
                        break;
                }

            }
        }






        #endregion

        private void TxbTimkiem_MouseClick(object sender, MouseEventArgs e)
        {
            txbTimkiem.Text = null;
        }

        //private void TxbTimkiem_KeyUp(object sender, KeyEventArgs e)
        //{
        //    string sqlString = "SELECT * FROM	dbo.BAN  WHERE SOBAN = @soban ";
        //    DataTable dt = Provider.Instance.ExecuteQuery(sqlString,new object[] { txbTimkiem.Text});
        //    int soBanTim = 0;
            
        //    foreach (DataRow item in dt.Rows)
        //    {
        //        if(item != null)
        //            soBanTim = (int)item[1];
        //    }
        //    loadTable(soBanTim);
        //}
    }
}
