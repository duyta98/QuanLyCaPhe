using QL_QuanCF.DataTransferObject;
using System.Collections.Generic;
using System.Data;

namespace QL_QuanCF.DataAccessObject
{
    public class FoodDAO
    {
        private static FoodDAO instance;

        public static FoodDAO Instance
        {
            get { if (instance == null) instance = new FoodDAO(); return FoodDAO.instance; }
            private set => instance = value;
        }

        public static int Height = 120;
        public static int Width = 120;

        private FoodDAO() { }

        public List<Food> LoadFoodLists()
        {
            List<Food> FoodLists = new List<Food>();
            DataTable dt = Provider.Instance.ExecuteQuery("dbo.spGetAllFood");
            foreach (DataRow dataRow in dt.Rows)
            {
                Food mon = new Food(dataRow);
                FoodLists.Add(mon);
            }
            return FoodLists;
        }
        /// <summary>
        /// Get all food by ID Cate
        /// </summary>
        /// <param name="id">ID category</param>
        /// <returns></returns>
        public List<Food> LoadFoodListsByIDCate(int id)
        {
            List<Food> FoodLists = new List<Food>();
            DataTable dt = Provider.Instance.ExecuteQuery("dbo.spGetAllFoodByIDCate " + id);
            foreach (DataRow dataRow in dt.Rows)
            {
                Food mon = new Food(dataRow);
                FoodLists.Add(mon);
            }
            return FoodLists;
        }

        public List<Food> LoadFoodListsBySearch(string text)
        {
            List<Food> FoodLists = new List<Food>();
            DataTable dt = Provider.Instance.ExecuteQuery("dbo.spGetAllFoodBySearch N'" + text + "'");
            foreach (DataRow dataRow in dt.Rows)
            {
                Food mon = new Food(dataRow);
                FoodLists.Add(mon);
            }
            return FoodLists;
        }
    }
}
