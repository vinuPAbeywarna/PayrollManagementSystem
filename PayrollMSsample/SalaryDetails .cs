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
    public partial class SalaryDetails : Form
    {
        public SalaryDetails()
        {
            InitializeComponent();
        }

        private void btnemsalarydetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewEmployeesalarydetails ss = new ViewEmployeesalarydetails();
            ss.Show();
        }

        private void btnhrsalarydetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageHRsalarydetail ss = new ManageHRsalarydetail();
            ss.Show();
        }

        private void btnadminslrydetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewAdminsalarydetails ss = new ViewAdminsalarydetails();
            ss.Show();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            SystemAdminPage ss = new SystemAdminPage();
            ss.Show();
        }
    }
}
