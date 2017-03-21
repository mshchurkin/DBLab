namespace DBLab
{
    partial class Queries
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
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Attribute = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sign = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbSign = new System.Windows.Forms.ComboBox();
            this.cmbCond = new System.Windows.Forms.ComboBox();
            this.cmbLeft = new System.Windows.Forms.ComboBox();
            this.btnDleft = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnDright = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.lbxTarget = new System.Windows.Forms.ListBox();
            this.lbxSource = new System.Windows.Forms.ListBox();
            this.cmbEntities = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvRes = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReport = new System.Windows.Forms.Button();
            this.tbxRight = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rtbText = new System.Windows.Forms.RichTextBox();
            this.dgvQueries = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCreateQuery = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueries)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQuery
            // 
            this.btnQuery.Enabled = false;
            this.btnQuery.Location = new System.Drawing.Point(487, 335);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 34);
            this.btnQuery.TabIndex = 29;
            this.btnQuery.Text = "Выполнить запрос";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(487, 230);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 34);
            this.btnDelete.TabIndex = 28;
            this.btnDelete.Text = "Удалить правило";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(487, 190);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 34);
            this.btnAdd.TabIndex = 27;
            this.btnAdd.Text = "Добавить правило";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Attribute,
            this.Sign,
            this.Value,
            this.Column1});
            this.dgv.Location = new System.Drawing.Point(12, 219);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(469, 150);
            this.dgv.TabIndex = 26;
            // 
            // Attribute
            // 
            this.Attribute.HeaderText = "Attribute";
            this.Attribute.Name = "Attribute";
            this.Attribute.ReadOnly = true;
            // 
            // Sign
            // 
            this.Sign.HeaderText = "Sign";
            this.Sign.Name = "Sign";
            this.Sign.ReadOnly = true;
            this.Sign.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Sign.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Value
            // 
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "OR/AND";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cmbSign
            // 
            this.cmbSign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSign.FormattingEnabled = true;
            this.cmbSign.Items.AddRange(new object[] {
            "OR",
            "AND"});
            this.cmbSign.Location = new System.Drawing.Point(430, 192);
            this.cmbSign.Name = "cmbSign";
            this.cmbSign.Size = new System.Drawing.Size(51, 21);
            this.cmbSign.TabIndex = 25;
            // 
            // cmbCond
            // 
            this.cmbCond.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCond.FormattingEnabled = true;
            this.cmbCond.Items.AddRange(new object[] {
            "=",
            "!=",
            "<",
            ">"});
            this.cmbCond.Location = new System.Drawing.Point(199, 192);
            this.cmbCond.Name = "cmbCond";
            this.cmbCond.Size = new System.Drawing.Size(53, 21);
            this.cmbCond.TabIndex = 23;
            // 
            // cmbLeft
            // 
            this.cmbLeft.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLeft.FormattingEnabled = true;
            this.cmbLeft.Location = new System.Drawing.Point(12, 192);
            this.cmbLeft.Name = "cmbLeft";
            this.cmbLeft.Size = new System.Drawing.Size(148, 21);
            this.cmbLeft.TabIndex = 22;
            this.cmbLeft.SelectedValueChanged += new System.EventHandler(this.cmbLeft_SelectedValueChanged);
            // 
            // btnDleft
            // 
            this.btnDleft.Location = new System.Drawing.Point(272, 158);
            this.btnDleft.Name = "btnDleft";
            this.btnDleft.Size = new System.Drawing.Size(31, 23);
            this.btnDleft.TabIndex = 21;
            this.btnDleft.Text = "<<";
            this.btnDleft.UseVisualStyleBackColor = true;
            this.btnDleft.Click += new System.EventHandler(this.btnDleft_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(272, 129);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(31, 23);
            this.btnLeft.TabIndex = 20;
            this.btnLeft.Text = "<";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnDright
            // 
            this.btnDright.Location = new System.Drawing.Point(272, 100);
            this.btnDright.Name = "btnDright";
            this.btnDright.Size = new System.Drawing.Size(31, 23);
            this.btnDright.TabIndex = 19;
            this.btnDright.Text = ">>";
            this.btnDright.UseVisualStyleBackColor = true;
            this.btnDright.Click += new System.EventHandler(this.btnDright_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(272, 71);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(31, 23);
            this.btnRight.TabIndex = 18;
            this.btnRight.Text = ">";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // lbxTarget
            // 
            this.lbxTarget.FormattingEnabled = true;
            this.lbxTarget.Location = new System.Drawing.Point(309, 65);
            this.lbxTarget.Name = "lbxTarget";
            this.lbxTarget.Size = new System.Drawing.Size(253, 121);
            this.lbxTarget.TabIndex = 17;
            // 
            // lbxSource
            // 
            this.lbxSource.FormattingEnabled = true;
            this.lbxSource.Location = new System.Drawing.Point(12, 65);
            this.lbxSource.Name = "lbxSource";
            this.lbxSource.Size = new System.Drawing.Size(253, 121);
            this.lbxSource.TabIndex = 16;
            // 
            // cmbEntities
            // 
            this.cmbEntities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEntities.FormattingEnabled = true;
            this.cmbEntities.Items.AddRange(new object[] {
            "Model",
            "Entity",
            "Relation",
            "Transformation",
            "Attribute",
            "Restriction",
            "Pictograph"});
            this.cmbEntities.Location = new System.Drawing.Point(12, 25);
            this.cmbEntities.Name = "cmbEntities";
            this.cmbEntities.Size = new System.Drawing.Size(121, 21);
            this.cmbEntities.TabIndex = 30;
            this.cmbEntities.SelectedIndexChanged += new System.EventHandler(this.cmbEntities_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Выберите таблицу:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(442, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Выберите атрибуты таблицы, которые должны отображаться в результатах запроса:";
            // 
            // dgvRes
            // 
            this.dgvRes.AllowUserToAddRows = false;
            this.dgvRes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRes.Location = new System.Drawing.Point(9, 493);
            this.dgvRes.Name = "dgvRes";
            this.dgvRes.ReadOnly = true;
            this.dgvRes.RowHeadersVisible = false;
            this.dgvRes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRes.Size = new System.Drawing.Size(550, 150);
            this.dgvRes.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 477);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Результаты запроса:";
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(417, 649);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(142, 23);
            this.btnReport.TabIndex = 35;
            this.btnReport.Text = "Выгрузить отчет в Excel";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // tbxRight
            // 
            this.tbxRight.Location = new System.Drawing.Point(291, 192);
            this.tbxRight.Name = "tbxRight";
            this.tbxRight.Size = new System.Drawing.Size(100, 20);
            this.tbxRight.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Текст запроса:";
            // 
            // rtbText
            // 
            this.rtbText.Location = new System.Drawing.Point(15, 388);
            this.rtbText.Name = "rtbText";
            this.rtbText.Size = new System.Drawing.Size(288, 86);
            this.rtbText.TabIndex = 37;
            this.rtbText.Text = "";
            this.rtbText.TextChanged += new System.EventHandler(this.rtbText_TextChanged);
            // 
            // dgvQueries
            // 
            this.dgvQueries.AllowUserToAddRows = false;
            this.dgvQueries.AllowUserToDeleteRows = false;
            this.dgvQueries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQueries.Location = new System.Drawing.Point(309, 388);
            this.dgvQueries.MultiSelect = false;
            this.dgvQueries.Name = "dgvQueries";
            this.dgvQueries.ReadOnly = true;
            this.dgvQueries.Size = new System.Drawing.Size(250, 86);
            this.dgvQueries.TabIndex = 38;
            this.dgvQueries.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQueries_CellContentDoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(306, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Запросы:";
            // 
            // btnCreateQuery
            // 
            this.btnCreateQuery.Enabled = false;
            this.btnCreateQuery.Location = new System.Drawing.Point(487, 295);
            this.btnCreateQuery.Name = "btnCreateQuery";
            this.btnCreateQuery.Size = new System.Drawing.Size(75, 34);
            this.btnCreateQuery.TabIndex = 40;
            this.btnCreateQuery.Text = "Создать запрос";
            this.btnCreateQuery.UseVisualStyleBackColor = true;
            this.btnCreateQuery.Click += new System.EventHandler(this.btnCreateQuery_Click);
            // 
            // Queries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 687);
            this.Controls.Add(this.btnCreateQuery);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvQueries);
            this.Controls.Add(this.rtbText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvRes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbEntities);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.cmbSign);
            this.Controls.Add(this.tbxRight);
            this.Controls.Add(this.cmbCond);
            this.Controls.Add(this.cmbLeft);
            this.Controls.Add(this.btnDleft);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnDright);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.lbxTarget);
            this.Controls.Add(this.lbxSource);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(590, 900);
            this.MinimumSize = new System.Drawing.Size(590, 726);
            this.Name = "Queries";
            this.Text = "Запросы";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Queries_FormClosed);
            this.Load += new System.EventHandler(this.Queries_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueries)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Attribute;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sign;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.ComboBox cmbSign;
        private System.Windows.Forms.ComboBox cmbCond;
        private System.Windows.Forms.ComboBox cmbLeft;
        private System.Windows.Forms.Button btnDleft;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnDright;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.ListBox lbxTarget;
        private System.Windows.Forms.ListBox lbxSource;
        private System.Windows.Forms.ComboBox cmbEntities;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvRes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.TextBox tbxRight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtbText;
        private System.Windows.Forms.DataGridView dgvQueries;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCreateQuery;
    }
}