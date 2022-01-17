using System.Data;
using System.Data.SqlClient;

namespace QL_QuanCF.DataAccessObject
{
    public class Provider
    {


        public static string cnnStr = "Data Source =localhost;Integrated security = true; Initial Catalog = QuanLyQuanCafe";
        private static Provider instance;

        public static Provider Instance
        {
            get { if (instance == null) instance = new Provider(); return instance; }
            private set { instance = value; }
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
        public int ExecuteNonQuery(string Query, object[] parameter = null)
        {
            int data = 0;
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

                data = sqlCommand.ExecuteNonQuery();

                sqlConnection.Close();
            }
            return data;
        }
        public object ExecuteScalar(string Query, object[] parameter = null)
        {

            object data = 0;
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

                data = sqlCommand.ExecuteScalar();

                sqlConnection.Close();
            }
            return data;
        }
    }
}
