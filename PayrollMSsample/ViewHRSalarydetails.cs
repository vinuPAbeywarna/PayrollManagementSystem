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
    public partial class ViewHRSalarydetails : Form
    {
        public ViewHRSalarydetails()
        {
            InitializeComponent();
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
                txtharry.Text = HRArrears;
                txthatt.Text = HRAttendance;
                txthbs.Text = HRTotalSalary;
                txthamount.Text = HRDeductedAmount;


            }
            else
            {
                MessageBox.Show("Invalid ID!");

            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txthname.Clear();
            txthbs.Clear();
            txthlee.Clear();
            txtharry.Clear();
            txthatt.Clear();
            txthbs.Clear();
            txthamount.Clear();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            HR ss = new HR();
            ss.Show();
        }
    }
}
