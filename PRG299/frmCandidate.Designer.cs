namespace PRG299
{
    partial class frmCandidate
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lblLastName;
            System.Windows.Forms.Label lblFirstName;
            System.Windows.Forms.Label lblMiddleName;
            System.Windows.Forms.Label lblStreetAddress;
            System.Windows.Forms.Label lblCity;
            System.Windows.Forms.Label lblState;
            System.Windows.Forms.Label lblPostalCode;
            System.Windows.Forms.Label lblEmail;
            System.Windows.Forms.Label lblPhone;
            System.Windows.Forms.Label lblDescription;
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.addressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtStreetAddress = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.emailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.phoneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.candidateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblEnter = new System.Windows.Forms.Label();
            this.cboState = new System.Windows.Forms.ComboBox();
            this.btnMembershipLevel = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            lblLastName = new System.Windows.Forms.Label();
            lblFirstName = new System.Windows.Forms.Label();
            lblMiddleName = new System.Windows.Forms.Label();
            lblStreetAddress = new System.Windows.Forms.Label();
            lblCity = new System.Windows.Forms.Label();
            lblState = new System.Windows.Forms.Label();
            lblPostalCode = new System.Windows.Forms.Label();
            lblEmail = new System.Windows.Forms.Label();
            lblPhone = new System.Windows.Forms.Label();
            lblDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new System.Drawing.Point(368, 80);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new System.Drawing.Size(61, 13);
            lblLastName.TabIndex = 3;
            lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new System.Drawing.Point(12, 80);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new System.Drawing.Size(60, 13);
            lblFirstName.TabIndex = 5;
            lblFirstName.Text = "First Name:";
            // 
            // lblMiddleName
            // 
            lblMiddleName.AutoSize = true;
            lblMiddleName.Location = new System.Drawing.Point(184, 80);
            lblMiddleName.Name = "lblMiddleName";
            lblMiddleName.Size = new System.Drawing.Size(72, 13);
            lblMiddleName.TabIndex = 7;
            lblMiddleName.Text = "Middle Name:";
            // 
            // lblStreetAddress
            // 
            lblStreetAddress.AutoSize = true;
            lblStreetAddress.Location = new System.Drawing.Point(11, 106);
            lblStreetAddress.Name = "lblStreetAddress";
            lblStreetAddress.Size = new System.Drawing.Size(48, 13);
            lblStreetAddress.TabIndex = 20;
            lblStreetAddress.Text = "Address:";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new System.Drawing.Point(11, 132);
            lblCity.Name = "lblCity";
            lblCity.Size = new System.Drawing.Size(27, 13);
            lblCity.TabIndex = 22;
            lblCity.Text = "City:";
            // 
            // lblState
            // 
            lblState.AutoSize = true;
            lblState.Location = new System.Drawing.Point(184, 132);
            lblState.Name = "lblState";
            lblState.Size = new System.Drawing.Size(35, 13);
            lblState.TabIndex = 24;
            lblState.Text = "State:";
            // 
            // lblPostalCode
            // 
            lblPostalCode.AutoSize = true;
            lblPostalCode.Location = new System.Drawing.Point(261, 132);
            lblPostalCode.Name = "lblPostalCode";
            lblPostalCode.Size = new System.Drawing.Size(67, 13);
            lblPostalCode.TabIndex = 26;
            lblPostalCode.Text = "Postal Code:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new System.Drawing.Point(12, 198);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(35, 13);
            lblEmail.TabIndex = 30;
            lblEmail.Text = "Email:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new System.Drawing.Point(11, 171);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new System.Drawing.Size(41, 13);
            lblPhone.TabIndex = 36;
            lblPhone.Text = "Phone:";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new System.Drawing.Point(195, 171);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new System.Drawing.Size(63, 13);
            lblDescription.TabIndex = 38;
            lblDescription.Text = "Description:";
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataMember = "Person";
            // 
            // txtLastName
            // 
            this.txtLastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "contactLastName", true));
            this.txtLastName.Location = new System.Drawing.Point(435, 77);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 4;
            // 
            // txtFirstName
            // 
            this.txtFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "contactFirstName", true));
            this.txtFirstName.Location = new System.Drawing.Point(78, 77);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 6;
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "contactMiddleName", true));
            this.txtMiddleName.Location = new System.Drawing.Point(262, 77);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(100, 20);
            this.txtMiddleName.TabIndex = 8;
            // 
            // addressBindingSource
            // 
            this.addressBindingSource.DataMember = "Address";
            // 
            // txtStreetAddress
            // 
            this.txtStreetAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addressBindingSource, "streetAddress", true));
            this.txtStreetAddress.Location = new System.Drawing.Point(78, 103);
            this.txtStreetAddress.Name = "txtStreetAddress";
            this.txtStreetAddress.Size = new System.Drawing.Size(178, 20);
            this.txtStreetAddress.TabIndex = 21;
            // 
            // txtCity
            // 
            this.txtCity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addressBindingSource, "city", true));
            this.txtCity.Location = new System.Drawing.Point(78, 129);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 23;
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addressBindingSource, "postalCode", true));
            this.txtPostalCode.Location = new System.Drawing.Point(334, 129);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(100, 20);
            this.txtPostalCode.TabIndex = 27;
            // 
            // emailBindingSource
            // 
            this.emailBindingSource.DataMember = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.emailBindingSource, "email", true));
            this.txtEmail.Location = new System.Drawing.Point(78, 198);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(356, 20);
            this.txtEmail.TabIndex = 31;
            // 
            // phoneBindingSource
            // 
            this.phoneBindingSource.DataMember = "Phone";
            // 
            // txtPhone
            // 
            this.txtPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneBindingSource, "phone", true));
            this.txtPhone.Location = new System.Drawing.Point(78, 168);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 37;
            // 
            // txtDescription
            // 
            this.txtDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneBindingSource, "description", true));
            this.txtDescription.Location = new System.Drawing.Point(264, 168);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(170, 20);
            this.txtDescription.TabIndex = 39;
            // 
            // candidateBindingSource
            // 
            this.candidateBindingSource.DataMember = "Candidate";
            // 
            // lblEnter
            // 
            this.lblEnter.AutoSize = true;
            this.lblEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnter.Location = new System.Drawing.Point(10, 25);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(306, 24);
            this.lblEnter.TabIndex = 40;
            this.lblEnter.Text = "Please Enter Your Information...";
            // 
            // cboState
            // 
            this.cboState.FormattingEnabled = true;
            this.cboState.Location = new System.Drawing.Point(225, 129);
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(30, 21);
            this.cboState.TabIndex = 41;
            // 
            // btnMembershipLevel
            // 
            this.btnMembershipLevel.Location = new System.Drawing.Point(207, 278);
            this.btnMembershipLevel.Name = "btnMembershipLevel";
            this.btnMembershipLevel.Size = new System.Drawing.Size(141, 23);
            this.btnMembershipLevel.TabIndex = 42;
            this.btnMembershipLevel.Text = "Select Membership Level";
            this.btnMembershipLevel.UseVisualStyleBackColor = true;
            this.btnMembershipLevel.Click += new System.EventHandler(this.btnMembershipLevel_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(14, 228);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(58, 13);
            this.lblUsername.TabIndex = 43;
            this.lblUsername.Text = "Username:";
            this.lblUsername.Visible = false;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(79, 228);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(126, 20);
            this.txtUsername.TabIndex = 44;
            this.txtUsername.Visible = false;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(225, 228);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 45;
            this.lblPassword.Text = "Password:";
            this.lblPassword.Visible = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(288, 228);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(146, 20);
            this.txtPassword.TabIndex = 46;
            this.txtPassword.Visible = false;
            // 
            // frmCandidate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 313);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnMembershipLevel);
            this.Controls.Add(this.cboState);
            this.Controls.Add(this.lblEnter);
            this.Controls.Add(lblPhone);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(lblDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(lblStreetAddress);
            this.Controls.Add(this.txtStreetAddress);
            this.Controls.Add(lblCity);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(lblState);
            this.Controls.Add(lblPostalCode);
            this.Controls.Add(this.txtPostalCode);
            this.Controls.Add(lblLastName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(lblFirstName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(lblMiddleName);
            this.Controls.Add(this.txtMiddleName);
            this.Name = "frmCandidate";
            this.Text = "JobFinder - New Candidate";
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidateBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.BindingSource addressBindingSource;
        private System.Windows.Forms.TextBox txtStreetAddress;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.BindingSource emailBindingSource;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.BindingSource phoneBindingSource;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.BindingSource candidateBindingSource;
        private System.Windows.Forms.Label lblEnter;
        private System.Windows.Forms.ComboBox cboState;
        private System.Windows.Forms.Button btnMembershipLevel;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
    }
}