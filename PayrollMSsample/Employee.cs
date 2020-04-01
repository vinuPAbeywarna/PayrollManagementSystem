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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void btnviewedetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewEmployeeDetail ss = new viewEmployeeDetail();
            ss.Show();
        }

        private void btnviewsdetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewEmployeesalarydetails ss = new ViewEmployeesalarydetails();
            ss.Show();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
