using System.Data;

namespace QL_QuanCF.DataTransferObject
{
    public class ShiftDTO
    {
        private int idShift;
        private string userName;
        private double totalSales;
        private int status;

        public ShiftDTO()
        {
        }

        public ShiftDTO(int IdShift, string UserName, double TotalSales, int Status)
        {
            idShift = IdShift;
            userName = UserName;
            totalSales = TotalSales;
            status = Status;
        }
        public ShiftDTO(DataRow dr)
        {
            idShift = int.Parse(dr[0].ToString());
            userName = dr[1].ToString();
            totalSales = double.Parse(dr[2].ToString());
            status = int.Parse(dr[3].ToString());
        }
        public int IdShift { get => idShift; set => idShift = value; }
        public string UserName { get => userName; set => userName = value; }
        public double TotalSales { get => totalSales; set => totalSales = value; }
        public int Status { get => status; set => status = value; }
    }
}
