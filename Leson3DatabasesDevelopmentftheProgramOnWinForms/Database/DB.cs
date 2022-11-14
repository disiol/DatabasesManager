using System;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Leson3DatabasesDevelopmentftheProgramOnWinForms.Database
{
    class DB
    {
        private const string HOST = "localhost";
        private const string PORT = "3306"; // 3306
        private const string DATABASE = "itproger";
        private const string USER = "root"; // mysql
        private const string PASS = "1"; // ""
        private string _connect;
        private MySqlCommand _command;

        public void ConectToDb()
        {
            _connect = $"Server={HOST};User={USER};Password={PASS};Database={DATABASE};Port={PORT};";
          
            string tableIfNotExistsUsersIdIntAutoIncrementPrimaryKeyLoginVarchar = "CREATE TABLE IF NOT EXISTS users (" +
                "id INT(11) AUTO_INCREMENT PRIMARY KEY," +
                "login VARCHAR(50)," +
                "password VARCHAR(50)" +
                ") ENGINE=MYISAM";

            Connect(tableIfNotExistsUsersIdIntAutoIncrementPrimaryKeyLoginVarchar);

        }
        
        public void CrateDb(string nameDatabase)
        {
            _connect = $"Server={HOST};User={USER};Password={PASS};Port={PORT};";
            _command.CommandText ="CREATE DATABASE IF NOT EXISTS Euniversity" ;

        }

        private async Task Connect(string commandCommandText)
        {
            using (MySqlConnection conn = new MySqlConnection(_connect))
            {
                try
                {
                    await conn.OpenAsync();
                    Console.WriteLine("Open");

                    _command = new MySqlCommand();


                    
                    
                    _command.CommandText = commandCommandText;
                    _command.Connection = conn;
                    await _command.ExecuteNonQueryAsync();
                    Console.WriteLine("Dne");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
                finally
                {
                    await _command.Connection.CloseAsync();
                    Console.WriteLine("CloseAsync");
                }
            }
        }
    }
}