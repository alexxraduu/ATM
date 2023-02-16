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
    public partial class History : Form
    {   
        private User myUser;
       
        public History(User user)
        {
            InitializeComponent();
            myUser = user;
        }


        private List<Transaction> GetTransactionsList()
        {
            var list = new List<Transaction>();
            SqlConnection conn = new SqlConnection(Utility.sqlConnString);
            conn.Open();
            string selectQuery = "SELECT * FROM TransactionTable where account_id=@accId";
            SqlCommand selectCmd = new SqlCommand(selectQuery, conn);
            selectCmd.Parameters.AddWithValue("@accId", myUser.AccountId);

            SqlDataReader reader = selectCmd.ExecuteReader();
               while(reader.Read())
                {
                    Transaction currentTransaction = new Transaction(
                    reader["account_id"].ToString(),
                    reader["date"].ToString(),
                    reader["type"].ToString(),
                    Convert.ToInt32(reader["amount"].ToString())
                    );
                    list.Add(currentTransaction);
                }
                reader.Close();
                conn.Close();

            return list;
            }
        private void History_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetTransactionsList();
            dataGridView1.Columns["AccId"].Visible = false;
            dataGridView1.Columns["Date"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["Type"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["Amount"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void StartHome()
        {
            Home home = new Home(myUser);
            home.Show();
            this.Close();
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
