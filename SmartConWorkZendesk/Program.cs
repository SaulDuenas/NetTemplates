using Microsoft.Extensions.Configuration;

namespace ConsoleSmartRank // Note: actual namespace depends on the project name.
{
    internal class Program
    {

        static void Main(string[] args)
        {

            var builder = new ConfigurationBuilder()
        .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            var configuration = builder.Build();

            var SmartBusinessDB = configuration["ConnectionStrings:SmartBusinessDB"];
            var sql_hierarchical_partner = configuration["sqlcommand:hierarchical_partner"];


            Console.WriteLine("hello world! from net6");
            Console.ReadLine();
        }

    }

}