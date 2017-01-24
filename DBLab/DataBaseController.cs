﻿using System;
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
                 $@"Data Source=(localdb)\localdb12;Initial Catalog=metaLabDB;Integrated Security=True";// можно просто тут менять путь один раз
                /* Мишино:*///$@"Data Source=(localdb)\Projects;Initial Catalog=metaLabDB;Integrated Security=True";
                /* Мишино:*///$@"Data Source=(localdb)\db12;Initial Catalog=metaLabDB;Integrated Security=True";
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
                reader.Close();
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

        public static int AddTable(string _name)
        {
            SqlCommand command = sqlConnection.CreateCommand();
            command.CommandText = "if not exists(select * from Entity where Name =N'" + _name + "') begin insert into Entity (Name) values(N'" + _name + "'); select distinct 1, id from Entity where Name=N'" + _name + "'; end else select distinct 0 from Entity; ";
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            if (isConnected == true)
            {
                adapter.Fill(dt);//command.ExecuteNonQuery();
                return Convert.ToInt32(dt.Rows[0][0]);
            }
            else
                return 0;
        }

        public static int EditTable(string _oldname, string _name)
        {
            SqlCommand command = sqlConnection.CreateCommand();

            DataTable dt = DisplayTable("dbo.Entity WHERE Name=N'"+_oldname+"'");

            command.CommandText = "if not exists(select * from Entity where Name = N'" + _name + "') begin update Entity SET Name = N'" + _name + "' WHERE ID = "+dt.Rows[0][0]+"; select distinct 1, id from Entity where Name=N'" + _name + "'; end else select distinct 0 from Entity; ";
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            if (isConnected == true)
            {
                adapter.Fill(dt);//command.ExecuteNonQuery();
                return Convert.ToInt32(dt.Rows[0][0]);
            }
            else
                return 0;
        }

        public static void AddAttr(string _name, int _table, string _type, int _key, int _null)
        {
            SqlCommand command = sqlConnection.CreateCommand();
            command.CommandText = "if not exists(select * from Attribute where Name =N'"+ _name + "') begin insert into Attribute (Name) values(N'"+ _name + "'); select distinct 1, id from Attribute where Name=N'"+ _name + "'; end else select distinct 0 from Attribute; ";
            
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            if (isConnected == true)
            {
                adapter.Fill(dt);//command.ExecuteNonQuery();
                if (int.Parse(dt.Rows[0][0].ToString())==1)
                {
                    command.CommandText = "insert into EA (id_Entity,id_Attribute,type,primary_key,is_null) values(@table,@attr,@type,@key,@null)";

                    command.Parameters.Add("table", SqlDbType.BigInt).Value = _table;
                    command.Parameters.Add("attr", SqlDbType.BigInt).Value = int.Parse(dt.Rows[0][1].ToString());
                    command.Parameters.Add("type", SqlDbType.NVarChar).Value = _type;
                    command.Parameters.Add("key", SqlDbType.Bit).Value = _key;
                    command.Parameters.Add("null", SqlDbType.Bit).Value = _null;

                    if (isConnected == true)
                    {
                        command.ExecuteNonQuery();
                    }
                }
                else
                {
                    MessageBox.Show("Атрибут с таким именем уже существует.","Ошибка",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        public static DataTable FillDgvAttr(int table)
        {
            SqlCommand command = sqlConnection.CreateCommand();
            command.CommandText = "select atr.Name as Название, ea.type as Тип, ea.primary_key as [Первичный ключ], ea.is_null as Обязательное from Attribute atr, EA ea where atr.id = ea.id_Attribute and ea.id_Entity = " + table.ToString();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            if (isConnected == true)
            {
                adapter.Fill(dt);
            }
            return dt;
        }
    }
}
