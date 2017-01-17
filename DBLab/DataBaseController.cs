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

        public static void AddTable(string _name, SqlConnection sqlConnection)
        {
            SqlCommand command = sqlConnection.CreateCommand();
            command.CommandText = "INSERT INTO Entity (Name) VALUES(@name)" ;
            command.Parameters.Add("Name", SqlDbType.NVarChar).Value =
               _name;
            sqlConnection.Open();
            try
            {
                command.ExecuteNonQuery();
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public static void EditTable(string _oldname, string _name, SqlConnection sqlConnection)
        {
            SqlCommand command = sqlConnection.CreateCommand();

            DataTable dt = DisplayTable("dbo.Entity WHERE Name="+_oldname, sqlConnection);

            command.CommandText = "UPDATE Entity SET Name = @name WHERE ID="+dt.Rows[0][0];
            command.Parameters.Add("Name", SqlDbType.NVarChar).Value =
               _name;
            sqlConnection.Open();
            try
            {
                command.ExecuteNonQuery();
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}
