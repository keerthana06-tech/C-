using System;

class Program
{
    static void Main(string[] args)
    {
        BankAccount account = new BankAccount(5000);

        try
        {
            Console.WriteLine("Enter amount to withdraw: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            account.Withdraw(amount);
        }
        catch (InsufficientFundsException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        Console.WriteLine("Final Balance: " + account.GetBalance());
    }
}