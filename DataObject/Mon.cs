using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_QuanCF.DataObject
{
    public class Mon
    {
        private string maMon;
        private string tenMon;
        private string dVT;
        private int gia;
        private string maLoaiMon;

        public string MaMon { get => maMon; set => maMon = value; }
        public string TenMon { get => tenMon; set => tenMon = value; }
        public string DVT { get => dVT; set => dVT = value; }
        public int Gia { get => gia; set => gia = value; }
        public string MaLoaiMon { get => maLoaiMon; set => maLoaiMon = value; }

        public Mon(string mamon, string tenmon, string dvt, int gia, string maloai)
        {
            this.MaMon = maloai;
            this.TenMon = tenmon;
            this.DVT = dvt;
            this.Gia = gia;
            this.MaLoaiMon = maloai;
        }

        public Mon(DataRow dr)
        {
            this.MaMon = dr[0].ToString();
            this.TenMon = dr[1].ToString();
            this.DVT = dr[2].ToString();
            this.Gia = (int)dr[3];
            this.MaLoaiMon = dr[4].ToString();
        }
    }
}
