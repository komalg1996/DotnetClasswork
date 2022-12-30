namespace Membership;

public static class AuthorisedManager
{
    //validate email & password
    public static bool Validate(string email, string password){
        bool status=false;
        if(email=="koko@gmail.com" && password=="komal"){
        status=true;
        }return status;
    }

    //register user
    public static bool Register(string firstName, string lastName, string email, string contactNo, string location){
        bool status=false;
        try{
            User user1=new User();
        user1.firstName=firstName;
        user1.lastName=lastName;
        user1.email=email;
        user1.contactNo=contactNo;
        user1.location=location;
        status=true;
        }
        catch(Exception e){

        }
        finally{

        }
        return status;
    }


}