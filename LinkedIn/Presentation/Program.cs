using LinkedIn.Persistance;
using Microsoft.Data.Sqlite;
using LinkedIn.Configuration;
using LinkedIn.Domain;

namespace LinkedIn.Presentation
{
    internal class Program
    {
        static void Test()
        {
            using var connection = new SqliteConnection("Data Source=linkedin.db");
            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText = "SELECT name FROM sqlite_master WHERE type='table'";

            using var reader = command.ExecuteReader();
            Console.WriteLine("Tables:");
            while (reader.Read())
            {
                Console.WriteLine($"- {reader.GetString(0)}");
            }
        }
        static void Main(string[] args)
        {
            TableInitializer.EnsureAllTables();

            Test();



            var connector = ConnectorFactory.GetConnector("sql");
            var userDao = connector.GetUserDao();
            var user = new User
            {
                Id = Guid.NewGuid(),
                FullName = "Myroslav",
                Nickname = "KAL0339",
                Location = "Ostrava",
                Email = "kal0339@vsb.cz",
                Password = "password0339",
                //ProfilePictureUrl = ""
            };
            userDao.Save(user);
            var allUsers = userDao.GetAll();
            Console.WriteLine("Users:");
            foreach (var u in allUsers)
            {
                Console.WriteLine($"- {u.FullName} ({u.Email})");
            }
        }
    }
}
