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
            if (isConnected == true)
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

            DataTable dt = DisplayTable("dbo.Entity WHERE Name=N'" + _oldname + "'");

            command.CommandText = "if not exists(select * from Entity where Name = N'" + _name + "') begin update Entity SET Name = N'" + _name + "' WHERE ID = " + dt.Rows[0][0] + "; select distinct 1, id from Entity where Name=N'" + _name + "'; end else select distinct 0 from Entity; ";
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            if (isConnected == true)
            {
                adapter.Fill(dt);//command.ExecuteNonQuery();
                return Convert.ToInt32(dt.Rows[0][0]);
            }
            else
                return 0;
        }

        public static void deleteTable(string _tableName)
        {
            SqlCommand command = sqlConnection.CreateCommand();
            command.CommandText = "";

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            command.CommandText = "delete from Entity where id in (select id from Entity where Name=N'"+_tableName+"')";

            if (isConnected == true)
            {
                command.ExecuteNonQuery();
            }
        }
        public static void dropTableByAttr(string _attrName)
        {
            SqlCommand command = sqlConnection.CreateCommand();
            command.CommandText = "";

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            command.CommandText = "delete from String where id_Attribute in (select id from Attribute where Name = N'"+_attrName+"') ";

            if (isConnected == true)
            {
                command.ExecuteNonQuery();
            }

            command.CommandText = "delete from Integer where id_Attribute in (select id from Attribute where Name = N'" + _attrName + "')";

            if (isConnected == true)
            {
                command.ExecuteNonQuery();
            }

            command.CommandText = "delete from Date where id_Attribute in (select id from Attribute where Name = N'" + _attrName + "')";

            if (isConnected == true)
            {
                command.ExecuteNonQuery();
            }

            command.CommandText = "delete from Float where id_Attribute in (select id from Attribute where Name = N'" + _attrName + "')";

            if (isConnected == true)
            {
                command.ExecuteNonQuery();
            }
        }

        public static void dropTableEntry(string attrColName, string attrColValue)
        {
            String attrType = getAttrtype(attrColName);
            switch (attrType)
            {
                case "string":
                    {
                        SqlCommand command = sqlConnection.CreateCommand();
                        command.CommandText = "delete from String where value=N'" + attrColValue + "' and id_Attribute in (select id from Attribute where Name = N'"+attrColName+"')";

                        DataTable dt = new DataTable();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);

                        if (isConnected == true)
                        {
                            command.ExecuteNonQuery();
                        }
                        else
                        {
                            MessageBox.Show("Ошибка", "Не удалось удалить данные.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
                case "integer":
                    {
                        SqlCommand command = sqlConnection.CreateCommand();
                        command.CommandText = "delete from Integer where value=N'" + attrColValue + "' and id_Attribute in (select id from Attribute where Name = N'" + attrColName + "')";

                        DataTable dt = new DataTable();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);

                        if (isConnected == true)
                        {
                            command.ExecuteNonQuery();
                        }
                        else
                        {
                            MessageBox.Show("Ошибка", "Не удалось добавить данные.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
                case "Date":
                    {
                        SqlCommand command = sqlConnection.CreateCommand();
                        command.CommandText = "delete from Date where value=N'" + attrColValue + "' and id_Attribute in (select id from Attribute where Name = N'" + attrColName + "')";

                        DataTable dt = new DataTable();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);

                        if (isConnected == true)
                        {
                            command.ExecuteNonQuery();
                        }
                        else
                        {
                            MessageBox.Show("Ошибка", "Не удалось добавить данные.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
                case "float":
                    {
                        SqlCommand command = sqlConnection.CreateCommand();
                        command.CommandText = "delete from Float where value=N'" + attrColValue + "' and id_Attribute in (select id from Attribute where Name = N'" + attrColName + "')";

                        DataTable dt = new DataTable();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);

                        if (isConnected == true)
                        {
                            command.ExecuteNonQuery();
                        }
                        else
                        {
                            MessageBox.Show("Ошибка", "Не удалось добавить данные.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
            }
        }
        public static void dropTable(string _tableName)
        {
            SqlCommand command = sqlConnection.CreateCommand();
            command.CommandText = "";

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            command.CommandText = "delete from String where id_InstanceEntity in (select id_InstanceEntity from InstanceEntity where id_Entity in(select id from Entity where Name=N'"+_tableName+"')) ";

            if (isConnected == true)
            {
                command.ExecuteNonQuery();
            }

            command.CommandText = "delete from Integer where id_InstanceEntity in (select id_InstanceEntity from InstanceEntity where id_Entity in(select id from Entity where Name=N'" + _tableName + "')) ";

            if (isConnected == true)
            {
                command.ExecuteNonQuery();
            }

            command.CommandText = "delete from Date where id_InstanceEntity in (select id_InstanceEntity from InstanceEntity where id_Entity in(select id from Entity where Name=N'" + _tableName + "')) ";

            if (isConnected == true)
            {
                command.ExecuteNonQuery();
            }

            command.CommandText = "delete from Float where id_InstanceEntity in (select id_InstanceEntity from InstanceEntity where id_Entity in(select id from Entity where Name=N'" + _tableName + "')) ";

            if (isConnected == true)
            {
                command.ExecuteNonQuery();
            }

            command.CommandText = "delete from InstanceEntity where id_Entity in(select id from Entity where Name=N'" + _tableName + "') ";

            if (isConnected == true)
            {
                command.ExecuteNonQuery();
            }

        }

        public static void AddAttr(string _name, int _table, string _type, int _key, int _null)
        {
            SqlCommand command = sqlConnection.CreateCommand();
            command.CommandText = "if not exists(select * from Attribute where Name =N'" + _name + "') begin insert into Attribute (Name) values(N'" + _name + "'); select distinct 1, id from Attribute where Name=N'" + _name + "'; end else select distinct 0 from Attribute; ";

            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            if (isConnected == true)
            {
                adapter.Fill(dt);//command.ExecuteNonQuery();
                if (int.Parse(dt.Rows[0][0].ToString()) == 1)
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
                    MessageBox.Show("Атрибут с таким именем уже существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        public static void EditAttr(int _id, string _name, string _type, int _key, int _null)
        {
            SqlCommand command = sqlConnection.CreateCommand();
            command.CommandText = "";

            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            command.CommandText = "update Attribute set Name = N'" + _name + "' where id =" + _id + " ; update EA set type = N'" + _type + "', primary_key = " + _key + ", is_null = " + _null + " where id_Attribute = " + _id + "";

            if (isConnected == true)
            {
                command.ExecuteNonQuery();
            }
        }

        public static void DelAttrByAttr(string _attrName)
        {
            SqlCommand command = sqlConnection.CreateCommand();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            command.CommandText = "delete from EA where id_Attribute in (select id from Attribute where Name=N'" + _attrName + "')";

            if (isConnected == true)
            {
                command.ExecuteNonQuery();
            }

            command.CommandText = "delete from Attribute where Name =N'" + _attrName + "'";

            if (isConnected == true)
            {
                command.ExecuteNonQuery();
            }
        }
        public static void DelAttrByEntity(string _tableName)
        {
            List<int> attrIds = new List<int>();
            SqlCommand command = sqlConnection.CreateCommand();
            command.CommandText = "select id_Attribute from EA where id_Entity in (select id from Entity where Name=N'" + _tableName + "')";
            if (isConnected == true)
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    attrIds.Add(Convert.ToInt32(reader[0].ToString()));
                }
                reader.Close();
            }

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            command.CommandText = "delete from EA where id_Entity in (select id from Entity where Name=N'" + _tableName + "')";

            if (isConnected == true)
            {
                command.ExecuteNonQuery();
            }

            foreach (int i in attrIds)
            {
                command.CommandText = "delete from Attribute where id =N'" + i + "'";

                if (isConnected == true)
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public static DataTable FillDgvAttr(int table)
        {
            SqlCommand command = sqlConnection.CreateCommand();
            command.CommandText = "select atr.id, atr.Name as Название, ea.type as Тип, ea.primary_key as [Первичный ключ], ea.is_null as Обязательное from Attribute atr, EA ea where atr.id = ea.id_Attribute and ea.id_Entity = " + table.ToString();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            if (isConnected == true)
            {
                adapter.Fill(dt);
            }
            return dt;
        }

        public static DataTable FillDgvRelation()
        {
            SqlCommand command = sqlConnection.CreateCommand();
            command.CommandText = "select id_Relation as ID, (select Name from Entity where id=id_EntityS) as [Таблица-источник], (select Name from Entity where id=id_EntityT) as [Таблица-приемник], (select Name from Attribute where id=id_Attribute) as [Атрибут-приемник], binder as [Имя связи] from Relation ";
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            if (isConnected == true)
            {
                adapter.Fill(dt);
            }
            return dt;
        }

        public static void AddRelation(string _id_en_s, string _id_en_t, string _id_at, string _binder)
        {
            SqlCommand command = sqlConnection.CreateCommand();
            command.CommandText = "insert into Relation (id_EntityS, id_EntityT, id_Attribute, binder) values(" + _id_en_s + ", " + _id_en_t + ", " + _id_at + ", N'" + _binder + "'); ";

            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            if (isConnected == true)
            {
                command.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Не удалось добавить связь.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void DelRelationByAttr(string _attrName)
        {
            List<int> entIds = new List<int>();
            SqlCommand command = sqlConnection.CreateCommand();
            command.CommandText = "select id_Entity from EA where primary_key=1 and id_Attribute in (select id from Attribute where Name=N'" + _attrName + "')";
            if (isConnected == true)
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    entIds.Add(Convert.ToInt32(reader[0].ToString()));
                }
                reader.Close();
            }
            command.CommandText = "";

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            command.CommandText = "delete from Relation where id_Attribute in (select id from Attribute where Name=N'" + _attrName + "') ";

            if (isConnected == true)
            {
                command.ExecuteNonQuery();
            }

            foreach (int i in entIds)
            {
                command.CommandText = "delete from Relation where id_EntityS =N'" + i + "'";

                if (isConnected == true)
                {
                    command.ExecuteNonQuery();
                }
            }
        }
        public static void DelRelationByEntity(string _tableName)
        {
            SqlCommand command = sqlConnection.CreateCommand();
            command.CommandText = "";

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            command.CommandText = "delete from Relation where id_EntityS in (select id from Entity where Name=N'" + _tableName + "') or id_EntityT in (select id from Entity where Name=N'" + _tableName + "')";

            if (isConnected == true)
            {
                command.ExecuteNonQuery();
            }
        }

        public static void DelRelationByName(string _relName)
        {
            SqlCommand command = sqlConnection.CreateCommand();
            command.CommandText = "";

            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            command.CommandText = "delete from Relation where binder=N'"+_relName+"'";

            if (isConnected == true)
            {
                command.ExecuteNonQuery();
            }
        }

        public static DataTable GetAttrForData(string table)
        {
            SqlCommand command = sqlConnection.CreateCommand();
            command.CommandText = "select a.id, a.Name, b.type, b.primary_key from (select * from metaLabDB.dbo.Attribute) a, (select id_Attribute, type, primary_key from metaLabDB.dbo.EA where id_Entity = " + table + ") b where a.id=b.id_Attribute";
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            if (isConnected == true)
            {
                adapter.Fill(dt);
            }
            return dt;
        }

        public static DataTable GetValueAttr(int c, string tablename, string atrname, string cond = "")
        {
            SqlCommand command = sqlConnection.CreateCommand();
            switch (c)
            {
                case 1:
                    command.CommandText = "select value from metaLabDB.dbo.String where id_Attribute = " + atrname + " and id_InstanceEntity in (select id_InstanceEntity from metaLabDB.dbo.InstanceEntity where id_Entity = " + tablename + ")";
                    break;
                case 2:
                    command.CommandText = "select value from metaLabDB.dbo.Float where id_Attribute = " + atrname + " and id_InstanceEntity in (select id_InstanceEntity from metaLabDB.dbo.InstanceEntity where id_Entity = " + tablename + ")";
                    break;
                case 3:
                    command.CommandText = "select value from metaLabDB.dbo.Integer where id_Attribute = " + atrname + " and id_InstanceEntity in (select id_InstanceEntity from metaLabDB.dbo.InstanceEntity where id_Entity = " + tablename + ")";
                    break;
                case 4:
                    command.CommandText = "select value from metaLabDB.dbo.Date where id_Attribute = " + atrname + " and id_InstanceEntity in (select id_InstanceEntity from metaLabDB.dbo.InstanceEntity where id_Entity = " + tablename + ")";
                    break;
            }
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            if (isConnected == true)
            {
                adapter.Fill(dt);
            }
            return dt;
        }

        public static DataTable CheckAttr(string id)
        {
            SqlCommand command = sqlConnection.CreateCommand();
            command.CommandText = "select r.id_EntityS, a.id_Attribute from Relation r, (select id_Entity, id_Attribute from EA where primary_key=1) a where r.id_EntityS=a.id_Entity and r.id_Attribute = " + id;
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            if (isConnected == true)
            {
                adapter.Fill(dt);
            }
            return dt;
        }

        public static DataTable GetInstance(string id)
        {
            SqlCommand command = sqlConnection.CreateCommand();
            command.CommandText = "select id_InstanceEntity from InstanceEntity where id_Entity = " + id;
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            if (isConnected == true)
            {
                adapter.Fill(dt);
            }
            return dt;
        }


        public static string getPrimaryKeyAttr(string table_Name)
        {
            SqlCommand command = sqlConnection.CreateCommand();
            String id_Entity = getIdByName(table_Name);
            command.CommandText = "select Name from Attribute where id in (select id_Attribute from EA where primary_key = 1 and id_Entity=N'"+id_Entity+"')";
            String attrName = "";
            if (isConnected == true)
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    attrName = reader[0].ToString();
               }
                reader.Close();
            }
            return attrName;
        }

        public static string getIdByName(string name)
        {
            SqlCommand command = sqlConnection.CreateCommand();
            command.CommandText = "select id from Entity where Name =N'" + name + "'";
            String id = "";
            if (isConnected == true)
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    id = reader[0].ToString();
                }
                reader.Close();
            }
            return id;
        }

        public static string getAttrtype(string attrName)
        {
            SqlCommand command = sqlConnection.CreateCommand();
            command.CommandText = "select type from EA where id_Attribute in (select id from Attribute where Name = N'"+attrName+"')";
            String attrType = "";
            if (isConnected == true)
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    attrType = reader[0].ToString();
                }
                reader.Close();
            }
            return attrType;
        }

        public static void addData(string attrColName, string attrColValue, string entity_name, string id_InstanceEntity)
        {
            if (id_InstanceEntity == "")
                id_InstanceEntity = (-1).ToString();
            String attrType = getAttrtype(attrColName);
            switch (attrType)
            {
                case "string":
                    {
                        String id_Entity = getIdByName(entity_name);
                        SqlCommand command = sqlConnection.CreateCommand();
                        command.CommandText = @"if exists(select 1 from InstanceEntity where id_InstanceEntity =" + id_InstanceEntity + @")
                                                 update String
                                                 set value = N'" + attrColValue + @"'
                                                 where id_Attribute in (select id from Attribute where Name = N'" + attrColName + @"')
                                                 and id_InstanceEntity =" + id_InstanceEntity + @" ;
                                              else
                                                insert into InstanceEntity(id_Entity)
                                                values(" + id_Entity + @");
                                                insert into String(id_Attribute, id_InstanceEntity, value)
                                                values((select id from Attribute where Name = N'" + attrColName + @"'), (select max(id_InstanceEntity) from InstanceEntity where id_Entity = " + id_Entity + @"), N'" + attrColValue + @"');
                                                select max(id_InstanceEntity)from InstanceEntity where id_Entity =" + id_Entity + "; ";

                        DataTable dt = new DataTable();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);

                        if (isConnected == true)
                        {
                            command.ExecuteNonQuery();
                        }
                        else
                        {
                            MessageBox.Show("Ошибка", "Не удалось добавить данные.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
                case "integer":
                    {
                        String id_Entity = getIdByName(entity_name);
                        SqlCommand command = sqlConnection.CreateCommand();
                        command.CommandText = @"if exists(select 1 from InstanceEntity where id_InstanceEntity = " + id_InstanceEntity + @")
                                                 update Integer
                                                 set value = N'" + attrColValue + @"'
                                                 where id_Attribute in (select id from Attribute where Name = N'" + attrColName + @"')
                                                 and id_InstanceEntity =" + id_InstanceEntity + @" ;
                                              else
                                                insert into InstanceEntity(id_Entity)
                                                values(" + id_Entity + @");
                                                insert into Integer(id_Attribute, id_InstanceEntity, value)
                                                values((select id from Attribute where Name = N'" + attrColName + @"'), (select max(id_InstanceEntity) from InstanceEntity where id_Entity = " + id_Entity + @"), N'" + attrColValue + @"');
                                                select max(id_InstanceEntity)from InstanceEntity where id_Entity =" + id_Entity + "; ";

                        DataTable dt = new DataTable();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);

                        if (isConnected == true)
                        {
                            command.ExecuteNonQuery();
                        }
                        else
                        {
                            MessageBox.Show("Ошибка", "Не удалось добавить данные.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
                case "Date":
                    {
                        String id_Entity = getIdByName(entity_name);
                        SqlCommand command = sqlConnection.CreateCommand();
                        command.CommandText = @"if exists(select 1 from InstanceEntity where id_InstanceEntity =" + id_InstanceEntity + @")
                                                 update Date
                                                 set value = N'" + attrColValue + @"'
                                                 where id_Attribute in (select id from Attribute where Name = N'" + attrColName + @"')
                                                 and id_InstanceEntity =" + id_InstanceEntity + @" ;
                                              else
                                                insert into InstanceEntity(id_Entity)
                                                values(" + id_Entity + @");
                                                insert into Date(id_Attribute, id_InstanceEntity, value)
                                                values((select id from Attribute where Name = N'" + attrColName + @"'), (select max(id_InstanceEntity) from InstanceEntity where id_Entity = " + id_Entity + @"), N'" + attrColValue + @"');
                                                select max(id_InstanceEntity)from InstanceEntity where id_Entity =" + id_Entity + "; ";

                        DataTable dt = new DataTable();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);

                        if (isConnected == true)
                        {
                            command.ExecuteNonQuery();
                        }
                        else
                        {
                            MessageBox.Show("Ошибка", "Не удалось добавить данные.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
                case "real":
                    {
                        String id_Entity = getIdByName(entity_name);
                        SqlCommand command = sqlConnection.CreateCommand();
                        command.CommandText = @"if exists(select 1 from InstanceEntity where id_InstanceEntity =" + id_InstanceEntity + @")
                                                 update Real
                                                 set value = N'" + attrColValue + @"'
                                                 where id_Attribute in (select id from Attribute where Name = N'" + attrColName + @"')
                                                 and id_InstanceEntity =" + id_InstanceEntity + @" ;
                                              else
                                                insert into InstanceEntity(id_Entity)
                                                values(" + id_Entity + @");
                                                insert into Real(id_Attribute, id_InstanceEntity, value)
                                                values((select id from Attribute where Name = N'" + attrColName + @"'), (select max(id_InstanceEntity) from InstanceEntity where id_Entity = " + id_Entity + @"), N'" + attrColValue + @"');
                                                select max(id_InstanceEntity)from InstanceEntity where id_Entity =" + id_Entity + "; ";

                        DataTable dt = new DataTable();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);

                        if (isConnected == true)
                        {
                            command.ExecuteNonQuery();
                        }
                        else
                        {
                            MessageBox.Show("Ошибка", "Не удалось добавить данные.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
            }
        }

        public static DataTable FillDgvQuery()
        {
            SqlCommand command = sqlConnection.CreateCommand();
            command.CommandText = "select string from Queries";
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            if (isConnected == true)
            {
                adapter.Fill(dt);
            }
            return dt;
        }

        public static void AddQuery(string query)
        {
            SqlCommand command = sqlConnection.CreateCommand();
            command.CommandText = "insert into Queries (string) values(N'" + query + "'); ";

            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            if (isConnected == true)
            {
                command.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Не удалось добавить запрос в БД.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
