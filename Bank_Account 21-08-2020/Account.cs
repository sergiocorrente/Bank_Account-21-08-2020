using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_21_08_2020
{
    class Account
    {
        public int AccountId { get; set; }
        public decimal Balance { get; set; }



        public decimal Deposit(decimal amount)
        {
            Balance += amount;
            return Balance;
        }

        public void Withdraw(decimal amount)
        {
            Balance -= amount;
        }


    }
}