using System.Data.SqlClient;

// Change this line to match StudentForm.cs
namespace StudentManagementSystem
{
    public class DBConnection
    {
        private static string connectionString =
            @"Data Source=(localdb)\MSSQLLocalDB;
              Initial Catalog=StudentManagementDB;
              Integrated Security=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}