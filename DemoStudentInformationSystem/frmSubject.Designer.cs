namespace DemoStudentInformationSystem
{
    partial class frmSubject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSubject));
            this.AdpDet1 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dsTran1 = new DemoStudentInformationSystem.dsTran();
            this.bsDet1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.subjectIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.campusIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.axL_CRUD_Controller1 = new AdvanceXtensionLibrary.AXL_CRUD_Controller();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsTran1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // AdpDet1
            // 
            this.AdpDet1.DeleteCommand = this.sqlDeleteCommand1;
            this.AdpDet1.InsertCommand = this.sqlInsertCommand1;
            this.AdpDet1.SelectCommand = this.sqlSelectCommand1;
            this.AdpDet1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Subjects", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("subject_Id", "subject_Id"),
                        new System.Data.Common.DataColumnMapping("Description", "Description"),
                        new System.Data.Common.DataColumnMapping("course_Id", "course_Id"),
                        new System.Data.Common.DataColumnMapping("campus_Id", "campus_Id"),
                        new System.Data.Common.DataColumnMapping("unit", "unit")})});
            this.AdpDet1.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlConnection1;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_subject_Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "subject_Id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Description", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Description", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_course_Id", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "course_Id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_campus_Id", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "campus_Id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_unit", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "unit", System.Data.DataRowVersion.Original, null)});
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
            new System.Data.SqlClient.SqlParameter("@Description", System.Data.SqlDbType.VarChar, 0, "Description"),
            new System.Data.SqlClient.SqlParameter("@course_Id", System.Data.SqlDbType.VarChar, 0, "course_Id"),
            new System.Data.SqlClient.SqlParameter("@campus_Id", System.Data.SqlDbType.VarChar, 0, "campus_Id"),
            new System.Data.SqlClient.SqlParameter("@unit", System.Data.SqlDbType.Int, 0, "unit")});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT Subjects.*\r\nFROM     Subjects";
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConnection1;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Description", System.Data.SqlDbType.VarChar, 0, "Description"),
            new System.Data.SqlClient.SqlParameter("@course_Id", System.Data.SqlDbType.VarChar, 0, "course_Id"),
            new System.Data.SqlClient.SqlParameter("@campus_Id", System.Data.SqlDbType.VarChar, 0, "campus_Id"),
            new System.Data.SqlClient.SqlParameter("@unit", System.Data.SqlDbType.Int, 0, "unit"),
            new System.Data.SqlClient.SqlParameter("@Original_subject_Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "subject_Id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Description", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Description", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_course_Id", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "course_Id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_campus_Id", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "campus_Id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_unit", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "unit", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@subject_Id", System.Data.SqlDbType.Int, 4, "subject_Id")});
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 491);
            this.panel1.TabIndex = 1;
            // 
            // dsTran1
            // 
            this.dsTran1.DataSetName = "dsTran";
            this.dsTran1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsDet1
            // 
            this.bsDet1.DataMember = "Subjects";
            this.bsDet1.DataSource = this.dsTran1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subjectIdDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.courseIdDataGridViewTextBoxColumn,
            this.campusIdDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn});
            this.dataGridView1.DataMember = "Subjects";
            this.dataGridView1.DataSource = this.dsTran1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(900, 491);
            this.dataGridView1.TabIndex = 0;
            // 
            // subjectIdDataGridViewTextBoxColumn
            // 
            this.subjectIdDataGridViewTextBoxColumn.DataPropertyName = "subject_Id";
            this.subjectIdDataGridViewTextBoxColumn.HeaderText = "subject_Id";
            this.subjectIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subjectIdDataGridViewTextBoxColumn.Name = "subjectIdDataGridViewTextBoxColumn";
            this.subjectIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.subjectIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // courseIdDataGridViewTextBoxColumn
            // 
            this.courseIdDataGridViewTextBoxColumn.DataPropertyName = "course_Id";
            this.courseIdDataGridViewTextBoxColumn.HeaderText = "course_Id";
            this.courseIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.courseIdDataGridViewTextBoxColumn.Name = "courseIdDataGridViewTextBoxColumn";
            this.courseIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // campusIdDataGridViewTextBoxColumn
            // 
            this.campusIdDataGridViewTextBoxColumn.DataPropertyName = "campus_Id";
            this.campusIdDataGridViewTextBoxColumn.HeaderText = "campus_Id";
            this.campusIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.campusIdDataGridViewTextBoxColumn.Name = "campusIdDataGridViewTextBoxColumn";
            this.campusIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "unit";
            this.unitDataGridViewTextBoxColumn.HeaderText = "unit";
            this.unitDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            this.unitDataGridViewTextBoxColumn.Width = 125;
            // 
            // axL_CRUD_Controller1
            // 
            this.axL_CRUD_Controller1._keyField = null;
            this.axL_CRUD_Controller1._keyVal = null;
            this.axL_CRUD_Controller1.adpDet1 = null;
            this.axL_CRUD_Controller1.adpDet2 = null;
            this.axL_CRUD_Controller1.adpHdr = null;
            this.axL_CRUD_Controller1.adpLst1 = this.AdpDet1;
            this.axL_CRUD_Controller1.bsDet1 = null;
            this.axL_CRUD_Controller1.bsDet2 = null;
            this.axL_CRUD_Controller1.bsHdr = null;
            this.axL_CRUD_Controller1.bsLst1 = this.bsDet1;
            this.axL_CRUD_Controller1.connection_string = null;
            this.axL_CRUD_Controller1.Dock = System.Windows.Forms.DockStyle.Top;
            this.axL_CRUD_Controller1.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.axL_CRUD_Controller1.form_type = 0;
            this.axL_CRUD_Controller1.isKey2Int = false;
            this.axL_CRUD_Controller1.isKeyInt = false;
            this.axL_CRUD_Controller1.Location = new System.Drawing.Point(0, 0);
            this.axL_CRUD_Controller1.Margin = new System.Windows.Forms.Padding(4);
            this.axL_CRUD_Controller1.Name = "axL_CRUD_Controller1";
            this.axL_CRUD_Controller1.record_action = 0;
            this.axL_CRUD_Controller1.series_type = 0;
            this.axL_CRUD_Controller1.Size = new System.Drawing.Size(900, 43);
            this.axL_CRUD_Controller1.TabIndex = 0;
            this.axL_CRUD_Controller1.tblDet1 = null;
            this.axL_CRUD_Controller1.tblDet2 = null;
            this.axL_CRUD_Controller1.tblHdr = null;
            this.axL_CRUD_Controller1.tblLst1 = this.dsTran1.Subjects;
            this.axL_CRUD_Controller1.withDelete = false;
            this.axL_CRUD_Controller1.withEdit = true;
            this.axL_CRUD_Controller1.withNew = false;
            this.axL_CRUD_Controller1.withOperation = true;
            this.axL_CRUD_Controller1.withRefresh = true;
            this.axL_CRUD_Controller1.withReport = true;
            this.axL_CRUD_Controller1.withSave = true;
            this.axL_CRUD_Controller1.btnRefresh_After += new System.EventHandler(this.axL_CRUD_Controller1_btnRefresh_After);
            // 
            // frmSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 534);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.axL_CRUD_Controller1);
            this.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmSubject";
            this.Text = "frmSubject";
            this.Load += new System.EventHandler(this.frmSubject_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsTran1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AdvanceXtensionLibrary.AXL_CRUD_Controller axL_CRUD_Controller1;
        private System.Windows.Forms.Panel panel1;
        private dsTran dsTran1;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIdDataGridViewTextBoxColumn;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter AdpDet1;
        private System.Windows.Forms.BindingSource bsDet1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn campusIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
    }
}