
namespace Account
{

    public class CheckingAccount: Account
    {
        private int accountNumber;
        private double balance;

        public double OverdraftLimit { get; set; }

        public CheckingAccount(int accountNumber, double initialBalance) :base(accountNumber)
        {
            this.accountNumber = accountNumber;
            this.balance = initialBalance;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited: ${amount} into Account {accountNumber}");
            }
        }

        public override void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawn ${amount} from Account {accountNumber}");
            }
            else
            {
                Console.WriteLine("Withdrawal failed: Insufficient funds.");
            }
        }

        public void DisplayAccountDetails()
        {
            Console.WriteLine($"Account Number: {accountNumber}");
            Console.WriteLine($"Balance: ${balance}");
        }
    }
}

