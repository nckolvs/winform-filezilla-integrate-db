using Renci.SshNet;
using System.Text;
using System.Text.Unicode;
using filezilla_integrate.Interfaces;
using filezilla_integrate.Models;
using filezilla_integrate.Auxiliar;

namespace filezilla_integrate
{
    internal class FilezillaIntegrate : IFilezillaIntegrate
    {
        internal readonly Credentials _credentials;
        private SftpClient? client;
        private SshClient? ssh;

        public FilezillaIntegrate(Credentials credentials)
        {
            _credentials = credentials;
        }

        public void Disconnect()
        {
            client?.Disconnect();
            ssh?.Disconnect();

            client?.Dispose();
            ssh?.Dispose();
        }

        public SftpClient SftpConnect()
        {
            client = new SftpClient (
            _credentials.Sftp,
            _credentials.Port == 0 ? 22 : _credentials.Port,
            _credentials.User,
            _credentials.Pass
            );

            client.Connect();
            return client;
        }

        public bool SftpUpload(string localFile, string remoteFile, string file)
        {
            string local = Path.GetDirectoryName(localFile) + "\\" + file;
            
            if (Directory.Exists(localFile) && File.Exists(local))
            {   
                var openFile = File.OpenRead(Path.Combine(local));
                if (client!.IsConnected)
                {
                    string remote = remoteFile + file;
                    client.UploadFile(openFile, remote, true);
                    return true;
                }
            }
            return false;
        }

        public SshClient sshConnect()
        {
            ssh = new SshClient (
            _credentials.Sftp,
            _credentials.Port == 0 ? 22 : _credentials.Port,
            _credentials.User,
            _credentials.Pass
            );

            ssh.Connect();
            return ssh;
        }

        public string sshExecute(string command) 
        {
            if (ssh!.IsConnected) {
                //CreateShellStream é um recurso que permite a execução de comandos ssh no servidor remoto e captura a saída do comando em um objeto
                var stream = ssh.CreateShellStream("vt-100", 80, 24, 800, 600, 1024);
                stream.WriteLine(command);

                List<string> resultExec = new List<string>();
                string line;
                while ((line = stream.ReadLine(TimeSpan.FromSeconds(2))!) != null)
                {
                    resultExec.Add(line + Environment.NewLine);
                }

                foreach (string txt in resultExec) 
                {
                    if (txt.ToUpper().Contains("SUCCESS")) return txt.ToUpper();
                }
                stream.Close();
            }
            return new string("");
        }
        
        public List<string> sshListAll(string command) 
        {
            List<string> view = new List<string>();
            if (ssh!.IsConnected) {
                SshCommand sshCommand = ssh.CreateCommand(String.Format("cd {0} && ls -lh", command));
                var result = sshCommand.Execute().Split("\n");

                foreach (string txt in result)
                {
                    view.Add(txt + Environment.NewLine);
                }
            }
            return view;
        }

        public List<string> openDialplan(string file, string remote)
        {
            //SshCommand é um recurso que permite a execução de comandos ssh no servidor remoto e captura a saída do comando em um objeto
            List<string> view = new List<string>();
            if (ssh!.IsConnected) {
                SshCommand sshCommand = ssh.CreateCommand(String.Format("cd {0} && cat {1}", remote, file));
                var result = sshCommand.Execute().Split("\n");

                foreach (string txt in result)
                {
                    view.Add(txt + Environment.NewLine);
                }
            }
            return view;
        }

        public bool editDialplan(string file, string remote, string dial, FieldDialplan fields)
        {            
            if (client!.IsConnected) 
            {
                Encoding encoding = Encoding.UTF8;
                HandlerXML xml = new HandlerXML();
                string fileContent = xml.EditXML(fields, dial);
                byte[] fileUpdate = encoding.GetBytes(fileContent);

                //MemoryStream é um recursos que permite a leitura e escrita de bytes em um array de bytes
                using (MemoryStream fileUpdateMemory = new MemoryStream(fileUpdate)) 
                {
                    client.UploadFile(fileUpdateMemory, remote + file, true);
                    return true;
                }                
            }
            return false;
        }
    }
}
