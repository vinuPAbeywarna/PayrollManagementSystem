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
    public partial class viewEmployeeDetail : Form
    {
        public viewEmployeeDetail()
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
            Employee ss = new Employee();
            ss.Show();
        }
    }
}
