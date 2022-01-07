using QL_QuanCF.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_QuanCF.DataAccessObject
{
    public class CategoryDAO
    {
        private static CategoryDAO instance;

        public CategoryDAO()
        {
        }

        public static CategoryDAO Instance
        {
            get { if (instance == null) instance = new CategoryDAO(); return CategoryDAO.instance; } 
            private set { instance = value; }
        }
        public List<Category> GetCategoryDTOs()
        {
            List<Category> categoryDTOs = new List<Category>();
            string query = "SELECT * FROM dbo.FOODCATEGORY";
            DataTable dt = Provider.Instance.ExecuteQuery(query);
            foreach (DataRow item in dt.Rows)
            {
                Category category = new Category(item);
                categoryDTOs.Add(category);
            }
            return categoryDTOs;
        }
    }
}
