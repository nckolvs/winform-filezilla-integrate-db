using System.Configuration;
using static filezilla_integrate.Enums.SQLProvider;
using Olos.Utils;

namespace filezilla_integrate.Models
{
    internal class SQLData
    {
        EncryptDecrypt decr = new EncryptDecrypt();
        public Provider? Provider
        {
            get
            {
                return (Provider)int.Parse(ConfigurationManager.AppSettings["SQLDbProvider"]!);
            }
        }
        public string? Servername
        {
            get
            {
                return decr.DecryptText(ConfigurationManager.AppSettings["SQLDbServer"]!);
            }
        }
        public string? Dbname
        {
            get
            {
                return decr.DecryptText(ConfigurationManager.AppSettings["SQLDatabase"]!);
            }
        }
        public string? Username
        {
            get
            {
                return decr.DecryptText(ConfigurationManager.AppSettings["SQLDbUsername"]!);
            }
        }
        public string? Password
        {
            get
            {
                return decr.DecryptText(ConfigurationManager.AppSettings["SQLDbPassword"]!);
            }
        }
        public string? Port
        {
            get
            {
                return decr.DecryptText(ConfigurationManager.AppSettings["SQLDbPort"]!);
            }
        }
    }
}
