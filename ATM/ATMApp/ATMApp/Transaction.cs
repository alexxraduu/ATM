using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMApp
{
    class Transaction
    {
        private string accId;
        public string AccId
        {
            get { return accId; }
            set { accId = value; }
        }

        private string date;
        public string Date
        {
            get { return date; }
            set { date = value; }
        }
        private string type;
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        private int amount;
        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public Transaction(string accId, string date, string type, int amount)
        {
            this.accId = accId;
            this.date = date;
            this.type = type;
            this.amount = amount;
        }
    }
}
