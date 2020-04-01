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
    public partial class ViewHRDetails : Form
    {
        public ViewHRDetails()
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

            command = new MySqlCommand(@"SELECT * FROM  hr WHERE HRID ='" + stID + "'", sqlCon);
            reader = command.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                string HrNAme, HrPassword, HrAddress, HrTeleNo, HrAge, HrBasicSalary, Hrattendance, HrEnterd;

                HrNAme = reader.GetString(1);
                HrPassword = reader.GetString(2);
                HrAddress = reader.GetString(3);
                HrTeleNo = reader.GetString(4);
                HrAge = reader.GetString(5);
                HrBasicSalary = reader.GetString(6);
                Hrattendance = reader.GetString(7);
                HrEnterd = reader.GetString(8);

                txthname.Text = HrNAme;
                txthpsaa.Text = HrPassword;
                txthadd.Text = HrAddress;
                txthtn.Text = HrTeleNo;
                txthage.Text = HrAge;
                txthbs.Text = HrBasicSalary;
                txthatt.Text = Hrattendance;
                txthed.Text = HrEnterd;
            }
            else
            {
                MessageBox.Show("Invalid ID!");
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {

            txthname.Clear();
            txthpsaa.Clear();
            txthadd.Clear();
            txthtn.Clear();
            txthage.Clear();
            txthbs.Clear();
            txthatt.Clear();
            txthed.Clear();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            HR ss = new HR();
            ss.Show();
        }
    }
}
