using System.Security.Cryptography.X509Certificates;

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

            var sqlCommand = new DbCommand(sql,"execute a sql query");
            sqlCommand.Execute();

            var oracleComman = new DbCommand(oracle, "execute an oracle query");
            oracleComman.Execute();
        }
    }
}
