namespace NHibernateClassGenerator
{
    partial class App
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
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.basicTab = new System.Windows.Forms.TabPage();
            this.btnGetData = new System.Windows.Forms.Button();
            this.btnSaveConnection = new System.Windows.Forms.Button();
            this.tabControlModes = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.generateButton = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.generateModernButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dbTableDetailsGridView = new System.Windows.Forms.DataGridView();
            this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDataType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSharpType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.isPrimaryKey = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isForeignKey = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isNullable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IsIdentity = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isUniqueKey = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ConstraintName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ForeignKeyTableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ForeignKeyColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtMapCode = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtDomainCode = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtServices = new System.Windows.Forms.TextBox();
            this.tableGroupBox = new System.Windows.Forms.GroupBox();
            this.TableFilterTextBox = new System.Windows.Forms.TextBox();
            this.tablesListBox = new System.Windows.Forms.ListBox();
            this.ownersComboBox = new System.Windows.Forms.ComboBox();
            this.labelTableName = new System.Windows.Forms.Label();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.labelScheme = new System.Windows.Forms.Label();
            this.txtScheme = new System.Windows.Forms.TextBox();
            this.labelConnectionString = new System.Windows.Forms.Label();
            this.txtConnectionString = new System.Windows.Forms.TextBox();
            this.advanceSettingsTabPage = new System.Windows.Forms.TabPage();
            this.mainTabControl.SuspendLayout();
            this.basicTab.SuspendLayout();
            this.tabControlModes.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbTableDetailsGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tableGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.basicTab);
            this.mainTabControl.Controls.Add(this.advanceSettingsTabPage);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(945, 601);
            this.mainTabControl.TabIndex = 0;
            // 
            // basicTab
            // 
            this.basicTab.Controls.Add(this.btnGetData);
            this.basicTab.Controls.Add(this.btnSaveConnection);
            this.basicTab.Controls.Add(this.tabControlModes);
            this.basicTab.Controls.Add(this.tabControl1);
            this.basicTab.Controls.Add(this.tableGroupBox);
            this.basicTab.Controls.Add(this.labelTableName);
            this.basicTab.Controls.Add(this.txtTableName);
            this.basicTab.Controls.Add(this.labelScheme);
            this.basicTab.Controls.Add(this.txtScheme);
            this.basicTab.Controls.Add(this.labelConnectionString);
            this.basicTab.Controls.Add(this.txtConnectionString);
            this.basicTab.Location = new System.Drawing.Point(4, 22);
            this.basicTab.Name = "basicTab";
            this.basicTab.Padding = new System.Windows.Forms.Padding(3);
            this.basicTab.Size = new System.Drawing.Size(937, 575);
            this.basicTab.TabIndex = 0;
            this.basicTab.Text = "tabPage1";
            this.basicTab.UseVisualStyleBackColor = true;
            // 
            // btnGetData
            // 
            this.btnGetData.Location = new System.Drawing.Point(547, 3);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(75, 23);
            this.btnGetData.TabIndex = 27;
            this.btnGetData.Text = "Get Info";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.btnGetInfo_Click);
            // 
            // btnSaveConnection
            // 
            this.btnSaveConnection.Location = new System.Drawing.Point(466, 3);
            this.btnSaveConnection.Name = "btnSaveConnection";
            this.btnSaveConnection.Size = new System.Drawing.Size(75, 23);
            this.btnSaveConnection.TabIndex = 26;
            this.btnSaveConnection.Text = "Save Info";
            this.btnSaveConnection.UseVisualStyleBackColor = true;
            this.btnSaveConnection.Click += new System.EventHandler(this.btnSaveConnection_Click);
            // 
            // tabControlModes
            // 
            this.tabControlModes.Controls.Add(this.tabPage5);
            this.tabControlModes.Controls.Add(this.tabPage6);
            this.tabControlModes.Location = new System.Drawing.Point(12, 472);
            this.tabControlModes.Name = "tabControlModes";
            this.tabControlModes.SelectedIndex = 0;
            this.tabControlModes.Size = new System.Drawing.Size(399, 100);
            this.tabControlModes.TabIndex = 25;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.generateButton);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(391, 74);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "SimpleMode";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(6, 45);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(106, 23);
            this.generateButton.TabIndex = 24;
            this.generateButton.Text = "&Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.generateModernButton);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(391, 74);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "Moder Mode";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // generateModernButton
            // 
            this.generateModernButton.Location = new System.Drawing.Point(6, 45);
            this.generateModernButton.Name = "generateModernButton";
            this.generateModernButton.Size = new System.Drawing.Size(106, 23);
            this.generateModernButton.TabIndex = 25;
            this.generateModernButton.Text = "&Generate";
            this.generateModernButton.UseVisualStyleBackColor = true;
            this.generateModernButton.Click += new System.EventHandler(this.generateModernButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(246, 84);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(681, 383);
            this.tabControl1.TabIndex = 23;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dbTableDetailsGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(673, 357);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Table Definition";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dbTableDetailsGridView
            // 
            this.dbTableDetailsGridView.AllowUserToAddRows = false;
            this.dbTableDetailsGridView.AllowUserToDeleteRows = false;
            this.dbTableDetailsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dbTableDetailsGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dbTableDetailsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbTableDetailsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnName,
            this.columnDataType,
            this.cSharpType,
            this.isPrimaryKey,
            this.isForeignKey,
            this.isNullable,
            this.IsIdentity,
            this.isUniqueKey,
            this.ConstraintName,
            this.ForeignKeyTableName,
            this.ForeignKeyColumnName});
            this.dbTableDetailsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbTableDetailsGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dbTableDetailsGridView.Location = new System.Drawing.Point(3, 3);
            this.dbTableDetailsGridView.Name = "dbTableDetailsGridView";
            this.dbTableDetailsGridView.RowHeadersVisible = false;
            this.dbTableDetailsGridView.Size = new System.Drawing.Size(667, 351);
            this.dbTableDetailsGridView.TabIndex = 5;
            // 
            // columnName
            // 
            this.columnName.DataPropertyName = "Name";
            this.columnName.HeaderText = "Column Name";
            this.columnName.Name = "columnName";
            this.columnName.ReadOnly = true;
            // 
            // columnDataType
            // 
            this.columnDataType.HeaderText = "Data Type";
            this.columnDataType.Name = "columnDataType";
            this.columnDataType.ReadOnly = true;
            // 
            // cSharpType
            // 
            this.cSharpType.HeaderText = "C# Type";
            this.cSharpType.Name = "cSharpType";
            this.cSharpType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cSharpType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // isPrimaryKey
            // 
            this.isPrimaryKey.HeaderText = "Primary Key";
            this.isPrimaryKey.Name = "isPrimaryKey";
            // 
            // isForeignKey
            // 
            this.isForeignKey.HeaderText = "Foreign Key";
            this.isForeignKey.Name = "isForeignKey";
            // 
            // isNullable
            // 
            this.isNullable.HeaderText = "Nullable";
            this.isNullable.Name = "isNullable";
            // 
            // IsIdentity
            // 
            this.IsIdentity.DataPropertyName = "IsIdentity";
            this.IsIdentity.HeaderText = "Identity";
            this.IsIdentity.Name = "IsIdentity";
            // 
            // isUniqueKey
            // 
            this.isUniqueKey.HeaderText = "Unique Key";
            this.isUniqueKey.Name = "isUniqueKey";
            // 
            // ConstraintName
            // 
            this.ConstraintName.DataPropertyName = "ConstraintName";
            this.ConstraintName.HeaderText = "Constraint";
            this.ConstraintName.Name = "ConstraintName";
            // 
            // ForeignKeyTableName
            // 
            this.ForeignKeyTableName.DataPropertyName = "ForeignKeyTableName";
            this.ForeignKeyTableName.HeaderText = "FK Table";
            this.ForeignKeyTableName.Name = "ForeignKeyTableName";
            // 
            // ForeignKeyColumnName
            // 
            this.ForeignKeyColumnName.DataPropertyName = "ForeignKeyColumnName";
            this.ForeignKeyColumnName.HeaderText = "FK Column";
            this.ForeignKeyColumnName.Name = "ForeignKeyColumnName";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtMapCode);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(673, 357);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Map Code";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtMapCode
            // 
            this.txtMapCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMapCode.Location = new System.Drawing.Point(3, 3);
            this.txtMapCode.Multiline = true;
            this.txtMapCode.Name = "txtMapCode";
            this.txtMapCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMapCode.Size = new System.Drawing.Size(667, 351);
            this.txtMapCode.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtDomainCode);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(673, 357);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Domain Code";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtDomainCode
            // 
            this.txtDomainCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDomainCode.Location = new System.Drawing.Point(3, 3);
            this.txtDomainCode.Multiline = true;
            this.txtDomainCode.Name = "txtDomainCode";
            this.txtDomainCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDomainCode.Size = new System.Drawing.Size(667, 351);
            this.txtDomainCode.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.txtServices);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(673, 357);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Services";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // txtServices
            // 
            this.txtServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtServices.Location = new System.Drawing.Point(3, 3);
            this.txtServices.Multiline = true;
            this.txtServices.Name = "txtServices";
            this.txtServices.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtServices.Size = new System.Drawing.Size(667, 351);
            this.txtServices.TabIndex = 1;
            // 
            // tableGroupBox
            // 
            this.tableGroupBox.Controls.Add(this.TableFilterTextBox);
            this.tableGroupBox.Controls.Add(this.tablesListBox);
            this.tableGroupBox.Controls.Add(this.ownersComboBox);
            this.tableGroupBox.Location = new System.Drawing.Point(12, 84);
            this.tableGroupBox.Name = "tableGroupBox";
            this.tableGroupBox.Size = new System.Drawing.Size(228, 383);
            this.tableGroupBox.TabIndex = 22;
            this.tableGroupBox.TabStop = false;
            this.tableGroupBox.Text = "Select Owner and Table(s)";
            // 
            // TableFilterTextBox
            // 
            this.TableFilterTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableFilterTextBox.Location = new System.Drawing.Point(6, 47);
            this.TableFilterTextBox.Name = "TableFilterTextBox";
            this.TableFilterTextBox.Size = new System.Drawing.Size(217, 20);
            this.TableFilterTextBox.TabIndex = 7;
            this.TableFilterTextBox.Tag = "Enter table filter here...";
            this.TableFilterTextBox.Text = "Enter table filter here...";
            // 
            // tablesListBox
            // 
            this.tablesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablesListBox.FormattingEnabled = true;
            this.tablesListBox.Location = new System.Drawing.Point(6, 73);
            this.tablesListBox.Name = "tablesListBox";
            this.tablesListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.tablesListBox.Size = new System.Drawing.Size(216, 290);
            this.tablesListBox.TabIndex = 6;
            // 
            // ownersComboBox
            // 
            this.ownersComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ownersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ownersComboBox.FormattingEnabled = true;
            this.ownersComboBox.Location = new System.Drawing.Point(6, 20);
            this.ownersComboBox.Name = "ownersComboBox";
            this.ownersComboBox.Size = new System.Drawing.Size(217, 21);
            this.ownersComboBox.TabIndex = 19;
            // 
            // labelTableName
            // 
            this.labelTableName.AutoSize = true;
            this.labelTableName.Location = new System.Drawing.Point(9, 64);
            this.labelTableName.Name = "labelTableName";
            this.labelTableName.Size = new System.Drawing.Size(62, 13);
            this.labelTableName.TabIndex = 5;
            this.labelTableName.Text = "TableName";
            // 
            // txtTableName
            // 
            this.txtTableName.Location = new System.Drawing.Point(117, 58);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(100, 20);
            this.txtTableName.TabIndex = 4;
            // 
            // labelScheme
            // 
            this.labelScheme.AutoSize = true;
            this.labelScheme.Location = new System.Drawing.Point(9, 38);
            this.labelScheme.Name = "labelScheme";
            this.labelScheme.Size = new System.Drawing.Size(46, 13);
            this.labelScheme.TabIndex = 3;
            this.labelScheme.Text = "Scheme";
            // 
            // txtScheme
            // 
            this.txtScheme.Location = new System.Drawing.Point(117, 32);
            this.txtScheme.Name = "txtScheme";
            this.txtScheme.Size = new System.Drawing.Size(100, 20);
            this.txtScheme.TabIndex = 2;
            this.txtScheme.Text = "dbo";
            // 
            // labelConnectionString
            // 
            this.labelConnectionString.AutoSize = true;
            this.labelConnectionString.Location = new System.Drawing.Point(9, 12);
            this.labelConnectionString.Name = "labelConnectionString";
            this.labelConnectionString.Size = new System.Drawing.Size(88, 13);
            this.labelConnectionString.TabIndex = 1;
            this.labelConnectionString.Text = "ConnectionString";
            // 
            // txtConnectionString
            // 
            this.txtConnectionString.Location = new System.Drawing.Point(117, 6);
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.Size = new System.Drawing.Size(343, 20);
            this.txtConnectionString.TabIndex = 0;
            // 
            // advanceSettingsTabPage
            // 
            this.advanceSettingsTabPage.Location = new System.Drawing.Point(4, 22);
            this.advanceSettingsTabPage.Name = "advanceSettingsTabPage";
            this.advanceSettingsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.advanceSettingsTabPage.Size = new System.Drawing.Size(937, 575);
            this.advanceSettingsTabPage.TabIndex = 1;
            this.advanceSettingsTabPage.Text = "tabPage2";
            this.advanceSettingsTabPage.UseVisualStyleBackColor = true;
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 601);
            this.Controls.Add(this.mainTabControl);
            this.Name = "App";
            this.Text = "Form1";
            this.mainTabControl.ResumeLayout(false);
            this.basicTab.ResumeLayout(false);
            this.basicTab.PerformLayout();
            this.tabControlModes.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dbTableDetailsGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tableGroupBox.ResumeLayout(false);
            this.tableGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage basicTab;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dbTableDetailsGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDataType;
        private System.Windows.Forms.DataGridViewComboBoxColumn cSharpType;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isPrimaryKey;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isForeignKey;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isNullable;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsIdentity;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isUniqueKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConstraintName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ForeignKeyTableName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ForeignKeyColumnName;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox tableGroupBox;
        private System.Windows.Forms.TextBox TableFilterTextBox;
        private System.Windows.Forms.ListBox tablesListBox;
        private System.Windows.Forms.ComboBox ownersComboBox;
        private System.Windows.Forms.Label labelTableName;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.Label labelScheme;
        private System.Windows.Forms.TextBox txtScheme;
        private System.Windows.Forms.Label labelConnectionString;
        private System.Windows.Forms.TextBox txtConnectionString;
        private System.Windows.Forms.TabPage advanceSettingsTabPage;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.TextBox txtDomainCode;
        private System.Windows.Forms.TextBox txtMapCode;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox txtServices;
        private System.Windows.Forms.TabControl tabControlModes;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button generateModernButton;
        private System.Windows.Forms.Button btnGetData;
        private System.Windows.Forms.Button btnSaveConnection;
    }
}

