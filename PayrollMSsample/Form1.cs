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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chekpw.Checked)
            {
                txtpw.UseSystemPasswordChar = false;
            }
            else
            {
                txtpw.UseSystemPasswordChar = true;
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string usertype;
            string username;
            string userpassword;

            usertype = comtype.SelectedItem.ToString();
            username = txtname.Text;
            userpassword = txtpw.Text;
            MySqlConnection sqlCon = null;
            string connection;
            connection = "server =127.0.0.1;database =payrollmanagments; user =root;Sslmode= none";

            sqlCon = new MySqlConnection(connection);
            sqlCon.Open();

            MySqlCommand command;
            MySqlDataReader reader;

            if (usertype == "System Administrator")
            {
                command = new MySqlCommand(@"SELECT* FROM systemadmin WHERE SystemAdminName='" + username + "'", sqlCon);
                reader = command.ExecuteReader();
                reader.Read();

                if (reader.HasRows)
                {
                    string databaseUserName;
                    string databasePassword;
                    databaseUserName = reader.GetString(0);
                    databasePassword = reader.GetString(2);

                    if (userpassword == databasePassword)
                    {
                        this.Hide();
                        SystemAdminPage ss = new SystemAdminPage();
                        ss.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalied Password");
                    }
                }
                else
                {
                    MessageBox.Show("Invalied User name!");
                }
            }
            else if (usertype == "HR")
            {
                command = new MySqlCommand(@"SELECT* FROM hr WHERE Name='" + username + "'", sqlCon);
                reader = command.ExecuteReader();
                reader.Read();

                if (reader.HasRows)
                {
                    string databaseUserName;
                    string databasePassword;
                    databaseUserName = reader.GetString(1);
                    databasePassword = reader.GetString(2);

                    if (userpassword == databasePassword)
                    {
                        this.Hide();
                        HR ss = new HR();
                        ss.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalied Password");
                    }
                }
                else
                {
                    MessageBox.Show("Invalied User name!");
                }
            }
            else if (usertype == "Employee")
            {
                command = new MySqlCommand(@"SELECT* FROM employee WHERE EmployeeName='" + username + "'", sqlCon);
                reader = command.ExecuteReader();
                reader.Read();

                if (reader.HasRows)
                {
                    string databaseUserName;
                    string databasePassword;
                    databaseUserName = reader.GetString(1);
                    databasePassword = reader.GetString(2);

                    if (userpassword == databasePassword)
                    {
                        this.Hide();
                        Employee ss = new Employee();
                        ss.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalied Password");
                    }
                }
                else
                {
                    MessageBox.Show("Invalied User name!");
                }
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
