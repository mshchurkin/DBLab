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
                if (cbxKey.Checked == true)
                {
                    foreach (DataGridViewRow r in dgvAttributes.Rows)
                    {
                        r.Cells[4].Value = 0;
                        Editer(r.Index);
                    }
                }
                DataBaseController.AddAttr(txtName.Text, tableid, cmbType.Text, Convert.ToInt32(cbxKey.Checked), Convert.ToInt32(cbxIsNull.Checked));
                dgvAttributes.DataSource = DataBaseController.FillDgvAttr(tableid);
                for (int i = 0; i < dgvAttributes.RowCount; i++)
                {
                    dgvAttributes.Rows[i].Cells[0].Value = dgvAttributes.Rows[i].Cells[3].Value.ToString();
                    dgvAttributes.UpdateCellValue(3, i);
                }
                dgvAttributes.Columns[0].DisplayIndex = 2;
                dgvAttributes.Columns[3].Visible = false;
                dgvAttributes.Columns[1].Visible = false;
            }
        }

        private void FormAddEditAttribute_Load(object sender, EventArgs e)
        {
            DataTable dt = DataBaseController.DisplayTable("Entity where Name=N'" + tableName + "'");
            tableid = Convert.ToInt32(dt.Rows[0][0]);
            dgvAttributes.DataSource = DataBaseController.FillDgvAttr(tableid);
            for (int i = 0; i < dgvAttributes.RowCount; i++)
            {
                dgvAttributes.Rows[i].Cells[0].Value = dgvAttributes.Rows[i].Cells[3].Value.ToString();
                dgvAttributes.UpdateCellValue(3, i);
            }
            dgvAttributes.Columns[0].DisplayIndex = 2;
            dgvAttributes.Columns[3].Visible = false;
            dgvAttributes.Columns[1].Visible = false;
        }

        private void dgvAttributes_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int row = dgvAttributes.CurrentCell.RowIndex;
            if (dgvAttributes.CurrentCell.ColumnIndex == 4)
            {
                foreach(DataGridViewRow r in dgvAttributes.Rows)
                {
                    if (r.Index != row)
                    {
                        r.Cells[4].Value = 0;
                        Editer(r.Index);
                    }
                }
            }
            Editer(row);
        }

        private void Editer(int row)
        {
            int idValue = Convert.ToInt32(dgvAttributes.Rows[row].Cells[1].Value);
            string nameValue = dgvAttributes.Rows[row].Cells[2].Value.ToString();
            dgvAttributes.Rows[row].Cells[3].Value = dgvAttributes.Rows[row].Cells[0].Value.ToString();
            string typeValue = dgvAttributes.Rows[row].Cells[3].Value.ToString();
            int keyValue = Convert.ToInt32(dgvAttributes.Rows[row].Cells[4].Value);
            int nullValue = Convert.ToInt32(dgvAttributes.Rows[row].Cells[5].Value);
            DataBaseController.EditAttr(idValue, nameValue, typeValue, keyValue, nullValue);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (dgvAttributes.CurrentRow != null)
                Editer(dgvAttributes.CurrentCell.RowIndex);
            this.Close();
        }
    }
}
