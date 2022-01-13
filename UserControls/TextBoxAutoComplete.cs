using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_QuanCF
{
    public partial class TextBoxAutoComplete : TextBox
    {
        public TextBoxAutoComplete()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Load DataSource Autocomplete to textbox from database
        /// </summary>
        /// <param name="sqlConn">SqlConnection String</param>
        /// <param name="query">Query String</param>
        /// <param name="columnName">Column get Data</param>
        public void loadDataAutoComplete(string sqlConn, string query, string columnName )
        {
            var myConnection = new SqlConnection(sqlConn);
            myConnection.Open();

            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

            SqlCommand cmd = new SqlCommand(query, myConnection);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows == true)
            {
                while (dr.Read())
                    collection.Add(dr[columnName].ToString());
            }

            dr.Close();
            myConnection.Close();

            AutoCompleteMode = AutoCompleteMode.Suggest;
            AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteCustomSource = collection;
            
        }
    }
}
