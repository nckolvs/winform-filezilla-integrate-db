using filezilla_integrate.Interfaces;
using filezilla_integrate.Models;
using System.Data;
using System.Data.SqlClient;

namespace filezilla_integrate.Database
{
    internal class MSSQL : ISQLConn<SqlDataReader, SqlParameter, SqlConnection>
    {
        private readonly SQLData? connData;
        private readonly SqlConnectionStringBuilder connString;

        public MSSQL(SQLData sql)
        {
            connData = sql;
            connString = new SqlConnectionStringBuilder
            {
                DataSource = connData!.Servername,
                InitialCatalog = connData.Dbname,
                UserID = connData.Username,
                Password = connData.Password,
                IntegratedSecurity = false
            };
        }

        public int ExecuteDML(string query)
        {
            SqlConnection conn = new SqlConnection(connString.ConnectionString);
            SqlCommand command = new SqlCommand();

            try
            {
                conn.Open();
                command.CommandText = query;
                command.Connection = conn;

                using (command) { return command.ExecuteNonQuery(); }
            }
            catch (Exception ex) { throw new Exception("Error: " + ex.Message.ToString()); }
        }

        public DataTable CollectTable(string query) 
        {   
            SqlConnection conn = new SqlConnection(connString.ConnectionString);
            SqlCommand command = new SqlCommand();                
            SqlDataAdapter fillFields = new SqlDataAdapter();
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
            catch (Exception ex) { throw new Exception("Error: " + ex.Message.ToString()); }
            finally { CloseConnection(conn); }
        }

        public DataTable CollectProcedure(string query, List<SqlParameter> values) 
        {   
            SqlConnection conn = new SqlConnection(connString.ConnectionString);
            SqlCommand command = new SqlCommand();                
            SqlDataAdapter fillFields = new SqlDataAdapter();
            DataTable dt = new DataTable();

            try
            {
                conn.Open();
                command.CommandText = query;
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = conn;

                foreach (SqlParameter param in values) { command.Parameters.Add(param); }

                fillFields.SelectCommand = command;
                fillFields.Fill(dt);
                return (dt);
            }
            catch (Exception ex) { throw new Exception("Error: " + ex.Message.ToString()); }
            finally { CloseConnection(conn); }
        }

        public SqlDataReader ExecuteQuery(string query) 
        {   
            SqlConnection conn = new SqlConnection(connString.ConnectionString);
            SqlCommand command = new SqlCommand();

            try
            {
                conn.Open();
                command.CommandText = query;
                command.CommandType = CommandType.Text;
                command.Connection = conn;

                return command.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex) { throw new Exception("Error: " + ex.Message.ToString()); }
        }

        public object ReturnId(string query) 
        {
            SqlConnection conn = new SqlConnection(connString.ConnectionString);
            SqlCommand command = new SqlCommand();

            try
            {
                conn.Open();
                command.CommandText = query;
                command.CommandType = CommandType.Text;
                command.Connection = conn;

                using (command) { return command.ExecuteScalar(); }
            }
            catch (Exception ex) { throw new Exception("Error: " + ex.Message.ToString()); }
            finally { CloseConnection(conn); }
        }

        public void CloseConnection(SqlConnection conn)
        {
            if (conn.State == ConnectionState.Open) conn.Close();
        }
    }
}