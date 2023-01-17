namespace DAL;
using BOL;
using System.Data;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
public class ProductManagerDAL
{

    static string conpath = @"server=localhost;user=root;password=Root@12345;port=3306;database=project;";

    public static List<Product> GetAllProducts()
    {
        List<Product> list = new List<Product>();
        //connection to database
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conpath;
        //fire query
        try
        {
            con.Open();
            string querry = "select* from products";
            MySqlCommand cmd = new MySqlCommand(querry, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int Id = int.Parse(reader["Id"].ToString());
                string? Name = reader["Name"].ToString();
                string? Category = reader["Category"].ToString();
                double UnitPrice = int.Parse(reader["UnitPrice"].ToString());
                string? ExpDate = reader["ExpDate"].ToString();

                Product p = new Product(Id, Name, Category, UnitPrice, ExpDate);
                list.Add(p);
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

        return list;
    }


    public static Product GetProduct(int id)
    {
        List<Product> list = GetAllProducts();
        foreach (Product product in list)
        {
            if (product.Id == id)
                return product;
        }
        return null;
    }

    public static bool insert(int id,string name, string category, double unitprice, string expdate)
    {
        //db connection
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conpath;
        //query
        bool ans = false;
        try
        {
            con.Open();
            string querry = "insert into products(Id,Name,Category,UnitPrice,ExpDate) values('" + id + "','" + name + "','" + category + "','" + unitprice + "','" + expdate + "')";

            MySqlCommand cmd = new MySqlCommand(querry, con);
            cmd.ExecuteNonQuery();
            ans = true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            con.Close();
        }
        return ans;

    }


    public static void Update(int id, string name, string category, double Price, string Date)
    {
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conpath;
        try
        {
            con.Open();
            string querry = "update products set Name='" + name + "', Category='" + category + "', UnitPrice='" + Price + "', ExpDate='" + Date + "' where Id=" + id;
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

    public static void Delete(int id)
    {
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conpath;
        try
        {
            con.Open();
            string querry = "delete from products where id=" + id;
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

}


