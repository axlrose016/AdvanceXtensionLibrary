namespace DemoStudentInformationSystem
{
    partial class frmStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudent));
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.AdpHdr = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbl1rowIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fldStringDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fldIntDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fldBoolDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dsTran = new DemoStudentInformationSystem.dsTran();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tbl2rowIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fldStringDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fldIntDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fldBoolDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tbl3rowIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentIdDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fldStringDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fldIntDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fldBoolDataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.tbl4rowIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentIdDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fldStringDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fldIntDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fldBoolDataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.tbl5rowIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentIdDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fldStringDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fldIntDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fldBoolDataGridViewCheckBoxColumn4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.tbl6rowIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentIdDataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fldStringDataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fldIntDataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fldBoolDataGridViewCheckBoxColumn5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.dataGridView7 = new System.Windows.Forms.DataGridView();
            this.tbl7rowIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentIdDataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fldStringDataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fldIntDataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fldBoolDataGridViewCheckBoxColumn6 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.dataGridView8 = new System.Windows.Forms.DataGridView();
            this.tbl8rowIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentIdDataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fldStringDataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fldIntDataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fldBoolDataGridViewCheckBoxColumn7 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.dataGridView9 = new System.Windows.Forms.DataGridView();
            this.tbl9rowIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentIdDataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fldStringDataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fldIntDataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fldBoolDataGridViewCheckBoxColumn8 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.dataGridView10 = new System.Windows.Forms.DataGridView();
            this.tbl10rowIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentIdDataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fldStringDataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fldIntDataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fldBoolDataGridViewCheckBoxColumn9 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.dataGridView11 = new System.Windows.Forms.DataGridView();
            this.tbl11rowIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentIdDataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fldStringDataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fldIntDataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fldBoolDataGridViewCheckBoxColumn10 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage12 = new System.Windows.Forms.TabPage();
            this.dataGridView12 = new System.Windows.Forms.DataGridView();
            this.tbl12rowIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentIdDataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fldStringDataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fldIntDataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fldBoolDataGridViewCheckBoxColumn11 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage13 = new System.Windows.Forms.TabPage();
            this.dataGridView13 = new System.Windows.Forms.DataGridView();
            this.studGrdIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentIdDataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grd1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grd2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grd3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grd4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grd5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grd6DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AdpDet2 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand3 = new System.Data.SqlClient.SqlCommand();
            this.adpDet1 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
            this.adpDet10 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand11 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand11 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand11 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand11 = new System.Data.SqlClient.SqlCommand();
            this.adpDet11 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand12 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand12 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand12 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand12 = new System.Data.SqlClient.SqlCommand();
            this.adpDet12 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand13 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand13 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand13 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand13 = new System.Data.SqlClient.SqlCommand();
            this.adpDet3 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand4 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand4 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand4 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand4 = new System.Data.SqlClient.SqlCommand();
            this.adpDet4 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand5 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand5 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand5 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand5 = new System.Data.SqlClient.SqlCommand();
            this.adpDet5 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand6 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand6 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand6 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand6 = new System.Data.SqlClient.SqlCommand();
            this.adpDet6 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand7 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand7 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand7 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand7 = new System.Data.SqlClient.SqlCommand();
            this.adpDet7 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand8 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand8 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand8 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand8 = new System.Data.SqlClient.SqlCommand();
            this.adpDet8 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand9 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand9 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand9 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand9 = new System.Data.SqlClient.SqlCommand();
            this.adpDet9 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand10 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand10 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand10 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand10 = new System.Data.SqlClient.SqlCommand();
            this.bsDet1 = new System.Windows.Forms.BindingSource(this.components);
            this.bsDet10 = new System.Windows.Forms.BindingSource(this.components);
            this.bsDet11 = new System.Windows.Forms.BindingSource(this.components);
            this.bsDet12 = new System.Windows.Forms.BindingSource(this.components);
            this.bsDet13 = new System.Windows.Forms.BindingSource(this.components);
            this.bsDet2 = new System.Windows.Forms.BindingSource(this.components);
            this.bsDet3 = new System.Windows.Forms.BindingSource(this.components);
            this.bsDet4 = new System.Windows.Forms.BindingSource(this.components);
            this.bsDet5 = new System.Windows.Forms.BindingSource(this.components);
            this.bsDet6 = new System.Windows.Forms.BindingSource(this.components);
            this.bsDet7 = new System.Windows.Forms.BindingSource(this.components);
            this.bsDet8 = new System.Windows.Forms.BindingSource(this.components);
            this.bsDet9 = new System.Windows.Forms.BindingSource(this.components);
            this.bsHdr = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.sqlSelectCommand14 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand14 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand14 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand14 = new System.Data.SqlClient.SqlCommand();
            this.adpDet13 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand15 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand15 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand15 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand15 = new System.Data.SqlClient.SqlCommand();
            this.adpDet14 = new System.Data.SqlClient.SqlDataAdapter();
            this.axL_CRUD_Controller1 = new AdvanceXtensionLibrary.AXL_CRUD_Controller();
            this.bsDet14 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTran)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).BeginInit();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView8)).BeginInit();
            this.tabPage9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView9)).BeginInit();
            this.tabPage10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView10)).BeginInit();
            this.tabPage11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView11)).BeginInit();
            this.tabPage12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView12)).BeginInit();
            this.tabPage13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView13)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsDet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsHdr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDet14)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=localhost\\mssqlserver2017;Initial Catalog=DemoCRUDUC;User ID=sa";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // AdpHdr
            // 
            this.AdpHdr.DeleteCommand = this.sqlDeleteCommand1;
            this.AdpHdr.InsertCommand = this.sqlInsertCommand1;
            this.AdpHdr.SelectCommand = this.sqlSelectCommand1;
            this.AdpHdr.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "StudentPersonalInfo", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Student_Id", "Student_Id"),
                        new System.Data.Common.DataColumnMapping("Fname", "Fname"),
                        new System.Data.Common.DataColumnMapping("Mname", "Mname"),
                        new System.Data.Common.DataColumnMapping("Lname", "Lname"),
                        new System.Data.Common.DataColumnMapping("Adrs1", "Adrs1"),
                        new System.Data.Common.DataColumnMapping("Adrs2", "Adrs2"),
                        new System.Data.Common.DataColumnMapping("ContactNo", "ContactNo")})});
            this.AdpHdr.UpdateCommand = this.sqlUpdateCommand1;
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
            this.sqlSelectCommand1.CommandText = "SELECT *\r\nFROM     StudentPersonalInfo\r\nWHERE  (Student_Id = @zkey1)";
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@zkey1", System.Data.SqlDbType.Int, 4, "Student_Id")});
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
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 42);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(928, 700);
            this.panel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Controls.Add(this.tabPage9);
            this.tabControl1.Controls.Add(this.tabPage10);
            this.tabControl1.Controls.Add(this.tabPage11);
            this.tabControl1.Controls.Add(this.tabPage12);
            this.tabControl1.Controls.Add(this.tabPage13);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 331);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(928, 369);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(920, 338);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tbl1rowIdDataGridViewTextBoxColumn,
            this.studentIdDataGridViewTextBoxColumn,
            this.fldStringDataGridViewTextBoxColumn,
            this.fldIntDataGridViewTextBoxColumn,
            this.fldBoolDataGridViewCheckBoxColumn});
            this.dataGridView1.DataMember = "SampTbl1";
            this.dataGridView1.DataSource = this.dsTran;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(914, 332);
            this.dataGridView1.TabIndex = 0;
            // 
            // tbl1rowIdDataGridViewTextBoxColumn
            // 
            this.tbl1rowIdDataGridViewTextBoxColumn.DataPropertyName = "Tbl1_row_Id";
            this.tbl1rowIdDataGridViewTextBoxColumn.HeaderText = "Tbl1_row_Id";
            this.tbl1rowIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tbl1rowIdDataGridViewTextBoxColumn.Name = "tbl1rowIdDataGridViewTextBoxColumn";
            this.tbl1rowIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.tbl1rowIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentIdDataGridViewTextBoxColumn
            // 
            this.studentIdDataGridViewTextBoxColumn.DataPropertyName = "Student_Id";
            this.studentIdDataGridViewTextBoxColumn.HeaderText = "Student_Id";
            this.studentIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentIdDataGridViewTextBoxColumn.Name = "studentIdDataGridViewTextBoxColumn";
            this.studentIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // fldStringDataGridViewTextBoxColumn
            // 
            this.fldStringDataGridViewTextBoxColumn.DataPropertyName = "Fld_String";
            this.fldStringDataGridViewTextBoxColumn.HeaderText = "Fld_String";
            this.fldStringDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fldStringDataGridViewTextBoxColumn.Name = "fldStringDataGridViewTextBoxColumn";
            this.fldStringDataGridViewTextBoxColumn.Width = 125;
            // 
            // fldIntDataGridViewTextBoxColumn
            // 
            this.fldIntDataGridViewTextBoxColumn.DataPropertyName = "Fld_Int";
            this.fldIntDataGridViewTextBoxColumn.HeaderText = "Fld_Int";
            this.fldIntDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fldIntDataGridViewTextBoxColumn.Name = "fldIntDataGridViewTextBoxColumn";
            this.fldIntDataGridViewTextBoxColumn.Width = 125;
            // 
            // fldBoolDataGridViewCheckBoxColumn
            // 
            this.fldBoolDataGridViewCheckBoxColumn.DataPropertyName = "Fld_Bool";
            this.fldBoolDataGridViewCheckBoxColumn.HeaderText = "Fld_Bool";
            this.fldBoolDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.fldBoolDataGridViewCheckBoxColumn.Name = "fldBoolDataGridViewCheckBoxColumn";
            this.fldBoolDataGridViewCheckBoxColumn.Width = 125;
            // 
            // dsTran
            // 
            this.dsTran.DataSetName = "dsTran";
            this.dsTran.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(920, 338);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tbl2rowIdDataGridViewTextBoxColumn,
            this.studentIdDataGridViewTextBoxColumn1,
            this.fldStringDataGridViewTextBoxColumn1,
            this.fldIntDataGridViewTextBoxColumn1,
            this.fldBoolDataGridViewCheckBoxColumn1});
            this.dataGridView2.DataMember = "SampTbl2";
            this.dataGridView2.DataSource = this.dsTran;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(914, 332);
            this.dataGridView2.TabIndex = 1;
            // 
            // tbl2rowIdDataGridViewTextBoxColumn
            // 
            this.tbl2rowIdDataGridViewTextBoxColumn.DataPropertyName = "Tbl2_row_Id";
            this.tbl2rowIdDataGridViewTextBoxColumn.HeaderText = "Tbl2_row_Id";
            this.tbl2rowIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tbl2rowIdDataGridViewTextBoxColumn.Name = "tbl2rowIdDataGridViewTextBoxColumn";
            this.tbl2rowIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.tbl2rowIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentIdDataGridViewTextBoxColumn1
            // 
            this.studentIdDataGridViewTextBoxColumn1.DataPropertyName = "Student_Id";
            this.studentIdDataGridViewTextBoxColumn1.HeaderText = "Student_Id";
            this.studentIdDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.studentIdDataGridViewTextBoxColumn1.Name = "studentIdDataGridViewTextBoxColumn1";
            this.studentIdDataGridViewTextBoxColumn1.Width = 125;
            // 
            // fldStringDataGridViewTextBoxColumn1
            // 
            this.fldStringDataGridViewTextBoxColumn1.DataPropertyName = "Fld_String";
            this.fldStringDataGridViewTextBoxColumn1.HeaderText = "Fld_String";
            this.fldStringDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.fldStringDataGridViewTextBoxColumn1.Name = "fldStringDataGridViewTextBoxColumn1";
            this.fldStringDataGridViewTextBoxColumn1.Width = 125;
            // 
            // fldIntDataGridViewTextBoxColumn1
            // 
            this.fldIntDataGridViewTextBoxColumn1.DataPropertyName = "Fld_Int";
            this.fldIntDataGridViewTextBoxColumn1.HeaderText = "Fld_Int";
            this.fldIntDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.fldIntDataGridViewTextBoxColumn1.Name = "fldIntDataGridViewTextBoxColumn1";
            this.fldIntDataGridViewTextBoxColumn1.Width = 125;
            // 
            // fldBoolDataGridViewCheckBoxColumn1
            // 
            this.fldBoolDataGridViewCheckBoxColumn1.DataPropertyName = "Fld_Bool";
            this.fldBoolDataGridViewCheckBoxColumn1.HeaderText = "Fld_Bool";
            this.fldBoolDataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.fldBoolDataGridViewCheckBoxColumn1.Name = "fldBoolDataGridViewCheckBoxColumn1";
            this.fldBoolDataGridViewCheckBoxColumn1.Width = 125;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(920, 338);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tbl3rowIdDataGridViewTextBoxColumn,
            this.studentIdDataGridViewTextBoxColumn2,
            this.fldStringDataGridViewTextBoxColumn2,
            this.fldIntDataGridViewTextBoxColumn2,
            this.fldBoolDataGridViewCheckBoxColumn2});
            this.dataGridView3.DataMember = "SampTbl3";
            this.dataGridView3.DataSource = this.dsTran;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(3, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(914, 332);
            this.dataGridView3.TabIndex = 1;
            // 
            // tbl3rowIdDataGridViewTextBoxColumn
            // 
            this.tbl3rowIdDataGridViewTextBoxColumn.DataPropertyName = "Tbl3_row_Id";
            this.tbl3rowIdDataGridViewTextBoxColumn.HeaderText = "Tbl3_row_Id";
            this.tbl3rowIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tbl3rowIdDataGridViewTextBoxColumn.Name = "tbl3rowIdDataGridViewTextBoxColumn";
            this.tbl3rowIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.tbl3rowIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentIdDataGridViewTextBoxColumn2
            // 
            this.studentIdDataGridViewTextBoxColumn2.DataPropertyName = "Student_Id";
            this.studentIdDataGridViewTextBoxColumn2.HeaderText = "Student_Id";
            this.studentIdDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.studentIdDataGridViewTextBoxColumn2.Name = "studentIdDataGridViewTextBoxColumn2";
            this.studentIdDataGridViewTextBoxColumn2.Width = 125;
            // 
            // fldStringDataGridViewTextBoxColumn2
            // 
            this.fldStringDataGridViewTextBoxColumn2.DataPropertyName = "Fld_String";
            this.fldStringDataGridViewTextBoxColumn2.HeaderText = "Fld_String";
            this.fldStringDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.fldStringDataGridViewTextBoxColumn2.Name = "fldStringDataGridViewTextBoxColumn2";
            this.fldStringDataGridViewTextBoxColumn2.Width = 125;
            // 
            // fldIntDataGridViewTextBoxColumn2
            // 
            this.fldIntDataGridViewTextBoxColumn2.DataPropertyName = "Fld_Int";
            this.fldIntDataGridViewTextBoxColumn2.HeaderText = "Fld_Int";
            this.fldIntDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.fldIntDataGridViewTextBoxColumn2.Name = "fldIntDataGridViewTextBoxColumn2";
            this.fldIntDataGridViewTextBoxColumn2.Width = 125;
            // 
            // fldBoolDataGridViewCheckBoxColumn2
            // 
            this.fldBoolDataGridViewCheckBoxColumn2.DataPropertyName = "Fld_Bool";
            this.fldBoolDataGridViewCheckBoxColumn2.HeaderText = "Fld_Bool";
            this.fldBoolDataGridViewCheckBoxColumn2.MinimumWidth = 6;
            this.fldBoolDataGridViewCheckBoxColumn2.Name = "fldBoolDataGridViewCheckBoxColumn2";
            this.fldBoolDataGridViewCheckBoxColumn2.Width = 125;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridView4);
            this.tabPage4.Location = new System.Drawing.Point(4, 27);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(920, 338);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tbl4rowIdDataGridViewTextBoxColumn,
            this.studentIdDataGridViewTextBoxColumn3,
            this.fldStringDataGridViewTextBoxColumn3,
            this.fldIntDataGridViewTextBoxColumn3,
            this.fldBoolDataGridViewCheckBoxColumn3});
            this.dataGridView4.DataMember = "SampTbl4";
            this.dataGridView4.DataSource = this.dsTran;
            this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView4.Location = new System.Drawing.Point(3, 3);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(914, 332);
            this.dataGridView4.TabIndex = 1;
            // 
            // tbl4rowIdDataGridViewTextBoxColumn
            // 
            this.tbl4rowIdDataGridViewTextBoxColumn.DataPropertyName = "Tbl4_row_Id";
            this.tbl4rowIdDataGridViewTextBoxColumn.HeaderText = "Tbl4_row_Id";
            this.tbl4rowIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tbl4rowIdDataGridViewTextBoxColumn.Name = "tbl4rowIdDataGridViewTextBoxColumn";
            this.tbl4rowIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.tbl4rowIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentIdDataGridViewTextBoxColumn3
            // 
            this.studentIdDataGridViewTextBoxColumn3.DataPropertyName = "Student_Id";
            this.studentIdDataGridViewTextBoxColumn3.HeaderText = "Student_Id";
            this.studentIdDataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.studentIdDataGridViewTextBoxColumn3.Name = "studentIdDataGridViewTextBoxColumn3";
            this.studentIdDataGridViewTextBoxColumn3.Width = 125;
            // 
            // fldStringDataGridViewTextBoxColumn3
            // 
            this.fldStringDataGridViewTextBoxColumn3.DataPropertyName = "Fld_String";
            this.fldStringDataGridViewTextBoxColumn3.HeaderText = "Fld_String";
            this.fldStringDataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.fldStringDataGridViewTextBoxColumn3.Name = "fldStringDataGridViewTextBoxColumn3";
            this.fldStringDataGridViewTextBoxColumn3.Width = 125;
            // 
            // fldIntDataGridViewTextBoxColumn3
            // 
            this.fldIntDataGridViewTextBoxColumn3.DataPropertyName = "Fld_Int";
            this.fldIntDataGridViewTextBoxColumn3.HeaderText = "Fld_Int";
            this.fldIntDataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.fldIntDataGridViewTextBoxColumn3.Name = "fldIntDataGridViewTextBoxColumn3";
            this.fldIntDataGridViewTextBoxColumn3.Width = 125;
            // 
            // fldBoolDataGridViewCheckBoxColumn3
            // 
            this.fldBoolDataGridViewCheckBoxColumn3.DataPropertyName = "Fld_Bool";
            this.fldBoolDataGridViewCheckBoxColumn3.HeaderText = "Fld_Bool";
            this.fldBoolDataGridViewCheckBoxColumn3.MinimumWidth = 6;
            this.fldBoolDataGridViewCheckBoxColumn3.Name = "fldBoolDataGridViewCheckBoxColumn3";
            this.fldBoolDataGridViewCheckBoxColumn3.Width = 125;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dataGridView5);
            this.tabPage5.Location = new System.Drawing.Point(4, 27);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(920, 338);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dataGridView5
            // 
            this.dataGridView5.AutoGenerateColumns = false;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tbl5rowIdDataGridViewTextBoxColumn,
            this.studentIdDataGridViewTextBoxColumn4,
            this.fldStringDataGridViewTextBoxColumn4,
            this.fldIntDataGridViewTextBoxColumn4,
            this.fldBoolDataGridViewCheckBoxColumn4});
            this.dataGridView5.DataMember = "SampTbl5";
            this.dataGridView5.DataSource = this.dsTran;
            this.dataGridView5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView5.Location = new System.Drawing.Point(3, 3);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowHeadersWidth = 51;
            this.dataGridView5.RowTemplate.Height = 24;
            this.dataGridView5.Size = new System.Drawing.Size(914, 332);
            this.dataGridView5.TabIndex = 1;
            // 
            // tbl5rowIdDataGridViewTextBoxColumn
            // 
            this.tbl5rowIdDataGridViewTextBoxColumn.DataPropertyName = "Tbl5_row_Id";
            this.tbl5rowIdDataGridViewTextBoxColumn.HeaderText = "Tbl5_row_Id";
            this.tbl5rowIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tbl5rowIdDataGridViewTextBoxColumn.Name = "tbl5rowIdDataGridViewTextBoxColumn";
            this.tbl5rowIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.tbl5rowIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentIdDataGridViewTextBoxColumn4
            // 
            this.studentIdDataGridViewTextBoxColumn4.DataPropertyName = "Student_Id";
            this.studentIdDataGridViewTextBoxColumn4.HeaderText = "Student_Id";
            this.studentIdDataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.studentIdDataGridViewTextBoxColumn4.Name = "studentIdDataGridViewTextBoxColumn4";
            this.studentIdDataGridViewTextBoxColumn4.Width = 125;
            // 
            // fldStringDataGridViewTextBoxColumn4
            // 
            this.fldStringDataGridViewTextBoxColumn4.DataPropertyName = "Fld_String";
            this.fldStringDataGridViewTextBoxColumn4.HeaderText = "Fld_String";
            this.fldStringDataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.fldStringDataGridViewTextBoxColumn4.Name = "fldStringDataGridViewTextBoxColumn4";
            this.fldStringDataGridViewTextBoxColumn4.Width = 125;
            // 
            // fldIntDataGridViewTextBoxColumn4
            // 
            this.fldIntDataGridViewTextBoxColumn4.DataPropertyName = "Fld_Int";
            this.fldIntDataGridViewTextBoxColumn4.HeaderText = "Fld_Int";
            this.fldIntDataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.fldIntDataGridViewTextBoxColumn4.Name = "fldIntDataGridViewTextBoxColumn4";
            this.fldIntDataGridViewTextBoxColumn4.Width = 125;
            // 
            // fldBoolDataGridViewCheckBoxColumn4
            // 
            this.fldBoolDataGridViewCheckBoxColumn4.DataPropertyName = "Fld_Bool";
            this.fldBoolDataGridViewCheckBoxColumn4.HeaderText = "Fld_Bool";
            this.fldBoolDataGridViewCheckBoxColumn4.MinimumWidth = 6;
            this.fldBoolDataGridViewCheckBoxColumn4.Name = "fldBoolDataGridViewCheckBoxColumn4";
            this.fldBoolDataGridViewCheckBoxColumn4.Width = 125;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.dataGridView6);
            this.tabPage6.Location = new System.Drawing.Point(4, 27);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(920, 338);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "tabPage6";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // dataGridView6
            // 
            this.dataGridView6.AutoGenerateColumns = false;
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tbl6rowIdDataGridViewTextBoxColumn,
            this.studentIdDataGridViewTextBoxColumn5,
            this.fldStringDataGridViewTextBoxColumn5,
            this.fldIntDataGridViewTextBoxColumn5,
            this.fldBoolDataGridViewCheckBoxColumn5});
            this.dataGridView6.DataMember = "SampTbl6";
            this.dataGridView6.DataSource = this.dsTran;
            this.dataGridView6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView6.Location = new System.Drawing.Point(3, 3);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.RowHeadersWidth = 51;
            this.dataGridView6.RowTemplate.Height = 24;
            this.dataGridView6.Size = new System.Drawing.Size(914, 332);
            this.dataGridView6.TabIndex = 1;
            // 
            // tbl6rowIdDataGridViewTextBoxColumn
            // 
            this.tbl6rowIdDataGridViewTextBoxColumn.DataPropertyName = "Tbl6_row_Id";
            this.tbl6rowIdDataGridViewTextBoxColumn.HeaderText = "Tbl6_row_Id";
            this.tbl6rowIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tbl6rowIdDataGridViewTextBoxColumn.Name = "tbl6rowIdDataGridViewTextBoxColumn";
            this.tbl6rowIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.tbl6rowIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentIdDataGridViewTextBoxColumn5
            // 
            this.studentIdDataGridViewTextBoxColumn5.DataPropertyName = "Student_Id";
            this.studentIdDataGridViewTextBoxColumn5.HeaderText = "Student_Id";
            this.studentIdDataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.studentIdDataGridViewTextBoxColumn5.Name = "studentIdDataGridViewTextBoxColumn5";
            this.studentIdDataGridViewTextBoxColumn5.Width = 125;
            // 
            // fldStringDataGridViewTextBoxColumn5
            // 
            this.fldStringDataGridViewTextBoxColumn5.DataPropertyName = "Fld_String";
            this.fldStringDataGridViewTextBoxColumn5.HeaderText = "Fld_String";
            this.fldStringDataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.fldStringDataGridViewTextBoxColumn5.Name = "fldStringDataGridViewTextBoxColumn5";
            this.fldStringDataGridViewTextBoxColumn5.Width = 125;
            // 
            // fldIntDataGridViewTextBoxColumn5
            // 
            this.fldIntDataGridViewTextBoxColumn5.DataPropertyName = "Fld_Int";
            this.fldIntDataGridViewTextBoxColumn5.HeaderText = "Fld_Int";
            this.fldIntDataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.fldIntDataGridViewTextBoxColumn5.Name = "fldIntDataGridViewTextBoxColumn5";
            this.fldIntDataGridViewTextBoxColumn5.Width = 125;
            // 
            // fldBoolDataGridViewCheckBoxColumn5
            // 
            this.fldBoolDataGridViewCheckBoxColumn5.DataPropertyName = "Fld_Bool";
            this.fldBoolDataGridViewCheckBoxColumn5.HeaderText = "Fld_Bool";
            this.fldBoolDataGridViewCheckBoxColumn5.MinimumWidth = 6;
            this.fldBoolDataGridViewCheckBoxColumn5.Name = "fldBoolDataGridViewCheckBoxColumn5";
            this.fldBoolDataGridViewCheckBoxColumn5.Width = 125;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.dataGridView7);
            this.tabPage7.Location = new System.Drawing.Point(4, 27);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(920, 338);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "tabPage7";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // dataGridView7
            // 
            this.dataGridView7.AutoGenerateColumns = false;
            this.dataGridView7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView7.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tbl7rowIdDataGridViewTextBoxColumn,
            this.studentIdDataGridViewTextBoxColumn6,
            this.fldStringDataGridViewTextBoxColumn6,
            this.fldIntDataGridViewTextBoxColumn6,
            this.fldBoolDataGridViewCheckBoxColumn6});
            this.dataGridView7.DataMember = "SampTbl7";
            this.dataGridView7.DataSource = this.dsTran;
            this.dataGridView7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView7.Location = new System.Drawing.Point(3, 3);
            this.dataGridView7.Name = "dataGridView7";
            this.dataGridView7.RowHeadersWidth = 51;
            this.dataGridView7.RowTemplate.Height = 24;
            this.dataGridView7.Size = new System.Drawing.Size(914, 332);
            this.dataGridView7.TabIndex = 1;
            // 
            // tbl7rowIdDataGridViewTextBoxColumn
            // 
            this.tbl7rowIdDataGridViewTextBoxColumn.DataPropertyName = "Tbl7_row_Id";
            this.tbl7rowIdDataGridViewTextBoxColumn.HeaderText = "Tbl7_row_Id";
            this.tbl7rowIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tbl7rowIdDataGridViewTextBoxColumn.Name = "tbl7rowIdDataGridViewTextBoxColumn";
            this.tbl7rowIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.tbl7rowIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentIdDataGridViewTextBoxColumn6
            // 
            this.studentIdDataGridViewTextBoxColumn6.DataPropertyName = "Student_Id";
            this.studentIdDataGridViewTextBoxColumn6.HeaderText = "Student_Id";
            this.studentIdDataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.studentIdDataGridViewTextBoxColumn6.Name = "studentIdDataGridViewTextBoxColumn6";
            this.studentIdDataGridViewTextBoxColumn6.Width = 125;
            // 
            // fldStringDataGridViewTextBoxColumn6
            // 
            this.fldStringDataGridViewTextBoxColumn6.DataPropertyName = "Fld_String";
            this.fldStringDataGridViewTextBoxColumn6.HeaderText = "Fld_String";
            this.fldStringDataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.fldStringDataGridViewTextBoxColumn6.Name = "fldStringDataGridViewTextBoxColumn6";
            this.fldStringDataGridViewTextBoxColumn6.Width = 125;
            // 
            // fldIntDataGridViewTextBoxColumn6
            // 
            this.fldIntDataGridViewTextBoxColumn6.DataPropertyName = "Fld_Int";
            this.fldIntDataGridViewTextBoxColumn6.HeaderText = "Fld_Int";
            this.fldIntDataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.fldIntDataGridViewTextBoxColumn6.Name = "fldIntDataGridViewTextBoxColumn6";
            this.fldIntDataGridViewTextBoxColumn6.Width = 125;
            // 
            // fldBoolDataGridViewCheckBoxColumn6
            // 
            this.fldBoolDataGridViewCheckBoxColumn6.DataPropertyName = "Fld_Bool";
            this.fldBoolDataGridViewCheckBoxColumn6.HeaderText = "Fld_Bool";
            this.fldBoolDataGridViewCheckBoxColumn6.MinimumWidth = 6;
            this.fldBoolDataGridViewCheckBoxColumn6.Name = "fldBoolDataGridViewCheckBoxColumn6";
            this.fldBoolDataGridViewCheckBoxColumn6.Width = 125;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.dataGridView8);
            this.tabPage8.Location = new System.Drawing.Point(4, 27);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(920, 338);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "tabPage8";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // dataGridView8
            // 
            this.dataGridView8.AutoGenerateColumns = false;
            this.dataGridView8.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView8.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tbl8rowIdDataGridViewTextBoxColumn,
            this.studentIdDataGridViewTextBoxColumn7,
            this.fldStringDataGridViewTextBoxColumn7,
            this.fldIntDataGridViewTextBoxColumn7,
            this.fldBoolDataGridViewCheckBoxColumn7});
            this.dataGridView8.DataMember = "SampTbl8";
            this.dataGridView8.DataSource = this.dsTran;
            this.dataGridView8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView8.Location = new System.Drawing.Point(3, 3);
            this.dataGridView8.Name = "dataGridView8";
            this.dataGridView8.RowHeadersWidth = 51;
            this.dataGridView8.RowTemplate.Height = 24;
            this.dataGridView8.Size = new System.Drawing.Size(914, 332);
            this.dataGridView8.TabIndex = 1;
            // 
            // tbl8rowIdDataGridViewTextBoxColumn
            // 
            this.tbl8rowIdDataGridViewTextBoxColumn.DataPropertyName = "Tbl8_row_Id";
            this.tbl8rowIdDataGridViewTextBoxColumn.HeaderText = "Tbl8_row_Id";
            this.tbl8rowIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tbl8rowIdDataGridViewTextBoxColumn.Name = "tbl8rowIdDataGridViewTextBoxColumn";
            this.tbl8rowIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.tbl8rowIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentIdDataGridViewTextBoxColumn7
            // 
            this.studentIdDataGridViewTextBoxColumn7.DataPropertyName = "Student_Id";
            this.studentIdDataGridViewTextBoxColumn7.HeaderText = "Student_Id";
            this.studentIdDataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.studentIdDataGridViewTextBoxColumn7.Name = "studentIdDataGridViewTextBoxColumn7";
            this.studentIdDataGridViewTextBoxColumn7.Width = 125;
            // 
            // fldStringDataGridViewTextBoxColumn7
            // 
            this.fldStringDataGridViewTextBoxColumn7.DataPropertyName = "Fld_String";
            this.fldStringDataGridViewTextBoxColumn7.HeaderText = "Fld_String";
            this.fldStringDataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.fldStringDataGridViewTextBoxColumn7.Name = "fldStringDataGridViewTextBoxColumn7";
            this.fldStringDataGridViewTextBoxColumn7.Width = 125;
            // 
            // fldIntDataGridViewTextBoxColumn7
            // 
            this.fldIntDataGridViewTextBoxColumn7.DataPropertyName = "Fld_Int";
            this.fldIntDataGridViewTextBoxColumn7.HeaderText = "Fld_Int";
            this.fldIntDataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.fldIntDataGridViewTextBoxColumn7.Name = "fldIntDataGridViewTextBoxColumn7";
            this.fldIntDataGridViewTextBoxColumn7.Width = 125;
            // 
            // fldBoolDataGridViewCheckBoxColumn7
            // 
            this.fldBoolDataGridViewCheckBoxColumn7.DataPropertyName = "Fld_Bool";
            this.fldBoolDataGridViewCheckBoxColumn7.HeaderText = "Fld_Bool";
            this.fldBoolDataGridViewCheckBoxColumn7.MinimumWidth = 6;
            this.fldBoolDataGridViewCheckBoxColumn7.Name = "fldBoolDataGridViewCheckBoxColumn7";
            this.fldBoolDataGridViewCheckBoxColumn7.Width = 125;
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.dataGridView9);
            this.tabPage9.Location = new System.Drawing.Point(4, 27);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(920, 338);
            this.tabPage9.TabIndex = 8;
            this.tabPage9.Text = "tabPage9";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // dataGridView9
            // 
            this.dataGridView9.AutoGenerateColumns = false;
            this.dataGridView9.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView9.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tbl9rowIdDataGridViewTextBoxColumn,
            this.studentIdDataGridViewTextBoxColumn8,
            this.fldStringDataGridViewTextBoxColumn8,
            this.fldIntDataGridViewTextBoxColumn8,
            this.fldBoolDataGridViewCheckBoxColumn8});
            this.dataGridView9.DataMember = "SampTbl9";
            this.dataGridView9.DataSource = this.dsTran;
            this.dataGridView9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView9.Location = new System.Drawing.Point(3, 3);
            this.dataGridView9.Name = "dataGridView9";
            this.dataGridView9.RowHeadersWidth = 51;
            this.dataGridView9.RowTemplate.Height = 24;
            this.dataGridView9.Size = new System.Drawing.Size(914, 332);
            this.dataGridView9.TabIndex = 1;
            // 
            // tbl9rowIdDataGridViewTextBoxColumn
            // 
            this.tbl9rowIdDataGridViewTextBoxColumn.DataPropertyName = "Tbl9_row_Id";
            this.tbl9rowIdDataGridViewTextBoxColumn.HeaderText = "Tbl9_row_Id";
            this.tbl9rowIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tbl9rowIdDataGridViewTextBoxColumn.Name = "tbl9rowIdDataGridViewTextBoxColumn";
            this.tbl9rowIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.tbl9rowIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentIdDataGridViewTextBoxColumn8
            // 
            this.studentIdDataGridViewTextBoxColumn8.DataPropertyName = "Student_Id";
            this.studentIdDataGridViewTextBoxColumn8.HeaderText = "Student_Id";
            this.studentIdDataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.studentIdDataGridViewTextBoxColumn8.Name = "studentIdDataGridViewTextBoxColumn8";
            this.studentIdDataGridViewTextBoxColumn8.Width = 125;
            // 
            // fldStringDataGridViewTextBoxColumn8
            // 
            this.fldStringDataGridViewTextBoxColumn8.DataPropertyName = "Fld_String";
            this.fldStringDataGridViewTextBoxColumn8.HeaderText = "Fld_String";
            this.fldStringDataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.fldStringDataGridViewTextBoxColumn8.Name = "fldStringDataGridViewTextBoxColumn8";
            this.fldStringDataGridViewTextBoxColumn8.Width = 125;
            // 
            // fldIntDataGridViewTextBoxColumn8
            // 
            this.fldIntDataGridViewTextBoxColumn8.DataPropertyName = "Fld_Int";
            this.fldIntDataGridViewTextBoxColumn8.HeaderText = "Fld_Int";
            this.fldIntDataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.fldIntDataGridViewTextBoxColumn8.Name = "fldIntDataGridViewTextBoxColumn8";
            this.fldIntDataGridViewTextBoxColumn8.Width = 125;
            // 
            // fldBoolDataGridViewCheckBoxColumn8
            // 
            this.fldBoolDataGridViewCheckBoxColumn8.DataPropertyName = "Fld_Bool";
            this.fldBoolDataGridViewCheckBoxColumn8.HeaderText = "Fld_Bool";
            this.fldBoolDataGridViewCheckBoxColumn8.MinimumWidth = 6;
            this.fldBoolDataGridViewCheckBoxColumn8.Name = "fldBoolDataGridViewCheckBoxColumn8";
            this.fldBoolDataGridViewCheckBoxColumn8.Width = 125;
            // 
            // tabPage10
            // 
            this.tabPage10.Controls.Add(this.dataGridView10);
            this.tabPage10.Location = new System.Drawing.Point(4, 27);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage10.Size = new System.Drawing.Size(920, 338);
            this.tabPage10.TabIndex = 9;
            this.tabPage10.Text = "tabPage10";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // dataGridView10
            // 
            this.dataGridView10.AutoGenerateColumns = false;
            this.dataGridView10.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView10.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tbl10rowIdDataGridViewTextBoxColumn,
            this.studentIdDataGridViewTextBoxColumn9,
            this.fldStringDataGridViewTextBoxColumn9,
            this.fldIntDataGridViewTextBoxColumn9,
            this.fldBoolDataGridViewCheckBoxColumn9});
            this.dataGridView10.DataMember = "SampTbl10";
            this.dataGridView10.DataSource = this.dsTran;
            this.dataGridView10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView10.Location = new System.Drawing.Point(3, 3);
            this.dataGridView10.Name = "dataGridView10";
            this.dataGridView10.RowHeadersWidth = 51;
            this.dataGridView10.RowTemplate.Height = 24;
            this.dataGridView10.Size = new System.Drawing.Size(914, 332);
            this.dataGridView10.TabIndex = 1;
            // 
            // tbl10rowIdDataGridViewTextBoxColumn
            // 
            this.tbl10rowIdDataGridViewTextBoxColumn.DataPropertyName = "Tbl10_row_Id";
            this.tbl10rowIdDataGridViewTextBoxColumn.HeaderText = "Tbl10_row_Id";
            this.tbl10rowIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tbl10rowIdDataGridViewTextBoxColumn.Name = "tbl10rowIdDataGridViewTextBoxColumn";
            this.tbl10rowIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.tbl10rowIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentIdDataGridViewTextBoxColumn9
            // 
            this.studentIdDataGridViewTextBoxColumn9.DataPropertyName = "Student_Id";
            this.studentIdDataGridViewTextBoxColumn9.HeaderText = "Student_Id";
            this.studentIdDataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.studentIdDataGridViewTextBoxColumn9.Name = "studentIdDataGridViewTextBoxColumn9";
            this.studentIdDataGridViewTextBoxColumn9.Width = 125;
            // 
            // fldStringDataGridViewTextBoxColumn9
            // 
            this.fldStringDataGridViewTextBoxColumn9.DataPropertyName = "Fld_String";
            this.fldStringDataGridViewTextBoxColumn9.HeaderText = "Fld_String";
            this.fldStringDataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.fldStringDataGridViewTextBoxColumn9.Name = "fldStringDataGridViewTextBoxColumn9";
            this.fldStringDataGridViewTextBoxColumn9.Width = 125;
            // 
            // fldIntDataGridViewTextBoxColumn9
            // 
            this.fldIntDataGridViewTextBoxColumn9.DataPropertyName = "Fld_Int";
            this.fldIntDataGridViewTextBoxColumn9.HeaderText = "Fld_Int";
            this.fldIntDataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.fldIntDataGridViewTextBoxColumn9.Name = "fldIntDataGridViewTextBoxColumn9";
            this.fldIntDataGridViewTextBoxColumn9.Width = 125;
            // 
            // fldBoolDataGridViewCheckBoxColumn9
            // 
            this.fldBoolDataGridViewCheckBoxColumn9.DataPropertyName = "Fld_Bool";
            this.fldBoolDataGridViewCheckBoxColumn9.HeaderText = "Fld_Bool";
            this.fldBoolDataGridViewCheckBoxColumn9.MinimumWidth = 6;
            this.fldBoolDataGridViewCheckBoxColumn9.Name = "fldBoolDataGridViewCheckBoxColumn9";
            this.fldBoolDataGridViewCheckBoxColumn9.Width = 125;
            // 
            // tabPage11
            // 
            this.tabPage11.Controls.Add(this.dataGridView11);
            this.tabPage11.Location = new System.Drawing.Point(4, 27);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage11.Size = new System.Drawing.Size(920, 338);
            this.tabPage11.TabIndex = 10;
            this.tabPage11.Text = "tabPage11";
            this.tabPage11.UseVisualStyleBackColor = true;
            // 
            // dataGridView11
            // 
            this.dataGridView11.AutoGenerateColumns = false;
            this.dataGridView11.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView11.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tbl11rowIdDataGridViewTextBoxColumn,
            this.studentIdDataGridViewTextBoxColumn10,
            this.fldStringDataGridViewTextBoxColumn10,
            this.fldIntDataGridViewTextBoxColumn10,
            this.fldBoolDataGridViewCheckBoxColumn10});
            this.dataGridView11.DataMember = "SampTbl11";
            this.dataGridView11.DataSource = this.dsTran;
            this.dataGridView11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView11.Location = new System.Drawing.Point(3, 3);
            this.dataGridView11.Name = "dataGridView11";
            this.dataGridView11.RowHeadersWidth = 51;
            this.dataGridView11.RowTemplate.Height = 24;
            this.dataGridView11.Size = new System.Drawing.Size(914, 332);
            this.dataGridView11.TabIndex = 1;
            // 
            // tbl11rowIdDataGridViewTextBoxColumn
            // 
            this.tbl11rowIdDataGridViewTextBoxColumn.DataPropertyName = "Tbl11_row_Id";
            this.tbl11rowIdDataGridViewTextBoxColumn.HeaderText = "Tbl11_row_Id";
            this.tbl11rowIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tbl11rowIdDataGridViewTextBoxColumn.Name = "tbl11rowIdDataGridViewTextBoxColumn";
            this.tbl11rowIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.tbl11rowIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentIdDataGridViewTextBoxColumn10
            // 
            this.studentIdDataGridViewTextBoxColumn10.DataPropertyName = "Student_Id";
            this.studentIdDataGridViewTextBoxColumn10.HeaderText = "Student_Id";
            this.studentIdDataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.studentIdDataGridViewTextBoxColumn10.Name = "studentIdDataGridViewTextBoxColumn10";
            this.studentIdDataGridViewTextBoxColumn10.Width = 125;
            // 
            // fldStringDataGridViewTextBoxColumn10
            // 
            this.fldStringDataGridViewTextBoxColumn10.DataPropertyName = "Fld_String";
            this.fldStringDataGridViewTextBoxColumn10.HeaderText = "Fld_String";
            this.fldStringDataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.fldStringDataGridViewTextBoxColumn10.Name = "fldStringDataGridViewTextBoxColumn10";
            this.fldStringDataGridViewTextBoxColumn10.Width = 125;
            // 
            // fldIntDataGridViewTextBoxColumn10
            // 
            this.fldIntDataGridViewTextBoxColumn10.DataPropertyName = "Fld_Int";
            this.fldIntDataGridViewTextBoxColumn10.HeaderText = "Fld_Int";
            this.fldIntDataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.fldIntDataGridViewTextBoxColumn10.Name = "fldIntDataGridViewTextBoxColumn10";
            this.fldIntDataGridViewTextBoxColumn10.Width = 125;
            // 
            // fldBoolDataGridViewCheckBoxColumn10
            // 
            this.fldBoolDataGridViewCheckBoxColumn10.DataPropertyName = "Fld_Bool";
            this.fldBoolDataGridViewCheckBoxColumn10.HeaderText = "Fld_Bool";
            this.fldBoolDataGridViewCheckBoxColumn10.MinimumWidth = 6;
            this.fldBoolDataGridViewCheckBoxColumn10.Name = "fldBoolDataGridViewCheckBoxColumn10";
            this.fldBoolDataGridViewCheckBoxColumn10.Width = 125;
            // 
            // tabPage12
            // 
            this.tabPage12.Controls.Add(this.dataGridView12);
            this.tabPage12.Location = new System.Drawing.Point(4, 27);
            this.tabPage12.Name = "tabPage12";
            this.tabPage12.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage12.Size = new System.Drawing.Size(920, 338);
            this.tabPage12.TabIndex = 11;
            this.tabPage12.Text = "tabPage12";
            this.tabPage12.UseVisualStyleBackColor = true;
            // 
            // dataGridView12
            // 
            this.dataGridView12.AutoGenerateColumns = false;
            this.dataGridView12.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView12.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tbl12rowIdDataGridViewTextBoxColumn,
            this.studentIdDataGridViewTextBoxColumn11,
            this.fldStringDataGridViewTextBoxColumn11,
            this.fldIntDataGridViewTextBoxColumn11,
            this.fldBoolDataGridViewCheckBoxColumn11});
            this.dataGridView12.DataMember = "SampTbl12";
            this.dataGridView12.DataSource = this.dsTran;
            this.dataGridView12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView12.Location = new System.Drawing.Point(3, 3);
            this.dataGridView12.Name = "dataGridView12";
            this.dataGridView12.RowHeadersWidth = 51;
            this.dataGridView12.RowTemplate.Height = 24;
            this.dataGridView12.Size = new System.Drawing.Size(914, 332);
            this.dataGridView12.TabIndex = 1;
            // 
            // tbl12rowIdDataGridViewTextBoxColumn
            // 
            this.tbl12rowIdDataGridViewTextBoxColumn.DataPropertyName = "Tbl12_row_Id";
            this.tbl12rowIdDataGridViewTextBoxColumn.HeaderText = "Tbl12_row_Id";
            this.tbl12rowIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tbl12rowIdDataGridViewTextBoxColumn.Name = "tbl12rowIdDataGridViewTextBoxColumn";
            this.tbl12rowIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.tbl12rowIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentIdDataGridViewTextBoxColumn11
            // 
            this.studentIdDataGridViewTextBoxColumn11.DataPropertyName = "Student_Id";
            this.studentIdDataGridViewTextBoxColumn11.HeaderText = "Student_Id";
            this.studentIdDataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.studentIdDataGridViewTextBoxColumn11.Name = "studentIdDataGridViewTextBoxColumn11";
            this.studentIdDataGridViewTextBoxColumn11.Width = 125;
            // 
            // fldStringDataGridViewTextBoxColumn11
            // 
            this.fldStringDataGridViewTextBoxColumn11.DataPropertyName = "Fld_String";
            this.fldStringDataGridViewTextBoxColumn11.HeaderText = "Fld_String";
            this.fldStringDataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.fldStringDataGridViewTextBoxColumn11.Name = "fldStringDataGridViewTextBoxColumn11";
            this.fldStringDataGridViewTextBoxColumn11.Width = 125;
            // 
            // fldIntDataGridViewTextBoxColumn11
            // 
            this.fldIntDataGridViewTextBoxColumn11.DataPropertyName = "Fld_Int";
            this.fldIntDataGridViewTextBoxColumn11.HeaderText = "Fld_Int";
            this.fldIntDataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.fldIntDataGridViewTextBoxColumn11.Name = "fldIntDataGridViewTextBoxColumn11";
            this.fldIntDataGridViewTextBoxColumn11.Width = 125;
            // 
            // fldBoolDataGridViewCheckBoxColumn11
            // 
            this.fldBoolDataGridViewCheckBoxColumn11.DataPropertyName = "Fld_Bool";
            this.fldBoolDataGridViewCheckBoxColumn11.HeaderText = "Fld_Bool";
            this.fldBoolDataGridViewCheckBoxColumn11.MinimumWidth = 6;
            this.fldBoolDataGridViewCheckBoxColumn11.Name = "fldBoolDataGridViewCheckBoxColumn11";
            this.fldBoolDataGridViewCheckBoxColumn11.Width = 125;
            // 
            // tabPage13
            // 
            this.tabPage13.Controls.Add(this.dataGridView13);
            this.tabPage13.Location = new System.Drawing.Point(4, 27);
            this.tabPage13.Name = "tabPage13";
            this.tabPage13.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage13.Size = new System.Drawing.Size(920, 338);
            this.tabPage13.TabIndex = 12;
            this.tabPage13.Text = "tabPage13";
            this.tabPage13.UseVisualStyleBackColor = true;
            // 
            // dataGridView13
            // 
            this.dataGridView13.AutoGenerateColumns = false;
            this.dataGridView13.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView13.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studGrdIdDataGridViewTextBoxColumn,
            this.subjectIdDataGridViewTextBoxColumn,
            this.studentIdDataGridViewTextBoxColumn12,
            this.grd1DataGridViewTextBoxColumn,
            this.grd2DataGridViewTextBoxColumn,
            this.grd3DataGridViewTextBoxColumn,
            this.grd4DataGridViewTextBoxColumn,
            this.grd5DataGridViewTextBoxColumn,
            this.grd6DataGridViewTextBoxColumn,
            this.remarksDataGridViewTextBoxColumn});
            this.dataGridView13.DataMember = "StudentGrade";
            this.dataGridView13.DataSource = this.dsTran;
            this.dataGridView13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView13.Location = new System.Drawing.Point(3, 3);
            this.dataGridView13.Name = "dataGridView13";
            this.dataGridView13.RowHeadersWidth = 51;
            this.dataGridView13.RowTemplate.Height = 24;
            this.dataGridView13.Size = new System.Drawing.Size(914, 332);
            this.dataGridView13.TabIndex = 0;
            // 
            // studGrdIdDataGridViewTextBoxColumn
            // 
            this.studGrdIdDataGridViewTextBoxColumn.DataPropertyName = "StudGrd_Id";
            this.studGrdIdDataGridViewTextBoxColumn.HeaderText = "StudGrd_Id";
            this.studGrdIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studGrdIdDataGridViewTextBoxColumn.Name = "studGrdIdDataGridViewTextBoxColumn";
            this.studGrdIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.studGrdIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // subjectIdDataGridViewTextBoxColumn
            // 
            this.subjectIdDataGridViewTextBoxColumn.DataPropertyName = "subject_Id";
            this.subjectIdDataGridViewTextBoxColumn.HeaderText = "subject_Id";
            this.subjectIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subjectIdDataGridViewTextBoxColumn.Name = "subjectIdDataGridViewTextBoxColumn";
            this.subjectIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentIdDataGridViewTextBoxColumn12
            // 
            this.studentIdDataGridViewTextBoxColumn12.DataPropertyName = "Student_Id";
            this.studentIdDataGridViewTextBoxColumn12.HeaderText = "Student_Id";
            this.studentIdDataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.studentIdDataGridViewTextBoxColumn12.Name = "studentIdDataGridViewTextBoxColumn12";
            this.studentIdDataGridViewTextBoxColumn12.Width = 125;
            // 
            // grd1DataGridViewTextBoxColumn
            // 
            this.grd1DataGridViewTextBoxColumn.DataPropertyName = "Grd1";
            this.grd1DataGridViewTextBoxColumn.HeaderText = "Grd1";
            this.grd1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.grd1DataGridViewTextBoxColumn.Name = "grd1DataGridViewTextBoxColumn";
            this.grd1DataGridViewTextBoxColumn.Width = 125;
            // 
            // grd2DataGridViewTextBoxColumn
            // 
            this.grd2DataGridViewTextBoxColumn.DataPropertyName = "Grd2";
            this.grd2DataGridViewTextBoxColumn.HeaderText = "Grd2";
            this.grd2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.grd2DataGridViewTextBoxColumn.Name = "grd2DataGridViewTextBoxColumn";
            this.grd2DataGridViewTextBoxColumn.Width = 125;
            // 
            // grd3DataGridViewTextBoxColumn
            // 
            this.grd3DataGridViewTextBoxColumn.DataPropertyName = "Grd3";
            this.grd3DataGridViewTextBoxColumn.HeaderText = "Grd3";
            this.grd3DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.grd3DataGridViewTextBoxColumn.Name = "grd3DataGridViewTextBoxColumn";
            this.grd3DataGridViewTextBoxColumn.Width = 125;
            // 
            // grd4DataGridViewTextBoxColumn
            // 
            this.grd4DataGridViewTextBoxColumn.DataPropertyName = "Grd4";
            this.grd4DataGridViewTextBoxColumn.HeaderText = "Grd4";
            this.grd4DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.grd4DataGridViewTextBoxColumn.Name = "grd4DataGridViewTextBoxColumn";
            this.grd4DataGridViewTextBoxColumn.Width = 125;
            // 
            // grd5DataGridViewTextBoxColumn
            // 
            this.grd5DataGridViewTextBoxColumn.DataPropertyName = "Grd5";
            this.grd5DataGridViewTextBoxColumn.HeaderText = "Grd5";
            this.grd5DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.grd5DataGridViewTextBoxColumn.Name = "grd5DataGridViewTextBoxColumn";
            this.grd5DataGridViewTextBoxColumn.Width = 125;
            // 
            // grd6DataGridViewTextBoxColumn
            // 
            this.grd6DataGridViewTextBoxColumn.DataPropertyName = "Grd6";
            this.grd6DataGridViewTextBoxColumn.HeaderText = "Grd6";
            this.grd6DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.grd6DataGridViewTextBoxColumn.Name = "grd6DataGridViewTextBoxColumn";
            this.grd6DataGridViewTextBoxColumn.Width = 125;
            // 
            // remarksDataGridViewTextBoxColumn
            // 
            this.remarksDataGridViewTextBoxColumn.DataPropertyName = "Remarks";
            this.remarksDataGridViewTextBoxColumn.HeaderText = "Remarks";
            this.remarksDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.remarksDataGridViewTextBoxColumn.Name = "remarksDataGridViewTextBoxColumn";
            this.remarksDataGridViewTextBoxColumn.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBox9);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(928, 331);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Information";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 292);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 18);
            this.label10.TabIndex = 18;
            this.label10.Text = "Password:";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(172, 289);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(201, 25);
            this.textBox9.TabIndex = 17;
            this.textBox9.Validating += new System.ComponentModel.CancelEventHandler(this.textBox9_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 257);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 18);
            this.label9.TabIndex = 16;
            this.label9.Text = "User Name:";
            // 
            // textBox8
            // 
            this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTran, "axl_security.username", true));
            this.textBox8.Location = new System.Drawing.Point(172, 254);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(201, 25);
            this.textBox8.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "Contact No.:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Address Line 2:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Address Line 1:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(714, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "(Last Name)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(428, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "(Middle Name)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "(First Name)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Full Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Student Number:";
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTran, "StudentPersonalInfo.ContactNo", true));
            this.textBox7.Location = new System.Drawing.Point(172, 219);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(136, 25);
            this.textBox7.TabIndex = 6;
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTran, "StudentPersonalInfo.Adrs2", true));
            this.textBox6.Location = new System.Drawing.Point(172, 184);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(449, 25);
            this.textBox6.TabIndex = 5;
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTran, "StudentPersonalInfo.Adrs1", true));
            this.textBox5.Location = new System.Drawing.Point(172, 149);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(449, 25);
            this.textBox5.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTran, "StudentPersonalInfo.Lname", true));
            this.textBox4.Location = new System.Drawing.Point(627, 79);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(287, 25);
            this.textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTran, "StudentPersonalInfo.Mname", true));
            this.textBox3.Location = new System.Drawing.Point(379, 79);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(242, 25);
            this.textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTran, "StudentPersonalInfo.Fname", true));
            this.textBox2.Location = new System.Drawing.Point(172, 79);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(201, 25);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTran, "StudentPersonalInfo.Student_Id", true));
            this.textBox1.Location = new System.Drawing.Point(172, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 25);
            this.textBox1.TabIndex = 0;
            // 
            // AdpDet2
            // 
            this.AdpDet2.DeleteCommand = this.sqlDeleteCommand3;
            this.AdpDet2.InsertCommand = this.sqlInsertCommand3;
            this.AdpDet2.SelectCommand = this.sqlSelectCommand3;
            this.AdpDet2.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "SampTbl1", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Tbl1_row_Id", "Tbl1_row_Id"),
                        new System.Data.Common.DataColumnMapping("Student_Id", "Student_Id"),
                        new System.Data.Common.DataColumnMapping("Fld_String", "Fld_String"),
                        new System.Data.Common.DataColumnMapping("Fld_Int", "Fld_Int"),
                        new System.Data.Common.DataColumnMapping("Fld_Bool", "Fld_Bool")})});
            this.AdpDet2.UpdateCommand = this.sqlUpdateCommand3;
            // 
            // sqlDeleteCommand3
            // 
            this.sqlDeleteCommand3.CommandText = resources.GetString("sqlDeleteCommand3.CommandText");
            this.sqlDeleteCommand3.Connection = this.sqlConnection1;
            this.sqlDeleteCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_Tbl1_row_Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Tbl1_row_Id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Student_Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Student_Id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Student_Id", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Student_Id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fld_String", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fld_String", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fld_String", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fld_String", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fld_Int", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fld_Int", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fld_Int", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fld_Int", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fld_Bool", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fld_Bool", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fld_Bool", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fld_Bool", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlInsertCommand3
            // 
            this.sqlInsertCommand3.CommandText = resources.GetString("sqlInsertCommand3.CommandText");
            this.sqlInsertCommand3.Connection = this.sqlConnection1;
            this.sqlInsertCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Student_Id", System.Data.SqlDbType.VarChar, 0, "Student_Id"),
            new System.Data.SqlClient.SqlParameter("@Fld_String", System.Data.SqlDbType.VarChar, 0, "Fld_String"),
            new System.Data.SqlClient.SqlParameter("@Fld_Int", System.Data.SqlDbType.Int, 0, "Fld_Int"),
            new System.Data.SqlClient.SqlParameter("@Fld_Bool", System.Data.SqlDbType.Bit, 0, "Fld_Bool")});
            // 
            // sqlSelectCommand3
            // 
            this.sqlSelectCommand3.CommandText = "SELECT *\r\nFROM     SampTbl1\r\nWHERE  (Student_Id = @zkey1)";
            this.sqlSelectCommand3.Connection = this.sqlConnection1;
            this.sqlSelectCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@zkey1", System.Data.SqlDbType.VarChar, 20, "Student_Id")});
            // 
            // sqlUpdateCommand3
            // 
            this.sqlUpdateCommand3.CommandText = resources.GetString("sqlUpdateCommand3.CommandText");
            this.sqlUpdateCommand3.Connection = this.sqlConnection1;
            this.sqlUpdateCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Student_Id", System.Data.SqlDbType.VarChar, 0, "Student_Id"),
            new System.Data.SqlClient.SqlParameter("@Fld_String", System.Data.SqlDbType.VarChar, 0, "Fld_String"),
            new System.Data.SqlClient.SqlParameter("@Fld_Int", System.Data.SqlDbType.Int, 0, "Fld_Int"),
            new System.Data.SqlClient.SqlParameter("@Fld_Bool", System.Data.SqlDbType.Bit, 0, "Fld_Bool"),
            new System.Data.SqlClient.SqlParameter("@Original_Tbl1_row_Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Tbl1_row_Id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Student_Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Student_Id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Student_Id", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Student_Id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fld_String", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fld_String", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fld_String", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fld_String", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fld_Int", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fld_Int", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fld_Int", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fld_Int", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fld_Bool", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fld_Bool", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fld_Bool", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fld_Bool", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Tbl1_row_Id", System.Data.SqlDbType.Int, 4, "Tbl1_row_Id")});
            // 
            // adpDet1
            // 
            this.adpDet1.DeleteCommand = this.sqlDeleteCommand2;
            this.adpDet1.InsertCommand = this.sqlInsertCommand2;
            this.adpDet1.SelectCommand = this.sqlSelectCommand2;
            this.adpDet1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "axl_security", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("user_Id", "user_Id"),
                        new System.Data.Common.DataColumnMapping("Student_Id", "Student_Id"),
                        new System.Data.Common.DataColumnMapping("username", "username"),
                        new System.Data.Common.DataColumnMapping("salt", "salt"),
                        new System.Data.Common.DataColumnMapping("hash_code", "hash_code")})});
            this.adpDet1.UpdateCommand = this.sqlUpdateCommand2;
            // 
            // sqlDeleteCommand2
            // 
            this.sqlDeleteCommand2.CommandText = resources.GetString("sqlDeleteCommand2.CommandText");
            this.sqlDeleteCommand2.Connection = this.sqlConnection1;
            this.sqlDeleteCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_user_Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "user_Id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Student_Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Student_Id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Student_Id", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Student_Id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_username", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "username", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_username", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "username", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlInsertCommand2
            // 
            this.sqlInsertCommand2.CommandText = resources.GetString("sqlInsertCommand2.CommandText");
            this.sqlInsertCommand2.Connection = this.sqlConnection1;
            this.sqlInsertCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Student_Id", System.Data.SqlDbType.VarChar, 0, "Student_Id"),
            new System.Data.SqlClient.SqlParameter("@username", System.Data.SqlDbType.VarChar, 0, "username"),
            new System.Data.SqlClient.SqlParameter("@salt", System.Data.SqlDbType.VarChar, 0, "salt"),
            new System.Data.SqlClient.SqlParameter("@hash_code", System.Data.SqlDbType.NVarChar, 0, "hash_code")});
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = "SELECT *\r\nFROM     axl_security\r\nWHERE  (Student_Id = @zkey1)";
            this.sqlSelectCommand2.Connection = this.sqlConnection1;
            this.sqlSelectCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@zkey1", System.Data.SqlDbType.VarChar, 20, "Student_Id")});
            // 
            // sqlUpdateCommand2
            // 
            this.sqlUpdateCommand2.CommandText = resources.GetString("sqlUpdateCommand2.CommandText");
            this.sqlUpdateCommand2.Connection = this.sqlConnection1;
            this.sqlUpdateCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Student_Id", System.Data.SqlDbType.VarChar, 0, "Student_Id"),
            new System.Data.SqlClient.SqlParameter("@username", System.Data.SqlDbType.VarChar, 0, "username"),
            new System.Data.SqlClient.SqlParameter("@salt", System.Data.SqlDbType.VarChar, 0, "salt"),
            new System.Data.SqlClient.SqlParameter("@hash_code", System.Data.SqlDbType.NVarChar, 0, "hash_code"),
            new System.Data.SqlClient.SqlParameter("@Original_user_Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "user_Id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Student_Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Student_Id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Student_Id", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Student_Id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_username", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "username", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_username", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "username", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@user_Id", System.Data.SqlDbType.Int, 4, "user_Id")});
            // 
            // adpDet10
            // 
            this.adpDet10.DeleteCommand = this.sqlDeleteCommand11;
            this.adpDet10.InsertCommand = this.sqlInsertCommand11;
            this.adpDet10.SelectCommand = this.sqlSelectCommand11;
            this.adpDet10.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "SampTbl9", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Tbl9_row_Id", "Tbl9_row_Id"),
                        new System.Data.Common.DataColumnMapping("Student_Id", "Student_Id"),
                        new System.Data.Common.DataColumnMapping("Fld_String", "Fld_String"),
                        new System.Data.Common.DataColumnMapping("Fld_Int", "Fld_Int"),
                        new System.Data.Common.DataColumnMapping("Fld_Bool", "Fld_Bool")})});
            this.adpDet10.UpdateCommand = this.sqlUpdateCommand11;
            // 
            // sqlDeleteCommand11
            // 
            this.sqlDeleteCommand11.CommandText = resources.GetString("sqlDeleteCommand11.CommandText");
            this.sqlDeleteCommand11.Connection = this.sqlConnection1;
            this.sqlDeleteCommand11.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_Tbl9_row_Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Tbl9_row_Id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Student_Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Student_Id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Student_Id", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Student_Id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fld_String", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fld_String", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fld_String", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fld_String", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fld_Int", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fld_Int", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fld_Int", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fld_Int", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fld_Bool", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fld_Bool", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fld_Bool", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fld_Bool", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlInsertCommand11
            // 
            this.sqlInsertCommand11.CommandText = resources.GetString("sqlInsertCommand11.CommandText");
            this.sqlInsertCommand11.Connection = this.sqlConnection1;
            this.sqlInsertCommand11.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Student_Id", System.Data.SqlDbType.VarChar, 0, "Student_Id"),
            new System.Data.SqlClient.SqlParameter("@Fld_String", System.Data.SqlDbType.VarChar, 0, "Fld_String"),
            new System.Data.SqlClient.SqlParameter("@Fld_Int", System.Data.SqlDbType.Int, 0, "Fld_Int"),
            new System.Data.SqlClient.SqlParameter("@Fld_Bool", System.Data.SqlDbType.Bit, 0, "Fld_Bool")});
            // 
            // sqlSelectCommand11
            // 
            this.sqlSelectCommand11.CommandText = "SELECT *\r\nFROM     SampTbl9\r\nWHERE  (Student_Id = @zkey1)";
            this.sqlSelectCommand11.Connection = this.sqlConnection1;
            this.sqlSelectCommand11.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@zkey1", System.Data.SqlDbType.VarChar, 20, "Student_Id")});
            // 
            // sqlUpdateCommand11
            // 
            this.sqlUpdateCommand11.CommandText = resources.GetString("sqlUpdateCommand11.CommandText");
            this.sqlUpdateCommand11.Connection = this.sqlConnection1;
            this.sqlUpdateCommand11.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Student_Id", System.Data.SqlDbType.VarChar, 0, "Student_Id"),
            new System.Data.SqlClient.SqlParameter("@Fld_String", System.Data.SqlDbType.VarChar, 0, "Fld_String"),
            new System.Data.SqlClient.SqlParameter("@Fld_Int", System.Data.SqlDbType.Int, 0, "Fld_Int"),
            new System.Data.SqlClient.SqlParameter("@Fld_Bool", System.Data.SqlDbType.Bit, 0, "Fld_Bool"),
            new System.Data.SqlClient.SqlParameter("@Original_Tbl9_row_Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Tbl9_row_Id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Student_Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Student_Id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Student_Id", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Student_Id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fld_String", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fld_String", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fld_String", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fld_String", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fld_Int", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fld_Int", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fld_Int", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fld_Int", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fld_Bool", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fld_Bool", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fld_Bool", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fld_Bool", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Tbl9_row_Id", System.Data.SqlDbType.Int, 4, "Tbl9_row_Id")});
            // 
            // adpDet11
            // 
            this.adpDet11.DeleteCommand = this.sqlDeleteCommand12;
            this.adpDet11.InsertCommand = this.sqlInsertCommand12;
            this.adpDet11.SelectCommand = this.sqlSelectCommand12;
            this.adpDet11.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "SampTbl10", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Tbl10_row_Id", "Tbl10_row_Id"),
                        new System.Data.Common.DataColumnMapping("Student_Id", "Student_Id"),
                        new System.Data.Common.DataColumnMapping("Fld_String", "Fld_String"),
                        new System.Data.Common.DataColumnMapping("Fld_Int", "Fld_Int"),
                        new System.Data.Common.DataColumnMapping("Fld_Bool", "Fld_Bool")})});
            this.adpDet11.UpdateCommand = this.sqlUpdateCommand12;
            // 
            // sqlDeleteCommand12
            // 
            this.sqlDeleteCommand12.CommandText = resources.GetString("sqlDeleteCommand12.CommandText");
            this.sqlDeleteCommand12.Connection = this.sqlConnection1;
            this.sqlDeleteCommand12.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_Tbl10_row_Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Tbl10_row_Id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Student_Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Student_Id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Student_Id", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Student_Id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fld_String", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fld_String", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fld_String", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fld_String", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fld_Int", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fld_Int", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fld_Int", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fld_Int", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fld_Bool", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fld_Bool", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fld_Bool", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fld_Bool", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlInsertCommand12
            // 
            this.sqlInsertCommand12.CommandText = resources.GetString("sqlInsertCommand12.CommandText");
            this.sqlInsertCommand12.Connection = this.sqlConnection1;
            this.sqlInsertCommand12.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Student_Id", System.Data.SqlDbType.VarChar, 0, "Student_Id"),
            new System.Data.SqlClient.SqlParameter("@Fld_String", System.Data.SqlDbType.VarChar, 0, "Fld_String"),
            new System.Data.SqlClient.SqlParameter("@Fld_Int", System.Data.SqlDbType.Int, 0, "Fld_Int"),
            new System.Data.SqlClient.SqlParameter("@Fld_Bool", System.Data.SqlDbType.Bit, 0, "Fld_Bool")});
            // 
            // sqlSelectCommand12
            // 
            this.sqlSelectCommand12.CommandText = "SELECT *\r\nFROM     SampTbl10\r\nWHERE  (Student_Id = @zkey1)";
            this.sqlSelectCommand12.Connection = this.sqlConnection1;
            this.sqlSelectCommand12.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@zkey1", System.Data.SqlDbType.VarChar, 20, "Student_Id")});
            // 
            // sqlUpdateCommand12
            // 
            this.sqlUpdateCommand12.CommandText = resources.GetString("sqlUpdateCommand12.CommandText");
            this.sqlUpdateCommand12.Connection = this.sqlConnection1;
            this.sqlUpdateCommand12.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Student_Id", System.Data.SqlDbType.VarChar, 0, "Student_Id"),
            new System.Data.SqlClient.SqlParameter("@Fld_String", System.Data.SqlDbType.VarChar, 0, "Fld_String"),
            new System.Data.SqlClient.SqlParameter("@Fld_Int", System.Data.SqlDbType.Int, 0, "Fld_Int"),
            new System.Data.SqlClient.SqlParameter("@Fld_Bool", System.Data.SqlDbType.Bit, 0, "Fld_Bool"),
            new System.Data.SqlClient.SqlParameter("@Original_Tbl10_row_Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Tbl10_row_Id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Student_Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Student_Id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Student_Id", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Student_Id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fld_String", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fld_String", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fld_String", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fld_String", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fld_Int", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fld_Int", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fld_Int", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fld_Int", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fld_Bool", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fld_Bool", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fld_Bool", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fld_Bool", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Tbl10_row_Id", System.Data.SqlDbType.Int, 4, "Tbl10_row_Id")});
            // 
            // adpDet12
            // 
            this.adpDet12.DeleteCommand = this.sqlDeleteCommand13;
            this.adpDet12.InsertCommand = this.sqlInsertCommand13;
            this.adpDet12.SelectCommand = this.sqlSelectCommand13;
            this.adpDet12.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "SampTbl11", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Tbl11_row_Id", "Tbl11_row_Id"),
                        new System.Data.Common.DataColumnMapping("Student_Id", "Student_Id"),
                        new System.Data.Common.DataColumnMapping("Fld_String", "Fld_String"),
                        new System.Data.Common.DataColumnMapping("Fld_Int", "Fld_Int"),
                        new System.Data.Common.DataColumnMapping("Fld_Bool", "Fld_Bool")})});
            this.adpDet12.UpdateCommand = this.sqlUpdateCommand13;
            // 
            // sqlDeleteCommand13
            // 
            this.sqlDeleteCommand13.CommandText = resources.GetString("sqlDeleteCommand13.CommandText");
            this.sqlDeleteCommand13.Connection = this.sqlConnection1;
            this.sqlDeleteCommand13.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_Tbl11_row_Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Tbl11_row_Id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Student_Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Student_Id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Student_Id", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Student_Id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fld_String", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fld_String", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fld_String", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fld_String", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fld_Int", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fld_Int", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fld_Int", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fld_Int", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fld_Bool", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fld_Bool", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fld_Bool", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fld_Bool", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlInsertCommand13
            // 
            this.sqlInsertCommand13.CommandText = resources.GetString("sqlInsertCommand13.CommandText");
            this.sqlInsertCommand13.Connection = this.sqlConnection1;
            this.sqlInsertCommand13.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Student_Id", System.Data.SqlDbType.VarChar, 0, "Student_Id"),
            new System.Data.SqlClient.SqlParameter("@Fld_String", System.Data.SqlDbType.VarChar, 0, "Fld_String"),
            new System.Data.SqlClient.SqlParameter("@Fld_Int", System.Data.SqlDbType.Int, 0, "Fld_Int"),
            new System.Data.SqlClient.SqlParameter("@Fld_Bool", System.Data.SqlDbType.Bit, 0, "Fld_Bool")});
            // 
            // sqlSelectCommand13
            // 
            this.sqlSelectCommand13.CommandText = "SELECT *\r\nFROM     SampTbl11\r\nWHERE  (Student_Id = @zkey1)";
            this.sqlSelectCommand13.Connection = this.sqlConnection1;
            this.sqlSelectCommand13.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@zkey1", System.Data.SqlDbType.VarChar, 20, "Student_Id")});
            // 
            // sqlUpdateCommand13
            // 
            this.sqlUpdateCommand13.CommandText = resources.GetString("sqlUpdateCommand13.CommandText");
            this.sqlUpdateCommand13.Connection = this.sqlConnection1;
            this.sqlUpdateCommand13.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Student_Id", System.Data.SqlDbType.VarChar, 0, "Student_Id"),
            new System.Data.SqlClient.SqlParameter("@Fld_String", System.Data.SqlDbType.VarChar, 0, "Fld_String"),
            new System.Data.SqlClient.SqlParameter("@Fld_Int", System.Data.SqlDbType.Int, 0, "Fld_Int"),
            new System.Data.SqlClient.SqlParameter("@Fld_Bool", System.Data.SqlDbType.Bit, 0, "Fld_Bool"),
            new System.Data.SqlClient.SqlParameter("@Original_Tbl11_row_Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Tbl11_row_Id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Student_Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Student_Id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Student_Id", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Student_Id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fld_String", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fld_String", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fld_String", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fld_String", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fld_Int", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fld_Int", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fld_Int", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fld_Int", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fld_Bool", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fld_Bool", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fld_Bool", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fld_Bool", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Tbl11_row_Id", System.Data.SqlDbType.Int, 4, "Tbl11_row_Id")});
            // 
            // adpDet3
            // 
            this.adpDet3.DeleteCommand = this.sqlDeleteCommand4;
            this.adpDet3.InsertCommand = this.sqlInsertCommand4;
            this.adpDet3.SelectCommand = this.sqlSelectCommand4;
            this.adpDet3.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "SampTbl2", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Tbl2_row_Id", "Tbl2_row_Id"),
                        new System.Data.Common.DataColumnMapping("Student_Id", "Student_Id"),
                        new System.Data.Common.DataColumnMapping("Fld_String", "Fld_String"),
                        new System.Data.Common.DataColumnMapping("Fld_Int", "Fld_Int"),
                        new System.Data.Common.DataColumnMapping("Fld_Bool", "Fld_Bool")})});
            this.adpDet3.UpdateCommand = this.sqlUpdateCommand4;
            // 
            // sqlDeleteCommand4
            // 
            this.sqlDeleteCommand4.CommandText = resources.GetString("sqlDeleteCommand4.CommandText");
            this.sqlDeleteCommand4.Connection = this.sqlConnection1;
            this.sqlDeleteCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_Tbl2_row_Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Tbl2_row_Id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Student_Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Student_Id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Student_Id", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Student_Id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fld_String", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fld_String", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fld_String", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fld_String", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fld_Int", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fld_Int", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fld_Int", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fld_Int", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fld_Bool", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fld_Bool", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fld_Bool", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fld_Bool", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlInsertCommand4
            // 
            this.sqlInsertCommand4.CommandText = resources.GetString("sqlInsertCommand4.CommandText");
            this.sqlInsertCommand4.Connection = this.sqlConnection1;
            this.sqlInsertCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Student_Id", System.Data.SqlDbType.VarChar, 0, "Student_Id"),
            new System.Data.SqlClient.SqlParameter("@Fld_String", System.Data.SqlDbType.VarChar, 0, "Fld_String"),
            new System.Data.SqlClient.SqlParameter("@Fld_Int", System.Data.SqlDbType.Int, 0, "Fld_Int"),
            new System.Data.SqlClient.SqlParameter("@Fld_Bool", System.Data.SqlDbType.Bit, 0, "Fld_Bool")});
            // 
            // sqlSelectCommand4
            // 
            this.sqlSelectCommand4.CommandText = "SELECT *\r\nFROM     SampTbl2\r\nWHERE  (Student_Id = @zkey1)";
            this.sqlSelectCommand4.Connection = this.sqlConnection1;
            this.sqlSelectCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@zkey1", System.Data.SqlDbType.VarChar, 20, "Student_Id")});
            // 
            // sqlUpdateCommand4
            // 
            this.sqlUpdateCommand4.CommandText = resources.GetString("sqlUpdateCommand4.CommandText");
            this.sqlUpdateCommand4.Connection = this.sqlConnection1;
            this.sqlUpdateCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Student_Id", System.Data.SqlDbType.VarChar, 0, "Student_Id"),
            new System.Data.SqlClient.SqlParameter("@Fld_String", System.Data.SqlDbType.VarChar, 0, "Fld_String"),
            new System.Data.SqlClient.SqlParameter("@Fld_Int", System.Data.SqlDbType.Int, 0, "Fld_Int"),
            new System.Data.SqlClient.SqlParameter("@Fld_Bool", System.Data.SqlDbType.Bit, 0, "Fld_Bool"),
            new System.Data.SqlClient.SqlParameter("@Original_Tbl2_row_Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Tbl2_row_Id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Student_Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Student_Id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Student_Id", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Student_Id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fld_String", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fld_String", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fld_String", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fld_String", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fld_Int", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fld_Int", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fld_Int", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fld_Int", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fld_Bool", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fld_Bool", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fld_Bool", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fld_Bool", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Tbl2_row_Id", System.Data.SqlDbType.Int, 4, "Tbl2_row_Id")});
            // 
            // adpDet4
            // 
            this.adpDet4.DeleteCommand = this.sqlDeleteCommand5;
            this.adpDet4.InsertCommand = this.sqlInsertCommand5;
            this.adpDet4.SelectCommand = this.sqlSelectCommand5;
            this.adpDet4.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "SampTbl3", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Tbl3_row_Id", "Tbl3_row_Id"),
                        new System.Data.Common.DataColumnMapping("Student_Id", "Student_Id"),
                        new System.Data.Common.DataColumnMapping("Fld_String", "Fld_String"),
                        new System.Data.Common.DataColumnMapping("Fld_Int", "Fld_Int"),
                        new System.Data.Common.DataColumnMapping("Fld_Bool", "Fld_Bool")})});
            this.adpDet4.UpdateCommand = this.sqlUpdateCommand5;
            // 
            // sqlDeleteCommand5
            // 
            this.sqlDeleteCommand5.CommandText = resources.GetString("sqlDeleteCommand5.CommandText");
            this.sqlDeleteCommand5.Connection = this.sqlConnection1;
            this.sqlDeleteCommand5.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_Tbl3_row_Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Tbl3_row_Id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Student_Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Student_Id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Student_Id", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Student_Id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fld_String", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fld_String", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fld_String", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fld_String", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fld_Int", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fld_Int", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fld_Int", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fld_Int", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fld_Bool", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fld_Bool", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fld_Bool", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fld_Bool", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlInsertCommand5
            // 
            this.sqlInsertCommand5.CommandText = resources.GetString("sqlInsertCommand5.CommandText");
            this.sqlInsertCommand5.Connection = this.sqlConnection1;
            this.sqlInsertCommand5.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Student_Id", System.Data.SqlDbType.VarChar, 0, "Student_Id"),
            new System.Data.SqlClient.SqlParameter("@Fld_String", System.Data.SqlDbType.VarChar, 0, "Fld_String"),
            new System.Data.SqlClient.SqlParameter("@Fld_Int", System.Data.SqlDbType.Int, 0, "Fld_Int"),
            new System.Data.SqlClient.SqlParameter("@Fld_Bool", System.Data.SqlDbType.Bit, 0, "Fld_Bool")});
            // 
            // sqlSelectCommand5
            // 
            this.sqlSelectCommand5.CommandText = "SELECT *\r\nFROM     SampTbl3\r\nWHERE  (Student_Id = @zkey1)";
            this.sqlSelectCommand5.Connection = this.sqlConnection1;
            this.sqlSelectCommand5.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@zkey1", System.Data.SqlDbType.VarChar, 20, "Student_Id")});
            // 
            // sqlUpdateCommand5
            // 
            this.sqlUpdateCommand5.CommandText = resources.GetString("sqlUpdateCommand5.CommandText");
            this.sqlUpdateCommand5.Connection = this.sqlConnection1;
            this.sqlUpdateCommand5.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Student_Id", System.Data.SqlDbType.VarChar, 0, "Student_Id"),
            new System.Data.SqlClient.SqlParameter("@Fld_String", System.Data.SqlDbType.VarChar, 0, "Fld_String"),
            new System.Data.SqlClient.SqlParameter("@Fld_Int", System.Data.SqlDbType.Int, 0, "Fld_Int"),
            new System.Data.SqlClient.SqlParameter("@Fld_Bool", System.Data.SqlDbType.Bit, 0, "Fld_Bool"),
            new System.Data.SqlClient.SqlParameter("@Original_Tbl3_row_Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Tbl3_row_Id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Student_Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Student_Id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Student_Id", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Student_Id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fld_String", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fld_String", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fld_String", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fld_String", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fld_Int", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fld_Int", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fld_Int", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fld_Int", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fld_Bool", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fld_Bool", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fld_Bool", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fld_Bool", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Tbl3_row_Id", System.Data.SqlDbType.Int, 4, "Tbl3_row_Id")});
            // 
            // adpDet5
            // 
            this.adpDet5.DeleteCommand = this.sqlDeleteCommand6;
            this.adpDet5.InsertCommand = this.sqlInsertCommand6;
            this.adpDet5.SelectCommand = this.sqlSelectCommand6;
            this.adpDet5.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "SampTbl4", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Tbl4_row_Id", "Tbl4_row_Id"),
                        new System.Data.Common.DataColumnMapping("Student_Id", "Student_Id"),
                        new System.Data.Common.DataColumnMapping("Fld_String", "Fld_String"),
                        new System.Data.Common.DataColumnMapping("Fld_Int", "Fld_Int"),
                        new System.Data.Common.DataColumnMapping("Fld_Bool", "Fld_Bool")})});
            this.adpDet5.UpdateCommand = this.sqlUpdateCommand6;
            // 
            // sqlDeleteCommand6
            // 
            this.sqlDeleteCommand6.CommandText = resources.GetString("sqlDeleteCommand6.CommandText");
            this.sqlDeleteCommand6.Connection = this.sqlConnection1;
            this.sqlDeleteCommand6.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_Tbl4_row_Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Tbl4_row_Id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Student_Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Student_Id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Student_Id", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Student_Id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fld_String", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fld_String", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fld_String", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fld_String", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fld_Int", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fld_Int", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fld_Int", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fld_Int", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fld_Bool", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fld_Bool", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fld_Bool", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fld_Bool", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlInsertCommand6
            // 
            this.sqlInsertCommand6.CommandText = resources.GetString("sqlInsertCommand6.CommandText");
            this.sqlInsertCommand6.Connection = this.sqlConnection1;
            this.sqlInsertCommand6.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Student_Id", System.Data.SqlDbType.VarChar, 0, "Student_Id"),
            new System.Data.SqlClient.SqlParameter("@Fld_String", System.Data.SqlDbType.VarChar, 0, "Fld_String"),
            new System.Data.SqlClient.SqlParameter("@Fld_Int", System.Data.SqlDbType.Int, 0, "Fld_Int"),
            new System.Data.SqlClient.SqlParameter("@Fld_Bool", System.Data.SqlDbType.Bit, 0, "Fld_Bool")});
            // 
            // sqlSelectCommand6
            // 
            this.sqlSelectCommand6.CommandText = "SELECT *\r\nFROM     SampTbl4\r\nWHERE  (Student_Id = @zkey1)";
            this.sqlSelectCommand6.Connection = this.sqlConnection1;
            this.sqlSelectCommand6.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@zkey1", System.Data.SqlDbType.VarChar, 20, "Student_Id")});
            // 
            // sqlUpdateCommand6
            // 
            this.sqlUpdateCommand6.CommandText = resources.GetString("sqlUpdateCommand6.CommandText");
            this.sqlUpdateCommand6.Connection = this.sqlConnection1;
            this.sqlUpdateCommand6.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Student_Id", System.Data.SqlDbType.VarChar, 0, "Student_Id"),
            new System.Data.SqlClient.SqlParameter("@Fld_String", System.Data.SqlDbType.VarChar, 0, "Fld_String"),
            new System.Data.SqlClient.SqlParameter("@Fld_Int", System.Data.SqlDbType.Int, 0, "Fld_Int"),
            new System.Data.SqlClient.SqlParameter("@Fld_Bool", System.Data.SqlDbType.Bit, 0, "Fld_Bool"),
            new System.Data.SqlClient.SqlParameter("@Original_Tbl4_row_Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Tbl4_row_Id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Student_Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Student_Id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Student_Id", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Student_Id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fld_String", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fld_String", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fld_String", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fld_String", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fld_Int", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fld_Int", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fld_Int", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fld_Int", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fld_Bool", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fld_Bool", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fld_Bool", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fld_Bool", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Tbl4_row_Id", System.Data.SqlDbType.Int, 4, "Tbl4_row_Id")});
            // 
            // adpDet6
            // 
            this.adpDet6.DeleteCommand = this.sqlDeleteCommand7;
            this.adpDet6.InsertCommand = this.sqlInsertCommand7;
            this.adpDet6.SelectCommand = this.sqlSelectCommand7;
            this.adpDet6.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "SampTbl5", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Tbl5_row_Id", "Tbl5_row_Id"),
                        new System.Data.Common.DataColumnMapping("Student_Id", "Student_Id"),
                        new System.Data.Common.DataColumnMapping("Fld_String", "Fld_String"),
                        new System.Data.Common.DataColumnMapping("Fld_Int", "Fld_Int"),
                        new System.Data.Common.DataColumnMapping("Fld_Bool", "Fld_Bool")})});
            this.adpDet6.UpdateCommand = this.sqlUpdateCommand7;
            // 
            // sqlDeleteCommand7
            // 
            this.sqlDeleteCommand7.CommandText = resources.GetString("sqlDeleteCommand7.CommandText");
            this.sqlDeleteCommand7.Connection = this.sqlConnection1;
            this.sqlDeleteCommand7.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_Tbl5_row_Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Tbl5_row_Id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Student_Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Student_Id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Student_Id", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Student_Id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fld_String", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fld_String", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fld_String", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fld_String", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fld_Int", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fld_Int", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fld_Int", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fld_Int", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fld_Bool", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fld_Bool", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fld_Bool", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fld_Bool", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlInsertCommand7
            // 
            this.sqlInsertCommand7.CommandText = resources.GetString("sqlInsertCommand7.CommandText");
            this.sqlInsertCommand7.Connection = this.sqlConnection1;
            this.sqlInsertCommand7.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Student_Id", System.Data.SqlDbType.VarChar, 0, "Student_Id"),
            new System.Data.SqlClient.SqlParameter("@Fld_String", System.Data.SqlDbType.VarChar, 0, "Fld_String"),
            new System.Data.SqlClient.SqlParameter("@Fld_Int", System.Data.SqlDbType.Int, 0, "Fld_Int"),
            new System.Data.SqlClient.SqlParameter("@Fld_Bool", System.Data.SqlDbType.Bit, 0, "Fld_Bool")});
            // 
            // sqlSelectCommand7
            // 
            this.sqlSelectCommand7.CommandText = "SELECT *\r\nFROM     SampTbl5\r\nWHERE  (Student_Id = @zkey1)";
            this.sqlSelectCommand7.Connection = this.sqlConnection1;
            this.sqlSelectCommand7.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@zkey1", System.Data.SqlDbType.VarChar, 20, "Student_Id")});
            // 
            // sqlUpdateCommand7
            // 
            this.sqlUpdateCommand7.CommandText = resources.GetString("sqlUpdateCommand7.CommandText");
            this.sqlUpdateCommand7.Connection = this.sqlConnection1;
            this.sqlUpdateCommand7.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Student_Id", System.Data.SqlDbType.VarChar, 0, "Student_Id"),
            new System.Data.SqlClient.SqlParameter("@Fld_String", System.Data.SqlDbType.VarChar, 0, "Fld_String"),
            new System.Data.SqlClient.SqlParameter("@Fld_Int", System.Data.SqlDbType.Int, 0, "Fld_Int"),
            new System.Data.SqlClient.SqlParameter("@Fld_Bool", System.Data.SqlDbType.Bit, 0, "Fld_Bool"),
            new System.Data.SqlClient.SqlParameter("@Original_Tbl5_row_Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Tbl5_row_Id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Student_Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Student_Id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Student_Id", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Student_Id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fld_String", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fld_String", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fld_String", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fld_String", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fld_Int", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fld_Int", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fld_Int", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fld_Int", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fld_Bool", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fld_Bool", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fld_Bool", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fld_Bool", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Tbl5_row_Id", System.Data.SqlDbType.Int, 4, "Tbl5_row_Id")});
            // 
            // adpDet7
            // 
            this.adpDet7.DeleteCommand = this.sqlDeleteCommand8;
            this.adpDet7.InsertCommand = this.sqlInsertCommand8;
            this.adpDet7.SelectCommand = this.sqlSelectCommand8;
            this.adpDet7.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "SampTbl6", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Tbl6_row_Id", "Tbl6_row_Id"),
                        new System.Data.Common.DataColumnMapping("Student_Id", "Student_Id"),
                        new System.Data.Common.DataColumnMapping("Fld_String", "Fld_String"),
                        new System.Data.Common.DataColumnMapping("Fld_Int", "Fld_Int"),
                        new System.Data.Common.DataColumnMapping("Fld_Bool", "Fld_Bool")})});
            this.adpDet7.UpdateCommand = this.sqlUpdateCommand8;
            // 
            // sqlDeleteCommand8
            // 
            this.sqlDeleteCommand8.CommandText = resources.GetString("sqlDeleteCommand8.CommandText");
            this.sqlDeleteCommand8.Connection = this.sqlConnection1;
            this.sqlDeleteCommand8.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_Tbl6_row_Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Tbl6_row_Id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Student_Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Student_Id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Student_Id", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Student_Id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fld_String", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fld_String", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fld_String", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fld_String", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fld_Int", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fld_Int", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fld_Int", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fld_Int", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fld_Bool", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fld_Bool", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fld_Bool", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fld_Bool", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlInsertCommand8
            // 
            this.sqlInsertCommand8.CommandText = resources.GetString("sqlInsertCommand8.CommandText");
            this.sqlInsertCommand8.Connection = this.sqlConnection1;
            this.sqlInsertCommand8.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Student_Id", System.Data.SqlDbType.VarChar, 0, "Student_Id"),
            new System.Data.SqlClient.SqlParameter("@Fld_String", System.Data.SqlDbType.VarChar, 0, "Fld_String"),
            new System.Data.SqlClient.SqlParameter("@Fld_Int", System.Data.SqlDbType.Int, 0, "Fld_Int"),
            new System.Data.SqlClient.SqlParameter("@Fld_Bool", System.Data.SqlDbType.Bit, 0, "Fld_Bool")});
            // 
            // sqlSelectCommand8
            // 
            this.sqlSelectCommand8.CommandText = "SELECT *\r\nFROM     SampTbl6\r\nWHERE  (Student_Id = @zkey1)";
            this.sqlSelectCommand8.Connection = this.sqlConnection1;
            this.sqlSelectCommand8.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@zkey1", System.Data.SqlDbType.VarChar, 20, "Student_Id")});
            // 
            // sqlUpdateCommand8
            // 
            this.sqlUpdateCommand8.CommandText = resources.GetString("sqlUpdateCommand8.CommandText");
            this.sqlUpdateCommand8.Connection = this.sqlConnection1;
            this.sqlUpdateCommand8.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Student_Id", System.Data.SqlDbType.VarChar, 0, "Student_Id"),
            new System.Data.SqlClient.SqlParameter("@Fld_String", System.Data.SqlDbType.VarChar, 0, "Fld_String"),
            new System.Data.SqlClient.SqlParameter("@Fld_Int", System.Data.SqlDbType.Int, 0, "Fld_Int"),
            new System.Data.SqlClient.SqlParameter("@Fld_Bool", System.Data.SqlDbType.Bit, 0, "Fld_Bool"),
            new System.Data.SqlClient.SqlParameter("@Original_Tbl6_row_Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Tbl6_row_Id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Student_Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Student_Id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Student_Id", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Student_Id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fld_String", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fld_String", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fld_String", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fld_String", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fld_Int", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fld_Int", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fld_Int", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fld_Int", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fld_Bool", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fld_Bool", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fld_Bool", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fld_Bool", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Tbl6_row_Id", System.Data.SqlDbType.Int, 4, "Tbl6_row_Id")});
            // 
            // adpDet8
            // 
            this.adpDet8.DeleteCommand = this.sqlDeleteCommand9;
            this.adpDet8.InsertCommand = this.sqlInsertCommand9;
            this.adpDet8.SelectCommand = this.sqlSelectCommand9;
            this.adpDet8.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "SampTbl7", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Tbl7_row_Id", "Tbl7_row_Id"),
                        new System.Data.Common.DataColumnMapping("Student_Id", "Student_Id"),
                        new System.Data.Common.DataColumnMapping("Fld_String", "Fld_String"),
                        new System.Data.Common.DataColumnMapping("Fld_Int", "Fld_Int"),
                        new System.Data.Common.DataColumnMapping("Fld_Bool", "Fld_Bool")})});
            this.adpDet8.UpdateCommand = this.sqlUpdateCommand9;
            // 
            // sqlDeleteCommand9
            // 
            this.sqlDeleteCommand9.CommandText = resources.GetString("sqlDeleteCommand9.CommandText");
            this.sqlDeleteCommand9.Connection = this.sqlConnection1;
            this.sqlDeleteCommand9.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_Tbl7_row_Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Tbl7_row_Id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Student_Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Student_Id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Student_Id", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Student_Id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fld_String", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fld_String", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fld_String", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fld_String", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fld_Int", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fld_Int", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fld_Int", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fld_Int", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fld_Bool", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fld_Bool", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fld_Bool", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fld_Bool", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlInsertCommand9
            // 
            this.sqlInsertCommand9.CommandText = resources.GetString("sqlInsertCommand9.CommandText");
            this.sqlInsertCommand9.Connection = this.sqlConnection1;
            this.sqlInsertCommand9.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Student_Id", System.Data.SqlDbType.VarChar, 0, "Student_Id"),
            new System.Data.SqlClient.SqlParameter("@Fld_String", System.Data.SqlDbType.VarChar, 0, "Fld_String"),
            new System.Data.SqlClient.SqlParameter("@Fld_Int", System.Data.SqlDbType.Int, 0, "Fld_Int"),
            new System.Data.SqlClient.SqlParameter("@Fld_Bool", System.Data.SqlDbType.Bit, 0, "Fld_Bool")});
            // 
            // sqlSelectCommand9
            // 
            this.sqlSelectCommand9.CommandText = "SELECT *\r\nFROM     SampTbl7\r\nWHERE  (Student_Id = @zkey1)";
            this.sqlSelectCommand9.Connection = this.sqlConnection1;
            this.sqlSelectCommand9.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@zkey1", System.Data.SqlDbType.VarChar, 20, "Student_Id")});
            // 
            // sqlUpdateCommand9
            // 
            this.sqlUpdateCommand9.CommandText = resources.GetString("sqlUpdateCommand9.CommandText");
            this.sqlUpdateCommand9.Connection = this.sqlConnection1;
            this.sqlUpdateCommand9.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Student_Id", System.Data.SqlDbType.VarChar, 0, "Student_Id"),
            new System.Data.SqlClient.SqlParameter("@Fld_String", System.Data.SqlDbType.VarChar, 0, "Fld_String"),
            new System.Data.SqlClient.SqlParameter("@Fld_Int", System.Data.SqlDbType.Int, 0, "Fld_Int"),
            new System.Data.SqlClient.SqlParameter("@Fld_Bool", System.Data.SqlDbType.Bit, 0, "Fld_Bool"),
            new System.Data.SqlClient.SqlParameter("@Original_Tbl7_row_Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Tbl7_row_Id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Student_Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Student_Id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Student_Id", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Student_Id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fld_String", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fld_String", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fld_String", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fld_String", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fld_Int", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fld_Int", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fld_Int", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fld_Int", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fld_Bool", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fld_Bool", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fld_Bool", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fld_Bool", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Tbl7_row_Id", System.Data.SqlDbType.Int, 4, "Tbl7_row_Id")});
            // 
            // adpDet9
            // 
            this.adpDet9.DeleteCommand = this.sqlDeleteCommand10;
            this.adpDet9.InsertCommand = this.sqlInsertCommand10;
            this.adpDet9.SelectCommand = this.sqlSelectCommand10;
            this.adpDet9.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "SampTbl8", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Tbl8_row_Id", "Tbl8_row_Id"),
                        new System.Data.Common.DataColumnMapping("Student_Id", "Student_Id"),
                        new System.Data.Common.DataColumnMapping("Fld_String", "Fld_String"),
                        new System.Data.Common.DataColumnMapping("Fld_Int", "Fld_Int"),
                        new System.Data.Common.DataColumnMapping("Fld_Bool", "Fld_Bool")})});
            this.adpDet9.UpdateCommand = this.sqlUpdateCommand10;
            // 
            // sqlDeleteCommand10
            // 
            this.sqlDeleteCommand10.CommandText = resources.GetString("sqlDeleteCommand10.CommandText");
            this.sqlDeleteCommand10.Connection = this.sqlConnection1;
            this.sqlDeleteCommand10.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_Tbl8_row_Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Tbl8_row_Id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Student_Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Student_Id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Student_Id", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Student_Id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fld_String", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fld_String", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fld_String", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fld_String", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fld_Int", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fld_Int", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fld_Int", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fld_Int", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fld_Bool", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fld_Bool", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fld_Bool", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fld_Bool", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlInsertCommand10
            // 
            this.sqlInsertCommand10.CommandText = resources.GetString("sqlInsertCommand10.CommandText");
            this.sqlInsertCommand10.Connection = this.sqlConnection1;
            this.sqlInsertCommand10.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Student_Id", System.Data.SqlDbType.VarChar, 0, "Student_Id"),
            new System.Data.SqlClient.SqlParameter("@Fld_String", System.Data.SqlDbType.VarChar, 0, "Fld_String"),
            new System.Data.SqlClient.SqlParameter("@Fld_Int", System.Data.SqlDbType.Int, 0, "Fld_Int"),
            new System.Data.SqlClient.SqlParameter("@Fld_Bool", System.Data.SqlDbType.Bit, 0, "Fld_Bool")});
            // 
            // sqlSelectCommand10
            // 
            this.sqlSelectCommand10.CommandText = "SELECT *\r\nFROM     SampTbl8\r\nWHERE  (Student_Id = @zkey1)";
            this.sqlSelectCommand10.Connection = this.sqlConnection1;
            this.sqlSelectCommand10.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@zkey1", System.Data.SqlDbType.VarChar, 20, "Student_Id")});
            // 
            // sqlUpdateCommand10
            // 
            this.sqlUpdateCommand10.CommandText = resources.GetString("sqlUpdateCommand10.CommandText");
            this.sqlUpdateCommand10.Connection = this.sqlConnection1;
            this.sqlUpdateCommand10.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Student_Id", System.Data.SqlDbType.VarChar, 0, "Student_Id"),
            new System.Data.SqlClient.SqlParameter("@Fld_String", System.Data.SqlDbType.VarChar, 0, "Fld_String"),
            new System.Data.SqlClient.SqlParameter("@Fld_Int", System.Data.SqlDbType.Int, 0, "Fld_Int"),
            new System.Data.SqlClient.SqlParameter("@Fld_Bool", System.Data.SqlDbType.Bit, 0, "Fld_Bool"),
            new System.Data.SqlClient.SqlParameter("@Original_Tbl8_row_Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Tbl8_row_Id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Student_Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Student_Id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Student_Id", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Student_Id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fld_String", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fld_String", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fld_String", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fld_String", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fld_Int", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fld_Int", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fld_Int", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fld_Int", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fld_Bool", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fld_Bool", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fld_Bool", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fld_Bool", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Tbl8_row_Id", System.Data.SqlDbType.Int, 4, "Tbl8_row_Id")});
            // 
            // bsDet1
            // 
            this.bsDet1.DataMember = "axl_security";
            this.bsDet1.DataSource = this.dsTran;
            // 
            // bsDet10
            // 
            this.bsDet10.DataMember = "SampTbl9";
            this.bsDet10.DataSource = this.dsTran;
            // 
            // bsDet11
            // 
            this.bsDet11.DataMember = "SampTbl10";
            this.bsDet11.DataSource = this.dsTran;
            // 
            // bsDet12
            // 
            this.bsDet12.DataMember = "SampTbl11";
            this.bsDet12.DataSource = this.dsTran;
            // 
            // bsDet13
            // 
            this.bsDet13.DataMember = "SampTbl12";
            this.bsDet13.DataSource = this.dsTran;
            // 
            // bsDet2
            // 
            this.bsDet2.DataMember = "SampTbl1";
            this.bsDet2.DataSource = this.dsTran;
            // 
            // bsDet3
            // 
            this.bsDet3.DataMember = "SampTbl2";
            this.bsDet3.DataSource = this.dsTran;
            // 
            // bsDet4
            // 
            this.bsDet4.DataMember = "SampTbl3";
            this.bsDet4.DataSource = this.dsTran;
            // 
            // bsDet5
            // 
            this.bsDet5.DataMember = "SampTbl4";
            this.bsDet5.DataSource = this.dsTran;
            // 
            // bsDet6
            // 
            this.bsDet6.DataMember = "SampTbl5";
            this.bsDet6.DataSource = this.dsTran;
            // 
            // bsDet7
            // 
            this.bsDet7.DataMember = "SampTbl6";
            this.bsDet7.DataSource = this.dsTran;
            // 
            // bsDet8
            // 
            this.bsDet8.DataMember = "SampTbl7";
            this.bsDet8.DataSource = this.dsTran;
            // 
            // bsDet9
            // 
            this.bsDet9.DataMember = "SampTbl8";
            this.bsDet9.DataSource = this.dsTran;
            // 
            // bsHdr
            // 
            this.bsHdr.DataMember = "StudentPersonalInfo";
            this.bsHdr.DataSource = this.dsTran;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.DataMember = "axl_security";
            this.errorProvider1.DataSource = this.dsTran;
            // 
            // sqlSelectCommand14
            // 
            this.sqlSelectCommand14.CommandText = "SELECT *\r\nFROM     SampTbl12\r\nWHERE  (Student_Id = @zkey1)";
            this.sqlSelectCommand14.Connection = this.sqlConnection1;
            this.sqlSelectCommand14.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@zkey1", System.Data.SqlDbType.VarChar, 20, "Student_Id")});
            // 
            // sqlInsertCommand14
            // 
            this.sqlInsertCommand14.CommandText = resources.GetString("sqlInsertCommand14.CommandText");
            this.sqlInsertCommand14.Connection = this.sqlConnection1;
            this.sqlInsertCommand14.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Student_Id", System.Data.SqlDbType.VarChar, 0, "Student_Id"),
            new System.Data.SqlClient.SqlParameter("@Fld_String", System.Data.SqlDbType.VarChar, 0, "Fld_String"),
            new System.Data.SqlClient.SqlParameter("@Fld_Int", System.Data.SqlDbType.Int, 0, "Fld_Int"),
            new System.Data.SqlClient.SqlParameter("@Fld_Bool", System.Data.SqlDbType.Bit, 0, "Fld_Bool")});
            // 
            // sqlUpdateCommand14
            // 
            this.sqlUpdateCommand14.CommandText = resources.GetString("sqlUpdateCommand14.CommandText");
            this.sqlUpdateCommand14.Connection = this.sqlConnection1;
            this.sqlUpdateCommand14.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Student_Id", System.Data.SqlDbType.VarChar, 0, "Student_Id"),
            new System.Data.SqlClient.SqlParameter("@Fld_String", System.Data.SqlDbType.VarChar, 0, "Fld_String"),
            new System.Data.SqlClient.SqlParameter("@Fld_Int", System.Data.SqlDbType.Int, 0, "Fld_Int"),
            new System.Data.SqlClient.SqlParameter("@Fld_Bool", System.Data.SqlDbType.Bit, 0, "Fld_Bool"),
            new System.Data.SqlClient.SqlParameter("@Original_Tbl12_row_Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Tbl12_row_Id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Student_Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Student_Id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Student_Id", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Student_Id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fld_String", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fld_String", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fld_String", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fld_String", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fld_Int", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fld_Int", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fld_Int", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fld_Int", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fld_Bool", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fld_Bool", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fld_Bool", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fld_Bool", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Tbl12_row_Id", System.Data.SqlDbType.Int, 4, "Tbl12_row_Id")});
            // 
            // sqlDeleteCommand14
            // 
            this.sqlDeleteCommand14.CommandText = resources.GetString("sqlDeleteCommand14.CommandText");
            this.sqlDeleteCommand14.Connection = this.sqlConnection1;
            this.sqlDeleteCommand14.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_Tbl12_row_Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Tbl12_row_Id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Student_Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Student_Id", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Student_Id", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Student_Id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fld_String", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fld_String", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fld_String", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fld_String", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fld_Int", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fld_Int", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fld_Int", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fld_Int", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Fld_Bool", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fld_Bool", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Fld_Bool", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fld_Bool", System.Data.DataRowVersion.Original, null)});
            // 
            // adpDet13
            // 
            this.adpDet13.DeleteCommand = this.sqlDeleteCommand14;
            this.adpDet13.InsertCommand = this.sqlInsertCommand14;
            this.adpDet13.SelectCommand = this.sqlSelectCommand14;
            this.adpDet13.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "SampTbl12", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Tbl12_row_Id", "Tbl12_row_Id"),
                        new System.Data.Common.DataColumnMapping("Student_Id", "Student_Id"),
                        new System.Data.Common.DataColumnMapping("Fld_String", "Fld_String"),
                        new System.Data.Common.DataColumnMapping("Fld_Int", "Fld_Int"),
                        new System.Data.Common.DataColumnMapping("Fld_Bool", "Fld_Bool")})});
            this.adpDet13.UpdateCommand = this.sqlUpdateCommand14;
            // 
            // sqlSelectCommand15
            // 
            this.sqlSelectCommand15.CommandText = "SELECT *\r\nFROM     StudentGrade\r\nWHERE  (Student_Id = @zkey1)";
            this.sqlSelectCommand15.Connection = this.sqlConnection1;
            this.sqlSelectCommand15.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@zkey1", System.Data.SqlDbType.Int, 4, "Student_Id")});
            // 
            // sqlInsertCommand15
            // 
            this.sqlInsertCommand15.CommandText = resources.GetString("sqlInsertCommand15.CommandText");
            this.sqlInsertCommand15.Connection = this.sqlConnection1;
            this.sqlInsertCommand15.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@subject_Id", System.Data.SqlDbType.Int, 0, "subject_Id"),
            new System.Data.SqlClient.SqlParameter("@Student_Id", System.Data.SqlDbType.Int, 0, "Student_Id"),
            new System.Data.SqlClient.SqlParameter("@Grd1", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(0)), "Grd1", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Grd2", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(0)), "Grd2", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Grd3", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(0)), "Grd3", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Grd4", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(0)), "Grd4", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Grd5", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(0)), "Grd5", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Grd6", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(0)), "Grd6", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Remarks", System.Data.SqlDbType.VarChar, 0, "Remarks")});
            // 
            // sqlUpdateCommand15
            // 
            this.sqlUpdateCommand15.CommandText = resources.GetString("sqlUpdateCommand15.CommandText");
            this.sqlUpdateCommand15.Connection = this.sqlConnection1;
            this.sqlUpdateCommand15.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@subject_Id", System.Data.SqlDbType.Int, 0, "subject_Id"),
            new System.Data.SqlClient.SqlParameter("@Student_Id", System.Data.SqlDbType.Int, 0, "Student_Id"),
            new System.Data.SqlClient.SqlParameter("@Grd1", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(0)), "Grd1", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Grd2", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(0)), "Grd2", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Grd3", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(0)), "Grd3", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Grd4", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(0)), "Grd4", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Grd5", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(0)), "Grd5", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Grd6", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(0)), "Grd6", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Remarks", System.Data.SqlDbType.VarChar, 0, "Remarks"),
            new System.Data.SqlClient.SqlParameter("@Original_StudGrd_Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "StudGrd_Id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_subject_Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "subject_Id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Student_Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Student_Id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Grd1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Grd1", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Grd1", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(0)), "Grd1", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Grd2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Grd2", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Grd2", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(0)), "Grd2", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Grd3", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Grd3", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Grd3", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(0)), "Grd3", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Grd4", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Grd4", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Grd4", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(0)), "Grd4", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Grd5", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Grd5", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Grd5", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(0)), "Grd5", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Grd6", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Grd6", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Grd6", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(0)), "Grd6", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Remarks", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Remarks", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Remarks", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Remarks", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@StudGrd_Id", System.Data.SqlDbType.Int, 4, "StudGrd_Id")});
            // 
            // sqlDeleteCommand15
            // 
            this.sqlDeleteCommand15.CommandText = resources.GetString("sqlDeleteCommand15.CommandText");
            this.sqlDeleteCommand15.Connection = this.sqlConnection1;
            this.sqlDeleteCommand15.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_StudGrd_Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "StudGrd_Id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_subject_Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "subject_Id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Student_Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Student_Id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Grd1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Grd1", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Grd1", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(0)), "Grd1", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Grd2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Grd2", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Grd2", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(0)), "Grd2", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Grd3", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Grd3", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Grd3", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(0)), "Grd3", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Grd4", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Grd4", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Grd4", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(0)), "Grd4", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Grd5", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Grd5", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Grd5", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(0)), "Grd5", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Grd6", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Grd6", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Grd6", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(0)), "Grd6", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Remarks", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Remarks", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Remarks", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Remarks", System.Data.DataRowVersion.Original, null)});
            // 
            // adpDet14
            // 
            this.adpDet14.DeleteCommand = this.sqlDeleteCommand15;
            this.adpDet14.InsertCommand = this.sqlInsertCommand15;
            this.adpDet14.SelectCommand = this.sqlSelectCommand15;
            this.adpDet14.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "StudentGrade", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("StudGrd_Id", "StudGrd_Id"),
                        new System.Data.Common.DataColumnMapping("subject_Id", "subject_Id"),
                        new System.Data.Common.DataColumnMapping("Student_Id", "Student_Id"),
                        new System.Data.Common.DataColumnMapping("Grd1", "Grd1"),
                        new System.Data.Common.DataColumnMapping("Grd2", "Grd2"),
                        new System.Data.Common.DataColumnMapping("Grd3", "Grd3"),
                        new System.Data.Common.DataColumnMapping("Grd4", "Grd4"),
                        new System.Data.Common.DataColumnMapping("Grd5", "Grd5"),
                        new System.Data.Common.DataColumnMapping("Grd6", "Grd6"),
                        new System.Data.Common.DataColumnMapping("Remarks", "Remarks")})});
            this.adpDet14.UpdateCommand = this.sqlUpdateCommand15;
            // 
            // axL_CRUD_Controller1
            // 
            this.axL_CRUD_Controller1._keyField = "Student_Id";
            this.axL_CRUD_Controller1._keyVal = null;
            this.axL_CRUD_Controller1.adpDet1 = this.adpDet1;
            this.axL_CRUD_Controller1.adpDet10 = this.adpDet10;
            this.axL_CRUD_Controller1.adpDet11 = this.adpDet11;
            this.axL_CRUD_Controller1.adpDet12 = this.adpDet12;
            this.axL_CRUD_Controller1.adpDet13 = this.adpDet13;
            this.axL_CRUD_Controller1.adpDet14 = this.adpDet14;
            this.axL_CRUD_Controller1.adpDet15 = null;
            this.axL_CRUD_Controller1.adpDet2 = this.AdpDet2;
            this.axL_CRUD_Controller1.adpDet3 = this.adpDet3;
            this.axL_CRUD_Controller1.adpDet4 = this.adpDet4;
            this.axL_CRUD_Controller1.adpDet5 = this.adpDet5;
            this.axL_CRUD_Controller1.adpDet6 = this.adpDet6;
            this.axL_CRUD_Controller1.adpDet7 = this.adpDet7;
            this.axL_CRUD_Controller1.adpDet8 = this.adpDet8;
            this.axL_CRUD_Controller1.adpDet9 = this.adpDet9;
            this.axL_CRUD_Controller1.adpHdr = this.AdpHdr;
            this.axL_CRUD_Controller1.adpLst1 = null;
            this.axL_CRUD_Controller1.bsDet1 = this.bsDet1;
            this.axL_CRUD_Controller1.bsDet10 = this.bsDet10;
            this.axL_CRUD_Controller1.bsDet11 = this.bsDet11;
            this.axL_CRUD_Controller1.bsDet12 = this.bsDet12;
            this.axL_CRUD_Controller1.bsDet13 = this.bsDet13;
            this.axL_CRUD_Controller1.bsDet14 = this.bsDet14;
            this.axL_CRUD_Controller1.bsDet15 = null;
            this.axL_CRUD_Controller1.bsDet2 = this.bsDet2;
            this.axL_CRUD_Controller1.bsDet3 = this.bsDet3;
            this.axL_CRUD_Controller1.bsDet4 = this.bsDet4;
            this.axL_CRUD_Controller1.bsDet5 = this.bsDet5;
            this.axL_CRUD_Controller1.bsDet6 = this.bsDet6;
            this.axL_CRUD_Controller1.bsDet7 = this.bsDet7;
            this.axL_CRUD_Controller1.bsDet8 = this.bsDet8;
            this.axL_CRUD_Controller1.bsDet9 = this.bsDet9;
            this.axL_CRUD_Controller1.bsHdr = this.bsHdr;
            this.axL_CRUD_Controller1.bsLst1 = null;
            this.axL_CRUD_Controller1.connection_string = null;
            this.axL_CRUD_Controller1.Dock = System.Windows.Forms.DockStyle.Top;
            this.axL_CRUD_Controller1.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.axL_CRUD_Controller1.form_type = 1;
            this.axL_CRUD_Controller1.isKey2Int = false;
            this.axL_CRUD_Controller1.isKeyInt = false;
            this.axL_CRUD_Controller1.Location = new System.Drawing.Point(0, 0);
            this.axL_CRUD_Controller1.Margin = new System.Windows.Forms.Padding(6);
            this.axL_CRUD_Controller1.Name = "axL_CRUD_Controller1";
            this.axL_CRUD_Controller1.operation1_caption = "";
            this.axL_CRUD_Controller1.operation10_caption = null;
            this.axL_CRUD_Controller1.operation2_caption = null;
            this.axL_CRUD_Controller1.operation3_caption = null;
            this.axL_CRUD_Controller1.operation4_caption = null;
            this.axL_CRUD_Controller1.operation5_caption = null;
            this.axL_CRUD_Controller1.operation6_caption = null;
            this.axL_CRUD_Controller1.operation7_caption = null;
            this.axL_CRUD_Controller1.operation8_caption = null;
            this.axL_CRUD_Controller1.operation9_caption = null;
            this.axL_CRUD_Controller1.record_action = 0;
            this.axL_CRUD_Controller1.report1_caption = null;
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
            this.axL_CRUD_Controller1.Size = new System.Drawing.Size(928, 42);
            this.axL_CRUD_Controller1.TabIndex = 0;
            this.axL_CRUD_Controller1.tblDet1 = this.dsTran.axl_security;
            this.axL_CRUD_Controller1.tblDet10 = this.dsTran.SampTbl9;
            this.axL_CRUD_Controller1.tblDet11 = this.dsTran.SampTbl10;
            this.axL_CRUD_Controller1.tblDet12 = this.dsTran.SampTbl11;
            this.axL_CRUD_Controller1.tblDet13 = this.dsTran.SampTbl12;
            this.axL_CRUD_Controller1.tblDet14 = this.dsTran.StudentGrade;
            this.axL_CRUD_Controller1.tblDet15 = null;
            this.axL_CRUD_Controller1.tblDet2 = this.dsTran.SampTbl1;
            this.axL_CRUD_Controller1.tblDet3 = this.dsTran.SampTbl2;
            this.axL_CRUD_Controller1.tblDet4 = this.dsTran.SampTbl3;
            this.axL_CRUD_Controller1.tblDet5 = this.dsTran.SampTbl4;
            this.axL_CRUD_Controller1.tblDet6 = this.dsTran.SampTbl5;
            this.axL_CRUD_Controller1.tblDet7 = this.dsTran.SampTbl6;
            this.axL_CRUD_Controller1.tblDet8 = this.dsTran.SampTbl7;
            this.axL_CRUD_Controller1.tblDet9 = this.dsTran.SampTbl8;
            this.axL_CRUD_Controller1.tblHdr = this.dsTran.StudentPersonalInfo;
            this.axL_CRUD_Controller1.tblLst1 = null;
            this.axL_CRUD_Controller1.withDelete = true;
            this.axL_CRUD_Controller1.withEdit = true;
            this.axL_CRUD_Controller1.withNew = true;
            this.axL_CRUD_Controller1.withOperation = true;
            this.axL_CRUD_Controller1.withRefresh = false;
            this.axL_CRUD_Controller1.withReport = false;
            this.axL_CRUD_Controller1.withSave = true;
            this.axL_CRUD_Controller1.InitializeHeader_After += new AdvanceXtensionLibrary.AXL_CRUD_Controller.EventDelegates(this.axL_CRUD_Controller1_InitializeHeader_After);
            // 
            // bsDet14
            // 
            this.bsDet14.DataMember = "StudentGrade";
            this.bsDet14.DataSource = this.dsTran;
            // 
            // frmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 742);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.axL_CRUD_Controller1);
            this.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmStudent";
            this.Load += new System.EventHandler(this.frmStudent_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTran)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            this.tabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).EndInit();
            this.tabPage8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView8)).EndInit();
            this.tabPage9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView9)).EndInit();
            this.tabPage10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView10)).EndInit();
            this.tabPage11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView11)).EndInit();
            this.tabPage12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView12)).EndInit();
            this.tabPage13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView13)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsDet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsHdr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDet14)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private dsTran dsTran;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter AdpHdr;
        private System.Windows.Forms.BindingSource bsHdr;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox8;
        public AdvanceXtensionLibrary.AXL_CRUD_Controller axL_CRUD_Controller1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand3;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand3;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand3;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand3;
        private System.Data.SqlClient.SqlDataAdapter AdpDet2;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand4;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand4;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand4;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand4;
        private System.Data.SqlClient.SqlDataAdapter adpDet3;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand5;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand5;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand5;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand5;
        private System.Data.SqlClient.SqlDataAdapter adpDet4;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand6;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand6;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand6;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand6;
        private System.Data.SqlClient.SqlDataAdapter adpDet5;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand7;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand7;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand7;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand7;
        private System.Data.SqlClient.SqlDataAdapter adpDet6;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand8;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand8;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand8;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand8;
        private System.Data.SqlClient.SqlDataAdapter adpDet7;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand9;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand9;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand9;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand9;
        private System.Data.SqlClient.SqlDataAdapter adpDet8;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand10;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand10;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand10;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand10;
        private System.Data.SqlClient.SqlDataAdapter adpDet9;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand11;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand11;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand11;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand11;
        private System.Data.SqlClient.SqlDataAdapter adpDet10;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand12;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand12;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand12;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand12;
        private System.Data.SqlClient.SqlDataAdapter adpDet11;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand13;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand13;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand13;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand13;
        private System.Data.SqlClient.SqlDataAdapter adpDet12;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand14;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand14;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand14;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand14;
        private System.Data.SqlClient.SqlDataAdapter adpDet13;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand15;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand15;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand15;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand15;
        private System.Data.SqlClient.SqlDataAdapter adpDet14;
        private System.Windows.Forms.BindingSource bsDet1;
        private System.Windows.Forms.BindingSource bsDet2;
        private System.Windows.Forms.BindingSource bsDet3;
        private System.Windows.Forms.BindingSource bsDet4;
        private System.Windows.Forms.BindingSource bsDet5;
        private System.Windows.Forms.BindingSource bsDet6;
        private System.Windows.Forms.BindingSource bsDet7;
        private System.Windows.Forms.BindingSource bsDet8;
        private System.Windows.Forms.BindingSource bsDet9;
        private System.Windows.Forms.BindingSource bsDet10;
        private System.Windows.Forms.BindingSource bsDet11;
        private System.Windows.Forms.BindingSource bsDet12;
        private System.Windows.Forms.BindingSource bsDet13;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand2;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand2;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
        private System.Data.SqlClient.SqlDataAdapter adpDet1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbl1rowIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fldStringDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fldIntDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn fldBoolDataGridViewCheckBoxColumn;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbl2rowIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fldStringDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fldIntDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn fldBoolDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbl3rowIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIdDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn fldStringDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn fldIntDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn fldBoolDataGridViewCheckBoxColumn2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbl4rowIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIdDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn fldStringDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn fldIntDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn fldBoolDataGridViewCheckBoxColumn3;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbl5rowIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIdDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn fldStringDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn fldIntDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn fldBoolDataGridViewCheckBoxColumn4;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbl6rowIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIdDataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn fldStringDataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn fldIntDataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn fldBoolDataGridViewCheckBoxColumn5;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.DataGridView dataGridView7;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbl7rowIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIdDataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn fldStringDataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn fldIntDataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn fldBoolDataGridViewCheckBoxColumn6;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.DataGridView dataGridView8;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbl8rowIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIdDataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn fldStringDataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn fldIntDataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn fldBoolDataGridViewCheckBoxColumn7;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.DataGridView dataGridView9;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbl9rowIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIdDataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn fldStringDataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn fldIntDataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewCheckBoxColumn fldBoolDataGridViewCheckBoxColumn8;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.DataGridView dataGridView10;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbl10rowIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIdDataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn fldStringDataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn fldIntDataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewCheckBoxColumn fldBoolDataGridViewCheckBoxColumn9;
        private System.Windows.Forms.TabPage tabPage11;
        private System.Windows.Forms.DataGridView dataGridView11;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbl11rowIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIdDataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn fldStringDataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn fldIntDataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewCheckBoxColumn fldBoolDataGridViewCheckBoxColumn10;
        private System.Windows.Forms.TabPage tabPage12;
        private System.Windows.Forms.DataGridView dataGridView12;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbl12rowIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIdDataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn fldStringDataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn fldIntDataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewCheckBoxColumn fldBoolDataGridViewCheckBoxColumn11;
        private System.Windows.Forms.TabPage tabPage13;
        private System.Windows.Forms.DataGridView dataGridView13;
        private System.Windows.Forms.DataGridViewTextBoxColumn studGrdIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIdDataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn grd1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grd2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grd3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grd4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grd5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grd6DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarksDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsDet14;
    }
}