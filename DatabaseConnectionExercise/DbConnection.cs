using System;

namespace DatabaseConnectionExercise
{
    public abstract class DbConnection
    {
        private readonly string _connectionString;
        private readonly TimeSpan _timeout;

        public DbConnection(string connectionString)
        {
            if(string.IsNullOrEmpty(connectionString))
                throw new InvalidOperationException("must have valid connection string");

            _connectionString = connectionString;
        }

        public abstract void Open();
        public abstract void Close();
    }
}