using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedIn.Domain;
using Microsoft.Data.Sqlite;
using LinkedIn.Persistance;

namespace LinkedIn.Infrastructure.Sql
{
    public class UserSqlDao : IUserDao
    {
        public User GetById(Guid id)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<User> GetAll()
        {
            var users = new List<User>();

            using var connection = SqliteHelper.GetConnection();

            var command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM Users";

            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var user = new User
                {
                    Id = Guid.Parse(reader.GetString(0)),
                    FullName = reader.GetString(1),
                    Nickname = reader.IsDBNull(2) ? null : reader.GetString(2),
                    Location = reader.IsDBNull(3) ? null : reader.GetString(3),
                    Email = reader.GetString(4),
                    Password = reader.GetString(5),
                    ProfilePictureUrl = reader.IsDBNull(6) ? null : reader.GetString(6)
                };

                users.Add(user);
            }

            return users;
        }
        public void Save(User user)
        {
            using var connection = SqliteHelper.GetConnection();

            var command = connection.CreateCommand();
            command.CommandText = @"
                INSERT INTO Users (
                    Id, FullName, Nickname, Location, Email, Password, ProfilePictureUrl
                ) VALUES (
                    $id, $fullName, $nickname, $location, $email, $password, $picture
                )";

            command.Parameters.AddWithValue("$id", user.Id.ToString());
            command.Parameters.AddWithValue("$fullName", user.FullName);
            command.Parameters.AddWithValue("$nickname", user.Nickname ?? "");
            command.Parameters.AddWithValue("$location", user.Location ?? "");
            command.Parameters.AddWithValue("$email", user.Email);
            command.Parameters.AddWithValue("$password", user.Password);
            command.Parameters.AddWithValue("$picture", user.ProfilePictureUrl ?? "");

            command.ExecuteNonQuery();
        }
        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
