using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMApp
{
    public partial class ChangePin : Form
    {
        private User myUser;
        private const int pinSize = 4;
        public ChangePin(User user)
        {
            InitializeComponent();
            myUser = user;
        }
       

        private bool CheckNumbers(string str, int size)
        {
            if (!string.IsNullOrEmpty(str) && Utility.IsDigitsOnly(str) && str.Length == size)
            {
                return true;
            }

            return false;
        }
        private void StartHome()
        {
            Home home = new Home(myUser);
            home.Show();
            this.Close();
        }

        private void ChangePinBtn_Click(object sender, EventArgs e)
        {
            if(newPinBox.Text.ToString().Equals(confirmPinBox.Text.ToString()) && CheckNumbers(newPinBox.Text.ToString(), pinSize))
            {
                myUser.Pin = newPinBox.Text.ToString();
                UpdateDb();
                MessageBox.Show("Pin changed successful!");
                StartHome();
            }
            else
            {
                MessageBox.Show("Incorrect input!");
            }
        }

        private void UpdateDb()
        {
            SqlConnection conn = new SqlConnection(Utility.sqlConnString);
            conn.Open();
            string updateQuery = "UPDATE Users SET pin=@pin WHERE account_id=@accountId";
            SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
            updateCmd.Parameters.AddWithValue("@pin", myUser.Pin);
            updateCmd.Parameters.AddWithValue("@accountId", myUser.AccountId);

            updateCmd.ExecuteNonQuery();

            conn.Close();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            StartHome();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
