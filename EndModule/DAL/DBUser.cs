namespace DAL;
using BOL;
using System.Text.Json;

public class DBUser{
    static string fpath= @"D:\study1\Dotnet\dotnet_classwork\EndModule\endmodule\wwwroot\database\user.json";

    public static bool sereialize(List<User> list){
    var option=new JsonSerializerOptions{IncludeFields=true};
    var users=JsonSerializer.Serialize(list,option);
    File.WriteAllText(fpath,users);
    return true;

    }

    public static List<User> deserialize(){
        string users= File.ReadAllText(fpath);
        List<User> list= JsonSerializer.Deserialize<List<User>>(users);
        return list;
    }




    public static bool Login(string email,string password){
        List<User> list=deserialize();
        foreach(User user in list){
            if(user.Email.Equals(email) && user.password.Equals(password))
            return true;
        }
    }

    public static bool Register(string name,string email,string password){
        List<User> list=new List<User>();
        list.Add(new User(name,email,password));
        sereialize(list);
        return true;
    }
}