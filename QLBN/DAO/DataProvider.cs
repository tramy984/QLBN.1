using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace QLBN.DAO
{
    public class DataProvider
    {
        private string connectionSTR = "Data Source=.;Initial Catalog=QLYBENHNHAN;Integrated Security=True;Encrypt=False";

        public DataTable ExecuteQuery(string query)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
            
        }
        public SqlCommand cmd
        {
            get { return cmd; }
        }
        public SqlConnection conection
        {
            get { return conection; }
        }
        public DataTable data
        {
            get { return data; }
        }
        public SqlDataAdapter adapter
        {
            get { return adapter; }
        }

    }
}
