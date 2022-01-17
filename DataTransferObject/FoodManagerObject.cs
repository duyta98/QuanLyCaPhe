using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_QuanCF.DataTransferObject
{
    public class FoodManagerObject : Food
    {
        private string nameUnit;
        private double cost;
        public FoodManagerObject()
        {
        }

        public FoodManagerObject(string nameUnit)
        {
            this.nameUnit = nameUnit;
        }

        public FoodManagerObject(DataRow dataRow)
        {
            NameUnit = dataRow["NAME"].ToString();
            IdFood = dataRow["ID"].ToString();
            NameFood = dataRow["NAMEFOOD"].ToString();
            IdCate = int.Parse(dataRow["IDCATE"].ToString());
            Cost = double.Parse(dataRow["COST"].ToString());
            Price = double.Parse(dataRow["PRICE"].ToString());
            if (dataRow["AVATAR"].ToString() != "")
            {
                AvatarDir = dataRow["AVATAR"].ToString();
            }
        }
        public string NameUnit { get => nameUnit; set => nameUnit = value; }
        public double Cost { get => cost; set => cost = value; }
    }
}
