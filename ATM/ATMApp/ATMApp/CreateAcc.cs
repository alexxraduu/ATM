using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ATMApp
{
    public partial class CreateAcc : Form
    {
        private const int accNumSize = 5;
        private const int phoneSize = 10;
        private const int pinSize = 4;
        private const int initialBalance = 0;

        public CreateAcc()
        {
            InitializeComponent();
            dateOfBirthBox.Format = DateTimePickerFormat.Custom;
            dateOfBirthBox.CustomFormat = "dd-MM-yyyy";
        }

        private bool CheckNumbers(string str, int size)
        {
            if(!string.IsNullOrEmpty(str) && Utility.IsDigitsOnly(str) && str.Length==size)
            {
                return true;
            }

            return false;
        }


        private bool CheckAccountNum(string str, SqlConnection conn)
        {
            string selectQuery = "select * from Users where account_id = @accId;";
            SqlCommand selectCmd = new SqlCommand(selectQuery, conn);
            selectCmd.Parameters.AddWithValue("@accId", str);
            var read = selectCmd.ExecuteReader();
            if (read.HasRows)
            {
                read.Close();
                return false;
            }
            read.Close();
            return true;
        }

        private void AddUser(SqlConnection conn, string accNum, string fName, string lName, string address, string phone, string pin, string dateOfBirth)
        {
            string insertQuery = "insert into Users values(@accId, @fName, @lName, @address, @phone, @pin, @dateOfBirth, @balance);";
            SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
            insertCmd.Parameters.AddWithValue("@accId", accNum);
            insertCmd.Parameters.AddWithValue("@fName", fName);
            insertCmd.Parameters.AddWithValue("@lName", lName);
            insertCmd.Parameters.AddWithValue("@address", address);
            insertCmd.Parameters.AddWithValue("@phone", phone);
            insertCmd.Parameters.AddWithValue("@pin", pin);
            insertCmd.Parameters.AddWithValue("@dateOfBirth", dateOfBirth);
            insertCmd.Parameters.AddWithValue("@balance", initialBalance);
            insertCmd.ExecuteNonQuery();
            MessageBox.Show("Account created!");
        }
        private void StartLogin()
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
              SqlConnection conn = new SqlConnection(Utility.sqlConnString);
               conn.Open();

            if (!CheckAccountNum(accBox.Text.ToString(), conn))
            {
                MessageBox.Show("Account number already exists!");
            }
            else if (CheckNumbers(accBox.Text.ToString(),accNumSize) && !string.IsNullOrEmpty(firstNameBox.Text.ToString()) && !string.IsNullOrEmpty(lastNameBox.Text.ToString()) && !string.IsNullOrEmpty(addressBox.Text.ToString()) && CheckNumbers(phoneBox.Text.ToString(), phoneSize) && CheckNumbers(pinBox.Text.ToString(), pinSize) && !string.IsNullOrEmpty(dateOfBirthBox.Value.ToString()))
             {
                    AddUser(conn,
                        accBox.Text.ToString(),
                        firstNameBox.Text.ToString(),
                        lastNBox.Text.ToString(),
                        addressBox.Text.ToString(),
                        phoneBox.Text.ToString(),
                        pinBox.Text.ToString(),
                        dateOfBirthBox.Value.Date.ToString("dd-MM-yyyy")
                        );
                     conn.Close();
                     StartLogin();
             }
             else if(!CheckNumbers(accBox.Text.ToString(),accNumSize) || !CheckNumbers(phoneBox.Text.ToString(),phoneSize) || !CheckNumbers(pinBox.Text.ToString(), pinSize))
             {
                 MessageBox.Show("Account number(size 5), Phone number(size 10) and PIN(size 4) must contain only digits!");
             }
            else
            {
                MessageBox.Show("Missing information!");
            }

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
