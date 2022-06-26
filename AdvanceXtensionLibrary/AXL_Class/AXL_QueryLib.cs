using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceXtensionLibrary.AXL_Class
{
    public class AXL_QueryLib
    {
        public void RefreshTable(string tblName, out string query, out string errMsg)
        {
            errMsg = string.Empty;
            query = string.Empty;
            try
            {
                query = String.Format("SELECT * FROM dbo.{0}", tblName);
            }
            catch (Exception ex)
            {
                if (System.Diagnostics.Debugger.IsAttached)
                    errMsg = String.Format("Refresh Query Failed. >> Message:{0} \n >> Stack Trace:{1} \n >> Inner Exception:{2} \n >> Target Site:{3}", ex.Message, ex.StackTrace, ex.InnerException, ex.TargetSite);
                else
                    errMsg = String.Format("Refresh Query Failed. >> Message:{0}", ex.Message);
            }
            
        }
    }
}
