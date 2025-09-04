

namespace ExceptionHandlingDemo
{
    // Custom exception class
    public class InsufficientFundsException : Exception
    {
        public InsufficientFundsException(string message) : base(message) { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BankApp.BankAccount account = new BankApp.BankAccount(1000);
            account.DisplayBalance();
            try
            {
                Console.WriteLine("Attempting to withdraw $1500...");
                account.Withdraw(1500);
            }
            catch (InsufficientFundsException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                account.DisplayBalance();
                Console.WriteLine("Thank you for using our banking services.");
            }
        }
    }
}