namespace DBLab
{
    partial class FormAddEditRelation
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtRelationName = new System.Windows.Forms.TextBox();
            this.cbxPrimaryTable = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxOutterTable = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxPrimaryAttr = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxOutterAttr = new System.Windows.Forms.ComboBox();
            this.btnAddRelation = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя связи:";
            // 
            // txtRelationName
            // 
            this.txtRelationName.Location = new System.Drawing.Point(83, 12);
            this.txtRelationName.Name = "txtRelationName";
            this.txtRelationName.Size = new System.Drawing.Size(259, 20);
            this.txtRelationName.TabIndex = 1;
            // 
            // cbxPrimaryTable
            // 
            this.cbxPrimaryTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPrimaryTable.FormattingEnabled = true;
            this.cbxPrimaryTable.Location = new System.Drawing.Point(12, 65);
            this.cbxPrimaryTable.Name = "cbxPrimaryTable";
            this.cbxPrimaryTable.Size = new System.Drawing.Size(148, 21);
            this.cbxPrimaryTable.TabIndex = 2;
            this.cbxPrimaryTable.SelectedValueChanged += new System.EventHandler(this.cbxPrimaryTable_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Таблица первичного ключа:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Таблица внешнего ключа:";
            // 
            // cbxOutterTable
            // 
            this.cbxOutterTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOutterTable.FormattingEnabled = true;
            this.cbxOutterTable.Location = new System.Drawing.Point(194, 65);
            this.cbxOutterTable.Name = "cbxOutterTable";
            this.cbxOutterTable.Size = new System.Drawing.Size(148, 21);
            this.cbxOutterTable.TabIndex = 5;
            this.cbxOutterTable.SelectedValueChanged += new System.EventHandler(this.cbxOutterTable_SelectedValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 168);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(330, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Атрибут первичного ключа:";
            // 
            // cbxPrimaryAttr
            // 
            this.cbxPrimaryAttr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPrimaryAttr.FormattingEnabled = true;
            this.cbxPrimaryAttr.Location = new System.Drawing.Point(12, 105);
            this.cbxPrimaryAttr.Name = "cbxPrimaryAttr";
            this.cbxPrimaryAttr.Size = new System.Drawing.Size(148, 21);
            this.cbxPrimaryAttr.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(191, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Атрибут внешнего ключа:";
            // 
            // cbxOutterAttr
            // 
            this.cbxOutterAttr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOutterAttr.FormattingEnabled = true;
            this.cbxOutterAttr.Location = new System.Drawing.Point(194, 105);
            this.cbxOutterAttr.Name = "cbxOutterAttr";
            this.cbxOutterAttr.Size = new System.Drawing.Size(148, 21);
            this.cbxOutterAttr.TabIndex = 10;
            // 
            // btnAddRelation
            // 
            this.btnAddRelation.Location = new System.Drawing.Point(122, 139);
            this.btnAddRelation.Name = "btnAddRelation";
            this.btnAddRelation.Size = new System.Drawing.Size(106, 23);
            this.btnAddRelation.TabIndex = 11;
            this.btnAddRelation.Text = "Добавить связь";
            this.btnAddRelation.UseVisualStyleBackColor = true;
            this.btnAddRelation.Click += new System.EventHandler(this.btnAddRelation_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(267, 324);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 12;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // FormAddEditRelation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 354);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnAddRelation);
            this.Controls.Add(this.cbxOutterAttr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxPrimaryAttr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbxOutterTable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxPrimaryTable);
            this.Controls.Add(this.txtRelationName);
            this.Controls.Add(this.label1);
            this.Name = "FormAddEditRelation";
            this.Text = "Работа со связями";
            this.Load += new System.EventHandler(this.FormAddEditRelation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRelationName;
        private System.Windows.Forms.ComboBox cbxPrimaryTable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxOutterTable;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxPrimaryAttr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxOutterAttr;
        private System.Windows.Forms.Button btnAddRelation;
        private System.Windows.Forms.Button btnOK;
    }
}