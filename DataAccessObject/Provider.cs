using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_QuanCF.Connections
{
    public class Provider
    {

        private string cnnStr = "Data Source =.; Initial Catalog = QuanLyQuanCaPhe; Integrated Security = True";
        private static Provider instance;

        public static Provider Instance
        {
            get { if (instance == null) instance = new Provider(); return Provider.instance; }
            private set { Provider.instance = value; }
        }
        private Provider() { }
        public DataTable ExecuteQuery(string Query, object[] parameter = null)
        {
            
            DataTable dt = new DataTable();
            using (SqlConnection sqlConnection = new SqlConnection(cnnStr))

            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlCommand sqlCommand = new SqlCommand(Query, sqlConnection);
                if (parameter != null)
                {
                    string[] listPara = Query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            sqlCommand.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dt);

                sqlConnection.Close();
            }
            return dt;
        }

    }
}
