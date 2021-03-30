using System;

namespace DatabaseConnectionExercise
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        public DbConnection(string connectionString)
        {
            if(string.IsNullOrEmpty(connectionString))
                throw new InvalidOperationException("must have valid connection string");

            ConnectionString = connectionString;
        }

        public abstract void Open();
        public abstract void Close();
    }
}