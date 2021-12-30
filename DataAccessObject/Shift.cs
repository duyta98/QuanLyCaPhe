using QL_QuanCF.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_QuanCF.DataAccessObject
{
    public class Shift
    {
        private static Shift instance;

        public Shift()
        {
        }

        public static Shift Instance 
        {
            get { if (instance == null) instance = new Shift(); return instance; }
            private set { instance = value; }
        }

        public int getIDShiftFromUser(string user)
        {
            DataTable dt = Provider.Instance.ExecuteQuery("SELECT * FROM SHIFTWORK WHERE USERNAMEOFSHIFT = @user AND STATUSSHIFT = 0", new object[] { user });
            if(dt.Rows.Count>0)
            {
                ShiftDTO shift = new ShiftDTO(dt.Rows[0]);
                return shift.IdShift;
            }
            return -1;
        }
    }
}
