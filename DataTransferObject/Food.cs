using System;
using System.Collections.Generic;
using System.Data;

namespace QL_QuanCF.DataTransferObject
{
    public class Food
    {
        private string idFood;
        private string nameFood;
        private int unit;
        private double price;
        private int idCate;
        private string avatarDir;

        public Food()
        {
        }

        public Food(DataRow dr)
        {
            idFood = dr["ID"].ToString();
            nameFood = dr["NAMEFOOD"].ToString();
            idCate = int.Parse(dr["IDCATE"].ToString());
            
            
            price = double.Parse(dr["PRICE"].ToString());
            unit = int.Parse(dr["UNIT"].ToString());
            if (dr["AVATAR"].ToString()!="")
            {
                avatarDir = dr["AVATAR"].ToString();
            }
        }

        public Food(string idFood, string nameFood, int unit, double price, int idCate, string avatarDir)
        {
            this.idFood = idFood;
            this.nameFood = nameFood;
            this.unit = unit;
            this.price = price;
            this.idCate = idCate;
            this.avatarDir = avatarDir;
        }

        public string IdFood { get => idFood; set => idFood = value; }
        public string NameFood { get => nameFood; set => nameFood = value; }
        public int Unit { get => unit; set => unit = value; }
        public double Price { get => price; set => price = value; }
        public int IdCate { get => idCate; set => idCate = value; }
        public string AvatarDir { get => avatarDir; set => avatarDir = value; }
    }
}
