using QL_QuanCF.Connections;
using QL_QuanCF.DataObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_QuanCF.DataAccessObject
{
    public class MonDTO
    {
        private static MonDTO instance;

        public static MonDTO Instance
        {
            get { if (instance == null) instance = new MonDTO(); return MonDTO.instance; }
            private set => instance = value;
        }

        public static int BanHeight = 150;
        public static int BanWidth = 150;

        private MonDTO() { }

        public List<Mon> LoadDanhSachBan()
        {
            List<Mon> DSMon = new List<Mon>();
            DataTable dt = Provider.Instance.ExecuteQuery("dbo.USP_GetTableList");
            foreach (DataRow dataRow in dt.Rows)
            {
                Mon mon = new Mon(dataRow);
                DSMon.Add(mon);
            }
            return DSMon;
        }
    }
}
