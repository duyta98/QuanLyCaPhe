using System;
using System.Data;

namespace QL_QuanCF.DataTransferObject
{
    public class BillCheckOut : Bill
    {
        private int pos;
        private string nameTab;
        private string nameAcc;
        private float promoPercent;
        private DateTime? dateIn;
        private DateTime? dateOut;
        private int status;

        public BillCheckOut(DataRow dataRow)
        {
            pos = int.Parse(dataRow[0].ToString());
            ID = int.Parse(dataRow[1].ToString());
            nameTab = dataRow[2].ToString();
            nameAcc = dataRow[3].ToString();
            if (dataRow[4].ToString() != "")
            {
                promoPercent = float.Parse(dataRow[4].ToString());
            }
            Amount = double.Parse(dataRow[5].ToString());
            dateIn = (DateTime)dataRow[6];
            dateOut = (DateTime)dataRow[7];
            status = int.Parse(dataRow[8].ToString());
        }

        public BillCheckOut(int pos, string nameTab, string nameAcc, float promoPercent, DateTime? dateIn, DateTime? dateOut, int status)
        {
            this.pos = pos;
            this.nameTab = nameTab;
            this.nameAcc = nameAcc;
            this.promoPercent = promoPercent;
            this.dateIn = dateIn;
            this.dateOut = dateOut;
            this.status = status;
        }

        public string NameTab { get => nameTab; set => nameTab = value; }
        public string NameAcc { get => nameAcc; set => nameAcc = value; }
        public float PromoPercent { get => promoPercent; set => promoPercent = value; }
        public int Pos { get => pos; set => pos = value; }
        public DateTime? DateIn { get => dateIn; set => dateIn = value; }
        public DateTime? DateOut { get => dateOut; set => dateOut = value; }
        public new int Status { get => status; set => status = value; }
    }
}
