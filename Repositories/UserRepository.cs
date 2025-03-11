using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace CodeSystem.Repositories
{
    public class UserRepository
    {
        private readonly string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=codesystemdb;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";

        public List<User> GetUsers()
        {
            var users = new List<User>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Users";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var user = new User
                                {
                                    Id = reader.GetInt32(0),
                                    Username = reader.GetString(1),
                                    Password = reader.GetString(2),
                                };
                                users.Add(user);
                                Console.WriteLine(user.Username);
                            }
                        }
                    }
                }
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return users;
        }

        public User loginUser(string username, string password)
        {
            var user = new User();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Users WHERE Username = @Username AND Password = @Password";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                user.Id = reader.GetInt32(0);
                                user.Username = reader.GetString(1);
                                user.Password = reader.GetString(2);
                            }
                        }
                    }
                }
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return user;
        }
    }
}
