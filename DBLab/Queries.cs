using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using Excel = Microsoft.Office.Interop.Excel;
//using Microsoft.Office.Tools.Excel;

namespace DBLab
{
    public partial class Queries : Form
    {
        int n = 0;
        string type = "";

        public Queries()
        {
            InitializeComponent();
        }

        private void Queries_Load(object sender, EventArgs e)// создание словаря из сущечтвующих множеств сущностей
        {
            cmbEntities.DataSource = DataBaseController.DisplayTable("Entity");
            cmbEntities.DisplayMember = "Name";
            dgvQueries.DataSource = DataBaseController.FillDgvQuery();
        }

        private void btnRight_Click(object sender, EventArgs e)// выбор атрибута для отображения в отчете
        {
            if (lbxSource.SelectedItem == null)
            {
                MessageBox.Show("Не выбран атрибут.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cmbLeft.Items.Add(lbxSource.SelectedItem.ToString());
                lbxTarget.Items.Add(lbxSource.SelectedItem.ToString());
                lbxSource.Items.RemoveAt(lbxSource.SelectedIndex);
            }
        }

        private void btnLeft_Click(object sender, EventArgs e)// удаление атрибута из списка для отображения в отчете
        {
            if (lbxTarget.SelectedItem == null)
            {
                MessageBox.Show("Не выбран атрибут.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cmbLeft.Items.Remove(lbxTarget.SelectedItem.ToString());
                lbxSource.Items.Add(lbxTarget.SelectedItem.ToString());
                lbxTarget.Items.RemoveAt(lbxTarget.SelectedIndex);
            }
        }

        private void btnDright_Click(object sender, EventArgs e)// выбор всех атрибутов для вывода в отчете
        {
            foreach (string oc in lbxSource.Items)
            {
                cmbLeft.Items.Add(oc);
                lbxTarget.Items.Add(oc);
            }
            lbxSource.Items.Clear();
        }

        private void btnDleft_Click(object sender, EventArgs e)// удаление всех атрибуто из списка для отображения в отчете
        {
            foreach (string oc in lbxTarget.Items)
            {
                cmbLeft.Items.Remove(oc);
                lbxSource.Items.Add(oc);
            }
            lbxTarget.Items.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)// добавление правила для запроса
        {
            if (cmbLeft.SelectedItem == null || cmbCond.SelectedItem == null || cmbSign.SelectedItem == null)
            {
                MessageBox.Show("Не введены все параметры.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool flag = true;
                switch (type)
                {
                    case "integer":
                        int m;
                        flag = int.TryParse(tbxRight.Text, out m);
                        break;
                    case "real":
                        double t;
                        flag = double.TryParse(tbxRight.Text, out t);
                        break;
                    case "date":
                        DateTime u;
                        flag = DateTime.TryParse(tbxRight.Text, out u);
                        break;
                }
                if (flag)
                {
                    dgv.Rows.Add();
                    dgv[0, dgv.RowCount - 1].Value = cmbLeft.SelectedItem;
                    dgv[1, dgv.RowCount - 1].Value = cmbCond.SelectedItem;
                    dgv[2, dgv.RowCount - 1].Value = tbxRight.Text;
                    if (!(dgv.Rows.Count == 1))
                        dgv[3, dgv.RowCount - 1].Value = cmbSign.SelectedItem;
                    else
                    {
                        dgv[3, dgv.RowCount - 1].Value = "";
                        btnCreateQuery.Enabled = true;
                    }
                }
                else
                    MessageBox.Show("Атрибут не может принимать введенное значение.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }

        private void btnDelete_Click(object sender, EventArgs e)// удаление правила из таблицы
        {
            if (dgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Отсутствуют правила в таблице.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dgv.Rows.Remove(dgv.SelectedRows[0]);
                if (dgv.Rows.Count == 0)
                    btnCreateQuery.Enabled = false;
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)// выполнение запроса
        {
            try
            {
                string[] mas = rtbText.Text.Trim().Split(' ', Convert.ToChar(10));
                string tablename = "";
                int k = 0;
                int m = 0;
                for (int i = 0; i < mas.Length; i++)
                {
                    if (mas[i] == "from")
                    {
                        tablename = mas[i + 1];
                        k = i + 3;
                        m = i;
                        break;
                    }
                }

                dgvRes.DataSource = null;
                dgvRes.Rows.Clear();
                dgvRes.Columns.Clear();

                DataTable dt_table_name = DataBaseController.DisplayTable("Entity where Name = N'" + tablename + "'");
                DataTable dt_atr = DataBaseController.GetAttrForData(dt_table_name.Rows[0][0].ToString());
                DataTable dt_data = DataBaseController.GetInstance(dt_table_name.Rows[0][0].ToString());

                for (int i = 0; i < dt_atr.Rows.Count; i++)
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
                        catch (Exception)
                        {
                            dt_data.Rows.Add();
                            dt_data.Rows[j][i + 1] = dt_data_col2.Rows[j][0];
                        }
                    }
                    dt_data.Columns[i + 1].Caption = dt_atr.Rows[i][1].ToString();
                    dt_data.Columns[i + 1].ColumnName = dt_atr.Rows[i][1].ToString();
                }

                for (int i = dt_data.Rows.Count - 1; i >= 0; i--)
                {
                    bool flag = true;
                    List<Tuple<bool, string>> results = new List<Tuple<bool, string>>();
                    while (k < mas.Length)
                    {
                        DateTime d;
                        switch (mas[k + 1])
                        {
                            case "=":
                                results.Add(Tuple.Create(dt_data.Rows[0][mas[k]].ToString() == mas[k + 2], (k + 3 >= mas.Length - 1) ? "" : mas[k + 3]));
                                break;
                            case "!=":
                                results.Add(Tuple.Create(dt_data.Rows[0][mas[k]].ToString() != mas[k + 2], (k + 3 >= mas.Length - 1) ? "" : mas[k + 3]));
                                break;
                            case ">":
                                if (DateTime.TryParse(mas[k + 2], out d))
                                    results.Add(Tuple.Create(Convert.ToDateTime(dt_data.Rows[0][mas[k]].ToString()) > Convert.ToDateTime(mas[k + 2]), (k + 3 >= mas.Length - 1) ? "" : mas[k + 3]));
                                else
                                    results.Add(Tuple.Create(Convert.ToDouble(dt_data.Rows[0][mas[k]].ToString()) > Convert.ToDouble(mas[k + 2]), (k + 3 >= mas.Length - 1) ? "" : mas[k + 3]));
                                break;
                            case "<":
                                if (DateTime.TryParse(mas[k + 2], out d))
                                    results.Add(Tuple.Create(Convert.ToDateTime(dt_data.Rows[0][mas[k]].ToString()) < Convert.ToDateTime(mas[k + 2]), (k + 3 >= mas.Length - 1) ? "" : mas[k + 3]));
                                else
                                    results.Add(Tuple.Create(Convert.ToDouble(dt_data.Rows[0][mas[k]].ToString()) < Convert.ToDouble(mas[k + 2]), (k + 3 >= mas.Length - 1) ? "" : mas[k + 3]));
                                break;
                        }
                        k += 4;
                    }

                    flag = results[0].Item1;
                    for (int j = 1; j < results.Count; j++)
                    {
                        if (results[j - 1].Item2 == "OR")
                            flag = flag || results[j].Item1;
                        else
                            flag = flag && results[j].Item1;
                    }

                    if (!flag)
                        dt_data.Rows.RemoveAt(i);
                }
                string[] masattr = new string[m - 1];
                Array.Copy(mas, 1, masattr, 0, m - 1);
                for (int i = 0; i < masattr.Length; i++)
                {
                    if (masattr[i].Contains(","))
                        masattr[i] = masattr[i].Remove(masattr[i].Length - 1);
                }
                for (int i = dt_data.Columns.Count - 1; i > 0; i--)
                {
                    if (!masattr.Contains(dt_data.Columns[i].Caption))
                        dt_data.Columns.RemoveAt(i);
                }

                dgvRes.DataSource = dt_data;
                dgvRes.Columns[0].Visible = false;
            }
            catch
            {
                MessageBox.Show("Запрос содержит ошибки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbEntities_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbxSource.Items.Clear();
            lbxTarget.Items.Clear();
            cmbLeft.Items.Clear();
            dgv.Rows.Clear();
            DataTable dt = DataBaseController.DisplayTable("Attribute where id in (select id_Attribute from EA where id_Entity = " + (cmbEntities.SelectedItem as DataRowView)[0].ToString() + ")");
            for (int i = 0; i < dt.Rows.Count; i++)
                lbxSource.Items.Add(dt.Rows[i][1].ToString());
        }

        private void Queries_FormClosed(object sender, FormClosedEventArgs e)
        {
            //mainFm.Enabled = true;
        }

        private void btnReport_Click(object sender, EventArgs e)// выгрузка отчета в Excel
        {
            Excel.Application xlsA = new Excel.Application();
            xlsA.Workbooks.Add();
            Excel.Worksheet xlsWs=xlsA.Workbooks[1].Worksheets.Item[1];
            for (int i = 0; i < dgvRes.RowCount; i++)
                for (int j = 0; j < dgvRes.ColumnCount; j++)
                {
                    DataGridViewCell cell = dgvRes[j, i];
                    xlsWs.Cells[i + 2, j + 1] = cell.Value.ToString();
                }
            for (int i = 0; i < dgvRes.ColumnCount;i++ )
            {
                xlsWs.Cells[1, i + 1] = dgvRes.Columns[i].Name;
                xlsA.Columns[i + 1].AutoFit();
            }
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel files (*.xls)|*.xls|Excel files (*.xlsx)|*.xlsx";
            sfd.Title = "Сохранение отчета";
            sfd.FileName = "Report" + n;
            n++;
            if (sfd.ShowDialog() == DialogResult.OK)
                xlsWs.SaveAs(sfd.FileName);

            xlsA.Visible = true;
        }

        private void cmbLeft_SelectedValueChanged(object sender, EventArgs e)
        {
            cmbCond.Items.Clear();
            cmbCond.Items.Add("=");
            cmbCond.Items.Add("!=");
            DataTable dt = DataBaseController.DisplayTable("EA where id_Attribute in ( select id from Attribute where Name = N'" + cmbLeft.SelectedItem.ToString() + "')");
            if (dt.Rows[0][3].ToString() == "integer" || dt.Rows[0][3].ToString() == "real")
            {
                cmbCond.Items.Add(">");
                cmbCond.Items.Add("<");
            }
            type = dt.Rows[0][3].ToString();
        }

        private void btnCreateQuery_Click(object sender, EventArgs e)
        {
            string text = "select ";
            foreach (string s in lbxTarget.Items)
            {
                text += s + ", ";
            }
            text = text.Remove(text.Length - 2, 2);
            text += "\nfrom " + (cmbEntities.SelectedItem as DataRowView)[1].ToString() + "\nwhere ";

            foreach (DataGridViewRow r in dgv.Rows)
            {
                if (r.Cells[3].Value.ToString() != "")
                    text += r.Cells[3].Value.ToString() + " ";
                text += r.Cells[0].Value.ToString() + " " + r.Cells[1].Value.ToString() + " " + r.Cells[2].Value.ToString() + " ";
            }
            rtbText.Text = text;

            DataBaseController.AddQuery(text);
            dgvQueries.DataSource = DataBaseController.FillDgvQuery();
        }

        private void rtbText_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(rtbText.Text))
                btnQuery.Enabled = true;
            else
                btnQuery.Enabled = false;
        }

        private void dgvQueries_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            rtbText.Text = dgvQueries[e.ColumnIndex, e.RowIndex].Value.ToString();
        }
    }
}
