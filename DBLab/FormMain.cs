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
                int result = DataBaseController.AddTable(addTable._Name);
                if (result == 0)
                    MessageBox.Show("Таблица с таким именем уже существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    int result = DataBaseController.EditTable(oldn, editTable._Name);
                    if (result == 0)
                        MessageBox.Show("Таблица с таким именем уже существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void addAttribute_Click(object sender, EventArgs e)
        {
            if (lvTables.SelectedItems.Count == 0)
            {
                MessageBox.Show("Не выбрана таблица", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FormAddEditAttribute addAttribute = new FormAddEditAttribute();
                addAttribute.DialogResult = DialogResult.Cancel;
                addAttribute.tableName = lvTables.SelectedItems[0].Text;
                addAttribute.Text = addAttribute.Text + " \"" + addAttribute.tableName + "\"";
                addAttribute.ShowDialog();
                if (addAttribute.DialogResult == DialogResult.OK)
                {
                }
                lvTables.Clear();
                this.FormMain_Load(sender, e);
            }
        }

        private void addRelation_Click(object sender, EventArgs e)
        {
            FormAddEditRelation addRelation = new FormAddEditRelation();
            addRelation.DialogResult = DialogResult.Cancel;
            addRelation.ShowDialog();
        }

        private void lvTables_DoubleClick(object sender, EventArgs e)
        {
            dgv.DataSource = null;
            dgv.Rows.Clear();
            dgv.Columns.Clear();

            DataTable dt_table_name = DataBaseController.DisplayTable("Entity where Name = N'" + lvTables.SelectedItems[0].Text+"'");
            DataTable dt_atr = DataBaseController.GetAttrForData(dt_table_name.Rows[0][0].ToString());
            DataTable dt_data = DataBaseController.GetInstance(dt_table_name.Rows[0][0].ToString());

            for ( int i=0; i<dt_atr.Rows.Count; i++)
            {
                dt_data.Columns.Add();
                DataTable dt_data_col2 = null;
                switch (dt_atr.Rows[i][2].ToString())
                {
                    case "string":
                        dt_data_col2 = DataBaseController.GetValueAttr(1, dt_table_name.Rows[0][0].ToString(), dt_atr.Rows[i][0].ToString());
                        break;
                    case "real":
                        dt_data_col2 = DataBaseController.GetValueAttr(2, dt_table_name.Rows[0][0].ToString(), dt_atr.Rows[i][0].ToString());
                        break;
                    case "integer":
                        dt_data_col2 = DataBaseController.GetValueAttr(3, dt_table_name.Rows[0][0].ToString(), dt_atr.Rows[i][0].ToString());
                        break;
                    case "date":
                        dt_data_col2 = DataBaseController.GetValueAttr(4, dt_table_name.Rows[0][0].ToString(), dt_atr.Rows[i][0].ToString());
                        break;
                }
                for (int j = 0; j < dt_data_col2.Rows.Count; j++)
                {  
                    try
                    {
                        dt_data.Rows[j][i + 1] = dt_data_col2.Rows[j][0];
                    }
                    catch(Exception)
                    {
                        dt_data.Rows.Add();
                        dt_data.Rows[j][i + 1] = dt_data_col2.Rows[j][0];
                    }
                }
                dt_data.Columns[i + 1].Caption = dt_atr.Rows[i][1].ToString();
                dt_data.Columns[i + 1].ColumnName = dt_atr.Rows[i][1].ToString();
            }

            dgv.DataSource = dt_data;

            for (int i = 0; i < dt_atr.Rows.Count; i++)
            {
                DataTable dt_res = DataBaseController.CheckAttr(dt_atr.Rows[i][0].ToString());
                if ((dt_res.Rows.Count != 0) && dt_atr.Rows[i][3].ToString() == "False")
                {
                    dgv.Columns.Add(new DataGridViewComboBoxColumn());
                    dgv.Columns[dgv.Columns.Count - 1].HeaderText = dgv.Columns[i + 1].HeaderText;
                    switch (dt_atr.Rows[i][2].ToString())
                    {
                        case "string":
                            (dgv.Columns[dgv.Columns.Count - 1] as DataGridViewComboBoxColumn).DataSource = DataBaseController.GetValueAttr(1, dt_res.Rows[0][0].ToString(), dt_res.Rows[0][1].ToString());
                            break;
                        case "real":
                            (dgv.Columns[dgv.Columns.Count - 1] as DataGridViewComboBoxColumn).DataSource = DataBaseController.GetValueAttr(2, dt_res.Rows[0][0].ToString(), dt_res.Rows[0][1].ToString());
                            break;
                        case "integer":
                            (dgv.Columns[dgv.Columns.Count - 1] as DataGridViewComboBoxColumn).DataSource = DataBaseController.GetValueAttr(3, dt_res.Rows[0][0].ToString(), dt_res.Rows[0][1].ToString());
                            break;
                        case "date":
                            (dgv.Columns[dgv.Columns.Count - 1] as DataGridViewComboBoxColumn).DataSource = DataBaseController.GetValueAttr(4, dt_res.Rows[0][0].ToString(), dt_res.Rows[0][1].ToString());
                            break;
                    }
                    (dgv.Columns[dgv.Columns.Count - 1] as DataGridViewComboBoxColumn).DisplayMember = "value";
                    (dgv.Columns[dgv.Columns.Count - 1] as DataGridViewComboBoxColumn).ValueMember = "value";
                    for (int j = 0; j < dgv.Rows.Count; j++)
                        dgv[dgv.Columns.Count - 1, j].Value = dgv[i + 1, j].Value;
                    dgv.Columns[i + 1].Visible = false;
                }
            }

            dgv.Columns[0].Visible = false;
        }

        private void dgv_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Queries frmQuery = new Queries();
            frmQuery.ShowDialog();
        }
    }
}
    
