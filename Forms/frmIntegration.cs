using filezilla_integrate.Models;
using filezilla_integrate.Auxiliar;

namespace filezilla_integrate
{
    public partial class frmIntegration : Form
    {
        private FilezillaIntegrate? _filezillaIntegrate;

        DBQuery query = new DBQuery();
        public frmIntegration()
        {
            InitializeComponent();
            hideObjects(false);
            cboVoicePortal.DataSource = query.VoicePortalServers();
            cboVoicePortal.ValueMember = "ServerIp";
            cboVoicePortal.DisplayMember = "Servername";
            cboVoicePortal.Refresh();
        }

        private void LoadIntegration()
        {
            Credentials credentials = new Credentials
            {
                Sftp = cboVoicePortal.SelectedValue.ToString()!,//txtSftp.Text.Trim(),
                User = txtUser.Text.Trim(),
                Pass = txtPass.Text.Trim(),
                Port = int.Parse(txtPort.Text.Trim())
            };
            _filezillaIntegrate = new FilezillaIntegrate(credentials);
        }

        #region Events
        private void txtOrigin_TextChanged(object sender, EventArgs e)
        {
            btnUpload.Enabled = (txtOrigin.Text.EndsWith("\\") && txtRemote.Text.EndsWith("/")) ? true : false;
        }

        private void txtFile_TextChanged(object sender, EventArgs e)
        {
            btnDialplan.Enabled = (txtFile.Text.Contains(".xml") && txtRemote.Text.EndsWith("/")) ? true : false;
        }

        private void txtListCommand_TextChanged(object sender, EventArgs e)
        {
            btnListAll.Enabled = (txtListCommand.Text.EndsWith("/")) ? true : false;
        }

        private void txtPort_TextChanged(object sender, EventArgs e)
        {
            btnEnter.Enabled = txtPort.Text.Length != 0 && int.TryParse(txtPort.Text, out _) ? true : false;
        }
        #endregion

        private void btnEnter_Click(object sender, EventArgs e)
        {
            LoadIntegration();
            try
            {
                _filezillaIntegrate!.SftpConnect();
                _filezillaIntegrate.sshConnect();
                txtStatus.Text = "Connected to " + _filezillaIntegrate._credentials.Sftp;
                hideObjects(true);
            }
            catch (Exception ex) { txtStatus.Text = ex.Message; }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            txtStatus.Clear();
            string validOrigin = txtOrigin.Text.Trim().Substring(Path.GetDirectoryName(txtOrigin.Text)!.Length + 1, 1);
            string localFile = validOrigin != "\\" ? txtOrigin.Text + "\\" : txtOrigin.Text;

            string validRemote = txtRemote.Text.Trim().Substring(txtRemote.Text.Length - 1, 1);
            string remoteFile = validRemote != "/" ? txtRemote.Text + "/" : txtRemote.Text;
            bool integrate = _filezillaIntegrate!.SftpUpload(localFile, remoteFile, txtFile.Text);

            txtStatus.Text = (integrate) ? "File uploaded" : "File not found";
            btnReload.Visible = (integrate) ? true : false;
            txtReload.Visible = (integrate) ? true : false;
            btnUpload.Enabled = false;
        }

        #region Drag and Drop
        private void hideObjects(bool valid)
        {
            txtStatus.ReadOnly = true;
            txtListAll.ReadOnly = true;

            if (valid)
            {
                txtFile.Visible = true;
                txtOrigin.Visible = true;
                lblUpload.Visible = true;
                btnUpload.Visible = true;
                btnDialplan.Visible = true;

                //btnListAll.Enabled = true;
                txtListCommand.Enabled = true;
                txtRemote.Visible = true;
                btnDisconnect.Visible = true;

                btnExit.Visible = false;
            }
            else
            {
                txtFile.Visible = false;
                txtOrigin.Visible = false;
                lblUpload.Visible = false;
                btnUpload.Visible = false;
                btnUpload.Enabled = false;
                btnReload.Visible = false;
                txtReload.Visible = false;
                btnDialplan.Visible = false;
                btnDialplan.Enabled = false;
                txtListCommand.Enabled = false;
                btnListAll.Enabled = false;
                txtStatus.Enabled = false;
                txtRemote.Visible = false;
                btnDisconnect.Visible = false;

                btnExit.Visible = true;
                btnEnter.Enabled = false;
            }
        }
        #endregion

        private void btnReload_Click(object sender, EventArgs e)
        {
            txtStatus.Clear();
            txtStatus.Text = _filezillaIntegrate!.sshExecute(txtReload.Text);
        }

        private void btnListAll_Click(object sender, EventArgs e)
        {
            foreach (string txt in _filezillaIntegrate!.sshListAll(txtListCommand.Text))
            {
                txtListAll.Text += txt;
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            _filezillaIntegrate!.Disconnect();
            Environment.Exit(0);
        }

        private void btnDialplan_Click(object sender, EventArgs e)
        {
            frmDialplan dialplan = new frmDialplan(_filezillaIntegrate!, txtFile.Text, txtRemote.Text);
            dialplan.ShowDialog();

            if (dialplan.reload)
            {
                btnReload.Enabled = true;
                btnReload.Visible = true;

                txtReload.Visible = true;
            }
            else
            {
                btnReload.Enabled = false;
                btnReload.Visible = false;

                txtReload.Visible = false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

    }
}