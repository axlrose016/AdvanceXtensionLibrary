﻿using System;
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
    public partial class frmSubject : Form
    {
        public frmSubject()
        {
            InitializeComponent();
        }

        private void frmSubject_Load(object sender, EventArgs e)
        {
            axL_CRUD_Controller1.connection_string = "Data Source=localhost\\mssqlserver2017;Initial Catalog=DemoCRUDUC;User ID=sa;Password=p@ssw0rd;";
            axL_CRUD_Controller1.record_action = 2;
            axL_CRUD_Controller1.InitializeCRUD();
        }

        private void axL_CRUD_Controller1_btnRefresh_After(object sender, EventArgs e)
        {
            if (bsDet1.CurrencyManager.Count <= 0)
                MessageBox.Show("No Record Found.", "System Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
