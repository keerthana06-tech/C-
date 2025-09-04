using System;

       class InsufficientFundsException : Exception {
           public InsufficientFundsException(string message) : base(message)

    {
     
       }

       class BankAccount {
       private double balance;
       public BankAccount(double initialBalance)

{
    balance = initialBalance;
}

    public void Deposit(double amount) {
        balance += amount;
         Console .WriteLine("Deposited: " + amount);
}

    public void Withdraw(double amount) {
         if (amount > balance) throw new InsufficientFundsException("Not enough balance!");
          balance -= amount;
          Console .WriteLine("Withdrawn: " + amount);
}

    public void DisplayBalance() {
         Console .WriteLine("Balance: " + balance);
}
}
