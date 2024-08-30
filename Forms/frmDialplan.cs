using filezilla_integrate.Auxiliar;
using filezilla_integrate.Models;

namespace filezilla_integrate
{
    internal partial class frmDialplan : Form
    {
        private readonly FilezillaIntegrate _filezillaIntegrate;
        private readonly string _file;
        private readonly string _remoteFile;
        private string dialplan = string.Empty;
        public bool reload = false;

        public frmDialplan(FilezillaIntegrate filezillaIntegrate, string file, string remoteFile)
        {
            InitializeComponent();

            this._filezillaIntegrate = filezillaIntegrate;
            this._file = file;
            this._remoteFile = remoteFile;

            loadDialplan();
        }

        private void loadDialplan()
        {
            _filezillaIntegrate.openDialplan(_file, _remoteFile).ForEach(x => dialplan += x);

            HandlerXML xml = new HandlerXML();
            FieldDialplan fields = xml.returnFields(dialplan);

            txtDialField01.Text = fields.Dialplan;
            txtDialField02.Text = fields.DestInboundCampaign.ToString();
            txtDialField03.Text = fields.NameMailingField;
            txtDialField04.Text = fields.Announcer;
            txtDialField05.Text = fields.Persona;
            txtDialField06.Text = fields.GenderAnnouncer.ToString();
            txtDialField07.Text = fields.Enable8Personas.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FieldDialplan fields = new FieldDialplan
            {
                Dialplan = txtDialField01.Text,
                DestInboundCampaign = int.Parse(txtDialField02.Text),
                NameMailingField = txtDialField03.Text,
                Announcer = txtDialField04.Text,
                Persona = txtDialField05.Text,
                GenderAnnouncer = Convert.ToChar(txtDialField06.Text),
                Enable8Personas = Convert.ToBoolean(txtDialField07.Text)
            };

            if (_filezillaIntegrate.editDialplan(_file, _remoteFile, dialplan!, fields))
            {
                MessageBox.Show("Dialplan saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                reload = true;
            }
            else MessageBox.Show("Dialplan failed to save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnDuplicate_Click(object sender, EventArgs e)
        {
            FieldDialplan fields = new FieldDialplan
            {
                Dialplan = txtDialField01.Text,
                DestInboundCampaign = int.Parse(txtDialField02.Text),
                NameMailingField = txtDialField03.Text,
                Announcer = txtDialField04.Text,
                Persona = txtDialField05.Text,
                GenderAnnouncer = Convert.ToChar(txtDialField06.Text),
                Enable8Personas = Convert.ToBoolean(txtDialField07.Text)
            };

            if (_filezillaIntegrate.editDialplan(String.Format("{0}.xml", fields.Dialplan), _remoteFile, dialplan!, fields))
            {
                MessageBox.Show("Dialplan saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                reload = true;
            }
            else MessageBox.Show("Dialplan failed to save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            reload = false;
            this.Close();
        }

    }
}
