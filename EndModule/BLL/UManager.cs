namespace BLL;
using DAL;
using BOL;

public class UManager{

    public bool Login(string email,string password){
        if(DBUser.Login(email,password))
        return true;
        return false;
    }
}