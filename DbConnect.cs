using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Demo_exam
{
    class DbConnect
    {
        SqlConnection sqlConnection = new SqlConnection(@"DATA Source=311-07-20;Initial Catalog=demo_exam;Integrated Security=True");

        public void openConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }

        }

        public void CloseConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }

        }

        public SqlConnection getConnection()
        {
            return sqlConnection;
        }

    }
}
