using System;

class SavingsAccount : BankAccount
{

  public override void CalculateInterest() {
    double interest = 0.5 * Balance;

    Balance = Balance + interest;
  }

  public void Withdraw() {
    if (Balance < 2000) {
      Console.Error.WriteLine("Insufficient balance");
    } else {
      this.Withdraw();
    }
  }


}