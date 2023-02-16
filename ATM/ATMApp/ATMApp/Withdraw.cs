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
    public partial class Withdraw : Form
    {
        private User myUser;
        public Withdraw(User user)
        {
            InitializeComponent();
            myUser = user;
        }
       
        private void StartHome()
        {
            Home home = new Home(myUser);
            home.Show();
            this.Close();
        }

        private bool CheckWithdrawAmount(string str)
        {
            if (!Utility.IsDigitsOnly(str) || Convert.ToInt32(str) % 10 != 0)
            {
                return false;
            }
            return true;
        }

        private void WithdrawBox_Click(object sender, EventArgs e)
        {
            if (CheckWithdrawAmount(amountBox.Text.ToString()) && Convert.ToInt32(amountBox.Text.ToString()) <= myUser.Balance)
            {
                myUser.Balance -= Convert.ToInt32(amountBox.Text.ToString());
                Utility.UpdateBalanceDB(myUser);
                DateTime date = DateTime.Now;
                Utility.AddTransaction(myUser, date.ToString("dd-MM-yyyy"), "WITHDRAW", Convert.ToInt32(amountBox.Text.ToString()));
                MessageBox.Show("Withdraw successful!");
                StartHome();
            }
            else
            {
                MessageBox.Show("Amount must be multiple of 10 and must contain only digits!");
                amountBox.Text = "";
            }
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
