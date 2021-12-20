using QL_QuanCF.DataTransferObject;
using System.Collections.Generic;
using System.Data;

namespace QL_QuanCF.DataAccessObject
{
    public class ListBillInfo
    {
        private static ListBillInfo instance;

        public ListBillInfo()
        {
        }

        public static ListBillInfo Instance
        {
            get { if (instance == null) instance = new ListBillInfo(); return instance; }
            private set => instance = value;
        }
        public List<ListBillInfoDTO> GetAllBillInfo(int idBill)
        {
            List<ListBillInfoDTO> lists = new List<ListBillInfoDTO>();
            DataTable dt = Provider.Instance.ExecuteQuery("spGetAllBillInfoByID " + idBill);
            foreach (DataRow item in dt.Rows)
            {
                ListBillInfoDTO BillInfo = new ListBillInfoDTO(item);
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
    }
}
