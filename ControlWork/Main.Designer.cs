namespace ControlWork
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.customerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerTitleIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerOtherInitialsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountTypeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cleareBalanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uncleareBalanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAddedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apressFinancialDataSet = new ControlWork.ApressFinancialDataSet();
            this.Save = new System.Windows.Forms.Button();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.customersTableAdapter = new ControlWork.ApressFinancialDataSetTableAdapters.CustomersTableAdapter();
            this.delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apressFinancialDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIdDataGridViewTextBoxColumn,
            this.customerTitleIdDataGridViewTextBoxColumn,
            this.customerFirstNameDataGridViewTextBoxColumn,
            this.customerOtherInitialsDataGridViewTextBoxColumn,
            this.customerLastNameDataGridViewTextBoxColumn,
            this.addressIdDataGridViewTextBoxColumn,
            this.accountNumberDataGridViewTextBoxColumn,
            this.accountTypeIdDataGridViewTextBoxColumn,
            this.cleareBalanceDataGridViewTextBoxColumn,
            this.uncleareBalanceDataGridViewTextBoxColumn,
            this.dateAddedDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.customersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1144, 360);
            this.dataGridView1.TabIndex = 0;
            // 
            // customerIdDataGridViewTextBoxColumn
            // 
            this.customerIdDataGridViewTextBoxColumn.DataPropertyName = "CustomerId";
            this.customerIdDataGridViewTextBoxColumn.HeaderText = "CustomerId";
            this.customerIdDataGridViewTextBoxColumn.Name = "customerIdDataGridViewTextBoxColumn";
            this.customerIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerTitleIdDataGridViewTextBoxColumn
            // 
            this.customerTitleIdDataGridViewTextBoxColumn.DataPropertyName = "CustomerTitleId";
            this.customerTitleIdDataGridViewTextBoxColumn.HeaderText = "CustomerTitleId";
            this.customerTitleIdDataGridViewTextBoxColumn.Name = "customerTitleIdDataGridViewTextBoxColumn";
            // 
            // customerFirstNameDataGridViewTextBoxColumn
            // 
            this.customerFirstNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerFirstName";
            this.customerFirstNameDataGridViewTextBoxColumn.HeaderText = "CustomerFirstName";
            this.customerFirstNameDataGridViewTextBoxColumn.Name = "customerFirstNameDataGridViewTextBoxColumn";
            // 
            // customerOtherInitialsDataGridViewTextBoxColumn
            // 
            this.customerOtherInitialsDataGridViewTextBoxColumn.DataPropertyName = "CustomerOtherInitials";
            this.customerOtherInitialsDataGridViewTextBoxColumn.HeaderText = "CustomerOtherInitials";
            this.customerOtherInitialsDataGridViewTextBoxColumn.Name = "customerOtherInitialsDataGridViewTextBoxColumn";
            // 
            // customerLastNameDataGridViewTextBoxColumn
            // 
            this.customerLastNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerLastName";
            this.customerLastNameDataGridViewTextBoxColumn.HeaderText = "CustomerLastName";
            this.customerLastNameDataGridViewTextBoxColumn.Name = "customerLastNameDataGridViewTextBoxColumn";
            // 
            // addressIdDataGridViewTextBoxColumn
            // 
            this.addressIdDataGridViewTextBoxColumn.DataPropertyName = "AddressId";
            this.addressIdDataGridViewTextBoxColumn.HeaderText = "AddressId";
            this.addressIdDataGridViewTextBoxColumn.Name = "addressIdDataGridViewTextBoxColumn";
            // 
            // accountNumberDataGridViewTextBoxColumn
            // 
            this.accountNumberDataGridViewTextBoxColumn.DataPropertyName = "AccountNumber";
            this.accountNumberDataGridViewTextBoxColumn.HeaderText = "AccountNumber";
            this.accountNumberDataGridViewTextBoxColumn.Name = "accountNumberDataGridViewTextBoxColumn";
            // 
            // accountTypeIdDataGridViewTextBoxColumn
            // 
            this.accountTypeIdDataGridViewTextBoxColumn.DataPropertyName = "AccountTypeId";
            this.accountTypeIdDataGridViewTextBoxColumn.HeaderText = "AccountTypeId";
            this.accountTypeIdDataGridViewTextBoxColumn.Name = "accountTypeIdDataGridViewTextBoxColumn";
            // 
            // cleareBalanceDataGridViewTextBoxColumn
            // 
            this.cleareBalanceDataGridViewTextBoxColumn.DataPropertyName = "CleareBalance";
            this.cleareBalanceDataGridViewTextBoxColumn.HeaderText = "CleareBalance";
            this.cleareBalanceDataGridViewTextBoxColumn.Name = "cleareBalanceDataGridViewTextBoxColumn";
            // 
            // uncleareBalanceDataGridViewTextBoxColumn
            // 
            this.uncleareBalanceDataGridViewTextBoxColumn.DataPropertyName = "UncleareBalance";
            this.uncleareBalanceDataGridViewTextBoxColumn.HeaderText = "UncleareBalance";
            this.uncleareBalanceDataGridViewTextBoxColumn.Name = "uncleareBalanceDataGridViewTextBoxColumn";
            // 
            // dateAddedDataGridViewTextBoxColumn
            // 
            this.dateAddedDataGridViewTextBoxColumn.DataPropertyName = "DateAdded";
            this.dateAddedDataGridViewTextBoxColumn.HeaderText = "DateAdded";
            this.dateAddedDataGridViewTextBoxColumn.Name = "dateAddedDataGridViewTextBoxColumn";
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.apressFinancialDataSet;
            // 
            // apressFinancialDataSet
            // 
            this.apressFinancialDataSet.DataSetName = "ApressFinancialDataSet";
            this.apressFinancialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(703, 390);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(225, 49);
            this.Save.TabIndex = 1;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT        CustomerDetails.Customers.*\r\nFROM            CustomerDetails.Custom" +
    "ers";
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = global::ControlWork.Properties.Settings.Default.ConnectionString;
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = resources.GetString("sqlInsertCommand1.CommandText");
            this.sqlInsertCommand1.Connection = this.sqlConnection1;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@CustomerTitleId", System.Data.SqlDbType.Int, 0, "CustomerTitleId"),
            new System.Data.SqlClient.SqlParameter("@CustomerFirstName", System.Data.SqlDbType.NVarChar, 0, "CustomerFirstName"),
            new System.Data.SqlClient.SqlParameter("@CustomerOtherInitials", System.Data.SqlDbType.NVarChar, 0, "CustomerOtherInitials"),
            new System.Data.SqlClient.SqlParameter("@CustomerLastName", System.Data.SqlDbType.NVarChar, 0, "CustomerLastName"),
            new System.Data.SqlClient.SqlParameter("@AddressId", System.Data.SqlDbType.BigInt, 0, "AddressId"),
            new System.Data.SqlClient.SqlParameter("@AccountNumber", System.Data.SqlDbType.NVarChar, 0, "AccountNumber"),
            new System.Data.SqlClient.SqlParameter("@AccountTypeId", System.Data.SqlDbType.Int, 0, "AccountTypeId"),
            new System.Data.SqlClient.SqlParameter("@CleareBalance", System.Data.SqlDbType.Money, 0, "CleareBalance"),
            new System.Data.SqlClient.SqlParameter("@UncleareBalance", System.Data.SqlDbType.Money, 0, "UncleareBalance"),
            new System.Data.SqlClient.SqlParameter("@DateAdded", System.Data.SqlDbType.Date, 0, "DateAdded")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConnection1;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@CustomerTitleId", System.Data.SqlDbType.Int, 0, "CustomerTitleId"),
            new System.Data.SqlClient.SqlParameter("@CustomerFirstName", System.Data.SqlDbType.NVarChar, 0, "CustomerFirstName"),
            new System.Data.SqlClient.SqlParameter("@CustomerOtherInitials", System.Data.SqlDbType.NVarChar, 0, "CustomerOtherInitials"),
            new System.Data.SqlClient.SqlParameter("@CustomerLastName", System.Data.SqlDbType.NVarChar, 0, "CustomerLastName"),
            new System.Data.SqlClient.SqlParameter("@AddressId", System.Data.SqlDbType.BigInt, 0, "AddressId"),
            new System.Data.SqlClient.SqlParameter("@AccountNumber", System.Data.SqlDbType.NVarChar, 0, "AccountNumber"),
            new System.Data.SqlClient.SqlParameter("@AccountTypeId", System.Data.SqlDbType.Int, 0, "AccountTypeId"),
            new System.Data.SqlClient.SqlParameter("@CleareBalance", System.Data.SqlDbType.Money, 0, "CleareBalance"),
            new System.Data.SqlClient.SqlParameter("@UncleareBalance", System.Data.SqlDbType.Money, 0, "UncleareBalance"),
            new System.Data.SqlClient.SqlParameter("@DateAdded", System.Data.SqlDbType.Date, 0, "DateAdded"),
            new System.Data.SqlClient.SqlParameter("@Original_CustomerId", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CustomerId", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CustomerTitleId", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CustomerTitleId", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CustomerFirstName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CustomerFirstName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_CustomerOtherInitials", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CustomerOtherInitials", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_CustomerOtherInitials", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CustomerOtherInitials", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CustomerLastName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CustomerLastName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_AddressId", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AddressId", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_AccountNumber", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AccountNumber", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_AccountTypeId", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AccountTypeId", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CleareBalance", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CleareBalance", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_UncleareBalance", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "UncleareBalance", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_DateAdded", System.Data.SqlDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DateAdded", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@CustomerId", System.Data.SqlDbType.BigInt, 8, "CustomerId")});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlConnection1;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_CustomerId", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CustomerId", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CustomerTitleId", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CustomerTitleId", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CustomerFirstName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CustomerFirstName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_CustomerOtherInitials", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CustomerOtherInitials", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_CustomerOtherInitials", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CustomerOtherInitials", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CustomerLastName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CustomerLastName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_AddressId", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AddressId", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_AccountNumber", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AccountNumber", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_AccountTypeId", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AccountTypeId", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CleareBalance", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CleareBalance", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_UncleareBalance", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "UncleareBalance", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_DateAdded", System.Data.SqlDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DateAdded", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Customers", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("CustomerId", "CustomerId"),
                        new System.Data.Common.DataColumnMapping("CustomerTitleId", "CustomerTitleId"),
                        new System.Data.Common.DataColumnMapping("CustomerFirstName", "CustomerFirstName"),
                        new System.Data.Common.DataColumnMapping("CustomerOtherInitials", "CustomerOtherInitials"),
                        new System.Data.Common.DataColumnMapping("CustomerLastName", "CustomerLastName"),
                        new System.Data.Common.DataColumnMapping("AddressId", "AddressId"),
                        new System.Data.Common.DataColumnMapping("AccountNumber", "AccountNumber"),
                        new System.Data.Common.DataColumnMapping("AccountTypeId", "AccountTypeId"),
                        new System.Data.Common.DataColumnMapping("CleareBalance", "CleareBalance"),
                        new System.Data.Common.DataColumnMapping("UncleareBalance", "UncleareBalance"),
                        new System.Data.Common.DataColumnMapping("DateAdded", "DateAdded")})});
            this.sqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(239, 390);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(209, 49);
            this.delete.TabIndex = 2;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 451);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apressFinancialDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Save;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private ApressFinancialDataSet apressFinancialDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private ApressFinancialDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerTitleIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerOtherInitialsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountTypeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cleareBalanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uncleareBalanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAddedDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button delete;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
    }
}

