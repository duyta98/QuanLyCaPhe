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

        /// <summary>
        /// Get all food by ID Cate
        /// </summary>
        /// <param name="id">ID category</param>
        /// <returns></returns>
        
        
        /// <summary>
        /// Get Food list using query with parameter can null
        /// </summary>
        /// <param name="query">Query String </param>
        /// <param name="parameter">list parameter</param>
        /// <returns></returns>
        public List<Food> LoadFoodLists(string query, object[] parameter = null)
        {
            List<Food> FoodLists = new List<Food>();
            DataTable dt = Provider.Instance.ExecuteQuery(query, parameter);
            foreach (DataRow dataRow in dt.Rows)
            {
                Food food = new Food(dataRow);
                FoodLists.Add(food);
            }
            return FoodLists;
        }
        public List<FoodManagerObject> LoadFoodListForManager(string query, object[] parameter = null)
        {
            List<FoodManagerObject> FoodLists = new List<FoodManagerObject>();
            DataTable dt = Provider.Instance.ExecuteQuery(query, parameter);
            foreach (DataRow dataRow in dt.Rows)
            {
                FoodManagerObject food = new FoodManagerObject(dataRow);
                FoodLists.Add(food);
            }
            return FoodLists;
        }
    }
}
