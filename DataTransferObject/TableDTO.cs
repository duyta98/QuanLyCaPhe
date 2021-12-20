using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_QuanCF.DataTransferObject
{
    public class TableDTO
    {
        public int ID { get => id; set => id = value; }
        public string TabName { get => tabName; set => tabName = value; }
        public string Status { get => status; set => status = value; }
        public int TabType { get => tabType; set => tabType = value; }
        public int Amount { get => amount; set => amount = value; }

        private string tabName;
        private string status;
        private int id;
        private int tabType;
        private int amount;
        

        public TableDTO(DataRow dr)
        {
            id = int.Parse(dr[0].ToString());
            tabName =dr[1].ToString();
            status = dr[2].ToString();
            tabType = int.Parse(dr[3].ToString());
            amount = int.Parse(dr[4].ToString());
        }

        public TableDTO(string tabName, string status, int id, int tabType, int amount)
        {
            this.tabName = tabName;
            this.status = status;
            this.id = id;
            this.tabType = tabType;
            this.amount = amount;
        }
    }
}
