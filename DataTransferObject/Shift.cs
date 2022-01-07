using System;
using System.Data;

namespace QL_QuanCF.DataTransferObject
{
    public class Shift
    {
        private int idShift;
        private string userName;
        private double totalSales;
        private int status;
        private DateTime? dateIn;
        private DateTime? dateOut;
        public Shift()
        {
        }

        public Shift(int IdShift, string UserName, double TotalSales, int Status, DateTime DateIn, DateTime DateOut)
        {
            idShift = IdShift;
            userName = UserName;
            totalSales = TotalSales;
            status = Status;
            dateIn = DateIn;
            dateOut = DateOut;
        }
        public Shift(DataRow dr)
        {
            idShift = int.Parse(dr["ID"].ToString());
            userName = dr["USERNAMEOFSHIFT"].ToString();
            totalSales = double.Parse(dr["TOTALSALES"].ToString());
            status = int.Parse(dr["STATUSSHIFT"].ToString());
            dateIn = (DateTime)dr["SHIFTSTART"];
            if (dr["SHIFTEND"].ToString() != "")
                dateOut = (DateTime)dr["SHIFTEND"];
        }
        public int IdShift { get => idShift; set => idShift = value; }
        public string UserName { get => userName; set => userName = value; }
        public double TotalSales { get => totalSales; set => totalSales = value; }
        public int Status { get => status; set => status = value; }
        public DateTime? DateIn { get => dateIn; set => dateIn = value; }
        public DateTime? DateOut { get => dateOut; set => dateOut = value; }
    }
}
