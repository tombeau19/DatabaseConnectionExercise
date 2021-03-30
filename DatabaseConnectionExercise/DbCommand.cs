using System;

namespace DatabaseConnectionExercise
{
    public class DbCommand
    {
        private readonly DbConnection _connection;
        private readonly string _dbInstruction;

        public DbCommand(DbConnection connection, string dbInstruction)
        {
            if(string.IsNullOrEmpty(dbInstruction))
                throw new InvalidOperationException("No Instructions");

            _connection = connection ?? throw new InvalidOperationException("null DbConnection");
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