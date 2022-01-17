using QL_QuanCF.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_QuanCF.DataAccessObject
{
    public class StaffDAO
    {
        private static StaffDAO instance;

        public static StaffDAO Instance
        {
            get { if (instance == null) instance = new StaffDAO(); return instance; }
            private set { instance = value; }
        }
        private StaffDAO() { }
        public List<Staff> loadAllStaff(string query, object[] parameter = null)
        {
            List<Staff> list = new List<Staff>();
            DataTable dt = Provider.Instance.ExecuteQuery(query,parameter);
            foreach (DataRow item in dt.Rows)
            {
                Staff staff = new Staff(item);
                list.Add(staff);
            }
            return list;
        }
        
    }
}
