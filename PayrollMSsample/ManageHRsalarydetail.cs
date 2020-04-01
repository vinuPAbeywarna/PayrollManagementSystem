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
    public partial class ManageHRsalarydetail : Form
    {
        public ManageHRsalarydetail()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string stID, stName, stBasicSalary, stLeaves, stArrears, stAttendance, stTotalSalary, stDeductedAmount;

            stID = txthid.Text;
            stName = txthname.Text;
            stBasicSalary = txthbs.Text;
            stLeaves = txthlee.Text;
            stArrears = txtharr.Text;
            stAttendance = txthatt.Text;
            stTotalSalary = txthts.Text;
            stDeductedAmount = txthamount.Text;

            MySqlConnection sqlCon = null;
            string connection;
            connection = "server =127.0.0.1;database =payrollmanagments; user =root;Sslmode= none";

            sqlCon = new MySqlConnection(connection);
            sqlCon.Open();

            MySqlCommand command;
            command = new MySqlCommand(@"INSERT INTO hrsalarydetail(HRID,Name,Basicsalary,Leaves,Arrears,Attendance,TotalSalary,DeductedAmount)value('" + stID + "','" + stName + "','" + stBasicSalary + "','" + stLeaves + "','" + stArrears + "','" + stAttendance + "','" + stTotalSalary + "','" + stDeductedAmount + "')", sqlCon);
            command.ExecuteNonQuery();
            MessageBox.Show("Adding New sallary detaila are successful");

        }

        private void btnview_Click(object sender, EventArgs e)
        {
            string stID;
            stID = txthid.Text;

            MySqlConnection sqlCon = null;
            string connection;
            connection = "server =127.0.0.1;database =payrollmanagments; user =root;Sslmode= none";

            sqlCon = new MySqlConnection(connection);
            sqlCon.Open();

            MySqlCommand command;
            MySqlDataReader reader;
            command = new MySqlCommand(@"SELECT * FROM hrsalarydetail WHERE HRID ='" + stID + "'", sqlCon);
            reader = command.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                string HRName, HRBasicSalary, HRLeaves, HRArrears, HRAttendance, HRTotalSalary, HRDeductedAmount;

                HRName = reader.GetString(1);
                HRBasicSalary = reader.GetString(2);
                HRLeaves = reader.GetString(3);
                HRArrears = reader.GetString(4);
                HRAttendance = reader.GetString(5);
                HRTotalSalary = reader.GetString(6);
                HRDeductedAmount = reader.GetString(7);


                txthname.Text = HRName;
                txthbs.Text = HRBasicSalary;
                txthlee.Text = HRLeaves;
                txtharr.Text = HRArrears;
                txthatt.Text = HRAttendance;
                txthts.Text = HRTotalSalary;
                txthamount.Text = HRDeductedAmount;


            }
            else
            {
                MessageBox.Show("Invalid ID!");

            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            string stID, stName, stBasicSalary, stLeaves, stArrears, stAttendance, stTotalSalary, stDeductedAmount;

            stID = txthid.Text;
            stName = txthname.Text;
            stBasicSalary = txthbs.Text;
            stLeaves = txthlee.Text;
            stArrears = txtharr.Text;
            stAttendance = txthatt.Text;
            stTotalSalary = txthts.Text;
            stDeductedAmount = txthamount.Text;

            MySqlConnection sqlCon = null;
            string connection;
            connection = "server =127.0.0.1;database =payrollmanagments; user =root;Sslmode= none";

            sqlCon = new MySqlConnection(connection);
            sqlCon.Open();

            MySqlCommand command;
            command = new MySqlCommand(@"UPDATE  hrsalarydetail SET Name='" + stName + "',BasicSalary='" + stBasicSalary + "',Leaves='" + stLeaves + "',Arrears='" + stArrears + "',TotalSalary='" + stTotalSalary + "',deductedAmount='" + stDeductedAmount + "' WHERE HRID='" + stID + "'", sqlCon);
            command.ExecuteNonQuery();
            MessageBox.Show("Edding is succesfull");
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string stID, stName, stBasicSalary, stLeaves, stArrears, stAttendance, stTotalSalary, stDeductedAmount;

            stID = txthid.Text;
            stName = txthname.Text;
            stBasicSalary = txthbs.Text;
            stLeaves = txthlee.Text;
            stArrears = txtharr.Text;
            stAttendance = txthatt.Text;
            stTotalSalary = txthts.Text;
            stDeductedAmount = txthamount.Text;

            MySqlConnection sqlCon = null;
            string connection;
            connection = "server =127.0.0.1;database =payrollmanagments; user =root;Sslmode= none";

            sqlCon = new MySqlConnection(connection);
            sqlCon.Open();

            MySqlCommand command;
            command = new MySqlCommand(@"DELETE FROM hrsalarydetail WHERE HRID='" + stID + "'", sqlCon);
            command.ExecuteNonQuery();
            MessageBox.Show("Deleting Salary Details");
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txthid.Clear();
            txthname.Clear();
            txthbs.Clear();
            txthlee.Clear();
            txtharr.Clear();
            txthatt.Clear();
            txthts.Clear();
            txthamount.Clear();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalaryDetails ss = new SalaryDetails();
            ss.Show();
        }
    }
}
