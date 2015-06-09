using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class SqlDataProvider
    {
        public SqlConnection Connection { get; set; }
        public SqlCommand Command { get; set; }


        public SqlDataProvider(string connStr)
        {
            this.Connection = new SqlConnection(connStr);
            this.Command = this.Connection.CreateCommand();
        }


        public DataTable GetDataTable(string query)
        {
            DataTable dt = new DataTable();

            this.Command.CommandText = query;

            SqlDataAdapter adapter = new SqlDataAdapter(this.Command);
            adapter.Fill(dt);

            return dt;
        }

        public object GetSingleData(string query)
        {
            object result = null;

            this.Command.CommandText = query;

            this.Connection.Open();

            result = this.Command.ExecuteScalar();

            this.Connection.Close();

            return result;
        }

        public int RunQuery(string sorgu)
        {
            int result = 0;

            this.Command.CommandText = sorgu;

            this.Connection.Open();

            result = this.Command.ExecuteNonQuery();

            this.Connection.Close();

            return result;
        }
    }
}
