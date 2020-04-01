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
    public partial class ViewAdminsalarydetails : Form
    {
        public ViewAdminsalarydetails()
        {
            InitializeComponent();
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

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalaryDetails ss = new SalaryDetails();
            ss.Show();
        }
    }
}
