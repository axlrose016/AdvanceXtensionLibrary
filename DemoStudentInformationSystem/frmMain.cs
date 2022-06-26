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
    public partial class frmMain : Form
    {
        public string uname { get; set; }
        public int userId { get; set; }
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            using (frmLogin _frm = new frmLogin())
            {
                _frm.ShowDialog();
                if (_frm.userId > 0)
                    return;
            }

            frmMenu _frmMenu = new frmMenu() { MdiParent = this };
            _frmMenu.Show();
        }
    }
}
