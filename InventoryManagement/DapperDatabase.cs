using Dapper;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace InventoryManagement
{
    public static class DbContents
    {
        public static string EmployeeConnectionString = ConfigurationManager.ConnectionStrings["UserFormDb"].ConnectionString;

    }
    //string InsertQuery = @"insert into UserFormmDb(Username,Password,FullName,PhoneNumber)values('@Username,@Password,@FullName,@PhoneNumber')";
    internal class DapperDatabase
    {
        string connString = DbContents.EmployeeConnectionString;
        public int Execute(string SP, object param)
        {
            using (var connection = new SqlConnection(connString))
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                var UserRows = connection.Execute(SP, param, commandType: CommandType.StoredProcedure);
                connection.Close();
                return UserRows;
            }
        }
    }
}
