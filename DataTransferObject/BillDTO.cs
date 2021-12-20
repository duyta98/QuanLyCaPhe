using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_QuanCF.DataTransferObject
{
    public class BillDTO
    {
        private int id;
        private DateTime? checkIn;//(?) allow null
        private DateTime? checkOut;
        private int idTable;
        private string idAcc;
        private double amount;
        private int status;

        public BillDTO(DataRow dataRow )
        {
            id = (int)dataRow["ID"];
            checkIn = (DateTime)dataRow["DATECHECKIN"];
            if(dataRow["DATECHECKOUT"].ToString() != "")
                checkOut = (DateTime)dataRow["DATECHECKOUT"];
            idTable = (int)dataRow["IDTAB"];
            idAcc = dataRow["IDACC"].ToString();
            amount = double.Parse(dataRow["AMOUNT"].ToString());
            status = (int)dataRow["STATUSBILL"];
        }

        public BillDTO(int ID, DateTime? checkIn, DateTime? checkOut, int idTable, string idAcc, double amount, int status)
        {
            this.id = ID;
            this.checkIn = checkIn;
            this.checkOut = checkOut;
            this.idTable = idTable;
            this.idAcc = idAcc;
            this.amount = amount;
            this.status = status;
        }

        public int ID { get => id; set => id = value; }
        public DateTime? CheckIn { get => checkIn; set => checkIn = value; }
        public DateTime? CheckOut { get => checkOut; set => checkOut = value; }
        public int IdTable { get => idTable; set => idTable = value; }
        public string IdAcc { get => idAcc; set => idAcc = value; }
        public double Amount { get => amount; set => amount = value; }
        public int Status { get => status; set => status = value; }
    }
}
