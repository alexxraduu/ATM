using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMApp
{
   public class User
    {
        private string accountId;
        public string AccountId
        {
            get { return accountId; }
            set { accountId = value; }
        }

        private string firstName;
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        private string lastName;
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        private string address;
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        private string phoneNum;
        public string PhoneNum
        {
            get { return phoneNum; }
            set { phoneNum = value; }
        }

        private string pin;
        public string Pin
        {
            get { return pin; }
            set { pin = value; }
        }

        private string dateOfBirth;
        public string DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        private int balance;
        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public User(string accountId, string firstName, string lastName, string address, string phoneNum, string pin, string dateOfBirth, int balance)
        {
            this.accountId = accountId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.phoneNum = phoneNum;
            this.pin = pin;
            this.dateOfBirth = dateOfBirth;
            this.balance = balance;
        }


    }
}
