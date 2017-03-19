using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBLab
{
    public partial class FormAddEditRelation : Form
    {
        public string tableName = "";
        private int tableid;
        public FormAddEditRelation()
        {
            InitializeComponent();
        }

        private void ChangePrimaryTable()
        {
            DataTable dt = DataBaseController.DisplayTable("Entity where id <> " + (cbxPrimaryTable.SelectedItem as DataRowView)[0].ToString());
            cbxOutterTable.DataSource = dt;
            cbxOutterTable.DisplayMember = "Name";
            string id0 = (cbxPrimaryTable.SelectedItem as DataRowView)[0].ToString();
            string id1 = (cbxOutterTable.SelectedItem as DataRowView)[0].ToString();
            dt = DataBaseController.DisplayTable("Attribute where id in (select id_Attribute from EA where primary_key = 1 and id_Entity = " + id0 + ") and not (exists (select 1 from Relation where id_EntityS = " + id0 + " and id_EntityT = " + id1 + "))");
            cbxPrimaryAttr.DataSource = dt;
            cbxPrimaryAttr.DisplayMember = "Name";
            ChangeOutterTable();
        }

        private void ChangeOutterTable()
        {
            string id0 = (cbxPrimaryTable.SelectedItem as DataRowView)[0].ToString();
            string id1 = (cbxOutterTable.SelectedItem as DataRowView)[0].ToString();
            DataTable dt = DataBaseController.DisplayTable("Attribute where id in (select id_Attribute from EA where id_Entity = " + id1 + ") and not (id in (select id_Attribute from Relation where id_EntityS = " + id0 + " and id_EntityT = " + id1 + " ))");
            cbxOutterAttr.DataSource = dt;
            cbxOutterAttr.DisplayMember = "Name";
        }

        private void FormAddEditRelation_Load(object sender, EventArgs e)
        {
            DataTable dt = DataBaseController.DisplayTable("Entity");
            cbxPrimaryTable.DataSource = dt;
            cbxPrimaryTable.DisplayMember = "Name";
            ChangePrimaryTable();

            dt = DataBaseController.FillDgvRelation();
            dataGridView1.DataSource = dt;

            dataGridView1.Columns[0].Visible = false;
        }

        private void cbxPrimaryTable_SelectedValueChanged(object sender, EventArgs e)
        {
            ChangePrimaryTable();
        }

        private void cbxOutterTable_SelectedValueChanged(object sender, EventArgs e)
        {
            ChangeOutterTable();
        }

        private void btnAddRelation_Click(object sender, EventArgs e)
        {
            if (cbxPrimaryAttr.Text == "" || cbxPrimaryTable.Text == "" || cbxOutterAttr.Text == "" || cbxOutterTable.Text == ""||txtRelationName.Text=="")
            {
                MessageBox.Show("Не введены все параметры", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataBaseController.AddRelation((cbxPrimaryTable.SelectedItem as DataRowView)[0].ToString(), (cbxOutterTable.SelectedItem as DataRowView)[0].ToString(), (cbxOutterAttr.SelectedItem as DataRowView)[0].ToString(),txtRelationName.Text.ToString());
                DataTable  dt = DataBaseController.FillDgvRelation();
                dataGridView1.DataSource = dt;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
