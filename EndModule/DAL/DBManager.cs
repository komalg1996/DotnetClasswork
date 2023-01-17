namespace DAL;
using BOL;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
//mysql 
public class DBManager
{

    //connection string
    static string conpath = @"server=localhost;port=3306;user=root;password=Root@12345;database=student";

    static string fpath= @"D:\study1\Dotnet\dotnet_classwork\EndModule\endmodule\wwwroot\database\user.json";

    //get all students in list
    public static List<Student> GetAll()
    {
        List<Student> students = new List<Student>();
        //db conect
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conpath;
        //open connection in try-catch
        try
        {
            //open con
            con.Open();
            //wright querry
            string querry = "select* from sdata";
            //fire querry
            MySqlCommand cmd = new MySqlCommand(querry, con);
            // cmd.Connection=con;
            // cmd.CommandText=querry;
            MySqlDataReader reader = cmd.ExecuteReader();
            //reading all data and adding into list
            while (reader.Read())
            {
                int rollno = int.Parse(reader["Rollno"].ToString());
                string name = reader["Name"].ToString();
                string email = reader["Email"].ToString();
                string city = reader["City"].ToString();

                Student s = new Student(rollno, name, email, city);
                students.Add(s);

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
        return students;
    }

    public static bool Insert(int rollno, string name, string email, string city)
    {
        //connection
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conpath;
        bool status = false;
        try
        {
            con.Open();
            string querry = "insert into Sdata values('" + rollno + "', '" + name + "', '" + email + "', '" + city + "') ";
            //fire query
            MySqlCommand cmd = new MySqlCommand(querry, con);
            cmd.ExecuteNonQuery();
            status = true;

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            con.Close();
        }

        return true;

    }
    public static void Update(int rollno, string name, string email, string city)
    {
        //connection
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conpath;;
        try
        {
            con.Open();
            string querry = "update sdata set name= '" + name + "', email='" + email + "', city='" + city + "'  where rollno= " + rollno;
            //fire query
            MySqlCommand cmd = new MySqlCommand(querry, con);
            cmd.ExecuteNonQuery();

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            con.Close();
        }

    }

    public static void Delete(int rollno)
    {
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conpath;
        try
        {
            con.Open();
            string query = "delete from Sdata where rollno=" + rollno;
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.ExecuteNonQuery();

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            con.Close();
        }
    }

    public static Student GetByRollno(int rollno)
    {
        List<Student> list = GetAll();
        foreach (Student s in list)
        {
            if (s.Rollno == rollno)
                return s;
        }
        return null;
    }

}
