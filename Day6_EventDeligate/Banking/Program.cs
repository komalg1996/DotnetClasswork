using EBanking;
using BankManager;

BankOperations bank=new BankOperations();
Account ac = new Account(1000);
Operations1 boperation=new Operations1(ac.ProcessBalance);
boperation();

Account acc1= new Account(10000);
acc1.underBalance+=Operations1;

Console.WriteLine("Enter Amount to Withdraw");
double amount=double.Parse(Console.ReadLine());
acc1.ProcessBalance(amount);
acc1.withdraw(amount);