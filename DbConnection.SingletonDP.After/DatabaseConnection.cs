using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConnection.SingletonDP.After
{
    public class DatabaseConnection
    {
        private readonly SqlConnection _connection;
        private static int _numberOfConnection = 0;

        private static DatabaseConnection _instance = default;

        private DatabaseConnection(string connectionString)
        {
            _connection = new SqlConnection(connectionString);
            _connection.Open();
            _numberOfConnection++;
            Console.WriteLine($"Database Connection Number -> {_numberOfConnection} is Open !");
        }


        public static DatabaseConnection CreateInstance(string connectionString)
        {
            if (_instance is null) _instance = new DatabaseConnection(connectionString);

            return _instance;

        }

    }
}
