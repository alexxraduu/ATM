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
    public partial class Deposit : Form
    {
        private User myUser;
        public Deposit(User user)
        {
            InitializeComponent();
            this.myUser = user;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StartHome()
        {
            Home home = new Home(myUser);
            home.Show();
            this.Close();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            StartHome();
        }

        private bool CheckDepositAmount(string str)
        {
            if(!Utility.IsDigitsOnly(str) || Convert.ToInt32(str) % 10 != 0)
            {
                return false;
            }
            return true;
        }
        private void DepositBox_Click(object sender, EventArgs e)
        {
            if (CheckDepositAmount(amountBox.Text.ToString()))
            {
                myUser.Balance += Convert.ToInt32(amountBox.Text.ToString());
                Utility.UpdateBalanceDB(myUser);
                DateTime date = DateTime.Now;
                Utility.AddTransaction(myUser, date.ToString("dd-MM-yyyy"), "DEPOSIT", Convert.ToInt32(amountBox.Text.ToString()));
                MessageBox.Show("Deposit successful!");
                StartHome();
            }
            else
            {
                MessageBox.Show("Amount must be multiple of 10 and must contain only digits!");
                amountBox.Text = "";
            }
        }

        
    }
}
