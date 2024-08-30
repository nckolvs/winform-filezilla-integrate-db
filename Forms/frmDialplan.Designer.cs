namespace filezilla_integrate
{
    partial class frmDialplan
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
            btnUpdate = new Button();
            btnBack = new Button();
            txtDialField01 = new TextBox();
            txtDialField02 = new TextBox();
            txtDialField03 = new TextBox();
            txtDialField04 = new TextBox();
            txtDialField05 = new TextBox();
            txtDialField06 = new TextBox();
            txtDialField07 = new TextBox();
            lblDialplan = new Label();
            lblInbound = new Label();
            lblMailing = new Label();
            lblAnnouncer = new Label();
            lblPersona = new Label();
            lblGender = new Label();
            lblEight = new Label();
            btnDuplicate = new Button();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Top;
            btnUpdate.Location = new Point(255, 261);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(103, 27);
            btnUpdate.TabIndex = 20;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Top;
            btnBack.Location = new Point(255, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(103, 27);
            btnBack.TabIndex = 21;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // txtDialField01
            // 
            txtDialField01.Location = new Point(116, 53);
            txtDialField01.Name = "txtDialField01";
            txtDialField01.Size = new Size(242, 23);
            txtDialField01.TabIndex = 22;
            // 
            // txtDialField02
            // 
            txtDialField02.Location = new Point(116, 82);
            txtDialField02.Name = "txtDialField02";
            txtDialField02.Size = new Size(242, 23);
            txtDialField02.TabIndex = 23;
            // 
            // txtDialField03
            // 
            txtDialField03.Location = new Point(116, 111);
            txtDialField03.Name = "txtDialField03";
            txtDialField03.Size = new Size(242, 23);
            txtDialField03.TabIndex = 24;
            // 
            // txtDialField04
            // 
            txtDialField04.Location = new Point(116, 140);
            txtDialField04.Name = "txtDialField04";
            txtDialField04.Size = new Size(242, 23);
            txtDialField04.TabIndex = 25;
            // 
            // txtDialField05
            // 
            txtDialField05.Location = new Point(116, 169);
            txtDialField05.Name = "txtDialField05";
            txtDialField05.Size = new Size(242, 23);
            txtDialField05.TabIndex = 26;
            // 
            // txtDialField06
            // 
            txtDialField06.Location = new Point(116, 198);
            txtDialField06.Name = "txtDialField06";
            txtDialField06.Size = new Size(242, 23);
            txtDialField06.TabIndex = 27;
            // 
            // txtDialField07
            // 
            txtDialField07.Location = new Point(116, 227);
            txtDialField07.Name = "txtDialField07";
            txtDialField07.Size = new Size(242, 23);
            txtDialField07.TabIndex = 28;
            // 
            // lblDialplan
            // 
            lblDialplan.AutoSize = true;
            lblDialplan.Location = new Point(60, 56);
            lblDialplan.Name = "lblDialplan";
            lblDialplan.Size = new Size(50, 15);
            lblDialplan.TabIndex = 30;
            lblDialplan.Text = "Dialplan";
            // 
            // lblInbound
            // 
            lblInbound.AutoSize = true;
            lblInbound.Location = new Point(3, 85);
            lblInbound.Name = "lblInbound";
            lblInbound.Size = new Size(107, 15);
            lblInbound.TabIndex = 31;
            lblInbound.Text = "InboundCampaign";
            // 
            // lblMailing
            // 
            lblMailing.AutoSize = true;
            lblMailing.Location = new Point(38, 114);
            lblMailing.Name = "lblMailing";
            lblMailing.Size = new Size(72, 15);
            lblMailing.TabIndex = 32;
            lblMailing.Text = "MailingField";
            // 
            // lblAnnouncer
            // 
            lblAnnouncer.AutoSize = true;
            lblAnnouncer.Location = new Point(44, 143);
            lblAnnouncer.Name = "lblAnnouncer";
            lblAnnouncer.Size = new Size(66, 15);
            lblAnnouncer.TabIndex = 33;
            lblAnnouncer.Text = "Announcer";
            // 
            // lblPersona
            // 
            lblPersona.AutoSize = true;
            lblPersona.Location = new Point(61, 172);
            lblPersona.Name = "lblPersona";
            lblPersona.Size = new Size(49, 15);
            lblPersona.TabIndex = 34;
            lblPersona.Text = "Persona";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(65, 201);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(45, 15);
            lblGender.TabIndex = 35;
            lblGender.Text = "Gender";
            // 
            // lblEight
            // 
            lblEight.AutoSize = true;
            lblEight.Location = new Point(15, 230);
            lblEight.Name = "lblEight";
            lblEight.Size = new Size(95, 15);
            lblEight.TabIndex = 36;
            lblEight.Text = "Enable8Personas";
            // 
            // btnDuplicate
            // 
            btnDuplicate.Anchor = AnchorStyles.Top;
            btnDuplicate.Location = new Point(116, 261);
            btnDuplicate.Name = "btnDuplicate";
            btnDuplicate.Size = new Size(103, 27);
            btnDuplicate.TabIndex = 37;
            btnDuplicate.Text = "Duplicate";
            btnDuplicate.UseVisualStyleBackColor = true;
            btnDuplicate.Click += btnDuplicate_Click;
            // 
            // frmDialplan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(372, 300);
            Controls.Add(btnDuplicate);
            Controls.Add(lblEight);
            Controls.Add(lblGender);
            Controls.Add(lblPersona);
            Controls.Add(lblAnnouncer);
            Controls.Add(lblMailing);
            Controls.Add(lblInbound);
            Controls.Add(lblDialplan);
            Controls.Add(txtDialField07);
            Controls.Add(txtDialField06);
            Controls.Add(txtDialField05);
            Controls.Add(txtDialField04);
            Controls.Add(txtDialField03);
            Controls.Add(txtDialField02);
            Controls.Add(txtDialField01);
            Controls.Add(btnBack);
            Controls.Add(btnUpdate);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmDialplan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmDialplan";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnUpdate;
        private Button btnBack;
        private TextBox txtDialField01;
        private TextBox txtDialField02;
        private TextBox txtDialField03;
        private TextBox txtDialField04;
        private TextBox txtDialField05;
        private TextBox txtDialField06;
        private TextBox txtDialField07;
        private Label lblDialplan;
        private Label lblInbound;
        private Label lblMailing;
        private Label lblAnnouncer;
        private Label lblPersona;
        private Label lblGender;
        private Label lblEight;
        private Button btnDuplicate;
    }
}