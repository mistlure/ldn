using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedIn.Persistance
{
    public class TableInitializer
    {
        public static void EnsureAllTables()
        {
            EnsureUsersTable();
            EnsurePostsTable();
            EnsureMessagesTable();
            EnsureSkillsTable();
            EnsureUserSkillsTable();
        }

        public static void EnsureUsersTable()
        {
            using var connection = SqliteHelper.GetConnection();
            var command = connection.CreateCommand();
            command.CommandText = @"
                CREATE TABLE IF NOT EXISTS Users (
                    Id TEXT PRIMARY KEY,
                    FullName TEXT,
                    Nickname TEXT,
                    Location TEXT,
                    Email TEXT,
                    Password TEXT,
                    ProfilePictureUrl TEXT
                )";
            command.ExecuteNonQuery();
        }

        public static void EnsurePostsTable()
        {
            using var connection = SqliteHelper.GetConnection();
            var command = connection.CreateCommand();
            command.CommandText = @"
                CREATE TABLE IF NOT EXISTS Posts (
                    Id TEXT PRIMARY KEY,
                    Content TEXT,
                    CreatedAt TEXT,
                    AuthorId TEXT,
                    FOREIGN KEY (AuthorId) REFERENCES Users(Id)
                )";
            command.ExecuteNonQuery();
        }

        public static void EnsureMessagesTable()
        {
            using var connection = SqliteHelper.GetConnection();
            var command = connection.CreateCommand();
            command.CommandText = @"
                CREATE TABLE IF NOT EXISTS Messages (
                    Id TEXT PRIMARY KEY,
                    Content TEXT,
                    SentAt TEXT,
                    SenderId TEXT,
                    ReceiverId TEXT,
                    FOREIGN KEY (SenderId) REFERENCES Users(Id),
                    FOREIGN KEY (ReceiverId) REFERENCES Users(Id)
                )";
            command.ExecuteNonQuery();
        }

        public static void EnsureSkillsTable()
        {
            using var connection = SqliteHelper.GetConnection();
            var command = connection.CreateCommand();
            command.CommandText = @"
                CREATE TABLE IF NOT EXISTS Skills (
                    Id TEXT PRIMARY KEY,
                    Name TEXT
                )";
            command.ExecuteNonQuery();
        }

        public static void EnsureUserSkillsTable()
        {
            using var connection = SqliteHelper.GetConnection();
            var command = connection.CreateCommand();
            command.CommandText = @"
                CREATE TABLE IF NOT EXISTS UserSkills (
                    UserId TEXT,
                    SkillId TEXT,
                    PRIMARY KEY (UserId, SkillId),
                    FOREIGN KEY (UserId) REFERENCES Users(Id),
                    FOREIGN KEY (SkillId) REFERENCES Skills(Id)
                )";
            command.ExecuteNonQuery();
        }
    }
}
