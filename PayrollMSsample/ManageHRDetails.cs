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
    public partial class ManageHRDetails : Form
    {
        public ManageHRDetails()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string stID, stNAme, stPassword, stAddress, stTeleNo, stAge, stBasicSalary, stattendance, stEnterd;

            stID = txthid.Text;
            stNAme = txthname.Text;
            stPassword = txthpsaa.Text;
            stAddress = txthadd.Text;
            stTeleNo = txthtn.Text;
            stAge = txthage.Text;
            stBasicSalary = txthbs.Text;
            stattendance = txthatt.Text;
            stEnterd = txthed.Text;

            MySqlConnection sqlCon = null;
            string connection;
            connection = "server =127.0.0.1;database =payrollmanagments; user =root;Sslmode= none";

            sqlCon = new MySqlConnection(connection);
            sqlCon.Open();

            MySqlCommand command;
            command = new MySqlCommand(@"INSERT INTO hr(HRID,Name,Password,Address,TeleNo,Age,Basicsalary,Attendance,Entereddate)value('" + stID + "','" + stNAme + "','" + stPassword + "','" + stAddress + "','" + stTeleNo + "','" + stAge + "','" + stBasicSalary + "','" + stattendance + "','" + stEnterd + "')", sqlCon);
            command.ExecuteNonQuery();
            MessageBox.Show("Adding New HR is succesfull");

        }

        private void btneddit_Click(object sender, EventArgs e)
        {
            string stID, stNAme, stPassword, stAddress, stTeleNo, stAge, stBasicSalary, stattendance, stEnterd;

            stID = txthid.Text;
            stNAme = txthname.Text;
            stPassword = txthpsaa.Text;
            stAddress = txthadd.Text;
            stTeleNo = txthtn.Text;
            stAge = txthage.Text;
            stBasicSalary = txthbs.Text;
            stattendance = txthatt.Text;
            stEnterd = txthed.Text;

            MySqlConnection sqlCon = null;
            string connection;
            connection = "server =127.0.0.1;database =payrollmanagments; user =root;Sslmode= none";

            sqlCon = new MySqlConnection(connection);
            sqlCon.Open();

            MySqlCommand command;
            command = new MySqlCommand(@"UPDATE hr SET Name='" + stNAme + "',Password='" + stPassword + "',Address='" + stAddress + "',TeleNo='" + stTeleNo + "',Age='" + stAge + "',Basicsalary='" + stBasicSalary + "',Attendance='" + stattendance + "',Entereddate='" + stEnterd + "' WHERE HRID='" + stID + "'", sqlCon);
            command.ExecuteNonQuery();
            MessageBox.Show("Editing is succesfull");
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

        private void btndelete_Click(object sender, EventArgs e)
        {
            string stID, stNAme, stPassword, stAddress, stTeleNo, stAge, stBasicSalary, stattendance, stEnterd;

            stID = txthid.Text;
            stNAme = txthname.Text;
            stPassword = txthpsaa.Text;
            stAddress = txthadd.Text;
            stTeleNo = txthtn.Text;
            stAge = txthage.Text;
            stBasicSalary = txthbs.Text;
            stattendance = txthatt.Text;
            stEnterd = txthed.Text;

            MySqlConnection sqlCon = null;
            string connection;
            connection = "server =127.0.0.1;database =payrollmanagments; user =root;Sslmode= none";

            sqlCon = new MySqlConnection(connection);
            sqlCon.Open();

            MySqlCommand command;
            command = new MySqlCommand(@"DELETE FROM hr WHERE HRID ='" + stID + "'", sqlCon);
            command.ExecuteNonQuery();
            MessageBox.Show("Deteting is successdul!");
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txthid.Clear();
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
            SystemAdminPage ss = new SystemAdminPage();
            ss.Show();
        }
    }
}
