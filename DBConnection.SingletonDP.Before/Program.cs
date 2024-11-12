namespace DBConnection.SingletonDP.Before
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var connection01 = new DatabaseConnection("Server = .; Database = Db01; Trusted_Connection = true; TrustServerCertificate = true"); ;
            var connection02 = new DatabaseConnection("Server = .; Database = Db01; Trusted_Connection = true; TrustServerCertificate = true"); ;

        }
    }
}
