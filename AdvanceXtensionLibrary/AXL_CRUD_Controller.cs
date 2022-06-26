using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using AdvanceXtensionLibrary.AXL_Class;

namespace AdvanceXtensionLibrary
{
    //VERSION NOTE: Version 1.0 03-20-2020
    public partial class AXL_CRUD_Controller : UserControl
    {
        #region LIBRARIES
        AXL_CRUD_Class crud = new AXL_CRUD_Class();
        #endregion
        #region BOOLEAN VARIABLES
        public bool isKeyInt { get; set; } //if true then the primary key is int else string
        public bool isKey2Int { get; set; }
        public bool withNew { get; set; }
        public bool withEdit { get; set; }
        public bool withDelete { get; set; }
        public bool withSave { get; set; }
        public bool withReport { get; set; }
        public bool withOperation { get; set; }
        public bool withRefresh { get; set; }
        #endregion
        #region STRING VARIABLES
        public string connection_string { get; set; }
        public string _keyVal { get; set; } 
        public string _keyField { get; set; }

        //Operation Variables
        public string operation1_caption { get; set; }
        public string operation2_caption { get; set; }
        public string operation3_caption { get; set; }
        public string operation4_caption { get; set; }
        public string operation5_caption { get; set; }
        public string operation6_caption { get; set; }
        public string operation7_caption { get; set; }
        public string operation8_caption { get; set; }
        public string operation9_caption { get; set; }
        public string operation10_caption { get; set; }

        //Report Variables
        public string report1_caption { get; set; }
        public string report2_caption { get; set; }
        public string report3_caption { get; set; }
        public string report4_caption { get; set; }
        public string report5_caption { get; set; }
        public string report6_caption { get; set; }
        public string report7_caption { get; set; }
        public string report8_caption { get; set; }
        public string report9_caption { get; set; }
        public string report10_caption { get; set; }
        #endregion

        #region INTEGER VARIABLES
        public int record_action { get; set; } // 0 - New; 1 - Edit; 2 - View;
        public int series_type { get; set; } // 0 - Auto Increment; 1 - Manual;
        public int form_type { get; set; } // 0 - List; 1 - Entry; 2 - List(View Only);
        #endregion
        #region SQL DATA ADAPTERS
        public SqlDataAdapter adpHdr { get; set; }
        public SqlDataAdapter adpDet1 { get; set; }
        public SqlDataAdapter adpDet2 { get; set; }
        public SqlDataAdapter adpDet3 { get; set; }
        public SqlDataAdapter adpDet4 { get; set; }
        public SqlDataAdapter adpDet5 { get; set; }
        public SqlDataAdapter adpDet6 { get; set; }
        public SqlDataAdapter adpDet7 { get; set; }
        public SqlDataAdapter adpDet8 { get; set; }
        public SqlDataAdapter adpDet9 { get; set; }
        public SqlDataAdapter adpDet10 { get; set; }
        public SqlDataAdapter adpDet11 { get; set; }
        public SqlDataAdapter adpDet12 { get; set; }
        public SqlDataAdapter adpDet13 { get; set; }
        public SqlDataAdapter adpDet14 { get; set; }
        public SqlDataAdapter adpDet15 { get; set; }
        public SqlDataAdapter adpLst1 { get; set; }
        #endregion
        #region BINDING SOURCES
        public BindingSource bsHdr { get; set; }
        public BindingSource bsDet1 { get; set; }
        public BindingSource bsDet2 { get; set; }
        public BindingSource bsDet3 { get; set; }
        public BindingSource bsDet4 { get; set; }
        public BindingSource bsDet5 { get; set; }
        public BindingSource bsDet6 { get; set; }
        public BindingSource bsDet7 { get; set; }
        public BindingSource bsDet8 { get; set; }
        public BindingSource bsDet9 { get; set; }
        public BindingSource bsDet10 { get; set; }
        public BindingSource bsDet11 { get; set; }
        public BindingSource bsDet12 { get; set; }
        public BindingSource bsDet13 { get; set; }
        public BindingSource bsDet14 { get; set; }
        public BindingSource bsDet15 { get; set; }
        public BindingSource bsLst1 { get; set; }
        #endregion
        #region DATA TABLES
        public DataTable tblHdr { get; set; }
        public DataTable tblDet1 { get; set; }
        public DataTable tblDet2 { get; set; }
        public DataTable tblDet3 { get; set; }
        public DataTable tblDet4 { get; set; }
        public DataTable tblDet5 { get; set; }
        public DataTable tblDet6 { get; set; }
        public DataTable tblDet7 { get; set; }
        public DataTable tblDet8 { get; set; }
        public DataTable tblDet9 { get; set; }
        public DataTable tblDet10 { get; set; }
        public DataTable tblDet11 { get; set; }
        public DataTable tblDet12 { get; set; }
        public DataTable tblDet13 { get; set; }
        public DataTable tblDet14 { get; set; }
        public DataTable tblDet15 { get; set; }
        public DataTable tblLst1 { get; set; }
        #endregion
        #region EVENT HANDLERS
        public delegate void EventDelegates();
        public event EventDelegates InitializeHeader_Before;
        public event EventDelegates InitializeHeader_After;
        public event EventHandler btnNew_Before;
        public event EventHandler btnNew_After;
        public event EventHandler btnSave_Before;
        public event EventHandler btnSave_After;
        public event EventHandler btnRefresh_Before;
        public event EventHandler btnRefresh_After;
        #endregion
        public AXL_CRUD_Controller()
        {
            InitializeComponent();
        }

        public void InitializeCRUD()
        {
            crud.connection_string = connection_string;
            crud._keyVal = _keyVal;
            crud._keyField = _keyField;
            crud.isKeyInt = isKeyInt;
            crud.isSuccess = true;
            #region init ADAPTERS
            crud.adpHdr = adpHdr;
            crud.adpDet1 = adpDet1;
            crud.adpDet2 = adpDet2;
            crud.adpDet3 = adpDet3;
            crud.adpDet4 = adpDet4;
            crud.adpDet5 = adpDet5;
            crud.adpDet6 = adpDet6;
            crud.adpDet7 = adpDet7;
            crud.adpDet8 = adpDet8;
            crud.adpDet9 = adpDet9;
            crud.adpDet10 = adpDet10;
            crud.adpDet11 = adpDet11;
            crud.adpDet12 = adpDet12;
            crud.adpDet13 = adpDet13;
            crud.adpDet14 = adpDet14;
            crud.adpDet15 = adpDet15;
            crud.adpLst1 = adpLst1;
            #endregion
            #region init BindingSource
            crud.bsHdr = bsHdr;
            crud.bsDet1 = bsDet1;
            crud.bsDet2 = bsDet2;
            crud.bsDet3 = bsDet3;
            crud.bsDet4 = bsDet4;
            crud.bsDet5 = bsDet5;
            crud.bsDet6 = bsDet6;
            crud.bsDet7 = bsDet7;
            crud.bsDet8 = bsDet8;
            crud.bsDet9 = bsDet9;
            crud.bsDet10 = bsDet10;
            crud.bsDet11 = bsDet11;
            crud.bsDet12 = bsDet12;
            crud.bsDet13 = bsDet13;
            crud.bsDet14 = bsDet14;
            crud.bsDet15 = bsDet15;
            crud.bsLst1 = bsLst1;
            #endregion
            #region init Datatables
            crud.tblHdr = tblHdr;
            crud.tblDet1 = tblDet1;
            crud.tblDet2 = tblDet2;
            crud.tblDet3 = tblDet3;
            crud.tblDet4 = tblDet4;
            crud.tblDet5 = tblDet5;
            crud.tblDet6 = tblDet6;
            crud.tblDet7 = tblDet7;
            crud.tblDet8 = tblDet8;
            crud.tblDet9 = tblDet9;
            crud.tblDet10 = tblDet10;
            crud.tblDet11 = tblDet11;
            crud.tblDet12 = tblDet12;
            crud.tblDet13 = tblDet13;
            crud.tblDet14 = tblDet14;
            crud.tblDet15 = tblDet15;
            crud.tblLst1 = tblLst1;
            crud.form_type = form_type;
            #endregion
            crud.SetupConnection();
            InitializeButtons();
            InitializeForm();
        }

        public void btnRefresh_Click(object sender, EventArgs e)
        {
            if (btnRefresh_Before != null)
                btnRefresh_Before(sender, e);

            crud.RefreshTables();

            if (btnRefresh_After != null)
                btnRefresh_After(sender, e);
        }

        public void ViewRecord()
        {
            try
            {
                if (adpHdr != null)
                {
                    adpHdr.SelectCommand.Parameters["@zkey1"].Value = _keyVal;
                    adpHdr.Fill(tblHdr);
                }
                if (adpDet1 != null)
                {
                    adpDet1.SelectCommand.Parameters["@zkey1"].Value = _keyVal;
                    adpDet1.Fill(tblDet1);
                }
                if (adpDet2 != null)
                {
                    adpDet2.SelectCommand.Parameters["@zkey1"].Value = _keyVal;
                    adpDet2.Fill(tblDet2);
                }
                if (adpDet3 != null)
                {
                    adpDet3.SelectCommand.Parameters["@zkey1"].Value = _keyVal;
                    adpDet3.Fill(tblDet3);
                }
                if (adpDet4 != null)
                {
                    adpDet4.SelectCommand.Parameters["@zkey1"].Value = _keyVal;
                    adpDet4.Fill(tblDet4);
                }
                if (adpDet5 != null)
                {
                    adpDet5.SelectCommand.Parameters["@zkey1"].Value = _keyVal;
                    adpDet5.Fill(tblDet5);
                }
                if (adpDet6 != null)
                {
                    adpDet6.SelectCommand.Parameters["@zkey1"].Value = _keyVal;
                    adpDet6.Fill(tblDet6);
                }
                if (adpDet7 != null)
                {
                    adpDet7.SelectCommand.Parameters["@zkey1"].Value = _keyVal;
                    adpDet7.Fill(tblDet7);
                }
                if (adpDet8 != null)
                {
                    adpDet8.SelectCommand.Parameters["@zkey1"].Value = _keyVal;
                    adpDet8.Fill(tblDet8);
                }
                if (adpDet9 != null)
                {
                    adpDet9.SelectCommand.Parameters["@zkey1"].Value = _keyVal;
                    adpDet9.Fill(tblDet9);
                }
                if (adpDet10 != null)
                {
                    adpDet10.SelectCommand.Parameters["@zkey1"].Value = _keyVal;
                    adpDet10.Fill(tblDet10);
                }
                if (adpDet11 != null)
                {
                    adpDet11.SelectCommand.Parameters["@zkey1"].Value = _keyVal;
                    adpDet11.Fill(tblDet11);
                }
                if (adpDet12 != null)
                {
                    adpDet12.SelectCommand.Parameters["@zkey1"].Value = _keyVal;
                    adpDet12.Fill(tblDet12);
                }
                if (adpDet13 != null)
                {
                    adpDet13.SelectCommand.Parameters["@zkey1"].Value = _keyVal;
                    adpDet13.Fill(tblDet13);
                }
                if (adpDet14 != null)
                {
                    adpDet14.SelectCommand.Parameters["@zkey1"].Value = _keyVal;
                    adpDet14.Fill(tblDet14);
                }
                if (adpDet15 != null)
                {
                    adpDet15.SelectCommand.Parameters["@zkey1"].Value = _keyVal;
                    adpDet15.Fill(tblDet15);
                }
            }
            catch (Exception ex)
            {
                if (System.Diagnostics.Debugger.IsAttached)
                    MessageBox.Show(String.Format("Viewing of Record Failed. >> Message:{0} \n >> Stack Trace:{1} \n >> Inner Exception:{2} \n >> Target Site:{3}", ex.Message, ex.StackTrace, ex.InnerException, ex.TargetSite));
                else
                    MessageBox.Show(String.Format("Viewing of Record Failed. >> Message:{0}", ex.Message));
            }
        }
        public void InitializeButtons()
        {
            try
            {
                if (!withNew)
                    btnNew.Visible = false;
                if (!withEdit)
                    btnEdit.Visible = false;
                if (!withDelete)
                    btnDelete.Visible = false;
                if (!withSave)
                    btnSave.Visible = false;
                if (!withReport)
                    btnReports.Visible = false;
                if (!withOperation)
                    btnOperations.Visible = false;
                if (!withRefresh)
                    btnRefresh.Visible = false;

                #region Operations
                if (!String.IsNullOrEmpty(operation1_caption))  {
                    btnOperation1.Visible = true;
                    btnOperation1.Text = operation1_caption;    } else btnOperation1.HideDropDown();
                if (!String.IsNullOrEmpty(operation2_caption))  {
                    btnOperation2.Visible = true;
                    btnOperation2.Text = operation2_caption;    } else btnOperation2.HideDropDown();
                if (!String.IsNullOrEmpty(operation3_caption))  {
                    btnOperation3.Visible = true;
                    btnOperation3.Text = operation3_caption;    } else btnOperation3.HideDropDown();
                if (!String.IsNullOrEmpty(operation4_caption))  {
                    btnOperation4.Visible = true;
                    btnOperation4.Text = operation4_caption;    } else btnOperation4.HideDropDown();
                if (!String.IsNullOrEmpty(operation5_caption))  {
                    btnOperation5.Visible = true;
                    btnOperation5.Text = operation5_caption;    } else btnOperation5.HideDropDown();
                if (!String.IsNullOrEmpty(operation6_caption))  {
                    btnOperation6.Visible = true;
                    btnOperation6.Text = operation6_caption;    } else btnOperation6.HideDropDown();
                if (!String.IsNullOrEmpty(operation7_caption))  {
                    btnOperation7.Visible = true;
                    btnOperation7.Text = operation7_caption;    } else btnOperation7.HideDropDown();
                if (!String.IsNullOrEmpty(operation8_caption))  {
                    btnOperation8.Visible = true;
                    btnOperation8.Text = operation8_caption;    } else btnOperation8.HideDropDown();
                if (!String.IsNullOrEmpty(operation9_caption))  {
                    btnOperation9.Visible = true;
                    btnOperation9.Text = operation9_caption;    } else btnOperation9.HideDropDown();
                if (!String.IsNullOrEmpty(operation10_caption)) {
                    btnOperation10.Visible = true;
                    btnOperation10.Text = operation10_caption;  } else btnOperation10.HideDropDown();
                #endregion
                #region Reports
                if (!String.IsNullOrEmpty(report1_caption)) { 
                    btnRpt1.Text = report1_caption; btnRpt1.Visible = true;              } else btnRpt1.HideDropDown();
                if (!String.IsNullOrEmpty(report2_caption)) {
                    btnRpt2.Text = report2_caption; btnRpt1.Visible = true;              } else btnRpt2.HideDropDown();   
                if (!String.IsNullOrEmpty(report3_caption)) { 
                    btnRpt3.Text = report3_caption; btnRpt1.Visible = true;              } else btnRpt3.HideDropDown();    
                if (!String.IsNullOrEmpty(report4_caption)) { 
                    btnRpt4.Text = report4_caption; btnRpt1.Visible = true;              } else btnRpt4.HideDropDown();
                if (!String.IsNullOrEmpty(report5_caption)) { 
                    btnRpt5.Text = report5_caption; btnRpt1.Visible = true;              } else btnRpt5.HideDropDown();  
                if (!String.IsNullOrEmpty(report6_caption)) { 
                    btnRpt6.Text = report6_caption; btnRpt1.Visible = true;              } else btnRpt6.HideDropDown();     
                if (!String.IsNullOrEmpty(report7_caption)) { 
                    btnRpt7.Text = report7_caption; btnRpt1.Visible = true;              } else btnRpt7.HideDropDown();
                if (!String.IsNullOrEmpty(report8_caption)) { 
                    btnRpt8.Text = report8_caption; btnRpt1.Visible = true;              } else btnRpt8.HideDropDown();
                if (!String.IsNullOrEmpty(report9_caption)) { 
                    btnRpt9.Text = report9_caption; btnRpt1.Visible = true;              } else btnRpt9.HideDropDown(); 
                if (!String.IsNullOrEmpty(report10_caption)){ 
                    btnRpt10.Text = report10_caption; btnRpt10.Visible = true;     } else btnRpt10.HideDropDown();   
                #endregion

                switch (record_action)
                {
                    case 0:
                        btnEdit.Enabled = false;
                        btnNew.Enabled = false;
                        btnSave.Enabled = true;
                        btnDelete.Enabled = false;
                        break;
                    case 1:
                        btnEdit.Enabled = false;
                        btnNew.Enabled = false;
                        btnSave.Enabled = true;
                        btnDelete.Enabled = true;
                        break;
                    case 2:
                        btnEdit.Enabled = true;
                        btnNew.Enabled = true;
                        btnSave.Enabled = false;
                        btnDelete.Enabled = false;
                        break;
                    case 3:
                        btnEdit.Enabled = true;
                        btnNew.Enabled = true;
                        btnSave.Enabled = false;
                        btnDelete.Enabled = false;
                        break;
                    default:
                        btnEdit.Enabled = false;
                        btnNew.Enabled = false;
                        btnSave.Enabled = false;
                        btnDelete.Enabled = false;
                        break;
                }
            }
            catch (Exception ex)
            {
                if (System.Diagnostics.Debugger.IsAttached)
                    MessageBox.Show(String.Format("Initialize Menu Failed. >> Message:{0} \n >> Stack Trace:{1} \n >> Inner Exception:{2} \n >> Target Site:{3}", ex.Message, ex.StackTrace, ex.InnerException, ex.TargetSite));
                else
                    MessageBox.Show(String.Format("Initialize Menu Failed. >> Message:{0}", ex.Message));
            }
        }
        public void InitializeForm()
        {
            try
            {
                if(record_action == 2 && form_type != 2)
                {
                    foreach(Control c in ParentForm.Controls)
                    {
                        if (c.Name.Contains("panel"))
                            c.Enabled = false;
                    }
                }
                else
                    foreach(Control c in ParentForm.Controls)
                    {
                        if (c.Name.Contains("panel"))
                            c.Enabled = true;
                    }

                InitializeButtons();
            }
            catch (Exception ex)
            {
                if (System.Diagnostics.Debugger.IsAttached)
                    MessageBox.Show(String.Format("Initialize Form Failed. >> Message:{0} \n >> Stack Trace:{1} \n >> Inner Exception:{2} \n >> Target Site:{3}", ex.Message, ex.StackTrace, ex.InnerException, ex.TargetSite));
                else
                    MessageBox.Show(String.Format("Initialize Form Failed. >> Message:{0}", ex.Message));
            }
        }
        public void InitializeHeader()
        {
            try
            {
                if (InitializeHeader_Before != null)
                    InitializeHeader_Before();

                if(bsHdr != null)
                {
                    bsHdr.CurrencyManager.AddNew();
                    DataRowView drvHdr = (DataRowView)bsHdr.CurrencyManager.Current;
                    if (series_type != 0)
                    {
                        if (isKeyInt)
                            drvHdr[_keyField] = -1;
                        else
                            drvHdr[_keyField] = "XXX";
                    }
                }

                if (InitializeHeader_After != null)
                    InitializeHeader_After();
            }
            catch (Exception ex)
            {
                if (System.Diagnostics.Debugger.IsAttached)
                    MessageBox.Show(String.Format("Initialize Form Failed. >> Message:{0} \n >> Stack Trace:{1} \n >> Inner Exception:{2} \n >> Target Site:{3}", ex.Message, ex.StackTrace, ex.InnerException, ex.TargetSite));
                else
                    MessageBox.Show(String.Format("Initialize Form Failed. >> Message:{0}", ex.Message));
            }
        }
        public void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave_Before != null)
                btnSave_Before(sender, e);

            ParentForm.Validate();
            crud.ValidateEdit();
            if (!crud.isSuccess)
                return;
            crud.SaveToDB();
            if (crud.isSuccess)
            {
                record_action = 2;
                InitializeForm();

                if (btnSave_After != null)
                    btnSave_After(sender, e);

                MessageBox.Show("Record Successfully Saved!");
            }
            else
                MessageBox.Show("Record failed to save.");
         }

        public void btnEdit_Click(object sender, EventArgs e)
        {
            record_action = 1;
            InitializeForm();
        }

        public void btnNew_Click(object sender, EventArgs e)
        {
            record_action = 0; 
            crud.ClearTheForm();
            InitializeHeader();
            InitializeForm();
            if (btnNew_Before != null)
                btnNew_Before(sender, e);

            if (btnNew_After != null)
                btnNew_After(sender, e);
        }

        public void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
