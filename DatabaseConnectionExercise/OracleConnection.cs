using System;

namespace DatabaseConnectionExercise
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) :
            base(connectionString)
        {

        }

        public override void Open()
        {
            Console.WriteLine("Open OracleConnection");
        }

        public override void Close()
        {
            Console.WriteLine("Close OracleConnection");
        }
    }
}