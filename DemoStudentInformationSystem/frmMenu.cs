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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmStudentList _frm = new frmStudentList() { MdiParent = MdiParent};
            _frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmSubject _frm = new frmSubject() { MdiParent = MdiParent };
            _frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmBranch _frm = new frmBranch() { MdiParent = MdiParent };
            _frm.Show();
        }
    }
}
