using QL_QuanCF.Connections;
using QL_QuanCF.DataObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_QuanCF.DuLieu
{
    public class BanDTO
    {
        private static BanDTO instance;

        public static BanDTO Instance
        {
            get { if (instance == null) instance = new BanDTO(); return BanDTO.instance; }
            private set => instance = value;
        }

        public static int BanHeight = 150;
        public static int BanWidth = 150;

        private BanDTO() { }

        public List<Ban> LoadDanhSachBan()
        {
            List<Ban> DSBan = new List<Ban>();
            DataTable dt = Provider.Instance.ExecuteQuery("dbo.USP_GetTableList");
            foreach (DataRow dataRow in dt.Rows)
            {
                Ban ban = new Ban(dataRow);
                DSBan.Add(ban);
            }
            return DSBan;
        }
    }
}
