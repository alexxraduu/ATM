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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CreateAccBtn_Click(object sender, EventArgs e)
        {
            CreateAcc createAcc = new CreateAcc();
            createAcc.Show();
            this.Close();
        }

        
        private void StartHome(User user)
        {
            Home home = new Home(user);
            home.Show();
            this.Close();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Utility.sqlConnString);
            conn.Open();
            string selectQuery = "SELECT * FROM Users where account_id=@accId and pin=@pin";
            SqlCommand selectCmd = new SqlCommand(selectQuery, conn);
            selectCmd.Parameters.AddWithValue("@accId", accBox.Text.ToString());
            selectCmd.Parameters.AddWithValue("@pin", pinBox.Text.ToString());

            SqlDataReader reader = selectCmd.ExecuteReader();
            if (!reader.HasRows)
            {
                MessageBox.Show("Accound number\\PIN invalid!");
            }
            else
            {
                reader.Read();
                User connectedUser = new User(
                    reader["account_id"].ToString(),
                    reader["first_name"].ToString(),
                    reader["last_name"].ToString(),
                    reader["address"].ToString(),
                    reader["phone"].ToString(),
                    reader["pin"].ToString(),
                    reader["date_of_birth"].ToString(),
                    Convert.ToInt32(reader["balance"].ToString())
                    );
                reader.Close();
                conn.Close();

                StartHome(connectedUser);

            }
        }
    }
}
