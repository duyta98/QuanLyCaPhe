using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_QuanCF.DataTransferObject
{
    public class CategoryDTO
    {
        private int id;
        private string name;

        public CategoryDTO()
        {
        }

        public CategoryDTO(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public CategoryDTO(DataRow row)
        {
            this.id = (int)row["ID"];
            this.name = row["NAMECATE"].ToString();
        }
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
    }
}
