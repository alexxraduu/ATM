using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMApp
{
    public partial class Home : Form
    {
        private User myUser;
        public Home(User user)
        {
            InitializeComponent();
            this.myUser = user;
        }

        private void DepositBtn_Click(object sender, EventArgs e)
        {
            Deposit deposit = new Deposit(myUser);
            deposit.Show();
            this.Close();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BalanceBtn_Click(object sender, EventArgs e)
        {
            Balance balance = new Balance(myUser);
            balance.Show();
            this.Close();
        }

        private void WithdrawBtn_Click(object sender, EventArgs e)
        {
            Withdraw withdraw = new Withdraw(myUser);
            withdraw.Show();
            this.Close();
        }

        private void ChangePinBtn_Click(object sender, EventArgs e)
        {
            ChangePin changePin = new ChangePin(myUser);
            changePin.Show();
            this.Close();
        }

        private void FastWithdrawBtn_Click(object sender, EventArgs e)
        {
            FastWithdraw fastWithdraw = new FastWithdraw(myUser);
            fastWithdraw.Show();
            this.Close();
        }

        private void HistoryBtn_Click(object sender, EventArgs e)
        {
            History history = new History(myUser);
            history.Show();
            this.Close();
        }
    }
}
