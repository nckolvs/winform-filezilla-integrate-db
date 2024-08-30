using filezilla_integrate.Interfaces;
using filezilla_integrate.Models;
using Npgsql;
using System.Data;

namespace filezilla_integrate.Database
{
    internal class PostgreSQL : ISQLConn<NpgsqlDataReader, NpgsqlParameter, NpgsqlConnection>
    {
        private readonly SQLData? connData;
        private readonly NpgsqlConnectionStringBuilder connString;

        public PostgreSQL(SQLData sql)
        {
            connData = sql;
            connString = new NpgsqlConnectionStringBuilder
            {
                Host = connData!.Servername,
                Port = int.Parse(connData.Port!),
                Username = connData.Username,
                Password = connData.Password,
                Database = connData.Dbname,
            };
        }

        public int ExecuteDML(string query)
        {
            NpgsqlConnection conn = new NpgsqlConnection(connString.ConnectionString);
            NpgsqlCommand command = new NpgsqlCommand();

            try
            {
                conn.Open();
                command.CommandText = query;
                command.Connection = conn;

                using (command) { return command.ExecuteNonQuery(); }
            }
            catch (NpgsqlException ex) { throw new NpgsqlException("Error: " + ex.Message.ToString()); }
            finally { CloseConnection(conn); }
        }

        public DataTable CollectTable(string query) 
        {   
            NpgsqlConnection conn = new NpgsqlConnection(connString.ConnectionString);
            NpgsqlCommand command = new NpgsqlCommand();
            NpgsqlDataAdapter fillFields = new NpgsqlDataAdapter();
            DataTable dt = new DataTable();

            try
            {
                conn.Open();
                command.CommandText = query;
                command.CommandType = CommandType.Text;
                command.Connection = conn;

                fillFields.SelectCommand = command;
                fillFields.Fill(dt);
                return (dt);
            }
            catch (NpgsqlException ex) { throw new NpgsqlException("Error: " + ex.Message.ToString()); }
            finally { CloseConnection(conn); }
        }

        public DataTable CollectProcedure(string query, List<NpgsqlParameter> values) 
        {
            NpgsqlConnection conn = new NpgsqlConnection(connString.ConnectionString);
            NpgsqlCommand command = new NpgsqlCommand();
            NpgsqlDataAdapter fillFields = new NpgsqlDataAdapter();
            DataTable dt = new DataTable();

            try
            {
                conn.Open();
                command.CommandText = query;
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = conn;

                foreach (NpgsqlParameter value in values) command.Parameters.Add(value);

                fillFields.SelectCommand = command;
                fillFields.Fill(dt);
                return (dt);
            }
            catch (NpgsqlException ex) { throw new NpgsqlException("Error: " + ex.Message.ToString()); }
            finally { CloseConnection(conn); }
        }

        public NpgsqlDataReader ExecuteQuery(string query) 
        {   
            NpgsqlConnection conn = new NpgsqlConnection(connString.ConnectionString);
            NpgsqlCommand command = new NpgsqlCommand();

            try
            {
                conn.Open();
                command.CommandText = query;
                command.CommandType = CommandType.Text;
                command.Connection = conn;

                return command.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (NpgsqlException ex) { throw new NpgsqlException("Error: " + ex.Message.ToString()); }
        }

        public object ReturnId(string query) 
        {
            NpgsqlConnection conn = new NpgsqlConnection(connString.ConnectionString);
            NpgsqlCommand command = new NpgsqlCommand();

            try
            {
                conn.Open();
                command.CommandText = query;
                command.CommandType = CommandType.Text;
                command.Connection = conn;

                using (command) { return command.ExecuteScalar()!; }
            }
            catch (NpgsqlException ex) { throw new NpgsqlException("Error: " + ex.Message.ToString()); }
            finally { CloseConnection(conn); }
        }

        public void CloseConnection(NpgsqlConnection conn)
        {
            if (conn.State == ConnectionState.Open) conn.Close();
        }        
    }
 }
