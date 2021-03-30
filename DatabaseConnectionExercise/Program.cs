using System;

namespace DatabaseConnectionExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var sql = new SqlConnection("sql connection string");
            sql.Open();
            sql.Close();

            var oracle = new OracleConnection("oracled connection string");
            oracle.Open();
            oracle.Close();
        }
    }
}
