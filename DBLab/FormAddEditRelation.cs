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
        }

        private void cbxPrimaryTable_SelectedValueChanged(object sender, EventArgs e)
        {
            ChangePrimaryTable();
        }

        private void cbxOutterTable_SelectedValueChanged(object sender, EventArgs e)
        {
            ChangeOutterTable();
        }
    }
}
