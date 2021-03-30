using System;

namespace DatabaseConnectionExercise
{
    public class DbCommand
    {
        private DbConnection _connection;
        private string _dbInstruction;

        public DbCommand(DbConnection connection, string dbInstruction)
        {
            if(connection == null)
                throw new InvalidOperationException("null DbConnection");

            if(string.IsNullOrEmpty(dbInstruction))
                throw new InvalidOperationException("No Instructions");

            _connection = connection;
            _dbInstruction = dbInstruction;
        }

        public void Execute()
        {
            _connection.Open();

            Console.WriteLine(_dbInstruction);

            _connection.Close();
        }
    }
}