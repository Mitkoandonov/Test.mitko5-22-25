using System.ComponentModel.Design;

namespace test._2._9klas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount acc = new BankAccount("Bg123","ivan" , 1000.00m );

            acc.Deposit(500.00m);
            acc.Withdraw(300.00m);
            acc.Withdraw(500.00m);

            acc.isActive = false;
            acc.Withdraw  (100.00m);
        }
    }
}
