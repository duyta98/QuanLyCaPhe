using QL_QuanCF.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_QuanCF.DataAccessObject
{
    public class ShiftDAO
    {
        private static ShiftDAO instance;

        public ShiftDAO()
        {
        }

        public static ShiftDAO Instance 
        {
            get { if (instance == null) instance = new ShiftDAO(); return instance; }
            private set { instance = value; }
        }

        public int getIDShiftFromUser(string user)
        {
            DataTable dt = Provider.Instance.ExecuteQuery("SELECT * FROM SHIFTWORK WHERE USERNAMEOFSHIFT = @user AND STATUSSHIFT = 0", new object[] { user });
            if(dt.Rows.Count>0)
            {
                Shift shift = new Shift(dt.Rows[0]);
                return shift.IdShift;
            }
            return -1;
        }
        public void insertShift(string user)
        {
            Provider.Instance.ExecuteNonQuery("uspInsertShift @user", new object[] { user });
        }
        public Shift getShift(int idShift)
        {
            DataTable dt = Provider.Instance.ExecuteQuery("SELECT * FROM dbo.SHIFTWORK WHERE ID = @id", new object[] { idShift });
            Shift shift = null;
            if (dt.Rows.Count > 0)
            {
                shift = new Shift(dt.Rows[0]);
            }
            return shift;
        }
    }
}
