using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_QuanCF.DataObject
{
    public class Ban
    {
        

        public float ID { get => iD; set => iD = value; }
        public int SoBan { get => soBan; set => soBan = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }

        private int soBan;

        private string trangThai;

        private float iD;
        public Ban(float id, int soban, string trangthai)
        {
            this.ID = id;
            this.SoBan = soban;
            this.TrangThai = trangthai;
        }

        public Ban(DataRow dr)
        {
            this.ID = (float)Convert.ToDouble(dr[0]);
            this.SoBan =(int)dr[1];
            this.TrangThai = dr[2].ToString();
        }
    }
}
