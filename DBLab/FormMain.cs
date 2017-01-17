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
         String connectionString =
                    $@"Data Source=(localdb)\Projects;Initial Catalog=metaLabDB;Integrated Security=True";
            SqlConnection sqlConn = new SqlConnection(connectionString);
            foreach (string elem in DataBaseController.listFiller(sqlConn))
            {
                lvTables.Items.Add(elem);
            }
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
    }
}
    
