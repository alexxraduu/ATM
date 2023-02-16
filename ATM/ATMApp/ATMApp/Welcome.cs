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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }
        private void StartLogin()
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void WelcomeImg_Click(object sender, EventArgs e)
        {
            StartLogin();
        }
    }
}
