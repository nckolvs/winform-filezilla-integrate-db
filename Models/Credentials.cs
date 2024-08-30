using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filezilla_integrate.Models
{
    internal class Credentials
    {
        public string Sftp { get; set; }
        public int Port { get; set; }
        public string User { get; set; }
        public string Pass { get; set; }
    }
}
