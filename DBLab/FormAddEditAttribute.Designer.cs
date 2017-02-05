namespace DBLab
{
    partial class FormAddEditAttribute
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
            this.components = new System.ComponentModel.Container();
            this.dgvAttributes = new System.Windows.Forms.DataGridView();
            this.cmsDeleteRow = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiDeleteRow = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddRelations = new System.Windows.Forms.Button();
            this.btnAddAttribute = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.cbxKey = new System.Windows.Forms.CheckBox();
            this.cbxIsNull = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.Type = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttributes)).BeginInit();
            this.cmsDeleteRow.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAttributes
            // 
            this.dgvAttributes.AllowUserToAddRows = false;
            this.dgvAttributes.AllowUserToResizeColumns = false;
            this.dgvAttributes.AllowUserToResizeRows = false;
            this.dgvAttributes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAttributes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttributes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Type});
            this.dgvAttributes.ContextMenuStrip = this.cmsDeleteRow;
            this.dgvAttributes.Location = new System.Drawing.Point(0, 60);
            this.dgvAttributes.MultiSelect = false;
            this.dgvAttributes.Name = "dgvAttributes";
            this.dgvAttributes.RowHeadersVisible = false;
            this.dgvAttributes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvAttributes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvAttributes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAttributes.Size = new System.Drawing.Size(448, 162);
            this.dgvAttributes.TabIndex = 0;
            // 
            // cmsDeleteRow
            // 
            this.cmsDeleteRow.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDeleteRow});
            this.cmsDeleteRow.Name = "cmsDeleteRow";
            this.cmsDeleteRow.Size = new System.Drawing.Size(159, 26);
            // 
            // tsmiDeleteRow
            // 
            this.tsmiDeleteRow.Name = "tsmiDeleteRow";
            this.tsmiDeleteRow.Size = new System.Drawing.Size(158, 22);
            this.tsmiDeleteRow.Text = "Удалить строку";
            // 
            // btnAddRelations
            // 
            this.btnAddRelations.Location = new System.Drawing.Point(157, 228);
            this.btnAddRelations.Name = "btnAddRelations";
            this.btnAddRelations.Size = new System.Drawing.Size(134, 23);
            this.btnAddRelations.TabIndex = 1;
            this.btnAddRelations.Text = "Работа со связями";
            this.btnAddRelations.UseVisualStyleBackColor = true;
            // 
            // btnAddAttribute
            // 
            this.btnAddAttribute.Location = new System.Drawing.Point(12, 228);
            this.btnAddAttribute.Name = "btnAddAttribute";
            this.btnAddAttribute.Size = new System.Drawing.Size(134, 23);
            this.btnAddAttribute.TabIndex = 4;
            this.btnAddAttribute.Text = "Добавить атрибут";
            this.btnAddAttribute.UseVisualStyleBackColor = true;
            this.btnAddAttribute.Click += new System.EventHandler(this.btnAddAttribute_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Тип";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Первичный ключ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Обязательное";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 29);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 9;
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "integer",
            "real",
            "string",
            "date"});
            this.cmbType.Location = new System.Drawing.Point(118, 28);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(97, 21);
            this.cmbType.TabIndex = 10;
            // 
            // cbxKey
            // 
            this.cbxKey.AutoSize = true;
            this.cbxKey.Location = new System.Drawing.Point(263, 32);
            this.cbxKey.Name = "cbxKey";
            this.cbxKey.Size = new System.Drawing.Size(15, 14);
            this.cbxKey.TabIndex = 11;
            this.cbxKey.UseVisualStyleBackColor = true;
            // 
            // cbxIsNull
            // 
            this.cbxIsNull.AutoSize = true;
            this.cbxIsNull.Location = new System.Drawing.Point(368, 32);
            this.cbxIsNull.Name = "cbxIsNull";
            this.cbxIsNull.Size = new System.Drawing.Size(15, 14);
            this.cbxIsNull.TabIndex = 12;
            this.cbxIsNull.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(302, 228);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(134, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Type
            // 
            this.Type.HeaderText = "Тип";
            this.Type.Items.AddRange(new object[] {
            "integer",
            "real",
            "string",
            "date"});
            this.Type.Name = "Type";
            this.Type.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // FormAddEditAttribute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 261);
            this.Controls.Add(this.cbxIsNull);
            this.Controls.Add(this.cbxKey);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddAttribute);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnAddRelations);
            this.Controls.Add(this.dgvAttributes);
            this.Name = "FormAddEditAttribute";
            this.Text = "Атрибуты таблицы";
            this.Load += new System.EventHandler(this.FormAddEditAttribute_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttributes)).EndInit();
            this.cmsDeleteRow.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAttributes;
        private System.Windows.Forms.Button btnAddRelations;
        private System.Windows.Forms.ContextMenuStrip cmsDeleteRow;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteRow;
        private System.Windows.Forms.Button btnAddAttribute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.CheckBox cbxKey;
        private System.Windows.Forms.CheckBox cbxIsNull;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DataGridViewComboBoxColumn Type;
    }
}