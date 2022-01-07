﻿using QL_QuanCF.DataTransferObject;
using System.Data;

namespace QL_QuanCF.DataAccessObject
{
    public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance 
        {
            get { if (instance == null) instance = new BillDAO(); return instance; }
            private set { instance = value; }
        }
        private BillDAO() { }
        /// <summary>
        /// Thành công  bill ID
        /// Thất bại -1;
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int getIDBillUncheckOutByIDTable(int id)
        {
            DataTable dt = Provider.Instance.ExecuteQuery("Select * FROM BILL where IDTAB = " + id + " and STATUSBILL = 0");
            if(dt.Rows.Count>0)
            {
                Bill b = new Bill(dt.Rows[0]);
                return b.ID;
            }    
            return -1;
        }
        public void insertBill(int idTab, string user)
        {
            Provider.Instance.ExecuteNonQuery("spInsertBill @idTable , @user", new object[] { idTab, user});
        }
        /// <summary>
        /// Update Amount Quest in a Table
        /// </summary>
        /// <param name="amount">Amount People</param>
        /// <param name="id">ID Table</param>
        public void updateAmountQuest(int amount, int id)
        {
            Provider.Instance.ExecuteNonQuery("Update TAB SET AMOUNTTAB = @amount where ID = @id", new object[] { amount, id });
        }

        public void CalAmountBill(int idBill)
        {
            Provider.Instance.ExecuteQuery("uspCalAmountBill @idBill", new object[] { idBill });
        }

        
    }
}