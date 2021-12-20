using QL_QuanCF.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_QuanCF.DataAccessObject
{
    public class Category
    {
        private static Category instance;

        public Category()
        {
        }

        public static Category Instance
        {
            get { if (instance == null) instance = new Category(); return Category.instance; } 
            private set { instance = value; }
        }
        public List<CategoryDTO> GetCategoryDTOs()
        {
            List<CategoryDTO> categoryDTOs = new List<CategoryDTO>();
            string query = "SELECT * FROM dbo.FOODCATEGORY";
            DataTable dt = Provider.Instance.ExecuteQuery(query);
            foreach (DataRow item in dt.Rows)
            {
                CategoryDTO category = new CategoryDTO(item);
                categoryDTOs.Add(category);
            }
            return categoryDTOs;
        }
    }
}
