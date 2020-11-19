 using System;
 
abstract class BankAccount
    {
        public string AcctNbr { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }
        public DateTime DateCreated { get; set; }

        public BankAccount()
        {
            AcctNbr = "0";
            Name = "null";
            Balance = 0;
            DateCreated = DateTime.Today;
        }

        public BankAccount(double balance)
        {
          Balance = balance;
        }

        public void Deposit(double amount)
        {
          Balance = Balance + amount;
          Console.WriteLine(Balance);
        }

        public void Withdraw(double amount)
        {
          if (Balance > amount) {
            Balance = Balance - amount;
          }
          else {
            Console.Error.WriteLine("Balance <= amount, CANNOT WITHDRAW.");
          }
          Console.WriteLine(Balance);
        }

        public abstract void CalculateInterest();

    }