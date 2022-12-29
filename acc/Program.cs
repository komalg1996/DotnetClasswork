// See https://aka.ms/new-console-template for more information
using Banking;
using Maths;
Console.WriteLine("Banking");

Account acc1= new Account(10000);
acc1.Deposit(50000);
float curbalanc1= acc1.GetBalance();
Console.WriteLine("current balance is :" +curbalanc1);

acc1.Withdraw(10000);
float curbalanc2= acc1.GetBalance();
Console.WriteLine("current balance is :" +curbalanc2);


Complex c1=new Complex(30,20);
Complex c2=new Complex(50,40);
Complex c3= c1+c2;
Console.WriteLine("Adition of complex num:{0} ",c3);