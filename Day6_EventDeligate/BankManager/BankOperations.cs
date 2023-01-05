namespace EBanking;

public delegate void Operations1(double amount); //deligate
public class BankOperations{
    public void BlockAccount(double amount){
        Console.WriteLine("Your account has been Blocked! Sorry for Inconvenience");
    }
    public void SendEmail(double amount){
        Console.WriteLine("Email sent regarding Account Blocked");
    }
    public void Sendsms(double amount){
        Console.WriteLine("Email SMS regarding Account Blocked");
    }
}