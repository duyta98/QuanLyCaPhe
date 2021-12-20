using QL_QuanCF.DataTransferObject;
using System.Collections.Generic;
using System.Data;

namespace QL_QuanCF.DataAccessObject
{
    public class Food
    {
        private static Food instance;

        public static Food Instance
        {
            get { if (instance == null) instance = new Food(); return Food.instance; }
            private set => instance = value;
        }

        public static int Height = 120;
        public static int Width = 120;

        private Food() { }

        public List<FoodDTO> LoadFoodLists()
        {
            List<FoodDTO> FoodLists = new List<FoodDTO>();
            DataTable dt = Provider.Instance.ExecuteQuery("dbo.spGetAllFood");
            foreach (DataRow dataRow in dt.Rows)
            {
                FoodDTO mon = new FoodDTO(dataRow);
                FoodLists.Add(mon);
            }
            return FoodLists;
        }
        /// <summary>
        /// Get all food by ID Cate
        /// </summary>
        /// <param name="id">ID category</param>
        /// <returns></returns>
        public List<FoodDTO> LoadFoodListsByIDCate(int id)
        {
            List<FoodDTO> FoodLists = new List<FoodDTO>();
            DataTable dt = Provider.Instance.ExecuteQuery("dbo.spGetAllFoodByIDCate "+id);
            foreach (DataRow dataRow in dt.Rows)
            {
                FoodDTO mon = new FoodDTO(dataRow);
                FoodLists.Add(mon);
            }
            return FoodLists;
        }

        public List<FoodDTO> LoadFoodListsBySearch(string text)
        {
            List<FoodDTO> FoodLists = new List<FoodDTO>();
            DataTable dt = Provider.Instance.ExecuteQuery("dbo.spGetAllFoodBySearch N'" + text + "'");
            foreach (DataRow dataRow in dt.Rows)
            {
                FoodDTO mon = new FoodDTO(dataRow);
                FoodLists.Add(mon);
            }
            return FoodLists;
        }
    }
}
