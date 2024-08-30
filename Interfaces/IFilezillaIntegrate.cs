using Microsoft.VisualBasic.ApplicationServices;
using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace filezilla_integrate.Interfaces
{
    internal interface IFilezillaIntegrate
    {
        SftpClient SftpConnect();
        bool SftpUpload(string localFile, string remoteFile, string file);

        SshClient sshConnect();
        string sshExecute(string command);
        List<string> sshListAll(string command);

        void Disconnect();
    }
}
