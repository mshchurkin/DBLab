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
            String connectionString =
                    $@"Data Source=(localdb)\Projects;Initial Catalog=metaLabDB;Integrated Security=True";
            SqlConnection sqlConn = new SqlConnection(connectionString);
            foreach (string elem in DataBaseController.listFiller(sqlConn))
            {
                lvTables.Items.Add(elem);
            }
            dgv.DataSource = DataBaseController.DisplayTable("dbo.String", sqlConn);
        }
    }
}
    
