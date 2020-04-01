using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollMSsample
{
    public partial class HR : Form
    {
        public HR()
        {
            InitializeComponent();
        }

        private void btnmngeemsalarydetail_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagrEmployeeSalaycs ss = new ManagrEmployeeSalaycs();
            ss.Show();
        }

        private void btnviewhrsdetail_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewHRSalarydetails ss = new ViewHRSalarydetails();
            ss.Show();
        }

        private void btnviewhrdetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewHRDetails ss = new ViewHRDetails();
            ss.Show();
        }

        private void btnmngadminsdetail_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageAdminSalarydetail ss = new ManageAdminSalarydetail();
            ss.Show();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
