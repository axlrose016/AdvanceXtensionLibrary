using AdvanceXtensionLibrary.AXL_Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoStudentInformationSystem
{
    public partial class frmStudent : Form
    {
        public frmStudent()
        {
            InitializeComponent();
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {
            switch (axL_CRUD_Controller1.record_action)
            {
                case 0:
                    axL_CRUD_Controller1.InitializeHeader();
                    break;
                case 1:
                    break;
                case 2:
                    axL_CRUD_Controller1.ViewRecord();
                    break;
                case 3:
                    break;
                default:
                    break;
            }
        }

        private void axL_CRUD_Controller1_InitializeHeader_After()
        {
            bsDet1.CurrencyManager.AddNew();
            DataRowView drvDet1 = (DataRowView)bsDet1.CurrencyManager.Current;
            drvDet1["user_Id"] = -1;
            bsDet1.CurrencyManager.EndCurrentEdit();
        }

        private void textBox9_Validating(object sender, CancelEventArgs e)
        {
            string salt = axl_guard.generateSalt(10);
            string hash = axl_guard.HashSHA256(textBox9.Text, salt);
            DataRowView drvDet2 = (DataRowView)bsDet1.CurrencyManager.Current;
            drvDet2["salt"] = salt;
            drvDet2["hash_code"] = hash;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
