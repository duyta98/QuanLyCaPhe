using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_QuanCF.DataTransferObject
{
    public class BillInfoCheckOut : ListBillInfo
    {
        private int pos;
        private double amount;

        public BillInfoCheckOut(int pos, double amount)
        {
            this.pos = pos;
            this.amount = amount;
        }
        public BillInfoCheckOut(DataRow dataRow)
        {
            Pos = int.Parse(dataRow[0].ToString());
            Name = dataRow[1].ToString();
            Quantity = int.Parse(dataRow[2].ToString());
            Price = double.Parse(dataRow[3].ToString());
            Amount = double.Parse(dataRow[4].ToString());

        }
        public int Pos { get => pos; set => pos = value; }
        public double Amount { get => amount; set => amount = value; }
    }
}
