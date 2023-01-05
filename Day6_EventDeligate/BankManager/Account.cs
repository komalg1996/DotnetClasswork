namespace BankManager;
using EBanking;
public class Account
{
    public event Operations1 underBalance;
    private double Balance;

    public Account(double amount){
        this.Balance= amount;
    }
    public void deposit(double amount){
       this.Balance += amount;
    }

public void withdraw(double amount){
    this.Balance-=amount;
} 

public override string ToString()
    {
        return base.ToString() + "Current Balance ="+ this.Balance;
    }

     public void ProcessBalance(){
        if(this.Balance<5000){
            //raise an event   
            underBalance(this.Balance);    
        }
    }

}


