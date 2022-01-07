using QL_QuanCF.DataTransferObject;
using System.Collections.Generic;
using System.Data;

namespace QL_QuanCF.DataAccessObject
{
    public class ListBillInfoDAO
    {
        private static ListBillInfoDAO instance;

        public ListBillInfoDAO()
        {
        }

        public static ListBillInfoDAO Instance
        {
            get { if (instance == null) instance = new ListBillInfoDAO(); return instance; }
            private set => instance = value;
        }
        public List<ListBillInfo> GetAllBillInfo(int idBill)
        {
            List<ListBillInfo> lists = new List<ListBillInfo>();
            DataTable dt = Provider.Instance.ExecuteQuery("spGetAllBillInfoByID " + idBill);
            foreach (DataRow item in dt.Rows)
            {
                ListBillInfo BillInfo = new ListBillInfo(item);
                lists.Add(BillInfo);
            }
            return lists;
        }
        public void insertBillInfo(int idBill, int idFood, int count)
        {
            Provider.Instance.ExecuteNonQuery("spInsertBillInfo @idBill , @idFood , @count", new object[] { idBill, idFood, count });
        }
        public void dellAllBillInfo(int idBill)
        {
            Provider.Instance.ExecuteNonQuery("spDelAllBillInfo @idBill", new object[] { idBill });
        }
        public void switchTable(int idTab1, int idTab2)
        {
            Provider.Instance.ExecuteNonQuery("uspSwitchTable @idTab1 , @idTab2", new object[] { idTab1,idTab2 });
        }
        public void MergeTable(int idTab1, int idTab2)
        {
            Provider.Instance.ExecuteNonQuery("uspMergeTable @idTab1 , @idTab2", new object[] { idTab1, idTab2 });
        }
    }
}
