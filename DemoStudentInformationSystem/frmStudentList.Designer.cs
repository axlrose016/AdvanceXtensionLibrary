namespace DemoStudentInformationSystem
{
    partial class frmStudentList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudentList));
            this.AdpList = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.bsList = new System.Windows.Forms.BindingSource(this.components);
            this.dsList1 = new DemoStudentInformationSystem.dsList();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adrs1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adrs2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.axL_CRUD_Controller1 = new AdvanceXtensionLibrary.AXL_CRUD_Controller();
            ((System.ComponentModel.ISupportInitialize)(this.bsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsList1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // AdpList
            // 
            this.AdpList.DeleteCommand = this.sqlDeleteCommand1;
            this.AdpList.InsertCommand = this.sqlInsertCommand1;
            this.AdpList.SelectCommand = this.sqlSelectCommand1;
            this.AdpList.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "StudentPersonalInfo", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Student_Id", "Student_Id"),
                        new System.Data.Common.DataColumnMapping("Fname", "Fname"),
                        new System.Data.Common.DataColumnMapping("Mname", "Mname"),
                        new System.Data.Common.DataColumnMapping("Lname", "Lname"),
                        new System.Data.Common.DataColumnMapping("Adrs1", "Adrs1"),
                        new System.Data.Common.DataColumnMapping("Adrs2", "Adrs2"),
                        new System.Data.Common.DataColumnMapping("ContactNo", "ContactNo")})});
            this.AdpList.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlConnection1;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_Student_Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Student_Id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fname", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fname", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fname", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fname", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Mname", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Mname", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Mname", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Mname", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Lname", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Lname", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Lname", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Lname", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Adrs1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Adrs1", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Adrs1", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Adrs1", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Adrs2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Adrs2", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Adrs2", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Adrs2", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ContactNo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ContactNo", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ContactNo", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ContactNo", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=localhost\\mssqlserver2017;Initial Catalog=DemoCRUDUC;User ID=sa";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = resources.GetString("sqlInsertCommand1.CommandText");
            this.sqlInsertCommand1.Connection = this.sqlConnection1;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Fname", System.Data.SqlDbType.VarChar, 0, "Fname"),
            new System.Data.SqlClient.SqlParameter("@Mname", System.Data.SqlDbType.VarChar, 0, "Mname"),
            new System.Data.SqlClient.SqlParameter("@Lname", System.Data.SqlDbType.VarChar, 0, "Lname"),
            new System.Data.SqlClient.SqlParameter("@Adrs1", System.Data.SqlDbType.VarChar, 0, "Adrs1"),
            new System.Data.SqlClient.SqlParameter("@Adrs2", System.Data.SqlDbType.VarChar, 0, "Adrs2"),
            new System.Data.SqlClient.SqlParameter("@ContactNo", System.Data.SqlDbType.VarChar, 0, "ContactNo")});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT StudentPersonalInfo.*\r\nFROM     StudentPersonalInfo";
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConnection1;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Fname", System.Data.SqlDbType.VarChar, 0, "Fname"),
            new System.Data.SqlClient.SqlParameter("@Mname", System.Data.SqlDbType.VarChar, 0, "Mname"),
            new System.Data.SqlClient.SqlParameter("@Lname", System.Data.SqlDbType.VarChar, 0, "Lname"),
            new System.Data.SqlClient.SqlParameter("@Adrs1", System.Data.SqlDbType.VarChar, 0, "Adrs1"),
            new System.Data.SqlClient.SqlParameter("@Adrs2", System.Data.SqlDbType.VarChar, 0, "Adrs2"),
            new System.Data.SqlClient.SqlParameter("@ContactNo", System.Data.SqlDbType.VarChar, 0, "ContactNo"),
            new System.Data.SqlClient.SqlParameter("@Original_Student_Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Student_Id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fname", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fname", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fname", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fname", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Mname", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Mname", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Mname", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Mname", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Lname", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Lname", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Lname", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Lname", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Adrs1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Adrs1", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Adrs1", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Adrs1", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Adrs2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Adrs2", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Adrs2", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Adrs2", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ContactNo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ContactNo", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ContactNo", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ContactNo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Student_Id", System.Data.SqlDbType.Int, 4, "Student_Id")});
            // 
            // bsList
            // 
            this.bsList.DataMember = "StudentPersonalInfo";
            this.bsList.DataSource = this.dsList1;
            // 
            // dsList1
            // 
            this.dsList1.DataSetName = "dsList";
            this.dsList1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 483);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIdDataGridViewTextBoxColumn,
            this.fnameDataGridViewTextBoxColumn,
            this.mnameDataGridViewTextBoxColumn,
            this.lnameDataGridViewTextBoxColumn,
            this.adrs1DataGridViewTextBoxColumn,
            this.adrs2DataGridViewTextBoxColumn,
            this.contactNoDataGridViewTextBoxColumn});
            this.dataGridView1.DataMember = "StudentPersonalInfo";
            this.dataGridView1.DataSource = this.dsList1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1010, 483);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // studentIdDataGridViewTextBoxColumn
            // 
            this.studentIdDataGridViewTextBoxColumn.DataPropertyName = "Student_Id";
            this.studentIdDataGridViewTextBoxColumn.HeaderText = "Student_Id";
            this.studentIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentIdDataGridViewTextBoxColumn.Name = "studentIdDataGridViewTextBoxColumn";
            this.studentIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // fnameDataGridViewTextBoxColumn
            // 
            this.fnameDataGridViewTextBoxColumn.DataPropertyName = "Fname";
            this.fnameDataGridViewTextBoxColumn.HeaderText = "Fname";
            this.fnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fnameDataGridViewTextBoxColumn.Name = "fnameDataGridViewTextBoxColumn";
            this.fnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // mnameDataGridViewTextBoxColumn
            // 
            this.mnameDataGridViewTextBoxColumn.DataPropertyName = "Mname";
            this.mnameDataGridViewTextBoxColumn.HeaderText = "Mname";
            this.mnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mnameDataGridViewTextBoxColumn.Name = "mnameDataGridViewTextBoxColumn";
            this.mnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lnameDataGridViewTextBoxColumn
            // 
            this.lnameDataGridViewTextBoxColumn.DataPropertyName = "Lname";
            this.lnameDataGridViewTextBoxColumn.HeaderText = "Lname";
            this.lnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lnameDataGridViewTextBoxColumn.Name = "lnameDataGridViewTextBoxColumn";
            this.lnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // adrs1DataGridViewTextBoxColumn
            // 
            this.adrs1DataGridViewTextBoxColumn.DataPropertyName = "Adrs1";
            this.adrs1DataGridViewTextBoxColumn.HeaderText = "Adrs1";
            this.adrs1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adrs1DataGridViewTextBoxColumn.Name = "adrs1DataGridViewTextBoxColumn";
            this.adrs1DataGridViewTextBoxColumn.Width = 125;
            // 
            // adrs2DataGridViewTextBoxColumn
            // 
            this.adrs2DataGridViewTextBoxColumn.DataPropertyName = "Adrs2";
            this.adrs2DataGridViewTextBoxColumn.HeaderText = "Adrs2";
            this.adrs2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adrs2DataGridViewTextBoxColumn.Name = "adrs2DataGridViewTextBoxColumn";
            this.adrs2DataGridViewTextBoxColumn.Width = 125;
            // 
            // contactNoDataGridViewTextBoxColumn
            // 
            this.contactNoDataGridViewTextBoxColumn.DataPropertyName = "ContactNo";
            this.contactNoDataGridViewTextBoxColumn.HeaderText = "ContactNo";
            this.contactNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contactNoDataGridViewTextBoxColumn.Name = "contactNoDataGridViewTextBoxColumn";
            this.contactNoDataGridViewTextBoxColumn.Width = 125;
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
            this.axL_CRUD_Controller1.adpLst1 = this.AdpList;
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
            this.axL_CRUD_Controller1.bsLst1 = this.bsList;
            this.axL_CRUD_Controller1.connection_string = null;
            this.axL_CRUD_Controller1.Dock = System.Windows.Forms.DockStyle.Top;
            this.axL_CRUD_Controller1.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.axL_CRUD_Controller1.form_type = 2;
            this.axL_CRUD_Controller1.isKey2Int = false;
            this.axL_CRUD_Controller1.isKeyInt = false;
            this.axL_CRUD_Controller1.Location = new System.Drawing.Point(0, 0);
            this.axL_CRUD_Controller1.Margin = new System.Windows.Forms.Padding(4);
            this.axL_CRUD_Controller1.Name = "axL_CRUD_Controller1";
            this.axL_CRUD_Controller1.operation1_caption = "";
            this.axL_CRUD_Controller1.operation10_caption = null;
            this.axL_CRUD_Controller1.operation2_caption = "";
            this.axL_CRUD_Controller1.operation3_caption = null;
            this.axL_CRUD_Controller1.operation4_caption = null;
            this.axL_CRUD_Controller1.operation5_caption = null;
            this.axL_CRUD_Controller1.operation6_caption = null;
            this.axL_CRUD_Controller1.operation7_caption = null;
            this.axL_CRUD_Controller1.operation8_caption = null;
            this.axL_CRUD_Controller1.operation9_caption = null;
            this.axL_CRUD_Controller1.record_action = 0;
            this.axL_CRUD_Controller1.report1_caption = "Test Report";
            this.axL_CRUD_Controller1.report10_caption = null;
            this.axL_CRUD_Controller1.report2_caption = null;
            this.axL_CRUD_Controller1.report3_caption = null;
            this.axL_CRUD_Controller1.report4_caption = null;
            this.axL_CRUD_Controller1.report5_caption = null;
            this.axL_CRUD_Controller1.report6_caption = null;
            this.axL_CRUD_Controller1.report7_caption = null;
            this.axL_CRUD_Controller1.report8_caption = null;
            this.axL_CRUD_Controller1.report9_caption = null;
            this.axL_CRUD_Controller1.series_type = 0;
            this.axL_CRUD_Controller1.Size = new System.Drawing.Size(1010, 41);
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
            this.axL_CRUD_Controller1.tblLst1 = this.dsList1.StudentPersonalInfo;
            this.axL_CRUD_Controller1.withDelete = false;
            this.axL_CRUD_Controller1.withEdit = false;
            this.axL_CRUD_Controller1.withNew = true;
            this.axL_CRUD_Controller1.withOperation = false;
            this.axL_CRUD_Controller1.withRefresh = true;
            this.axL_CRUD_Controller1.withReport = true;
            this.axL_CRUD_Controller1.withSave = false;
            this.axL_CRUD_Controller1.btnNew_Before += new System.EventHandler(this.axL_CRUD_Controller1_btnNew_Before);
            this.axL_CRUD_Controller1.btnRefresh_After += new System.EventHandler(this.axL_CRUD_Controller1_btnRefresh_After);
            // 
            // frmStudentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 524);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.axL_CRUD_Controller1);
            this.Name = "frmStudentList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmStudentList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsList1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AdvanceXtensionLibrary.AXL_CRUD_Controller axL_CRUD_Controller1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adrs1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adrs2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNoDataGridViewTextBoxColumn;
        private dsList dsList1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter AdpList;
        private System.Windows.Forms.BindingSource bsList;
    }
}

