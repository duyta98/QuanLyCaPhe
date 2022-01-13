using QL_QuanCF.DataTransferObject;
using System.Collections.Generic;
using System.Data;

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
        public List<Category> GetCategory()
        {
            List<Category> categorys = new List<Category>();
            string query = "SELECT * FROM dbo.FOODCATEGORY";
            DataTable dt = Provider.Instance.ExecuteQuery(query);
            foreach (DataRow item in dt.Rows)
            {
                Category category = new Category(item);
                categorys.Add(category);
            }
            return categorys;
        }
    }
}
