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
    public partial class FastWithdraw : Form
    {
        private User myUser;
        public FastWithdraw(User user)
        {
            InitializeComponent();
            myUser = user;
        }

        private void Withdraw(string amountStr)
        {
            string[] amount = amountStr.Split(' ');
            if ( Convert.ToInt32(amount[0]) <= myUser.Balance)
            {
                myUser.Balance -= Convert.ToInt32(amount[0]);
                Utility.UpdateBalanceDB(myUser);
                DateTime date = DateTime.Now;
                Utility.AddTransaction(myUser, date.ToString("dd-MM-yyyy"), "WITHDRAW", Convert.ToInt32(amount[0]));
                MessageBox.Show("Withdraw successful!");
                StartHome();
            } else
            {
                MessageBox.Show("Insuficient founds!");
            }
        }
        private void StartHome()
        {
            Home home = new Home(myUser);
            home.Show();
            this.Close();
        }

        private void Withdraw100_Click(object sender, EventArgs e)
        {
            Withdraw(withdraw100.Text.ToString());
        }

        private void Withdraw200_Click(object sender, EventArgs e)
        {
            Withdraw(withdraw200.Text.ToString());
        }

        private void Withdraw500_Click(object sender, EventArgs e)
        {
            Withdraw(withdraw500.Text.ToString());
        }

        private void Withdraw50_Click(object sender, EventArgs e)
        {
            Withdraw(withdraw50.Text.ToString());
        }

        private void Withdraw1000_Click(object sender, EventArgs e)
        {
            Withdraw(withdraw1000.Text.ToString());
        }

        private void Withdraw2000_Click(object sender, EventArgs e)
        {
            Withdraw(withdraw2000.Text.ToString());
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
