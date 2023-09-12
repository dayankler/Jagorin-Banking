using System; // You need to include the System namespace for Console

namespace Account
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a SavingsAccount
            SavingsAccount savingsAccount = new SavingsAccount(1234, 0.03);
            savingsAccount.Deposit(1500);
            savingsAccount.DisplayAccountDetails();
            savingsAccount.CalculateInterest();
            savingsAccount.DisplayAccountDetails();

            Console.WriteLine();

            // Create a CheckingAccount
            CheckingAccount checkingAccount = new CheckingAccount(12345 , 0);
            checkingAccount.Deposit(1700);
            checkingAccount.DisplayAccountDetails();
            checkingAccount.Withdraw(1500);
            checkingAccount.DisplayAccountDetails();
        }
    }
}


















