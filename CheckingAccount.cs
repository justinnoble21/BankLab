using System;

class CheckingAccount : BankAccount
{

  public override void CalculateInterest() {
    double interest = 0.05 * Balance;

    Balance = Balance + interest;

    Console.WriteLine("Balance updated: " + Balance);
  }

  public void Withdraw(double amount) {}

}