namespace DbConnection.SingletonDP.After
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var connection01 = new DatabaseConnection("Server = .; Database = Db01; Trusted_Connection = true; TrustServerCertificate = true"); ;
            //var connection02 = new DatabaseConnection("Server = .; Database = Db01; Trusted_Connection = true; TrustServerCertificate = true"); ;

            var connection01 = DatabaseConnection.CreateInstance("Server = .; Database = Db01; Trusted_Connection = true; TrustServerCertificate = true");
            var connection02 = DatabaseConnection.CreateInstance("Server = .; Database = Db01; Trusted_Connection = true; TrustServerCertificate = true");

        }
    }
}
