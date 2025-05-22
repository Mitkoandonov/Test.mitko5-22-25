using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test._2._9klas
{

    public class BankAccount
    {

        private string accountNum;
        private decimal balance;


        public string AccountHolder { get; set; }
        public bool isActive { get; set; }


        public BankAccount(string accountNum, string AccountHolder, decimal balance, bool isActiv)
        {
            this.accountNum = accountNum;
            this.AccountHolder = AccountHolder;
            this.balance = balance;
            this.isActive = true;

        }


        public void Deposit(decimal amount)
        {
            if (amount > 0 )
            {
                balance += amount;
                Console.WriteLine("Deposit" + amount);


            }
            else
            {
                Console.WriteLine("Deposit must be positiv");
            }
            Console.WriteLine("Balance:" + balance);
        }
        public void Withdraw(decimal amount)
        {
            if (!isActive)
            {
                Console.WriteLine("operating faild , Acount is inactive");
            }
            else if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine("not emough balance");
            }
            Console.WriteLine("balance " + balance);
        }    


    }
}
