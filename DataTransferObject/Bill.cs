using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_QuanCF.DataTransferObject
{
    public class Bill
    {
        private int id;
        private DateTime? checkIn;//(?) allow null
        private DateTime? checkOut;
        private int idTable;
        private string idAcc;
        private double amount;
        private int status;
        private int idPromotion;
        private int idShift;

        public Bill(DataRow dataRow )
        {
            id = (int)dataRow["ID"];
            checkIn = (DateTime)dataRow["DATECHECKIN"];
            if(dataRow["DATECHECKOUT"].ToString() != "")
                checkOut = (DateTime)dataRow["DATECHECKOUT"];
            idTable = (int)dataRow["IDTAB"];
            idAcc = dataRow["IDACC"].ToString();
            amount = double.Parse(dataRow["AMOUNT"].ToString());
            status = (int)dataRow["STATUSBILL"];
            if (dataRow["IDPROMOTION"].ToString() != "")
                idPromotion = int.Parse(dataRow["IDPROMOTION"].ToString());
            if (dataRow["IDSHIFT"].ToString() != "")
                idShift = (int)dataRow["IDSHIFT"];
        }

        public Bill(int ID, DateTime? checkIn, DateTime? checkOut, int idTable, string idAcc, double amount, int status, int idShift)
        {
            id = ID;
            this.checkIn = checkIn;
            this.checkOut = checkOut;
            this.idTable = idTable;
            this.idAcc = idAcc;
            this.amount = amount;
            this.status = status;
            this.idShift = idShift;
        }

        public int ID { get => id; set => id = value; }
        public DateTime? CheckIn { get => checkIn; set => checkIn = value; }
        public DateTime? CheckOut { get => checkOut; set => checkOut = value; }
        public int IdTable { get => idTable; set => idTable = value; }
        public string IdAcc { get => idAcc; set => idAcc = value; }
        public double Amount { get => amount; set => amount = value; }
        public int Status { get => status; set => status = value; }
        public int IdPromotion { get => idPromotion; set => idPromotion = value; }
        public int IdShift { get => idShift; set => idShift = value; }
    }
}
