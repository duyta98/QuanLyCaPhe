using QL_QuanCF.DataTransferObject;
using System.Collections.Generic;
using System.Data;

namespace QL_QuanCF.DataAccessObject
{
    public class Table
    {
        private static Table instance;

        public static Table Instance
        {
            get { if (instance == null) instance = new Table(); return instance; }
            private set => instance = value;
        }

        public static int BanHeight = 150;
        public static int BanWidth = 150;

        private Table() { }
        /// <summary>
        /// get all table by Type
        /// </summary>
        /// <param name="tabType"></param>
        /// <returns></returns>
        public List<TableDTO> LoadTable(int tabType)
        {
            List<TableDTO> DSBan = new List<TableDTO>();
            DataTable dt = Provider.Instance.ExecuteQuery("dbo.spGetTableList " + tabType);
            foreach (DataRow dataRow in dt.Rows)
            {
                TableDTO ban = new TableDTO(dataRow);
                DSBan.Add(ban);
            }
            return DSBan;
        }
        /// <summary>
        /// Get all table by input string
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public List<TableDTO> LoadTable(string input)
        {
            List<TableDTO> DSBan = new List<TableDTO>();
            DataTable dt = Provider.Instance.ExecuteQuery("dbo.spSearchTable " + input);
            foreach (DataRow dataRow in dt.Rows)
            {
                TableDTO ban = new TableDTO(dataRow);
                DSBan.Add(ban);
            }
            return DSBan;
        }
        public void updateTableWhenCreateBill(int amountPeople, int idTable)
        {
            Provider.Instance.ExecuteNonQuery("EXEC spUpdateTabWhenCreateBill @tabCountPeople , @idTab", new object[] { amountPeople, idTable });
        }
    }
}
