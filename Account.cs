namespace Account
{
    public class Account
    {
        //Properties 
        public int AccountNum { get; set; }
        public double Balance { get; set; }

        //Constructor 
        public Account(int accountNumber)
        {
            this.AccountNum = accountNumber;
        }

        //Method 
        public double Deposit(double amount)
        {
            Balance += amount; // Update the balance field
            Deposit(amount);
            return Balance;
        }

        public virtual void Withdraw(double amount)
        {
            if (amount > Balance)
            {
                Balance -= amount; // Update the balance field
            }
            
        }

        public double CalculateInterest(double interestRate)
        {
            double interest = Balance * (interestRate / 100);
            Balance += interest;
            return interest;
        }

        public void DisplayAccountDetails()
        {
            Console.WriteLine($"Account Number: {AccountNum}");
            Console.WriteLine($"Balance: ${Balance}");
        }

        
    }
}











