using System;
using System.Collections.Generic;
using System.Data;

namespace QL_QuanCF.DataTransferObject
{
    public class Food
    {
        private string idFood;
        private string nameFood;
        private string unit;
        private double price;
        private string idCate;

        public Food()
        {
        }

        public Food(DataRow dr)
        {
            idFood = dr[0].ToString();
            nameFood = dr[1].ToString();
            idCate = dr[2].ToString();
            price = Double.Parse(dr[3].ToString());
            unit = dr[4].ToString();
        }

        public Food(string idFood, string nameFood, string unit, int price, string idCate)
        {
            this.idFood = idFood;
            this.nameFood = nameFood;
            this.unit = unit;
            this.price = price;
            this.idCate = idCate;
        }

        public string IdFood { get => idFood; set => idFood = value; }
        public string NameFood { get => nameFood; set => nameFood = value; }
        public string Unit { get => unit; set => unit = value; }
        public double Price { get => price; set => price = value; }
        public string IdCate { get => idCate; set => idCate = value; }

        public static implicit operator List<object>(Food v)
        {
            throw new NotImplementedException();
        }
    }
}
