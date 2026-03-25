using System.Data.SqlClient;

namespace Student_Management_System.Database
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