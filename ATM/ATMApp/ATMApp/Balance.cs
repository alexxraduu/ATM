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
    public partial class Balance : Form
    {
        private User myUser;
        public Balance(User user)
        {
            InitializeComponent();
            this.myUser = user;
            accNumTxt.Text = myUser.FirstName + " " + myUser.LastName;
            balanceTxt.Text = myUser.Balance.ToString() + " Lei";
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Home home = new Home(myUser);
            home.Show();
            this.Close();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
