using System.Data;

namespace QL_QuanCF.DataTransferObject
{
    public class Category
    {
        private int id;
        private string name;

        public Category()
        {
        }

        public Category(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public Category(DataRow row)
        {
            this.id = (int)row["ID"];
            this.name = row["NAMECATE"].ToString();
        }
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
    }
}
