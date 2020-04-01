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
    public partial class manageEmployeedatails : Form
    {
        public manageEmployeedatails()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string stID, stNAme, stPassword, stAddress, stTeleNo, stAge, stBasicSalary, stattendance, stEnterd;

            stID = txtid.Text;
            stNAme = txtname.Text;
            stPassword = txtpass.Text;
            stAddress = txtadd.Text;
            stTeleNo = txttn.Text;
            stAge = txtage.Text;
            stBasicSalary = txtbs.Text;
            stattendance = txtatt.Text;
            stEnterd = txtdate.Text;

            MySqlConnection sqlCon = null;
            string connection;
            connection = "server =127.0.0.1;database =payrollmanagments; user =root;Sslmode= none";

            sqlCon = new MySqlConnection(connection);
            sqlCon.Open();

            MySqlCommand command;
            command = new MySqlCommand(@"INSERT INTO employee(EmployeeId,EmployeeName,Password,Address,TeleNo,Age,Basicsalary,Attendance,Enterddate)value('" + stID + "','" + stNAme + "','" + stPassword + "','" + stAddress + "','" + stTeleNo + "','" + stAge + "','" + stBasicSalary + "','" + stattendance + "','" + stEnterd + "')", sqlCon);
            command.ExecuteNonQuery();
            MessageBox.Show("Adding New Employee is succesfull");

        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            string stID, stNAme, stPassword, stAddress, stTeleNo, stAge, stBasicSalary, stattendance, stEnterd;

            stID = txtid.Text;
            stNAme = txtname.Text;
            stPassword = txtpass.Text;
            stAddress = txtadd.Text;
            stTeleNo = txttn.Text;
            stAge = txtage.Text;
            stBasicSalary = txtbs.Text;
            stattendance = txtatt.Text;
            stEnterd = txtdate.Text;

            MySqlConnection sqlCon = null;
            string connection;
            connection = "server =127.0.0.1;database =payrollmanagments; user =root;Sslmode= none";

            sqlCon = new MySqlConnection(connection);
            sqlCon.Open();

            MySqlCommand command;
            command = new MySqlCommand(@"UPDATE employee SET EmployeeName='" + stNAme + "',Password='" + stPassword + "',Address='" + stAddress + "',TeleNo='" + stTeleNo + "',Age='" + stAge + "',Basicsalary='" + stBasicSalary + "',Attendance='" + stattendance + "',Enterddate='" + stEnterd + "' WHERE EmployeeId='" + stID + "'", sqlCon);
            command.ExecuteNonQuery();
            MessageBox.Show("Editing is succesfull");

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

            command = new MySqlCommand(@"SELECT * FROM  employee WHERE EmployeeId ='" + stID + "'", sqlCon);
            reader = command.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                string EmpNAme, EmpPassword, EmpAddress, EmpTeleNo, EmpAge, EmpBasicSalary, Empattendance, EmpEnterd;

                EmpNAme = reader.GetString(1);
                EmpPassword = reader.GetString(2);
                EmpAddress = reader.GetString(3);
                EmpTeleNo = reader.GetString(4);
                EmpAge = reader.GetString(5);
                EmpBasicSalary = reader.GetString(6);
                Empattendance = reader.GetString(7);
                EmpEnterd = reader.GetString(8);

                txtname.Text = EmpNAme;
                txtpass.Text = EmpPassword;
                txtadd.Text = EmpAddress;
                txttn.Text = EmpTeleNo;
                txtage.Text = EmpAge;
                txtbs.Text = EmpBasicSalary;
                txtatt.Text = Empattendance;
                txtdate.Text = EmpEnterd;

            }
            else
            {
                MessageBox.Show("Invalid ID!");
            }

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string stID, stNAme, stPassword, stAddress, stTeleNo, stAge, stBasicSalary, stattendance, stEnterd;

            stID = txtid.Text;
            stNAme = txtname.Text;
            stPassword = txtpass.Text;
            stAddress = txtadd.Text;
            stTeleNo = txttn.Text;
            stAge = txtage.Text;
            stBasicSalary = txtbs.Text;
            stattendance = txtatt.Text;
            stEnterd = txtdate.Text;

            MySqlConnection sqlCon = null;
            string connection;
            connection = "server =127.0.0.1;database =payrollmanagments; user =root;Sslmode= none";

            sqlCon = new MySqlConnection(connection);
            sqlCon.Open();

            MySqlCommand command;
            command = new MySqlCommand(@"DELETE FROM employee WHERE EmployeeId ='" + stID + "'", sqlCon);
            command.ExecuteNonQuery();
            MessageBox.Show("Deteting is successful");
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtid.Clear();
            txtname.Clear();
            txtpass.Clear();
            txtadd.Clear();
            txttn.Clear();
            txtage.Clear();
            txtbs.Clear();
            txtatt.Clear();
            txtdate.Clear();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            SystemAdminPage ss = new SystemAdminPage();
            ss.Show();
        }
    }
}
