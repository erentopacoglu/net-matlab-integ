using System.Data;
using System.Data.SqlClient;

namespace ConsoleApp2.connect2sql
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string connectionString = "Your_Connection_String_Here";
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Your SQL Server code goes here (e.g., INSERT statements to insert data into the database)
            }
        }
    }
}