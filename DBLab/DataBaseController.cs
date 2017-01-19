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
        private static String connectionString =
                // $@"Data Source=(localdb)\localdb12;Initial Catalog=metaLabDB;Integrated Security=True";// можно просто тут менять путь один раз
                /* Мишино:*/$@"Data Source=(localdb)\Projects;Initial Catalog=metaLabDB;Integrated Security=True";
        public static SqlConnection sqlConnection = new SqlConnection(connectionString);
        public static bool isConnected = false;
        public static void Coneect()
        {
            try
            {
                sqlConnection.Open();
                isConnected = true;
            }
            catch
            {
                MessageBox.Show("Connection failed!", "Error!");
            }
        }
        public static void Disconnect()
        {
            if (sqlConnection.State == ConnectionState.Open)
                sqlConnection.Close();
        }
        public static IEnumerable<string> listFiller()
        {
            if (isConnected ==true)
            {
                SqlCommand command = sqlConnection.CreateCommand();
                command.CommandText = "SELECT * FROM dbo.Entity";

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                    yield return (reader.GetString(1));
            }
        }
        public static DataTable DisplayTable(string tableName)
        {
                SqlCommand command = sqlConnection.CreateCommand();
                command.CommandText = "SELECT * FROM " + tableName;
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
            if (isConnected == true)
            {
                adapter.Fill(dt);
            }
            return dt;
        }

        public static void AddTable(string _name)
        {
            SqlCommand command = sqlConnection.CreateCommand();
            command.CommandText = "INSERT INTO Entity (Name) VALUES(@name)" ;
            command.Parameters.Add("Name", SqlDbType.NVarChar).Value =
               _name;
            if (isConnected == true)
            {
                command.ExecuteNonQuery();
            }
        }

        public static void EditTable(string _oldname, string _name)
        {
            SqlCommand command = sqlConnection.CreateCommand();

            DataTable dt = DisplayTable("dbo.Entity WHERE Name='"+_oldname+"'");

            command.CommandText = "UPDATE Entity SET Name = @name WHERE ID="+dt.Rows[0][0];
            command.Parameters.Add("Name", SqlDbType.NVarChar).Value =
               _name;
            if (isConnected == true)
            {
                command.ExecuteNonQuery();
            }
        }
    }
}
