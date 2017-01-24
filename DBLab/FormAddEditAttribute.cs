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
    public partial class FormAddEditAttribute : Form
    {
        public string tableName = "";
        private int tableid;

        public FormAddEditAttribute()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddAttribute_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || cmbType.Text == "")
            {
                MessageBox.Show("Не введены все параметры", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataTable dt = DataBaseController.DisplayTable("Entity where Name=N'" + tableName + "'");
                tableid = Convert.ToInt32(dt.Rows[0][0]);
                DataBaseController.AddAttr(txtName.Text, tableid, cmbType.Text, Convert.ToInt32(cbxKey.Checked), Convert.ToInt32(cbxIsNull.Checked));
                dgvAttributes.DataSource = DataBaseController.FillDgvAttr(tableid);
            }
        }

        private void FormAddEditAttribute_Load(object sender, EventArgs e)
        {
            DataTable dt = DataBaseController.DisplayTable("Entity where Name=N'" + tableName + "'");
            tableid = Convert.ToInt32(dt.Rows[0][0]);
            dgvAttributes.DataSource = DataBaseController.FillDgvAttr(tableid);
        }
    }
}
