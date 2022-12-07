using Dapper;
using System.Configuration;
using System.Data.SqlClient;

namespace InventoryManagement
{
    public static class DbContents
    {
        public static string EmployeeConnectionString = ConfigurationManager.ConnectionStrings["UserFormDb"].ConnectionString;

    }
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
    }
    internal class DapperDatabase 
    {
        string connString = DbContents.EmployeeConnectionString;
        public int Execute(User user)
        {
            using (var connection = new SqlConnection(connString))
            {
                string InsertQuery = @"insert into UserFormmDb(Username,Password,FullName,PhoneNumber)values('@Username,@Password,@FullName,@PhoneNumber')";
                connection.Open();
                var UserRows = connection.Execute(InsertQuery, new { Username = user.Username, Password = user.Password, Fullname = user.FullName, PhoneNumber = user.PhoneNumber });
                connection.Close();
                return UserRows;

            }
        }

    }
}
