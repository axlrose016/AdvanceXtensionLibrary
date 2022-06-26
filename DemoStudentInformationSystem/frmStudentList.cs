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
    public partial class frmStudentList : Form
    {
        public frmStudentList()
        {
            InitializeComponent();
        }

        private void frmStudentList_Load(object sender, EventArgs e)
        {
            axL_CRUD_Controller1.connection_string = "Data Source=localhost\\mssqlserver2017;Initial Catalog=DemoCRUDUC;User ID=sa;Password=p@ssw0rd;";
            axL_CRUD_Controller1.record_action = 2;
            axL_CRUD_Controller1.InitializeCRUD();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            int row = Convert.ToInt32(dataGridView1.CurrentRow.Cells["studentIdDataGridViewTextBoxColumn"].Value);
            if(row <= 0)
            {
                MessageBox.Show("No selected record.", "System Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            using(frmStudent _frm = new frmStudent())
            {
                _frm.axL_CRUD_Controller1.connection_string = "Data Source=localhost\\mssqlserver2017;Initial Catalog=DemoCRUDUC;User ID=sa;Password=p@ssw0rd;";
                _frm.axL_CRUD_Controller1._keyVal = Convert.ToString(row);
                _frm.axL_CRUD_Controller1.record_action = 2;
                _frm.axL_CRUD_Controller1.InitializeCRUD();
                _frm.ShowDialog();
            }
        }

        private void axL_CRUD_Controller1_btnRefresh_After(object sender, EventArgs e)
        {
            if (bsList.CurrencyManager.Count <= 0)
                MessageBox.Show("No record found.", "System Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void axL_CRUD_Controller1_btnNew_Before(object sender, EventArgs e)
        {
            try
            {
                using (frmStudent _frm = new frmStudent())
                {
                    _frm.axL_CRUD_Controller1.connection_string = "Data Source=localhost\\mssqlserver2017;Initial Catalog=DemoCRUDUC;User ID=sa;Password=p@ssw0rd;";
                    _frm.axL_CRUD_Controller1.record_action = 0;
                    _frm.axL_CRUD_Controller1.InitializeCRUD();
                    _frm.ShowDialog();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(String.Format("Student List Before New >> Error:{0}", ex.Message));
            }
        }
    }
}
