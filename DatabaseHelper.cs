using System;
using System.Data.SQLite;

namespace Zadanie
{
    public static class DatabaseHelper
    {
        private const string ConnectionString = "Data Source=books.db;Version=3;";

        public static void InitializeDatabase()
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                string createTableQuery = @"
                    CREATE TABLE IF NOT EXISTS Books (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Title TEXT NOT NULL,
                        Author TEXT NOT NULL,
                        Genre TEXT NOT NULL
                    );";
                var command = new SQLiteCommand(createTableQuery, connection);
                command.ExecuteNonQuery();
            }
        }

        public static SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(ConnectionString);
        }

        public static List<string> GetBooksByGenre(string genre)
        {
            var books = new List<string>();
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = "SELECT Title FROM Books WHERE Genre = @Genre";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Genre", genre);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            books.Add(reader["Title"].ToString());
                        }
                    }
                }
            }
            return books;
        }
    }
}
