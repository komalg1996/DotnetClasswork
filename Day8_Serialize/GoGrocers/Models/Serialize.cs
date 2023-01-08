using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using USERNAME;

namespace SERIAL;

public class Serialize
{
    //File path
    string filepath =
        @"D:\study1\Dotnet\dotnet_classwork\Day8_Serialize\GoGrocers\wwwroot\data\login.json";

    //De-Serialize data from file
    List<User> dataList = new List<User>();

    public List<User> restore()
    {
        string loginDetailsString = File.ReadAllText(filepath);
        List<User> loginDetails = JsonSerializer.Deserialize<List<User>>(loginDetailsString);
        return loginDetails;
    }

    // sample admin data
    public void adminLog()
    {
        User u1 = new User("Komal", "Ghorpade", 96950, "Komal@gmail.com", "komal");
        dataList.Add(u1);

        var options = new JsonSerializerOptions { IncludeFields = true };
        var userlistJSON = JsonSerializer.Serialize<List<User>>(dataList, options);
        File.WriteAllText(filepath, userlistJSON);
    }

    //method to register user
    public bool register(
        string firstname,
        string lastname,
        int contactNum,
        string email,
        string password
    )
    {
        List<User> userList = restore();
        foreach (User user in userList)
        {
            if (user.Email == email)
            {
                return false;
            }
        }
        //serialize of data
        User u1 = new User(firstname, lastname, contactNum, email, password);
        userList.Add(u1);

        var options = new JsonSerializerOptions { IncludeFields = true };
        var userlistJSON = JsonSerializer.Serialize<List<User>>(userList, options);
        File.WriteAllText(filepath, userlistJSON);
        return true;
    }

    //method for login data
    public bool login(string email, string password)
    {
        List<User> userList = restore();
        foreach (User user in userList)
        {
            if (user.Email == email && user.Password == password)
            {
                return true;
            }
        }
        return false;
    }
}
