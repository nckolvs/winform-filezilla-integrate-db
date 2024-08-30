namespace filezilla_integrate
{
    partial class frmIntegration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIntegration));
            txtPass = new TextBox();
            txtPort = new TextBox();
            txtUser = new TextBox();
            txtStatus = new TextBox();
            txtOrigin = new TextBox();
            btnEnter = new Button();
            btnUpload = new Button();
            lblSftp = new Label();
            lblUser = new Label();
            lblPass = new Label();
            lblUpload = new Label();
            lbloPort = new Label();
            txtFile = new TextBox();
            btnReload = new Button();
            txtReload = new TextBox();
            btnListAll = new Button();
            txtListAll = new TextBox();
            txtListCommand = new TextBox();
            btnDisconnect = new Button();
            btnDialplan = new Button();
            lblFilezilla = new Label();
            pbxFilezilla = new PictureBox();
            label1 = new Label();
            txtRemote = new TextBox();
            btnExit = new Button();
            cboVoicePortal = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pbxFilezilla).BeginInit();
            SuspendLayout();
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtPass.Location = new Point(84, 118);
            txtPass.Multiline = true;
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(192, 25);
            txtPass.TabIndex = 2;
            // 
            // txtPort
            // 
            txtPort.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtPort.Location = new Point(282, 90);
            txtPort.Multiline = true;
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(57, 25);
            txtPort.TabIndex = 3;
            txtPort.TextChanged += txtPort_TextChanged;
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtUser.Location = new Point(84, 90);
            txtUser.Multiline = true;
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(192, 25);
            txtUser.TabIndex = 1;
            // 
            // txtStatus
            // 
            txtStatus.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtStatus.Location = new Point(345, 63);
            txtStatus.Multiline = true;
            txtStatus.Name = "txtStatus";
            txtStatus.ScrollBars = ScrollBars.Vertical;
            txtStatus.Size = new Size(267, 80);
            txtStatus.TabIndex = 4;
            // 
            // txtOrigin
            // 
            txtOrigin.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtOrigin.Location = new Point(116, 178);
            txtOrigin.Multiline = true;
            txtOrigin.Name = "txtOrigin";
            txtOrigin.Size = new Size(496, 25);
            txtOrigin.TabIndex = 0;
            txtOrigin.TextChanged += txtOrigin_TextChanged;
            // 
            // btnEnter
            // 
            btnEnter.Location = new Point(282, 121);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(57, 22);
            btnEnter.TabIndex = 4;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(26, 177);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(83, 57);
            btnUpload.TabIndex = 0;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // lblSftp
            // 
            lblSftp.AutoSize = true;
            lblSftp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSftp.Location = new Point(26, 62);
            lblSftp.Name = "lblSftp";
            lblSftp.Size = new Size(44, 21);
            lblSftp.TabIndex = 8;
            lblSftp.Text = "SFTP";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUser.Location = new Point(26, 90);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(42, 21);
            lblUser.TabIndex = 9;
            lblUser.Text = "User";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPass.Location = new Point(26, 118);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(40, 21);
            lblPass.TabIndex = 10;
            lblPass.Text = "Pass";
            // 
            // lblUpload
            // 
            lblUpload.AutoSize = true;
            lblUpload.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUpload.Location = new Point(26, 153);
            lblUpload.Name = "lblUpload";
            lblUpload.Size = new Size(84, 21);
            lblUpload.TabIndex = 12;
            lblUpload.Text = "UploadFile";
            // 
            // lbloPort
            // 
            lbloPort.AutoSize = true;
            lbloPort.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbloPort.Location = new Point(291, 63);
            lbloPort.Name = "lbloPort";
            lbloPort.Size = new Size(38, 21);
            lbloPort.TabIndex = 13;
            lbloPort.Text = "Port";
            // 
            // txtFile
            // 
            txtFile.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtFile.Location = new Point(116, 240);
            txtFile.Multiline = true;
            txtFile.Name = "txtFile";
            txtFile.Size = new Size(497, 25);
            txtFile.TabIndex = 0;
            txtFile.TextChanged += txtFile_TextChanged;
            // 
            // btnReload
            // 
            btnReload.Location = new Point(27, 276);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(83, 25);
            btnReload.TabIndex = 14;
            btnReload.Text = "Reload";
            btnReload.UseVisualStyleBackColor = true;
            btnReload.Click += btnReload_Click;
            // 
            // txtReload
            // 
            txtReload.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtReload.Location = new Point(115, 276);
            txtReload.Name = "txtReload";
            txtReload.ScrollBars = ScrollBars.Vertical;
            txtReload.Size = new Size(497, 25);
            txtReload.TabIndex = 15;
            // 
            // btnListAll
            // 
            btnListAll.Location = new Point(628, 276);
            btnListAll.Name = "btnListAll";
            btnListAll.Size = new Size(526, 25);
            btnListAll.TabIndex = 16;
            btnListAll.Text = "ListAll";
            btnListAll.UseVisualStyleBackColor = true;
            btnListAll.Click += btnListAll_Click;
            // 
            // txtListAll
            // 
            txtListAll.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtListAll.Location = new Point(628, 94);
            txtListAll.Multiline = true;
            txtListAll.Name = "txtListAll";
            txtListAll.ScrollBars = ScrollBars.Vertical;
            txtListAll.Size = new Size(526, 176);
            txtListAll.TabIndex = 17;
            // 
            // txtListCommand
            // 
            txtListCommand.AcceptsReturn = true;
            txtListCommand.AcceptsTab = true;
            txtListCommand.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtListCommand.Location = new Point(708, 63);
            txtListCommand.Name = "txtListCommand";
            txtListCommand.ScrollBars = ScrollBars.Vertical;
            txtListCommand.Size = new Size(446, 25);
            txtListCommand.TabIndex = 18;
            txtListCommand.TextChanged += txtListCommand_TextChanged;
            // 
            // btnDisconnect
            // 
            btnDisconnect.Location = new Point(1018, 17);
            btnDisconnect.Name = "btnDisconnect";
            btnDisconnect.Size = new Size(83, 32);
            btnDisconnect.TabIndex = 19;
            btnDisconnect.Text = "Disconnect";
            btnDisconnect.UseVisualStyleBackColor = true;
            btnDisconnect.Click += btnDisconnect_Click;
            // 
            // btnDialplan
            // 
            btnDialplan.Location = new Point(27, 239);
            btnDialplan.Name = "btnDialplan";
            btnDialplan.Size = new Size(82, 26);
            btnDialplan.TabIndex = 20;
            btnDialplan.Text = "Dialplan";
            btnDialplan.UseVisualStyleBackColor = true;
            btnDialplan.Click += btnDialplan_Click;
            // 
            // lblFilezilla
            // 
            lblFilezilla.AutoSize = true;
            lblFilezilla.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblFilezilla.Location = new Point(69, 17);
            lblFilezilla.Name = "lblFilezilla";
            lblFilezilla.Size = new Size(235, 32);
            lblFilezilla.TabIndex = 21;
            lblFilezilla.Text = "Filezilla Integration";
            // 
            // pbxFilezilla
            // 
            pbxFilezilla.Image = (Image)resources.GetObject("pbxFilezilla.Image");
            pbxFilezilla.Location = new Point(28, 17);
            pbxFilezilla.Name = "pbxFilezilla";
            pbxFilezilla.Size = new Size(38, 38);
            pbxFilezilla.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxFilezilla.TabIndex = 22;
            pbxFilezilla.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(628, 65);
            label1.Name = "label1";
            label1.Size = new Size(74, 21);
            label1.TabIndex = 23;
            label1.Text = "Directory";
            // 
            // txtRemote
            // 
            txtRemote.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtRemote.Location = new Point(116, 209);
            txtRemote.Multiline = true;
            txtRemote.Name = "txtRemote";
            txtRemote.Size = new Size(496, 25);
            txtRemote.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(1107, 17);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(47, 32);
            btnExit.TabIndex = 25;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // cboVoicePortal
            // 
            cboVoicePortal.FormattingEnabled = true;
            cboVoicePortal.Location = new Point(84, 65);
            cboVoicePortal.Name = "cboVoicePortal";
            cboVoicePortal.Size = new Size(192, 21);
            cboVoicePortal.TabIndex = 0;
            // 
            // frmIntegration
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1174, 321);
            Controls.Add(cboVoicePortal);
            Controls.Add(btnExit);
            Controls.Add(txtRemote);
            Controls.Add(label1);
            Controls.Add(pbxFilezilla);
            Controls.Add(lblFilezilla);
            Controls.Add(btnDialplan);
            Controls.Add(btnDisconnect);
            Controls.Add(txtListCommand);
            Controls.Add(txtListAll);
            Controls.Add(btnListAll);
            Controls.Add(btnReload);
            Controls.Add(txtReload);
            Controls.Add(txtFile);
            Controls.Add(lbloPort);
            Controls.Add(lblUpload);
            Controls.Add(lblPass);
            Controls.Add(lblUser);
            Controls.Add(lblSftp);
            Controls.Add(btnUpload);
            Controls.Add(btnEnter);
            Controls.Add(txtOrigin);
            Controls.Add(txtStatus);
            Controls.Add(txtUser);
            Controls.Add(txtPort);
            Controls.Add(txtPass);
            Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "frmIntegration";
            Padding = new Padding(17, 60, 17, 17);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Integration";
            ((System.ComponentModel.ISupportInitialize)pbxFilezilla).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtPass;
        private TextBox txtPort;
        private TextBox txtUser;
        private TextBox txtStatus;
        private TextBox txtOrigin;
        private Button btnEnter;
        private Button btnUpload;
        private Label lblSftp;
        private Label lblUser;
        private Label lblPass;
        private Label lblUpload;
        private Label lbloPort;
        private TextBox txtFile;
        private Button btnReload;
        private TextBox txtReload;
        private Button btnListAll;
        private TextBox txtListAll;
        private TextBox txtListCommand;
        private Button btnDisconnect;
        private Button btnDialplan;
        private Label lblFilezilla;
        private PictureBox pbxFilezilla;
        private Label label1;
        private TextBox txtRemote;
        private Button btnExit;
        private ComboBox cboVoicePortal;
    }
}