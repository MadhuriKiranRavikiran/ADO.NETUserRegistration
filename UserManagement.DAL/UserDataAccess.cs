using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using UserManagement.DAL.Model;


namespace UserManagement.DAL
{
    public class UserDataAccess
    {
        private readonly string connectionString;

        public UserDataAccess()
        {
            connectionString = ConfigurationManager.ConnectionStrings["UserManagementDBConnectionString"].ConnectionString;
        }

        public void AddUser(UserModel user)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Users (UserName, Email, Password) VALUES (@UserName, @Email, @Password)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserName", user.UserName);
                command.Parameters.AddWithValue("@Email", user.Email);
                command.Parameters.AddWithValue("@Password", user.Password);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

    }
}
