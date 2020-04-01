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
    public partial class ManageAdminSalarydetail : Form
    {
        public ManageAdminSalarydetail()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string stID, stName, stBasicSalary, stLeaves, stArrears, stAttendance, stTotalSalary, stDeductedAmount;

            stID = txtaid.Text;
            stName = txtaname.Text;
            stBasicSalary = txtabs.Text;
            stLeaves = txtalee.Text;
            stArrears = txtarry.Text;
            stAttendance = txtaatt.Text;
            stTotalSalary = txtats.Text;
            stDeductedAmount = txtada.Text;

            MySqlConnection sqlCon = null;
            string connection;
            connection = "server =127.0.0.1;database =payrollmanagments; user =root;Sslmode= none";

            sqlCon = new MySqlConnection(connection);
            sqlCon.Open();

            MySqlCommand command;
            command = new MySqlCommand(@"INSERT INTO admimsalarydetails(AdminID,Name,Basicsalary,Leaves,Arrears,Attendance,TotalSalary,DeductedAmount)value('" + stID + "','" + stName + "','" + stBasicSalary + "','" + stLeaves + "','" + stArrears + "','" + stAttendance + "','" + stTotalSalary + "','" + stDeductedAmount + "')", sqlCon);
            command.ExecuteNonQuery();
            MessageBox.Show("Adding New sallary detaila are successful");
        }

        private void btneddit_Click(object sender, EventArgs e)
        {
            string stID, stName, stBasicSalary, stLeaves, stArrears, stAttendance, stTotalSalary, stDeductedAmount;

            stID = txtaid.Text;
            stName = txtaname.Text;
            stBasicSalary = txtabs.Text;
            stLeaves = txtalee.Text;
            stArrears = txtarry.Text;
            stAttendance = txtaatt.Text;
            stTotalSalary = txtats.Text;
            stDeductedAmount = txtada.Text;

            MySqlConnection sqlCon = null;
            string connection;
            connection = "server =127.0.0.1;database =payrollmanagments; user =root;Sslmode= none";

            sqlCon = new MySqlConnection(connection);
            sqlCon.Open();

            MySqlCommand command;
            command = new MySqlCommand(@"UPDATE  admimsalarydetails SET Name='" + stName + "',BasicSalary='" + stBasicSalary + "',Leaves='" + stLeaves + "',Arrears='" + stArrears + "',TotalSalary='" + stTotalSalary + "',deductedAmount='" + stDeductedAmount + "' WHERE AdminID='" + stID + "'", sqlCon);
            command.ExecuteNonQuery();
            MessageBox.Show("Edding is succesfull");
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            string stID;
            stID = txtaid.Text;

            MySqlConnection sqlCon = null;
            string connection;
            connection = "server =127.0.0.1;database =payrollmanagments; user =root;Sslmode= none";

            sqlCon = new MySqlConnection(connection);
            sqlCon.Open();

            MySqlCommand command;
            MySqlDataReader reader;
            command = new MySqlCommand(@"SELECT * FROM  admimsalarydetails WHERE AdminID ='" + stID + "'", sqlCon);
            reader = command.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                string AdminName, AdminBasicSalary, AdminLeaves, AdminArrears, AdminAttendance, AdminTotalSalary, AdminDeductedAmount;

                AdminName = reader.GetString(1);
                AdminBasicSalary = reader.GetString(2);
                AdminLeaves = reader.GetString(3);
                AdminArrears = reader.GetString(4);
                AdminAttendance = reader.GetString(5);
                AdminTotalSalary = reader.GetString(6);
                AdminDeductedAmount = reader.GetString(7);


                txtaname.Text = AdminName;
                txtabs.Text = AdminBasicSalary;
                txtalee.Text = AdminLeaves;
                txtarry.Text = AdminArrears;
                txtaatt.Text = AdminAttendance;
                txtats.Text = AdminTotalSalary;
                txtada.Text = AdminDeductedAmount;


            }
            else
            {
                MessageBox.Show("Invalid ID!");

            }

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string stID, stName, stBasicSalary, stLeaves, stArrears, stAttendance, stTotalSalary, stDeductedAmount;

            stID = txtaid.Text;
            stName = txtaname.Text;
            stBasicSalary = txtabs.Text;
            stLeaves = txtalee.Text;
            stArrears = txtarry.Text;
            stAttendance = txtaatt.Text;
            stTotalSalary = txtats.Text;
            stDeductedAmount = txtada.Text;

            MySqlConnection sqlCon = null;
            string connection;
            connection = "server =127.0.0.1;database =payrollmanagments; user =root;Sslmode= none";

            sqlCon = new MySqlConnection(connection);
            sqlCon.Open();

            MySqlCommand command;
            command = new MySqlCommand(@"DELETE FROM   admimsalarydetails WHERE AdminID ='" + stID + "'", sqlCon);
            command.ExecuteNonQuery();
            MessageBox.Show("Deleting Salary Details");
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
             txtaid.Clear();
             txtaname.Clear();
             txtabs.Clear();
             txtalee.Clear();
             txtarry.Clear();
             txtaatt.Clear();
             txtats.Clear();
             txtada.Clear();
        }

        private void btnack_Click(object sender, EventArgs e)
        {
            this.Hide();
            HR ss = new HR();
            ss.Show();
        }
    
    }
}
