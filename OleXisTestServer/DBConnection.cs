using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using MySql.Data.MySqlClient;

namespace OleXisTestServer
{
    static class DBConnection
    {
        static MySqlConnection connection;

        static public void Connect(string connectionString, string database)
        {
            if (connection != null)
                Disconnect();
            connection = new MySqlConnection(connectionString);
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = "SELECT SCHEMA_NAME FROM INFORMATION_SCHEMA.SCHEMATA WHERE SCHEMA_NAME = '" + database + "'";
            var result = command.ExecuteReader();
            if (result.Read())
            {
                result.Close();
                command = connection.CreateCommand();
                command.CommandText = "use " + database;
                command.ExecuteNonQuery();
            }
            else
            {
                result.Close();
                PrepareDBFirstUse(database);
            }
        }

        static public MySqlCommand PrepareExecProcedureCommand(string procname, params string[] _params)
        {
            var command = connection.CreateCommand();
            var commandText = new StringBuilder("call " + procname + "(");
            for(var i = 0; i < _params.Length; i++)
            {
                commandText.Append("@param");
                commandText.Append(i);
                commandText.Append(",");
                command.Parameters.Add(new MySqlParameter("@param" + i, _params[i]));
            }
            commandText.Remove(commandText.Length - 1, 1);
            if(_params.Length > 0)
                commandText.Append(")");
            command.CommandText = commandText.ToString();
            return command;
        }

        static public MySqlCommand GetCommand()
        {
            return connection.CreateCommand();
        }

        static public void Disconnect()
        {
            connection.Close();
        }

        static private void PrepareDBFirstUse(string database)
        {
            var command = connection.CreateCommand();
            command = connection.CreateCommand();
            command.CommandText = "CREATE SCHEMA IF NOT EXISTS `" + database + "` DEFAULT CHARACTER SET utf8";
            command.ExecuteNonQuery();
            command = connection.CreateCommand();
            command.CommandText = "use " + database;
            command.ExecuteNonQuery();

            var script = new MySqlScript(connection, File.ReadAllText("SQL/create_database.sql", Encoding.UTF8));
            script.Execute();

            script = new MySqlScript(connection, File.ReadAllText("SQL/sql.sql", Encoding.UTF8));
            script.Delimiter = "$";
            script.Execute();

            script = new MySqlScript(connection, File.ReadAllText("SQL/first_user.sql", Encoding.UTF8));
            script.Execute();
        }
    }
}
