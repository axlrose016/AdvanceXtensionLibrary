namespace DemoStudentInformationSystem
{
    partial class frmBranch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBranch));
            this.panel1 = new System.Windows.Forms.Panel();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.adpLst1 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.brachIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsTran1 = new DemoStudentInformationSystem.dsTran();
            this.axL_CRUD_Controller1 = new AdvanceXtensionLibrary.AXL_CRUD_Controller();
            this.bsLst1 = new System.Windows.Forms.BindingSource(this.components);
            this.sqlUpdateCommand = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand = new System.Data.SqlClient.SqlCommand();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTran1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLst1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 62);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(668, 318);
            this.panel1.TabIndex = 1;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT Branch.*\r\nFROM     Branch";
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = "INSERT INTO [Branch] ([Branch_Code], [Description]) VALUES (@Branch_Code, @Descri" +
    "ption);\r\nSELECT Brach_Id, Branch_Code, Description FROM Branch WHERE (Brach_Id =" +
    " SCOPE_IDENTITY())";
            this.sqlInsertCommand1.Connection = this.sqlConnection1;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Branch_Code", System.Data.SqlDbType.VarChar, 0, "Branch_Code"),
            new System.Data.SqlClient.SqlParameter("@Description", System.Data.SqlDbType.VarChar, 0, "Description")});
            // 
            // adpLst1
            // 
            this.adpLst1.DeleteCommand = this.sqlDeleteCommand;
            this.adpLst1.InsertCommand = this.sqlInsertCommand1;
            this.adpLst1.SelectCommand = this.sqlSelectCommand1;
            this.adpLst1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Branch", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Brach_Id", "Brach_Id"),
                        new System.Data.Common.DataColumnMapping("Branch_Code", "Branch_Code"),
                        new System.Data.Common.DataColumnMapping("Description", "Description")})});
            this.adpLst1.UpdateCommand = this.sqlUpdateCommand;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=localhost\\mssqlserver2017;Initial Catalog=DemoCRUDUC;User ID=sa";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.brachIdDataGridViewTextBoxColumn,
            this.branchCodeDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataMember = "Branch";
            this.dataGridView1.DataSource = this.dsTran1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(668, 318);
            this.dataGridView1.TabIndex = 0;
            // 
            // brachIdDataGridViewTextBoxColumn
            // 
            this.brachIdDataGridViewTextBoxColumn.DataPropertyName = "Brach_Id";
            this.brachIdDataGridViewTextBoxColumn.HeaderText = "Brach_Id";
            this.brachIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.brachIdDataGridViewTextBoxColumn.Name = "brachIdDataGridViewTextBoxColumn";
            this.brachIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.brachIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // branchCodeDataGridViewTextBoxColumn
            // 
            this.branchCodeDataGridViewTextBoxColumn.DataPropertyName = "Branch_Code";
            this.branchCodeDataGridViewTextBoxColumn.HeaderText = "Branch_Code";
            this.branchCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.branchCodeDataGridViewTextBoxColumn.Name = "branchCodeDataGridViewTextBoxColumn";
            this.branchCodeDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // dsTran1
            // 
            this.dsTran1.DataSetName = "dsTran";
            this.dsTran1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // axL_CRUD_Controller1
            // 
            this.axL_CRUD_Controller1._keyField = null;
            this.axL_CRUD_Controller1._keyVal = null;
            this.axL_CRUD_Controller1.adpDet1 = null;
            this.axL_CRUD_Controller1.adpDet10 = null;
            this.axL_CRUD_Controller1.adpDet11 = null;
            this.axL_CRUD_Controller1.adpDet12 = null;
            this.axL_CRUD_Controller1.adpDet13 = null;
            this.axL_CRUD_Controller1.adpDet14 = null;
            this.axL_CRUD_Controller1.adpDet15 = null;
            this.axL_CRUD_Controller1.adpDet2 = null;
            this.axL_CRUD_Controller1.adpDet3 = null;
            this.axL_CRUD_Controller1.adpDet4 = null;
            this.axL_CRUD_Controller1.adpDet5 = null;
            this.axL_CRUD_Controller1.adpDet6 = null;
            this.axL_CRUD_Controller1.adpDet7 = null;
            this.axL_CRUD_Controller1.adpDet8 = null;
            this.axL_CRUD_Controller1.adpDet9 = null;
            this.axL_CRUD_Controller1.adpHdr = null;
            this.axL_CRUD_Controller1.adpLst1 = this.adpLst1;
            this.axL_CRUD_Controller1.bsDet1 = null;
            this.axL_CRUD_Controller1.bsDet10 = null;
            this.axL_CRUD_Controller1.bsDet11 = null;
            this.axL_CRUD_Controller1.bsDet12 = null;
            this.axL_CRUD_Controller1.bsDet13 = null;
            this.axL_CRUD_Controller1.bsDet14 = null;
            this.axL_CRUD_Controller1.bsDet15 = null;
            this.axL_CRUD_Controller1.bsDet2 = null;
            this.axL_CRUD_Controller1.bsDet3 = null;
            this.axL_CRUD_Controller1.bsDet4 = null;
            this.axL_CRUD_Controller1.bsDet5 = null;
            this.axL_CRUD_Controller1.bsDet6 = null;
            this.axL_CRUD_Controller1.bsDet7 = null;
            this.axL_CRUD_Controller1.bsDet8 = null;
            this.axL_CRUD_Controller1.bsDet9 = null;
            this.axL_CRUD_Controller1.bsHdr = null;
            this.axL_CRUD_Controller1.bsLst1 = this.bsLst1;
            this.axL_CRUD_Controller1.connection_string = null;
            this.axL_CRUD_Controller1.Dock = System.Windows.Forms.DockStyle.Top;
            this.axL_CRUD_Controller1.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.axL_CRUD_Controller1.form_type = 0;
            this.axL_CRUD_Controller1.isKey2Int = false;
            this.axL_CRUD_Controller1.isKeyInt = false;
            this.axL_CRUD_Controller1.Location = new System.Drawing.Point(0, 0);
            this.axL_CRUD_Controller1.Margin = new System.Windows.Forms.Padding(6);
            this.axL_CRUD_Controller1.Name = "axL_CRUD_Controller1";
            this.axL_CRUD_Controller1.record_action = 0;
            this.axL_CRUD_Controller1.series_type = 0;
            this.axL_CRUD_Controller1.Size = new System.Drawing.Size(668, 62);
            this.axL_CRUD_Controller1.TabIndex = 0;
            this.axL_CRUD_Controller1.tblDet1 = null;
            this.axL_CRUD_Controller1.tblDet10 = null;
            this.axL_CRUD_Controller1.tblDet11 = null;
            this.axL_CRUD_Controller1.tblDet12 = null;
            this.axL_CRUD_Controller1.tblDet13 = null;
            this.axL_CRUD_Controller1.tblDet14 = null;
            this.axL_CRUD_Controller1.tblDet15 = null;
            this.axL_CRUD_Controller1.tblDet2 = null;
            this.axL_CRUD_Controller1.tblDet3 = null;
            this.axL_CRUD_Controller1.tblDet4 = null;
            this.axL_CRUD_Controller1.tblDet5 = null;
            this.axL_CRUD_Controller1.tblDet6 = null;
            this.axL_CRUD_Controller1.tblDet7 = null;
            this.axL_CRUD_Controller1.tblDet8 = null;
            this.axL_CRUD_Controller1.tblDet9 = null;
            this.axL_CRUD_Controller1.tblHdr = null;
            this.axL_CRUD_Controller1.tblLst1 = this.dsTran1.Branch;
            this.axL_CRUD_Controller1.withDelete = false;
            this.axL_CRUD_Controller1.withEdit = true;
            this.axL_CRUD_Controller1.withNew = false;
            this.axL_CRUD_Controller1.withOperation = false;
            this.axL_CRUD_Controller1.withRefresh = true;
            this.axL_CRUD_Controller1.withReport = false;
            this.axL_CRUD_Controller1.withSave = true;
            // 
            // bsLst1
            // 
            this.bsLst1.DataMember = "Branch";
            this.bsLst1.DataSource = this.dsTran1;
            // 
            // sqlUpdateCommand
            // 
            this.sqlUpdateCommand.CommandText = resources.GetString("sqlUpdateCommand.CommandText");
            this.sqlUpdateCommand.Connection = this.sqlConnection1;
            this.sqlUpdateCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Branch_Code", System.Data.SqlDbType.VarChar, 0, "Branch_Code"),
            new System.Data.SqlClient.SqlParameter("@Description", System.Data.SqlDbType.VarChar, 0, "Description"),
            new System.Data.SqlClient.SqlParameter("@Original_Brach_Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Brach_Id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Branch_Code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Branch_Code", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Branch_Code", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Branch_Code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Description", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Description", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Brach_Id", System.Data.SqlDbType.Int, 4, "Brach_Id")});
            // 
            // sqlDeleteCommand
            // 
            this.sqlDeleteCommand.CommandText = resources.GetString("sqlDeleteCommand.CommandText");
            this.sqlDeleteCommand.Connection = this.sqlConnection1;
            this.sqlDeleteCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_Brach_Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Brach_Id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Branch_Code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Branch_Code", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Branch_Code", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Branch_Code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Description", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Description", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, null)});
            // 
            // frmBranch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 380);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.axL_CRUD_Controller1);
            this.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmBranch";
            this.Text = "frmBranch";
            this.Load += new System.EventHandler(this.frmBranch_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTran1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLst1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AdvanceXtensionLibrary.AXL_CRUD_Controller axL_CRUD_Controller1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn brachIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private dsTran dsTran1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlDataAdapter adpLst1;
        private System.Windows.Forms.BindingSource bsLst1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand;
    }
}