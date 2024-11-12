using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBConnection.SingletonDP.Before
{
    public class DatabaseConnection
    {
        private readonly SqlConnection _connection;
        private static int _numberOfConnection = 0;

        public DatabaseConnection(string connectionString)
        {
            _connection = new SqlConnection(connectionString);
            _connection.Open();
            _numberOfConnection++;
            Console.WriteLine($"Database Connection Number -> {_numberOfConnection} is Open !");
        }

    }
}
