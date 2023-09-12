using Account;

namespace Account
{
    

    // Define the SavingsAccount class inheriting from Account
    public class SavingsAccount : Account
    {
        private int accountNumber;
        private double balance;
        private double interestRate;

        public SavingsAccount(int accountNumber, double interestRate) : base(accountNumber)
        {
            this.accountNumber = accountNumber;
            this.balance = 0; // Start with a zero balance
            this.interestRate = interestRate;
        }



        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                
            }
        }

        public void CalculateInterest()
        {
            double interest = balance * interestRate;
            balance += interest;
            Console.WriteLine($"Interest Earned: ${interest}");
        }

        public void DisplayAccountDetails()
        {
           
            Console.WriteLine($"Account Number: {accountNumber}");
            Console.WriteLine($"Balance: ${balance}");
        }
    }
}
