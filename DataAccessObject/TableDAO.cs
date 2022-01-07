using QL_QuanCF.DataTransferObject;
using System.Collections.Generic;
using System.Data;

namespace QL_QuanCF.DataAccessObject
{
    public class TableDAO
    {
        private static TableDAO instance;

        public static TableDAO Instance
        {
            get { if (instance == null) instance = new TableDAO(); return instance; }
            private set => instance = value;
        }

        public static int BanHeight = 150;
        public static int BanWidth = 150;

        private TableDAO() { }
        /// <summary>
        /// get all table by Type
        /// </summary>
        /// <param name="tabType"></param>
        /// <returns></returns>
        public List<Table> LoadTable(int tabType)
        {
            List<Table> DSBan = new List<Table>();
            DataTable dt = Provider.Instance.ExecuteQuery("spGetTableListByType " + tabType);
            foreach (DataRow dataRow in dt.Rows)
            {
                Table ban = new Table(dataRow);
                DSBan.Add(ban);
            }
            return DSBan;
        }
        public List<Table> LoadTableUnCheckOut()
        {
            List<Table> DSBan = new List<Table>();
            DataTable dt = Provider.Instance.ExecuteQuery("uspGetTableUnCheckOut");
            foreach (DataRow dataRow in dt.Rows)
            {
                Table ban = new Table(dataRow);
                DSBan.Add(ban);
            }
            return DSBan;
        }
        /// <summary>
        /// Get all table by input string
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public List<Table> LoadTable(string input)
        {
            List<Table> DSBan = new List<Table>();
            DataTable dt = Provider.Instance.ExecuteQuery("uspGetTableByName " + input);
            foreach (DataRow dataRow in dt.Rows)
            {
                Table ban = new Table(dataRow);
                DSBan.Add(ban);
            }
            return DSBan;
        }
        public void updateTableWhenCreateBill(int amountPeople, int idTable)
        {
            Provider.Instance.ExecuteNonQuery("EXEC spUpdateTabWhenCreateBill @tabCountPeople , @idTab", new object[] { amountPeople, idTable });
        }
        public Table GetTable(int id)
        {
            DataTable dt = Provider.Instance.ExecuteQuery("SELECT * FROM dbo.TAB WHERE ID = @id", new object[] { id });
            Table tb = new Table();
            if (dt.Rows.Count > 0)
            {
                tb = new Table(dt.Rows[0]);
            }
            return tb;
        }
    }
}
