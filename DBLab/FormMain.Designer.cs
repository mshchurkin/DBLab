namespace DBLab
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.lvTables = new System.Windows.Forms.ListView();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.addTable = new System.Windows.Forms.ToolStripButton();
            this.editTable = new System.Windows.Forms.ToolStripButton();
            this.deleteTable = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.addAttribute = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.addRelation = new System.Windows.Forms.ToolStripButton();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.delDtaBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tsMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // lvTables
            // 
            this.lvTables.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.lvTables.AutoArrange = false;
            this.lvTables.Dock = System.Windows.Forms.DockStyle.Left;
            this.lvTables.LabelWrap = false;
            this.lvTables.Location = new System.Drawing.Point(0, 25);
            this.lvTables.MultiSelect = false;
            this.lvTables.Name = "lvTables";
            this.lvTables.Size = new System.Drawing.Size(171, 413);
            this.lvTables.TabIndex = 0;
            this.lvTables.UseCompatibleStateImageBehavior = false;
            this.lvTables.SelectedIndexChanged += new System.EventHandler(this.lvTables_SelectedIndexChanged);
            this.lvTables.DoubleClick += new System.EventHandler(this.lvTables_DoubleClick);
            // 
            // tsMain
            // 
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.addTable,
            this.editTable,
            this.deleteTable,
            this.toolStripLabel2,
            this.addAttribute,
            this.toolStripLabel3,
            this.addRelation,
            this.delDtaBtn,
            this.toolStripLabel4,
            this.toolStripButton1});
            this.tsMain.Location = new System.Drawing.Point(0, 0);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(655, 25);
            this.tsMain.TabIndex = 1;
            this.tsMain.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(121, 22);
            this.toolStripLabel1.Text = "Работа с таблицами:";
            // 
            // addTable
            // 
            this.addTable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addTable.Image = ((System.Drawing.Image)(resources.GetObject("addTable.Image")));
            this.addTable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addTable.Name = "addTable";
            this.addTable.Size = new System.Drawing.Size(23, 22);
            this.addTable.Click += new System.EventHandler(this.addTable_Click);
            // 
            // editTable
            // 
            this.editTable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editTable.Image = ((System.Drawing.Image)(resources.GetObject("editTable.Image")));
            this.editTable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editTable.Name = "editTable";
            this.editTable.Size = new System.Drawing.Size(23, 22);
            this.editTable.Click += new System.EventHandler(this.editTable_Click);
            // 
            // deleteTable
            // 
            this.deleteTable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteTable.Enabled = false;
            this.deleteTable.Image = ((System.Drawing.Image)(resources.GetObject("deleteTable.Image")));
            this.deleteTable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteTable.Name = "deleteTable";
            this.deleteTable.Size = new System.Drawing.Size(23, 22);
            this.deleteTable.Click += new System.EventHandler(this.deleteTable_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(125, 22);
            this.toolStripLabel2.Text = "Работа с атрибутами:";
            // 
            // addAttribute
            // 
            this.addAttribute.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addAttribute.Image = ((System.Drawing.Image)(resources.GetObject("addAttribute.Image")));
            this.addAttribute.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addAttribute.Name = "addAttribute";
            this.addAttribute.Size = new System.Drawing.Size(23, 22);
            this.addAttribute.Click += new System.EventHandler(this.addAttribute_Click);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(112, 22);
            this.toolStripLabel3.Text = "Работа со связями:";
            // 
            // addRelation
            // 
            this.addRelation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addRelation.Image = ((System.Drawing.Image)(resources.GetObject("addRelation.Image")));
            this.addRelation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addRelation.Name = "addRelation";
            this.addRelation.Size = new System.Drawing.Size(23, 22);
            this.addRelation.Click += new System.EventHandler(this.addRelation_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToOrderColumns = true;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(171, 25);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(484, 413);
            this.dgv.TabIndex = 2;
            this.dgv.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellEndEdit);
            this.dgv.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgv_DataError);
            this.dgv.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_RowEnter);
            // 
            // delDtaBtn
            // 
            this.delDtaBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.delDtaBtn.Image = ((System.Drawing.Image)(resources.GetObject("delDtaBtn.Image")));
            this.delDtaBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.delDtaBtn.Name = "delDtaBtn";
            this.delDtaBtn.Size = new System.Drawing.Size(95, 22);
            this.delDtaBtn.Text = "Удалить строку";
            this.delDtaBtn.Visible = false;
            this.delDtaBtn.Click += new System.EventHandler(this.delDtaBtn_Click);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel4.Text = "Запросы:";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // FormMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 438);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.lvTables);
            this.Controls.Add(this.tsMain);
            this.Name = "FormMain";
            this.Text = "Работа с БД";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvTables;
        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ToolStripButton addTable;
        private System.Windows.Forms.ToolStripButton editTable;
        private System.Windows.Forms.ToolStripButton deleteTable;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton addAttribute;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton addRelation;
        private System.Windows.Forms.ToolStripButton delDtaBtn;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

