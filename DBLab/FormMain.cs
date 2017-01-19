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
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            editTable.Enabled = false;
            deleteTable.Enabled = false;
            foreach (string elem in DataBaseController.listFiller())
            {
                lvTables.Items.Add(elem);
            }
            CheckListBox();
            //dgv.DataSource = DataBaseController.DisplayTable("dbo.String", sqlConn);
        }

        private void FormMain_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            DataBaseController.Disconnect();
        }
        private void addTable_Click(object sender, EventArgs e)
        {
            FormAddEditTable addTable = new FormAddEditTable();
            addTable.DialogResult = DialogResult.Cancel;
            addTable.Text = "Добавление" + addTable.Text;
            addTable.ShowDialog();
            if (addTable.DialogResult == DialogResult.OK)
            {
                DataBaseController.AddTable(addTable._Name);
            }
            lvTables.Clear();
            this.FormMain_Load(sender, e);
        }

        private void editTable_Click(object sender, EventArgs e)
        {
            string oldn;
            if (lvTables.SelectedItems.Count == 0)
            {
                MessageBox.Show("Не выбрана таблица", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FormAddEditTable editTable = new FormAddEditTable();
                oldn = lvTables.SelectedItems[0].Text;
                editTable.DialogResult = DialogResult.Cancel;
                editTable._Name = oldn;
                editTable.Text = "Редактирование " + editTable.Text;

                editTable.ShowDialog();
                if (editTable.DialogResult == DialogResult.OK)
                {
                    DataBaseController.EditTable(oldn, editTable._Name);
                }
                lvTables.Clear();
                this.FormMain_Load(sender, e);
            }
        }

        private void CheckListBox()
        {
            if (lvTables.Items.Count != 0)
            {
                editTable.Enabled = true;
                deleteTable.Enabled = true;
            }
            else
            {
                editTable.Enabled = false;
                deleteTable.Enabled = false;
            }
        }
    }
}
    
