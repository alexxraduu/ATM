using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMApp
{
    class Utility
    {
        public static string sqlConnString = "Data Source=DESKTOP-9VI85EP\\SQLEXPRESS;Initial Catalog=atm_db;Integrated Security=True";

        public static bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }

        public static void UpdateBalanceDB(User user)
        {
            SqlConnection conn = new SqlConnection(Utility.sqlConnString);
            conn.Open();
            string updateQuery = "UPDATE Users SET balance=@balance WHERE account_id=@accountId";
            SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
            updateCmd.Parameters.AddWithValue("@balance", user.Balance);
            updateCmd.Parameters.AddWithValue("@accountId", user.AccountId);
            updateCmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void AddTransaction(User user, string date, string type, int amount)
        {
            SqlConnection conn = new SqlConnection(Utility.sqlConnString);
            conn.Open();
            string inserQuery = "INSERT INTO TransactionTable values(@accId, @date, @type, @amount);";
            SqlCommand insertCmd = new SqlCommand(inserQuery, conn);
            insertCmd.Parameters.AddWithValue("@accId", user.AccountId);
            insertCmd.Parameters.AddWithValue("@date", date);
            insertCmd.Parameters.AddWithValue("@type", type);
            insertCmd.Parameters.AddWithValue("@amount", amount);
            insertCmd.ExecuteNonQuery();
            conn.Close();
        }


    }

    
}
