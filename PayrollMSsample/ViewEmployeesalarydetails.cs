using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PayrollMSsample
{
    public partial class ViewEmployeesalarydetails : Form
    {
        public ViewEmployeesalarydetails()
        {
            InitializeComponent();
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            string stID;
            stID = txtid.Text;

            MySqlConnection sqlCon = null;
            string connection;
            connection = "server =127.0.0.1;database =payrollmanagments; user =root;Sslmode= none";

            sqlCon = new MySqlConnection(connection);
            sqlCon.Open();

            MySqlCommand command;
            MySqlDataReader reader;
            command = new MySqlCommand(@"SELECT * FROM employeesalarydetails WHERE EmployeeId ='" + stID + "'", sqlCon);
            reader = command.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                string EmpName, EmpBasicSalary, EmpLeaves, EmpArrears, EmpAttendance, EmpTotalSalary, EmpDeductedAmount;

                EmpName = reader.GetString(1);
                EmpBasicSalary = reader.GetString(2);
                EmpLeaves = reader.GetString(3);
                EmpArrears = reader.GetString(4);
                EmpAttendance = reader.GetString(5);
                EmpTotalSalary = reader.GetString(6);
                EmpDeductedAmount = reader.GetString(7);


                txtname.Text = EmpName;
                txtbs.Text = EmpBasicSalary;
                txtleaves.Text = EmpLeaves;
                txtarry.Text = EmpArrears;
                txtatt.Text = EmpAttendance;
                txttos.Text = EmpTotalSalary;
                txtamount.Text = EmpDeductedAmount;


            }
            else
            {
                MessageBox.Show("Invalid ID!");

            }


        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtbs.Clear();
            txtleaves.Clear();
            txtarry.Clear();
            txtatt.Clear();
            txttos.Clear();
            txtamount.Clear();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee ss = new Employee();
            ss.Show();
        }
    }
}
