namespace BLL;
using DAL;
public class Manager
{
    public bool validateBL(string email,string password){
        if(DBManager.validateDL(email,password))
            return true;
            return false;
        
     
    }
     public bool RegisterBL(string name, string email, string password, int contact)
    {
        if (DBManager.RegisterBL(name, email, password, contact))
            return true;
        return false;
    }
}
