namespace DAL;
using BOL;
using MySql.Data.MySqlClient;

public class DBManager
{
    static string connectPath = @"server=localhost;port=3306;user=root;password=Root@12345;database=project";

    public static List<User> GetAllUser()
    {
        List<User> users = new List<User>();
        //connect to db
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = connectPath;
        try
        {
            con.Open();
            string querry = "select* from user";
            MySqlCommand cmd = new MySqlCommand(querry, con);
            cmd.Connection = con;
            cmd.CommandText = querry;
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = int.Parse(reader["Id"].ToString());
                string name = reader["Name"].ToString();
                string email = reader["Email"].ToString();
                string password = reader["Password"].ToString();
                int contact = int.Parse(reader["Contact"].ToString());

                User u = new User(id, name, email, password, contact);
                users.Add(u);
            }


        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            con.Close();
        }
        return users;

    }
    public static bool validateDL(string email, string password)
    {
        List<User> users = GetAllUser();
        foreach (User user in users)
        {
            if (user.Email.Equals(email) && user.password.Equals(password))
            {
                return true;
            }
        }
        return false;
    }

    public static bool RegisterBL(string name, string email, string password, int contact)
    {
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = connectPath;
        bool status = false;
        try{
            con.Open();
            string querry= "insert into user(name,email,password,contact) values(' "
                + name
                + "','"
                + email
                + "','"
                + password
                + "','"
                + contact
                + "')";

            MySqlCommand cmd= new MySqlCommand(querry,con); 
            cmd.ExecuteNonQuery();
            status=true;   

        }catch(Exception e){
            Console.WriteLine(e.Message);
        }finally{
            con.Close();
        }
         return status;
    }

}
