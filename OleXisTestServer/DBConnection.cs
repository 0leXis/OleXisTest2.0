using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using MySql.Data.MySqlClient;

namespace OleXisTestServer
{
    static class DBConnection
    {
        static MySqlConnection connection;

        static public void Connect(string connectionString)
        {
            if (connection != null)
                Disconnect();
            connection = new MySqlConnection(connectionString);
            connection.Open();
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
            commandText.Append(")");
            command.CommandText = commandText.ToString();
            return command;
        }

        static public void Disconnect()
        {
            connection.Close();
        }
    }
}
