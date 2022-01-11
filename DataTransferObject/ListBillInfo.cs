using System.Data;

namespace QL_QuanCF.DataTransferObject
{
    public class ListBillInfo
    {
        private int id;
        private string name;
        private int quantity;
        private double price;

        public ListBillInfo()
        {
        }

        public ListBillInfo(int id, string name, int quantity, double price)
        {
            this.id = id;
            this.name = name;
            this.quantity = quantity;
            this.price = price;
        }

        public string Name { get => name; set => name = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public double Price { get => price; set => price = value; }
        public int Id { get => id; set => id = value; }

        public ListBillInfo(DataRow row)
        {
            id = int.Parse(row[0].ToString());
            name = row[1].ToString();
            quantity = int.Parse(row[2].ToString());
            price = double.Parse(row[3].ToString());
        }


    }
}
