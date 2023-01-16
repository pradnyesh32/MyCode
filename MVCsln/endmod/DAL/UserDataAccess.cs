namespace dbconnect;
using stud;
using System.Data;
using MySql.Data.MySqlClient;

public class UsersDataAccess
{
    public static string conString = @"server=localhost; port=3306; user=root; password=root123; database=iacsd";
    public static List<Student> GetAllStudent()
    {
        List<Student> allNotes = new List<Student>();
        MySqlConnection con = new MySqlConnection(conString);

        try
        {
            string query = "select * from users";
            DataSet ds = new DataSet();
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(ds);

            DataTable dt = ds.Tables[0];
            DataRowCollection rows = dt.Rows;
            foreach (DataRow row in rows)
            {
                Student user = new Student
                {
                    Id = int.Parse(row["id"].ToString()),
                    Name = row["name"].ToString(),
                    Course = row["course"].ToString(),
                   
                };
                allNotes.Add(user);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        return allNotes;
    }

    public static Student GetUserById(int id)
    {
        Student user = null;
        MySqlConnection con = new MySqlConnection(conString);

        try
        {
            con.Open();
            string query = "select * from users where userid=" + id;
            MySqlCommand command = new MySqlCommand(query, con);
            MySqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                user = new Student
                {
                    Id = int.Parse(reader["userid"].ToString()),
                    Name = reader["username"].ToString(),
                    Course = reader["course"].ToString(),
                   
                };
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
        return user;
    }

    public static void SaveNewUser(Student user)
    {
        MySqlConnection con = new MySqlConnection(conString);

        try
        {
            con.Open();
            string query = $"insert into users(username, course, purchasedate) values('{user.Name}', '{user.Course}')";
            MySqlCommand command = new MySqlCommand(query, con);
            command.ExecuteNonQuery();
            con.Close();
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

    public static void DeleteUserById(int id)
    {
        MySqlConnection con = new MySqlConnection(conString);

        try
        {
            con.Open();
            string query = "delete from users where userid =" + id;
            MySqlCommand command = new MySqlCommand(query, con);
            command.ExecuteNonQuery();
            con.Close();
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