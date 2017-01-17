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
            this.addTable = new System.Windows.Forms.ToolStripButton();
            this.deleteTable = new System.Windows.Forms.ToolStripButton();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.tsMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // lvTables
            // 
            this.lvTables.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.lvTables.AutoArrange = false;
            this.lvTables.Dock = System.Windows.Forms.DockStyle.Left;
            this.lvTables.Location = new System.Drawing.Point(0, 25);
            this.lvTables.Name = "lvTables";
            this.lvTables.Size = new System.Drawing.Size(171, 413);
            this.lvTables.TabIndex = 0;
            this.lvTables.UseCompatibleStateImageBehavior = false;
            // 
            // tsMain
            // 
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTable,
            this.deleteTable});
            this.tsMain.Location = new System.Drawing.Point(0, 0);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(655, 25);
            this.tsMain.TabIndex = 1;
            this.tsMain.Text = "toolStrip1";
            // 
            // addTable
            // 
            this.addTable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addTable.Image = ((System.Drawing.Image)(resources.GetObject("addTable.Image")));
            this.addTable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addTable.Name = "addTable";
            this.addTable.Size = new System.Drawing.Size(23, 22);
            // 
            // deleteTable
            // 
            this.deleteTable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteTable.Image = ((System.Drawing.Image)(resources.GetObject("deleteTable.Image")));
            this.deleteTable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteTable.Name = "deleteTable";
            this.deleteTable.Size = new System.Drawing.Size(23, 22);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(171, 25);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(484, 413);
            this.dgv.TabIndex = 2;
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
        private System.Windows.Forms.ToolStripButton deleteTable;
    }
}

