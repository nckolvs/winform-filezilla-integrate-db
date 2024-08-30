using filezilla_integrate.Database;
using filezilla_integrate.Models;
using System.Data;
using System.Data.SqlClient;
using static filezilla_integrate.Enums.SQLProvider;

namespace filezilla_integrate.Auxiliar
{
    internal class DBQuery
    {
        private static readonly SQLData? connData = new SQLData();

        public List<VoicePortal> VoicePortalServers()
        {
            List<VoicePortal> list = new List<VoicePortal>();
            VoicePortal voicePortal;
            Dictionary<string, int> VPL = new Dictionary<string, int> {
                { "Servername", 0 }, { "ServerIp", 1 }
            };

            voicePortal = new VoicePortal
            {
                Servername = "",
                ServerIp = "0"
            };
            list.Add(voicePortal);

            foreach (DataRow row in ReturnVPL().Rows)
            {
                object[] array = row.ItemArray!;
                voicePortal = new VoicePortal {
                    Servername = array[VPL["Servername"]]!.ToString()!,
                    ServerIp = array[VPL["ServerIp"]]!.ToString()!
                };
                list.Add(voicePortal);
            }

            return list;
        }

        private static DataTable ReturnVPL()
        {
            string query = "", database = "[ProfessionalServices01]", schema = "[dbo]";
            if (connData!.Provider!.Value == Provider.MSSQL) {
                MSSQL conn = new MSSQL(connData);
                SqlDataReader x = conn.ExecuteQuery(String.Format("Select {0}.{1}.FN_ConvertIpToServer('{2}')", database, schema, connData!.Servername));

                if (x.Read()) query = x[0].ToString()!;

                string server = query;
                query = String.Format("SELECT * FROM {0}.{1}.{2}.ODA_VoicePortalServers", server, database, schema);
                return conn.CollectTable(query);
            } else {
                PostgreSQL conn = new PostgreSQL(connData);
                query = "SELECT * FROM ODA_VoicePortalServers";
                return conn.CollectTable(query);
            } 
        }
    }
}
