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
    public partial class ManagrEmployeeSalaycs : Form
    {
        public ManagrEmployeeSalaycs()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string stID, stName, stBasicSalary, stLeaves, stArrears, stAttendance, stTotalSalary, stDeductedAmount;

            stID = txtId.Text;
            stName = txtname.Text;
            stBasicSalary = txtbs.Text;
            stLeaves = txtle.Text;
            stArrears = txtarr.Text;
            stAttendance = txtatt.Text;
            stTotalSalary = txtts.Text;
            stDeductedAmount = txtamount.Text;

            MySqlConnection sqlCon = null;
            string connection;
            connection = "server =127.0.0.1;database =payrollmanagments; user =root;Sslmode= none";

            sqlCon = new MySqlConnection(connection);
            sqlCon.Open();

            MySqlCommand command;
            command = new MySqlCommand(@"INSERT INTO employeesalarydetails(EmployeeId,Name,Basicsalary,Leaves,Arrears,Attendance,TotalSalary,DeductedAmount)value('" + stID + "','" + stName + "','" + stBasicSalary + "','" + stLeaves + "','" + stArrears + "','" + stAttendance + "','" + stTotalSalary + "','" + stDeductedAmount + "')", sqlCon);
            command.ExecuteNonQuery();
            MessageBox.Show("Adding New sallary detaila are successful");
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            string stID;
            stID = txtId.Text;

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
                txtle.Text = EmpLeaves;
                txtarr.Text = EmpArrears;
                txtatt.Text = EmpAttendance;
                txtts.Text = EmpTotalSalary;
                txtamount.Text = EmpDeductedAmount;


            }
            else
            {
                MessageBox.Show("Invalid ID!");

            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            string stID, stName, stBasicSalary, stLeaves, stArrears, stAttendance, stTotalSalary, stDeductedAmount;

            stID = txtId.Text;
            stName = txtname.Text;
            stBasicSalary = txtbs.Text;
            stLeaves = txtle.Text;
            stArrears = txtarr.Text;
            stAttendance = txtatt.Text;
            stTotalSalary = txtts.Text;
            stDeductedAmount = txtamount.Text;

            MySqlConnection sqlCon = null;
            string connection;
            connection = "server =127.0.0.1;database =payrollmanagments; user =root;Sslmode= none";

            sqlCon = new MySqlConnection(connection);
            sqlCon.Open();

            MySqlCommand command;
            command = new MySqlCommand(@"UPDATE employeesalarydetails SET Name='" + stName + "',BasicSalar='" + stBasicSalary + "',Leaves='" + stLeaves + "',Arrears='" + stArrears + "',TotalSalary='" + stTotalSalary + "',deductedAmount='" + stDeductedAmount + "' WHERE EmployeeId='" + stID + "'", sqlCon);
            command.ExecuteNonQuery();
            MessageBox.Show("Edding is succesfull");
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string stID, stName, stBasicSalary, stLeaves, stArrears, stAttendance, stTotalSalary, stDeductedAmount;

            stID = txtId.Text;
            stName = txtname.Text;
            stBasicSalary = txtbs.Text;
            stLeaves = txtle.Text;
            stArrears = txtarr.Text;
            stAttendance = txtatt.Text;
            stTotalSalary = txtts.Text;
            stDeductedAmount = txtamount.Text;

            MySqlConnection sqlCon = null;
            string connection;
            connection = "server =127.0.0.1;database =payrollmanagments; user =root;Sslmode= none";

            sqlCon = new MySqlConnection(connection);
            sqlCon.Open();

            MySqlCommand command;
            command = new MySqlCommand(@"DELETE FROM employeesalarydetail WHERE EmployeeId ='" + stID + "'", sqlCon);
            command.ExecuteNonQuery();
            MessageBox.Show("Deleting Salary Details");
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtname.Clear();
            txtbs.Clear();
            txtle.Clear();
            txtarr.Clear();
            txtatt.Clear();
            txtts.Clear();
            txtamount.Clear();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            HR ss = new HR();
            ss.Show();
        }
    }
}
