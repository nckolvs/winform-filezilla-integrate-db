using filezilla_integrate.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filezilla_integrate.Interfaces
{
    internal interface ISQLConn<TDataReader, TParam, TConnection>
    {
        int ExecuteDML(string query);
        DataTable CollectTable(string query);
        DataTable CollectProcedure(string query, List<TParam> values);
        TDataReader ExecuteQuery(string query);
        object ReturnId(string query);
        void CloseConnection(TConnection conn);
    }
}
