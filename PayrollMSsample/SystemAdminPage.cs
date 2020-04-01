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
    public partial class SystemAdminPage : Form
    {
        public SystemAdminPage()
        {
            InitializeComponent();
        }

        private void btnManageEm_Click(object sender, EventArgs e)
        {
            this.Hide();
            manageEmployeedatails ss = new manageEmployeedatails();
            ss.Show();
        }

        private void btnmanageHR_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageHRDetails ss = new ManageHRDetails();
            ss.Show();
        }

        private void btnviewslry_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalaryDetails ss = new SalaryDetails();
            ss.Show();
        }

        private void btnmanageHRslry_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageHRsalarydetail ss = new ManageHRsalarydetail();
            ss.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            SystemAdminPage ss = new SystemAdminPage();
            ss.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
