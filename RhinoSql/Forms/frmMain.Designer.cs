namespace RhinoSql.Forms
{
    partial class frmMain
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
            this.TabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.tpGeneral = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtView = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtbxQuery = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvParams = new System.Windows.Forms.DataGridView();
            this.paramName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Output = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Remove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtProcedureName = new System.Windows.Forms.TextBox();
            this.chkErrorHandle = new MaterialSkin.Controls.MaterialCheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkBoxMSSQL = new MaterialSkin.Controls.MaterialCheckBox();
            this.chkBoxMySQl = new MaterialSkin.Controls.MaterialCheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.TabControl.SuspendLayout();
            this.tpGeneral.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParams)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl.Controls.Add(this.tpGeneral);
            this.TabControl.Controls.Add(this.tabPage2);
            this.TabControl.Depth = 0;
            this.TabControl.Location = new System.Drawing.Point(16, 104);
            this.TabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1037, 776);
            this.TabControl.TabIndex = 0;
            // 
            // tpGeneral
            // 
            this.tpGeneral.Controls.Add(this.groupBox5);
            this.tpGeneral.Controls.Add(this.groupBox4);
            this.tpGeneral.Controls.Add(this.groupBox3);
            this.tpGeneral.Controls.Add(this.groupBox2);
            this.tpGeneral.Controls.Add(this.groupBox1);
            this.tpGeneral.Location = new System.Drawing.Point(4, 22);
            this.tpGeneral.Name = "tpGeneral";
            this.tpGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tpGeneral.Size = new System.Drawing.Size(1029, 750);
            this.tpGeneral.TabIndex = 0;
            this.tpGeneral.Text = "General";
            this.tpGeneral.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtView);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox5.Location = new System.Drawing.Point(563, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(460, 738);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "View";
            // 
            // txtView
            // 
            this.txtView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtView.Location = new System.Drawing.Point(7, 23);
            this.txtView.Multiline = true;
            this.txtView.Name = "txtView";
            this.txtView.Size = new System.Drawing.Size(447, 709);
            this.txtView.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listBox1);
            this.groupBox4.Controls.Add(this.txtbxQuery);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox4.Location = new System.Drawing.Point(6, 516);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(540, 228);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Query";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(11, 205);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(46, 17);
            this.listBox1.TabIndex = 1;
            this.listBox1.Visible = false;
            // 
            // txtbxQuery
            // 
            this.txtbxQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxQuery.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtbxQuery.Location = new System.Drawing.Point(7, 20);
            this.txtbxQuery.Multiline = true;
            this.txtbxQuery.Name = "txtbxQuery";
            this.txtbxQuery.Size = new System.Drawing.Size(527, 179);
            this.txtbxQuery.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvParams);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox3.Location = new System.Drawing.Point(6, 165);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(540, 335);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Parameters";
            // 
            // dgvParams
            // 
            this.dgvParams.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvParams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParams.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.paramName,
            this.Type,
            this.Size,
            this.Output,
            this.Remove});
            this.dgvParams.Location = new System.Drawing.Point(11, 19);
            this.dgvParams.Name = "dgvParams";
            this.dgvParams.RowHeadersVisible = false;
            this.dgvParams.Size = new System.Drawing.Size(523, 310);
            this.dgvParams.TabIndex = 0;
            this.dgvParams.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvParams_CellContentClick);
            this.dgvParams.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvParams_CellEndEdit);
            this.dgvParams.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvParams_DataError);
            // 
            // paramName
            // 
            this.paramName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.paramName.HeaderText = "Param name";
            this.paramName.Name = "paramName";
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Items.AddRange(new object[] {
            "image",
            "text",
            "uniqueidentifier",
            "date",
            "time",
            "datetime2",
            "datetimeoffset",
            "tinyint",
            "smallint",
            "int",
            "smalldatetime",
            "real",
            "money",
            "datetime",
            "float",
            "sql_variant",
            "ntext",
            "bit",
            "decimal",
            "numeric",
            "smallmoney",
            "bigint",
            "hierarchyid",
            "geometry",
            "geography",
            "varbinary",
            "varchar",
            "binary",
            "char",
            "timestamp",
            "nvarchar",
            "nchar",
            "xml",
            "sysname",
            "AuditObservations",
            "OnlineFoms"});
            this.Type.Name = "Type";
            // 
            // Size
            // 
            this.Size.HeaderText = "Size";
            this.Size.Name = "Size";
            this.Size.Width = 70;
            // 
            // Output
            // 
            this.Output.HeaderText = "Output";
            this.Output.Name = "Output";
            this.Output.Width = 50;
            // 
            // Remove
            // 
            this.Remove.HeaderText = "Remove";
            this.Remove.Name = "Remove";
            this.Remove.Text = "Remove";
            this.Remove.UseColumnTextForButtonValue = true;
            this.Remove.Width = 70;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtProcedureName);
            this.groupBox2.Controls.Add(this.chkErrorHandle);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox2.Location = new System.Drawing.Point(6, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(540, 61);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Error Handling";
            // 
            // txtProcedureName
            // 
            this.txtProcedureName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcedureName.Location = new System.Drawing.Point(11, 23);
            this.txtProcedureName.Name = "txtProcedureName";
            this.txtProcedureName.Size = new System.Drawing.Size(315, 26);
            this.txtProcedureName.TabIndex = 3;
            this.txtProcedureName.TextChanged += new System.EventHandler(this.txtProcedureName_TextChanged);
            this.txtProcedureName.Enter += new System.EventHandler(this.txtProcedureName_Enter);
            this.txtProcedureName.Leave += new System.EventHandler(this.txtProcedureName_Leave);
            // 
            // chkErrorHandle
            // 
            this.chkErrorHandle.AutoSize = true;
            this.chkErrorHandle.Depth = 0;
            this.chkErrorHandle.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkErrorHandle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkErrorHandle.Location = new System.Drawing.Point(415, 19);
            this.chkErrorHandle.Margin = new System.Windows.Forms.Padding(0);
            this.chkErrorHandle.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkErrorHandle.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkErrorHandle.Name = "chkErrorHandle";
            this.chkErrorHandle.Ripple = true;
            this.chkErrorHandle.Size = new System.Drawing.Size(105, 30);
            this.chkErrorHandle.TabIndex = 2;
            this.chkErrorHandle.Text = "Error handle";
            this.chkErrorHandle.UseVisualStyleBackColor = true;
            this.chkErrorHandle.CheckedChanged += new System.EventHandler(this.chkErrorHandle_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkBoxMSSQL);
            this.groupBox1.Controls.Add(this.chkBoxMySQl);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 68);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SQL version";
            // 
            // chkBoxMSSQL
            // 
            this.chkBoxMSSQL.AutoSize = true;
            this.chkBoxMSSQL.Checked = true;
            this.chkBoxMSSQL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoxMSSQL.Depth = 0;
            this.chkBoxMSSQL.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkBoxMSSQL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkBoxMSSQL.Location = new System.Drawing.Point(11, 23);
            this.chkBoxMSSQL.Margin = new System.Windows.Forms.Padding(0);
            this.chkBoxMSSQL.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkBoxMSSQL.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkBoxMSSQL.Name = "chkBoxMSSQL";
            this.chkBoxMSSQL.Ripple = true;
            this.chkBoxMSSQL.Size = new System.Drawing.Size(79, 30);
            this.chkBoxMSSQL.TabIndex = 0;
            this.chkBoxMSSQL.Text = "MS SQL";
            this.chkBoxMSSQL.UseVisualStyleBackColor = true;
            this.chkBoxMSSQL.CheckedChanged += new System.EventHandler(this.chkBoxMSSQL_CheckedChanged);
            // 
            // chkBoxMySQl
            // 
            this.chkBoxMySQl.AutoSize = true;
            this.chkBoxMySQl.Depth = 0;
            this.chkBoxMySQl.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkBoxMySQl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkBoxMySQl.Location = new System.Drawing.Point(137, 23);
            this.chkBoxMySQl.Margin = new System.Windows.Forms.Padding(0);
            this.chkBoxMySQl.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkBoxMySQl.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkBoxMySQl.Name = "chkBoxMySQl";
            this.chkBoxMySQl.Ripple = true;
            this.chkBoxMySQl.Size = new System.Drawing.Size(77, 30);
            this.chkBoxMySQl.TabIndex = 1;
            this.chkBoxMySQl.Text = "My SQL";
            this.chkBoxMySQl.UseVisualStyleBackColor = true;
            this.chkBoxMySQl.CheckedChanged += new System.EventHandler(this.chkBoxMySQl_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1029, 750);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Editor";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // TabSelector
            // 
            this.TabSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabSelector.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TabSelector.BaseTabControl = this.TabControl;
            this.TabSelector.Depth = 0;
            this.TabSelector.Location = new System.Drawing.Point(16, 75);
            this.TabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabSelector.Name = "TabSelector";
            this.TabSelector.Size = new System.Drawing.Size(1033, 23);
            this.TabSelector.TabIndex = 1;
            this.TabSelector.Text = "materialTabSelector1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 901);
            this.Controls.Add(this.TabSelector);
            this.Controls.Add(this.TabControl);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rhino SQL";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.TabControl.ResumeLayout(false);
            this.tpGeneral.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParams)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl TabControl;
        private System.Windows.Forms.TabPage tpGeneral;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTabSelector TabSelector;
        private MaterialSkin.Controls.MaterialCheckBox chkBoxMSSQL;
        private MaterialSkin.Controls.MaterialCheckBox chkBoxMySQl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialCheckBox chkErrorHandle;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvParams;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtbxQuery;
        private System.Windows.Forms.DataGridViewTextBoxColumn paramName;
        private System.Windows.Forms.DataGridViewComboBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Output;
        private System.Windows.Forms.DataGridViewButtonColumn Remove;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtView;
        private System.Windows.Forms.TextBox txtProcedureName;
    }
}