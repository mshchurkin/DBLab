using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBLab
{
    class DataBaseController
    {
        public static IEnumerable<string> listFiller(SqlConnection sqlConnection)
        {
            sqlConnection.Open();
            SqlCommand command = sqlConnection.CreateCommand();
            command.CommandText = "SELECT * FROM dbo.Entity";
            SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                    yield return (reader.GetString(1));
            sqlConnection.Close();
        }
        public static DataTable DisplayTable(string tableName, SqlConnection sqlConnection)
        {
            SqlCommand command = sqlConnection.CreateCommand();
        command.CommandText = "SELECT * FROM " + tableName;
            DataTable dt = new DataTable();
        SqlDataAdapter adapter = new SqlDataAdapter(command);
            sqlConnection.Open();
            try
            {
                adapter.Fill(dt);
            }
            catch
            {
                MessageBox.Show("Connection failed!", "Error!");
            }
            finally
            {
                sqlConnection.Close();
            }
            return dt;
        }
    }
}
