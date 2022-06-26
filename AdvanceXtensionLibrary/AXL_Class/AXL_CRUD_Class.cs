using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace AdvanceXtensionLibrary.AXL_Class
{
    public class AXL_CRUD_Class
    {
        #region LIBRARIES 
        AXL_QueryLib qlib = new AXL_QueryLib();
        #endregion
        #region STRING VARIABLES
        public string connection_string { get; set; }
        public string _keyVal { get; set; }
        public string _keyField { get; set; }
        #endregion
        #region INT VARIABLES
        public int form_type { get; set; }
        #endregion
        #region BOOLEAN VARIABLES
        public bool isSuccess { get; set; }
        public bool isKeyInt { get; set; }
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
        SqlConnection conn = new SqlConnection();

        public void SetupConnection()
        {
            try
            {
                conn.ConnectionString = connection_string;
                if(adpHdr != null)
                {
                    adpHdr.SelectCommand.Connection = conn;
                    adpHdr.DeleteCommand.Connection = conn;
                    adpHdr.InsertCommand.Connection = conn;
                    adpHdr.UpdateCommand.Connection = conn;

                    adpHdr.SelectCommand.CommandTimeout = 0;
                    adpHdr.DeleteCommand.CommandTimeout = 0;
                    adpHdr.InsertCommand.CommandTimeout = 0;
                    adpHdr.UpdateCommand.CommandTimeout = 0;
                }
                if(adpDet1 != null)
                {
                    adpDet1.SelectCommand.Connection = conn;
                    adpDet1.DeleteCommand.Connection = conn;
                    adpDet1.InsertCommand.Connection = conn;
                    adpDet1.UpdateCommand.Connection = conn;

                    adpDet1.SelectCommand.CommandTimeout = 0;
                    adpDet1.DeleteCommand.CommandTimeout = 0;
                    adpDet1.InsertCommand.CommandTimeout = 0;
                    adpDet1.UpdateCommand.CommandTimeout = 0;
                }
                if(adpDet2 != null)
                {
                    adpDet2.SelectCommand.Connection = conn;
                    adpDet2.UpdateCommand.Connection = conn;
                    adpDet2.InsertCommand.Connection = conn;
                    adpDet2.DeleteCommand.Connection = conn;

                    adpDet2.SelectCommand.CommandTimeout = 0;
                    adpDet2.UpdateCommand.CommandTimeout = 0;
                    adpDet2.InsertCommand.CommandTimeout = 0;
                    adpDet2.DeleteCommand.CommandTimeout = 0;
                }
                if (adpDet3 != null)
                {
                    adpDet3.SelectCommand.Connection = conn;
                    adpDet3.UpdateCommand.Connection = conn;
                    adpDet3.InsertCommand.Connection = conn;
                    adpDet3.DeleteCommand.Connection = conn;

                    adpDet3.SelectCommand.CommandTimeout = 0;
                    adpDet3.UpdateCommand.CommandTimeout = 0;
                    adpDet3.InsertCommand.CommandTimeout = 0;
                    adpDet3.DeleteCommand.CommandTimeout = 0;
                }
                if (adpDet4 != null)
                {
                    adpDet4.SelectCommand.Connection = conn;
                    adpDet4.UpdateCommand.Connection = conn;
                    adpDet4.InsertCommand.Connection = conn;
                    adpDet4.DeleteCommand.Connection = conn;

                    adpDet4.SelectCommand.CommandTimeout = 0;
                    adpDet4.UpdateCommand.CommandTimeout = 0;
                    adpDet4.InsertCommand.CommandTimeout = 0;
                    adpDet4.DeleteCommand.CommandTimeout = 0;
                }
                if (adpDet5 != null)
                {
                    adpDet5.SelectCommand.Connection = conn;
                    adpDet5.UpdateCommand.Connection = conn;
                    adpDet5.InsertCommand.Connection = conn;
                    adpDet5.DeleteCommand.Connection = conn;

                    adpDet5.SelectCommand.CommandTimeout = 0;
                    adpDet5.UpdateCommand.CommandTimeout = 0;
                    adpDet5.InsertCommand.CommandTimeout = 0;
                    adpDet5.DeleteCommand.CommandTimeout = 0;
                }
                if (adpDet6 != null)
                {
                    adpDet6.SelectCommand.Connection = conn;
                    adpDet6.UpdateCommand.Connection = conn;
                    adpDet6.InsertCommand.Connection = conn;
                    adpDet6.DeleteCommand.Connection = conn;

                    adpDet6.SelectCommand.CommandTimeout = 0;
                    adpDet6.UpdateCommand.CommandTimeout = 0;
                    adpDet6.InsertCommand.CommandTimeout = 0;
                    adpDet6.DeleteCommand.CommandTimeout = 0;
                }
                if (adpDet7 != null)
                {
                    adpDet7.SelectCommand.Connection = conn;
                    adpDet7.UpdateCommand.Connection = conn;
                    adpDet7.InsertCommand.Connection = conn;
                    adpDet7.DeleteCommand.Connection = conn;

                    adpDet7.SelectCommand.CommandTimeout = 0;
                    adpDet7.UpdateCommand.CommandTimeout = 0;
                    adpDet7.InsertCommand.CommandTimeout = 0;
                    adpDet7.DeleteCommand.CommandTimeout = 0;
                }
                if (adpDet8 != null)
                {
                    adpDet8.SelectCommand.Connection = conn;
                    adpDet8.UpdateCommand.Connection = conn;
                    adpDet8.InsertCommand.Connection = conn;
                    adpDet8.DeleteCommand.Connection = conn;

                    adpDet8.SelectCommand.CommandTimeout = 0;
                    adpDet8.UpdateCommand.CommandTimeout = 0;
                    adpDet8.InsertCommand.CommandTimeout = 0;
                    adpDet8.DeleteCommand.CommandTimeout = 0;
                }
                if (adpDet9 != null)
                {
                    adpDet9.SelectCommand.Connection = conn;
                    adpDet9.UpdateCommand.Connection = conn;
                    adpDet9.InsertCommand.Connection = conn;
                    adpDet9.DeleteCommand.Connection = conn;

                    adpDet9.SelectCommand.CommandTimeout = 0;
                    adpDet9.UpdateCommand.CommandTimeout = 0;
                    adpDet9.InsertCommand.CommandTimeout = 0;
                    adpDet9.DeleteCommand.CommandTimeout = 0;
                }
                if (adpDet10 != null)
                {
                    adpDet10.SelectCommand.Connection = conn;
                    adpDet10.UpdateCommand.Connection = conn;
                    adpDet10.InsertCommand.Connection = conn;
                    adpDet10.DeleteCommand.Connection = conn;

                    adpDet10.SelectCommand.CommandTimeout = 0;
                    adpDet10.UpdateCommand.CommandTimeout = 0;
                    adpDet10.InsertCommand.CommandTimeout = 0;
                    adpDet10.DeleteCommand.CommandTimeout = 0;
                }
                if (adpDet11 != null)
                {
                    adpDet11.SelectCommand.Connection = conn;
                    adpDet11.UpdateCommand.Connection = conn;
                    adpDet11.InsertCommand.Connection = conn;
                    adpDet11.DeleteCommand.Connection = conn;

                    adpDet11.SelectCommand.CommandTimeout = 0;
                    adpDet11.UpdateCommand.CommandTimeout = 0;
                    adpDet11.InsertCommand.CommandTimeout = 0;
                    adpDet11.DeleteCommand.CommandTimeout = 0;
                }
                if (adpDet12 != null)
                {
                    adpDet12.SelectCommand.Connection = conn;
                    adpDet12.UpdateCommand.Connection = conn;
                    adpDet12.InsertCommand.Connection = conn;
                    adpDet12.DeleteCommand.Connection = conn;

                    adpDet12.SelectCommand.CommandTimeout = 0;
                    adpDet12.UpdateCommand.CommandTimeout = 0;
                    adpDet12.InsertCommand.CommandTimeout = 0;
                    adpDet12.DeleteCommand.CommandTimeout = 0;
                }
                if (adpDet13 != null)
                {
                    adpDet13.SelectCommand.Connection = conn;
                    adpDet13.UpdateCommand.Connection = conn;
                    adpDet13.InsertCommand.Connection = conn;
                    adpDet13.DeleteCommand.Connection = conn;

                    adpDet13.SelectCommand.CommandTimeout = 0;
                    adpDet13.UpdateCommand.CommandTimeout = 0;
                    adpDet13.InsertCommand.CommandTimeout = 0;
                    adpDet13.DeleteCommand.CommandTimeout = 0;
                }
                if (adpDet14 != null)
                {
                    adpDet14.SelectCommand.Connection = conn;
                    adpDet14.UpdateCommand.Connection = conn;
                    adpDet14.InsertCommand.Connection = conn;
                    adpDet14.DeleteCommand.Connection = conn;

                    adpDet14.SelectCommand.CommandTimeout = 0;
                    adpDet14.UpdateCommand.CommandTimeout = 0;
                    adpDet14.InsertCommand.CommandTimeout = 0;
                    adpDet14.DeleteCommand.CommandTimeout = 0;
                }
                if (adpDet15 != null)
                {
                    adpDet15.SelectCommand.Connection = conn;
                    adpDet15.UpdateCommand.Connection = conn;
                    adpDet15.InsertCommand.Connection = conn;
                    adpDet15.DeleteCommand.Connection = conn;

                    adpDet15.SelectCommand.CommandTimeout = 0;
                    adpDet15.UpdateCommand.CommandTimeout = 0;
                    adpDet15.InsertCommand.CommandTimeout = 0;
                    adpDet15.DeleteCommand.CommandTimeout = 0;
                }
                if (adpLst1 != null)
                {
                    if(form_type != 2)
                    {
                        adpLst1.UpdateCommand.Connection = conn;
                        adpLst1.InsertCommand.Connection = conn;
                        adpLst1.DeleteCommand.Connection = conn;

                        adpLst1.UpdateCommand.CommandTimeout = 0;
                        adpLst1.InsertCommand.CommandTimeout = 0;
                        adpLst1.DeleteCommand.CommandTimeout = 0;

                    }
                    adpLst1.SelectCommand.Connection = conn;
                    adpLst1.SelectCommand.CommandTimeout = 0;
                }
            }
            catch(Exception ex)
            {
                if (System.Diagnostics.Debugger.IsAttached)
                    MessageBox.Show(String.Format("CRUD Setup Connection Failed. >> Message:{0} \n >> Stack Trace:{1} \n >> Inner Exception:{2} \n >> Target Site:{3}", ex.Message, ex.StackTrace, ex.InnerException, ex.TargetSite));
                else
                    MessageBox.Show(String.Format("CRUD Setup Connection Failed. >> Message:{0}", ex.Message));
            }
        }
        public void RefreshTables()
        {
            try
            {
                string query = string.Empty;
                string errMsg = string.Empty;
                if(adpHdr != null)
                {
                    tblHdr.Clear();
                    qlib.RefreshTable(tblHdr.TableName, out query, out errMsg);
                    if (!String.IsNullOrEmpty(query) || String.IsNullOrEmpty(errMsg))
                    {
                        adpHdr.SelectCommand.CommandText = query;
                        adpHdr.Fill(tblHdr);
                    }
                }
                if (adpDet1 != null)
                {
                    tblDet1.Clear();
                    qlib.RefreshTable(tblDet1.TableName, out query, out errMsg);
                    if (!String.IsNullOrEmpty(query) || String.IsNullOrEmpty(errMsg))
                    {
                        adpDet1.SelectCommand.CommandText = query;
                        adpDet1.Fill(tblDet1);
                    }
                }
                if (adpDet2 != null)
                {
                    tblDet2.Clear();
                    qlib.RefreshTable(tblDet2.TableName, out query, out errMsg);
                    if (!String.IsNullOrEmpty(query) || String.IsNullOrEmpty(errMsg))
                    {
                        adpDet2.SelectCommand.CommandText = query;
                        adpDet2.Fill(tblDet2);
                    }
                }
                if (adpDet3 != null)
                {
                    tblDet3.Clear();
                    qlib.RefreshTable(tblDet3.TableName, out query, out errMsg);
                    if (!String.IsNullOrEmpty(query) || String.IsNullOrEmpty(errMsg))
                    {
                        adpDet3.SelectCommand.CommandText = query;
                        adpDet3.Fill(tblDet3);
                    }
                }
                if (adpDet4 != null)
                {
                    tblDet4.Clear();
                    qlib.RefreshTable(tblDet4.TableName, out query, out errMsg);
                    if (!String.IsNullOrEmpty(query) || String.IsNullOrEmpty(errMsg))
                    {
                        adpDet4.SelectCommand.CommandText = query;
                        adpDet4.Fill(tblDet4);
                    }
                }
                if (adpDet5 != null)
                {
                    tblDet5.Clear();
                    qlib.RefreshTable(tblDet5.TableName, out query, out errMsg);
                    if (!String.IsNullOrEmpty(query) || String.IsNullOrEmpty(errMsg))
                    {
                        adpDet5.SelectCommand.CommandText = query;
                        adpDet5.Fill(tblDet5);
                    }
                }
                if (adpDet6 != null)
                {
                    tblDet6.Clear();
                    qlib.RefreshTable(tblDet6.TableName, out query, out errMsg);
                    if (!String.IsNullOrEmpty(query) || String.IsNullOrEmpty(errMsg))
                    {
                        adpDet6.SelectCommand.CommandText = query;
                        adpDet6.Fill(tblDet6);
                    }
                }
                if (adpDet7 != null)
                {
                    tblDet7.Clear();
                    qlib.RefreshTable(tblDet7.TableName, out query, out errMsg);
                    if (!String.IsNullOrEmpty(query) || String.IsNullOrEmpty(errMsg))
                    {
                        adpDet7.SelectCommand.CommandText = query;
                        adpDet7.Fill(tblDet7);
                    }
                }
                if (adpDet8 != null)
                {
                    tblDet8.Clear();
                    qlib.RefreshTable(tblDet8.TableName, out query, out errMsg);
                    if (!String.IsNullOrEmpty(query) || String.IsNullOrEmpty(errMsg))
                    {
                        adpDet8.SelectCommand.CommandText = query;
                        adpDet8.Fill(tblDet8);
                    }
                }
                if (adpDet9 != null)
                {
                    tblDet9.Clear();
                    qlib.RefreshTable(tblDet9.TableName, out query, out errMsg);
                    if (!String.IsNullOrEmpty(query) || String.IsNullOrEmpty(errMsg))
                    {
                        adpDet9.SelectCommand.CommandText = query;
                        adpDet9.Fill(tblDet9);
                    }
                }
                if (adpDet10 != null)
                {
                    tblDet10.Clear();
                    qlib.RefreshTable(tblDet10.TableName, out query, out errMsg);
                    if (!String.IsNullOrEmpty(query) || String.IsNullOrEmpty(errMsg))
                    {
                        adpDet10.SelectCommand.CommandText = query;
                        adpDet10.Fill(tblDet10);
                    }
                }
                if (adpDet11 != null)
                {
                    tblDet11.Clear();
                    qlib.RefreshTable(tblDet11.TableName, out query, out errMsg);
                    if (!String.IsNullOrEmpty(query) || String.IsNullOrEmpty(errMsg))
                    {
                        adpDet11.SelectCommand.CommandText = query;
                        adpDet11.Fill(tblDet11);
                    }
                }
                if (adpDet12 != null)
                {
                    tblDet12.Clear();
                    qlib.RefreshTable(tblDet12.TableName, out query, out errMsg);
                    if (!String.IsNullOrEmpty(query) || String.IsNullOrEmpty(errMsg))
                    {
                        adpDet12.SelectCommand.CommandText = query;
                        adpDet12.Fill(tblDet12);
                    }
                }
                if (adpDet13 != null)
                {
                    tblDet13.Clear();
                    qlib.RefreshTable(tblDet13.TableName, out query, out errMsg);
                    if (!String.IsNullOrEmpty(query) || String.IsNullOrEmpty(errMsg))
                    {
                        adpDet13.SelectCommand.CommandText = query;
                        adpDet13.Fill(tblDet13);
                    }
                }
                if (adpDet14 != null)
                {
                    tblDet14.Clear();
                    qlib.RefreshTable(tblDet14.TableName, out query, out errMsg);
                    if (!String.IsNullOrEmpty(query) || String.IsNullOrEmpty(errMsg))
                    {
                        adpDet14.SelectCommand.CommandText = query;
                        adpDet14.Fill(tblDet14);
                    }
                }
                if (adpDet15 != null)
                {
                    tblDet15.Clear();
                    qlib.RefreshTable(tblDet15.TableName, out query, out errMsg);
                    if (!String.IsNullOrEmpty(query) || String.IsNullOrEmpty(errMsg))
                    {
                        adpDet15.SelectCommand.CommandText = query;
                        adpDet15.Fill(tblDet15);
                    }
                }
                if (adpLst1 != null)
                {
                    tblLst1.Clear();
                    qlib.RefreshTable(tblLst1.TableName, out query, out errMsg);
                    if (!String.IsNullOrEmpty(query) || String.IsNullOrEmpty(errMsg))
                    {
                        adpLst1.SelectCommand.CommandText = query;
                        adpLst1.Fill(tblLst1);
                    }
                }
            }
            catch (Exception ex)
            {
                if (System.Diagnostics.Debugger.IsAttached)
                    MessageBox.Show(String.Format("Refresh Table Failed. >> Message:{0} \n >> Stack Trace:{1} \n >> Inner Exception:{2} \n >> Target Site:{3}", ex.Message, ex.StackTrace, ex.InnerException, ex.TargetSite));
                else
                    MessageBox.Show(String.Format("Refresh Table Failed. >> Message:{0}", ex.Message));
            }
        }
        public void ValidateEdit()
        {
            try
            {
                if (bsHdr != null)
                    bsHdr.CurrencyManager.EndCurrentEdit();
                if (bsDet1 != null)
                    bsDet1.CurrencyManager.EndCurrentEdit();
                if (bsDet2 != null)
                    bsDet2.CurrencyManager.EndCurrentEdit();
                if (bsDet3 != null)
                    bsDet3.CurrencyManager.EndCurrentEdit();
                if (bsDet4 != null)
                    bsDet4.CurrencyManager.EndCurrentEdit();
                if (bsDet5 != null)
                    bsDet5.CurrencyManager.EndCurrentEdit();
                if (bsDet6 != null)
                    bsDet6.CurrencyManager.EndCurrentEdit();
                if (bsDet7 != null)
                    bsDet7.CurrencyManager.EndCurrentEdit();
                if (bsDet8 != null)
                    bsDet8.CurrencyManager.EndCurrentEdit();
                if (bsDet9 != null)
                    bsDet9.CurrencyManager.EndCurrentEdit();
                if (bsDet10 != null)
                    bsDet10.CurrencyManager.EndCurrentEdit();
                if (bsDet11 != null)
                    bsDet11.CurrencyManager.EndCurrentEdit();
                if (bsDet12 != null)
                    bsDet12.CurrencyManager.EndCurrentEdit();
                if (bsDet13 != null)
                    bsDet13.CurrencyManager.EndCurrentEdit();
                if (bsDet14 != null)
                    bsDet14.CurrencyManager.EndCurrentEdit();
                if (bsDet15 != null)
                    bsDet15.CurrencyManager.EndCurrentEdit();
            }
            catch (Exception ex)
            {
                isSuccess = false;
                if (System.Diagnostics.Debugger.IsAttached)
                    MessageBox.Show(String.Format("Validate Edit Failed. >> Message:{0} \n >> Stack Trace:{1} \n >> Inner Exception:{2} \n >> Target Site:{3}", ex.Message, ex.StackTrace, ex.InnerException, ex.TargetSite));
                else
                    MessageBox.Show(String.Format("Validate Edit Failed. >> Message:{0}", ex.Message));
            }
        }
        public void SaveToDB()
        {
            string errMsg = string.Empty;
            try
            {
                conn.Close();
                using(TransactionScope scope = new TransactionScope())
                {
                    try
                    {
                        conn.Open();

                        if(form_type == 1)
                        {
                            if (adpHdr != null)
                                adpHdr.Update(tblHdr);

                            //Assign the Child Key Foreach Bindingsource rows
                            FillChildKey(out errMsg);
                            if (!isSuccess || !String.IsNullOrEmpty(errMsg))
                            {
                                scope.Dispose();

                                if (System.Diagnostics.Debugger.IsAttached)
                                    MessageBox.Show(errMsg);
                                else
                                    MessageBox.Show(errMsg);
                                return;
                            }

                            if (adpDet1 != null)
                                adpDet1.Update(tblDet1);
                            if (adpDet2 != null)
                                adpDet2.Update(tblDet2);
                            if (adpDet3 != null)
                                adpDet3.Update(tblDet3);
                            if (adpDet4 != null)
                                adpDet4.Update(tblDet4);
                            if (adpDet5 != null)
                                adpDet5.Update(tblDet5);
                            if (adpDet6 != null)
                                adpDet6.Update(tblDet6);
                            if (adpDet7 != null)
                                adpDet7.Update(tblDet7);
                            if (adpDet8 != null)
                                adpDet8.Update(tblDet8);
                            if (adpDet9 != null)
                                adpDet9.Update(tblDet9);
                            if (adpDet10 != null)
                                adpDet10.Update(tblDet10);
                            if (adpDet11 != null)
                                adpDet11.Update(tblDet11);
                            if (adpDet12 != null)
                                adpDet12.Update(tblDet12);
                            if (adpDet13 != null)
                                adpDet13.Update(tblDet13);
                            if (adpDet14 != null)
                                adpDet14.Update(tblDet14);
                            if (adpDet15 != null)
                                adpDet15.Update(tblDet15);
                        }
                        else
                        {
                            if (adpLst1 != null)
                                adpLst1.Update(tblLst1);
                        }

                       
                        
                        scope.Complete();
                    }
                    catch(Exception ex)
                    {
                        isSuccess = false;
                        scope.Dispose();

                        if (System.Diagnostics.Debugger.IsAttached)
                            MessageBox.Show(String.Format("Save Record Failed. >> Message:{0} \n >> Stack Trace:{1} \n >> Inner Exception:{2} \n >> Target Site:{3}", ex.Message, ex.StackTrace, ex.InnerException, ex.TargetSite));
                        else
                            MessageBox.Show(String.Format("Save Record Failed. >> Message:{0}", ex.Message));
                    }
                }
            }
            catch (Exception ex)
            {
                isSuccess = false;
                if (conn.State == ConnectionState.Open)
                    conn.Close();

                if (System.Diagnostics.Debugger.IsAttached)
                    MessageBox.Show(String.Format("Save Record Failed. >> Message:{0} \n >> Stack Trace:{1} \n >> Inner Exception:{2} \n >> Target Site:{3}", ex.Message, ex.StackTrace, ex.InnerException, ex.TargetSite));
                else
                    MessageBox.Show(String.Format("Save Record Failed. >> Message:{0}", ex.Message));
            }
        }
        public void FillChildKey(out string errMsg)
        {
            errMsg = string.Empty;
            try
            {
                DataRowView drvHdr = (DataRowView)bsHdr.CurrencyManager.Current;
                if (bsDet1 != null)
                {
                    foreach(DataRowView drvDet1 in bsDet1.CurrencyManager.List)
                    {
                        if (!String.IsNullOrEmpty(_keyField))
                            drvDet1[_keyField] = drvHdr[_keyField];
                    }
                }
                if (bsDet2 != null)
                {
                    foreach (DataRowView drvDet2 in bsDet2.CurrencyManager.List)
                    {
                        if (!String.IsNullOrEmpty(_keyField))
                            drvDet2[_keyField] = drvHdr[_keyField];
                    }
                }
                if (bsDet3 != null)
                {
                    foreach (DataRowView drvDet3 in bsDet3.CurrencyManager.List)
                    {
                        if (!String.IsNullOrEmpty(_keyField))
                            drvDet3[_keyField] = drvHdr[_keyField];
                    }
                }
                if (bsDet4 != null)
                {
                    foreach (DataRowView drvDet4 in bsDet4.CurrencyManager.List)
                    {
                        if (!String.IsNullOrEmpty(_keyField))
                            drvDet4[_keyField] = drvHdr[_keyField];
                    }
                }
                if (bsDet5 != null)
                {
                    foreach (DataRowView drvDet5 in bsDet5.CurrencyManager.List)
                    {
                        if (!String.IsNullOrEmpty(_keyField))
                            drvDet5[_keyField] = drvHdr[_keyField];
                    }
                }
                if (bsDet6 != null)
                {
                    foreach (DataRowView drvDet6 in bsDet6.CurrencyManager.List)
                    {
                        if (!String.IsNullOrEmpty(_keyField))
                            drvDet6[_keyField] = drvHdr[_keyField];
                    }
                }
                if (bsDet7 != null)
                {
                    foreach (DataRowView drvDet7 in bsDet7.CurrencyManager.List)
                    {
                        if (!String.IsNullOrEmpty(_keyField))
                            drvDet7[_keyField] = drvHdr[_keyField];
                    }
                }
                if (bsDet8 != null)
                {
                    foreach (DataRowView drvDet8 in bsDet8.CurrencyManager.List)
                    {
                        if (!String.IsNullOrEmpty(_keyField))
                            drvDet8[_keyField] = drvHdr[_keyField];
                    }
                }
                if (bsDet9 != null)
                {
                    foreach (DataRowView drvDet9 in bsDet9.CurrencyManager.List)
                    {
                        if (!String.IsNullOrEmpty(_keyField))
                            drvDet9[_keyField] = drvHdr[_keyField];
                    }
                }
                if (bsDet10 != null)
                {
                    foreach (DataRowView drvDet10 in bsDet10.CurrencyManager.List)
                    {
                        if (!String.IsNullOrEmpty(_keyField))
                            drvDet10[_keyField] = drvHdr[_keyField];
                    }
                }
                if (bsDet11 != null)
                {
                    foreach (DataRowView drvDet11 in bsDet11.CurrencyManager.List)
                    {
                        if (!String.IsNullOrEmpty(_keyField))
                            drvDet11[_keyField] = drvHdr[_keyField];
                    }
                }
                if (bsDet12 != null)
                {
                    foreach (DataRowView drvDet12 in bsDet12.CurrencyManager.List)
                    {
                        if (!String.IsNullOrEmpty(_keyField))
                            drvDet12[_keyField] = drvHdr[_keyField];
                    }
                }
                if (bsDet13 != null)
                {
                    foreach (DataRowView drvDet13 in bsDet13.CurrencyManager.List)
                    {
                        if (!String.IsNullOrEmpty(_keyField))
                            drvDet13[_keyField] = drvHdr[_keyField];
                    }
                }
                if (bsDet14 != null)
                {
                    foreach (DataRowView drvDet14 in bsDet14.CurrencyManager.List)
                    {
                        if (!String.IsNullOrEmpty(_keyField))
                            drvDet14[_keyField] = drvHdr[_keyField];
                    }
                }
                if (bsDet15 != null)
                {
                    foreach (DataRowView drvDet15 in bsDet15.CurrencyManager.List)
                    {
                        if (!String.IsNullOrEmpty(_keyField))
                            drvDet15[_keyField] = drvHdr[_keyField];
                    }
                }
            }
            catch(Exception ex)
            {
                isSuccess = false;
                if (System.Diagnostics.Debugger.IsAttached)
                {
                    errMsg = String.Format("Filling Child Key Failed. >> Message:{0} \n >> Stack Trace:{1} \n >> Inner Exception:{2} \n >> Target Site:{3}", ex.Message, ex.StackTrace, ex.InnerException, ex.TargetSite);
                    MessageBox.Show(errMsg);
                }
                else
                {
                    errMsg = String.Format("Filling Child Key Failed. >> Message:{0}", ex.Message);
                    MessageBox.Show(errMsg);
                }
            }
        }
        public void ClearTheForm()
        {
            try
            {
                if(tblHdr != null)
                    tblHdr.Clear();
                if(tblDet1 != null)
                    tblDet1.Clear();
                if (tblDet2 != null)
                    tblDet2.Clear();
                if (tblDet3 != null)
                    tblDet3.Clear();
                if (tblDet4 != null)
                    tblDet4.Clear();
                if (tblDet5 != null)
                    tblDet5.Clear();
                if (tblDet6 != null)
                    tblDet6.Clear();
                if (tblDet7 != null)
                    tblDet7.Clear();
                if (tblDet8 != null)
                    tblDet8.Clear();
                if (tblDet9 != null)
                    tblDet9.Clear();
                if (tblDet10 != null)
                    tblDet10.Clear();
                if (tblDet11 != null)
                    tblDet11.Clear();
                if (tblDet12 != null)
                    tblDet12.Clear();
                if (tblDet13 != null)
                    tblDet13.Clear();
                if (tblDet14 != null)
                    tblDet14.Clear();
                if (tblDet15 != null)
                    tblDet15.Clear();
                if (tblLst1 != null)
                    tblLst1.Clear();
            }
            catch (Exception ex)
            {
                if (System.Diagnostics.Debugger.IsAttached)
                    MessageBox.Show(String.Format("Form Cleaning Failed. >> Message:{0} \n >> Stack Trace:{1} \n >> Inner Exception:{2} \n >> Target Site:{3}", ex.Message, ex.StackTrace, ex.InnerException, ex.TargetSite));
                else
                    MessageBox.Show(String.Format("Form Cleaning Failed. >> Message:{0}", ex.Message));
            }
        }
    }
}
