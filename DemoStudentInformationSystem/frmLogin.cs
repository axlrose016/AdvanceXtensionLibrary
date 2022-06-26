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
    public partial class frmLogin : Form
    {
        public int userId { get; set; }
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = string.Empty;
            //Guid uId = new Guid("00000000-0000-0000-0000-000000000000");
            int uId = -1;
            axl_guard.login_axl_security("Data Source=localhost\\mssqlserver2017;Initial Catalog=DemoCRUDUC;User ID=sa;Password=p@ssw0rd;", "axl_security", "username", "user_Id", textBox1.Text, textBox2.Text, out username, out uId);
            if (String.IsNullOrEmpty(username))
            {
                MessageBox.Show("Invalid Credentials, Please try again.", "System Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                userId = uId;
                this.Close();
            }
        }
    }
}
