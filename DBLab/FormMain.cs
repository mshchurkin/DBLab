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

namespace DBLab
{
    public partial class FormMain : Form
    {
        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        private static String connectionString =
                $@"Data Source=(localdb)\localdb12;Initial Catalog=metaLabDB;Integrated Security=True";
        SqlConnection sqlConn = new SqlConnection(connectionString);

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD
            //System.Security.SecureString ss= new System.Security.SecureString();
            //ss.MakeReadOnly();
            //SqlCredential sqlCred = new SqlCredential("9C4A/mshchurkin", ss)
            // Bind the DataGridView to the BindingSource
            // and load the data from the database.
            dgv.DataSource = DataBaseController.DisplayTable("dbo.String", sqlConn);
        }

        private void addTable_Click(object sender, EventArgs e)
        {
            FormAddEditTable addTable = new FormAddEditTable();
            addTable.DialogResult = DialogResult.Cancel;
            addTable.Text = "Добавление" + addTable.Text;
            addTable.ShowDialog();
            if (addTable.DialogResult == DialogResult.OK)
            {
                DataBaseController.AddTable(addTable._Name, sqlConn);
            }
            // !!!! сюда добавить обновление листвью после добавления таблицы
        }

        private void editTable_Click(object sender, EventArgs e)
        {
            string oldn;
            FormAddEditTable editTable = new FormAddEditTable();
            oldn = lvTables.SelectedItems[0].Text;
            editTable.DialogResult = DialogResult.Cancel;
            editTable._Name = oldn;
            editTable.Text = "Редактирвоание " + editTable.Text;

            editTable.ShowDialog();
            if (editTable.DialogResult == DialogResult.OK)
            {
                DataBaseController.EditTable(oldn, editTable._Name, sqlConn);
            }
        }




        //    private void GetData(string selectCommand)
        //    {
        //        try
        //        {
        //            // Specify a connection string. Replace the given value with a 
        //            // valid connection string for a Northwind SQL Server sample
        //            // database accessible to your system.

        //            dataAdapter = new SqlDataAdapter(selectCommand, connectionString);

        //            // Create a command builder to generate SQL update, insert, and
        //            // delete commands based on selectCommand. These are used to
        //            // update the database.
        //            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

        //            // Populate a new data table and bind it to the BindingSource.
        //            DataTable table = new DataTable();
        //            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
        //            dataAdapter.Fill(table);
        //            bindingSource1.DataSource = table;

        //            // Resize the DataGridView columns to fit the newly loaded content.
        //            dgv.AutoResizeColumns(
        //                DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
        //        }
        //        catch (SqlException)
        //        {
        //            MessageBox.Show("fuck");
        //        }
        //    }
=======
            String connectionString =
                    $@"Data Source=(localdb)\Projects;Initial Catalog=metaLabDB;Integrated Security=True";
            SqlConnection sqlConn = new SqlConnection(connectionString);
            foreach (string elem in DataBaseController.listFiller(sqlConn))
            {
                lvTables.Items.Add(elem);
            }
            dgv.DataSource = DataBaseController.DisplayTable("dbo.String", sqlConn);
        }
>>>>>>> issue#2_load_tables_on_start
    }
}
    
