using System.Data.SQLite;

namespace AppointmentSystem
{
    public static class DatabaseHelper
    {
        private const string ConnectionString = "Data Source=Appointments.db;Version=3;";

        // Method to initialize the database and create the Appointments table
        public static void InitializeDatabase()
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                string sql = @"
                CREATE TABLE IF NOT EXISTS Appointments (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL,
                    StudentId TEXT NOT NULL,
                    Email TEXT NOT NULL,
                    YearLevel TEXT NOT NULL,
                    TimeSlot TEXT NOT NULL,
                    AppointmentDateTime TEXT NOT NULL
                )";
                using (var command = new SQLiteCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
