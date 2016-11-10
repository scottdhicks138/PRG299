namespace PRG299
{
    partial class frmMembershipLevel
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
            System.Windows.Forms.Label lblCCNumber;
            System.Windows.Forms.Label lblPaymentMethod;
            System.Windows.Forms.Label lblExpiration;
            System.Windows.Forms.Label lblSecurityCode;
            System.Windows.Forms.Label lblBillingZip;
            this.lblMembershipLevels = new System.Windows.Forms.Label();
            this.radBasic = new System.Windows.Forms.RadioButton();
            this.radPremium = new System.Windows.Forms.RadioButton();
            this.candidateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtCCNumber = new System.Windows.Forms.TextBox();
            this.cboPaymentMethod = new System.Windows.Forms.ComboBox();
            this.txtExpiration = new System.Windows.Forms.TextBox();
            this.txtSecurityCode = new System.Windows.Forms.TextBox();
            this.txtBillingZip = new System.Windows.Forms.TextBox();
            this.btnSubmitPayment = new System.Windows.Forms.Button();
            lblCCNumber = new System.Windows.Forms.Label();
            lblPaymentMethod = new System.Windows.Forms.Label();
            lblExpiration = new System.Windows.Forms.Label();
            lblSecurityCode = new System.Windows.Forms.Label();
            lblBillingZip = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.candidateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCCNumber
            // 
            lblCCNumber.AutoSize = true;
            lblCCNumber.Location = new System.Drawing.Point(21, 119);
            lblCCNumber.Name = "lblCCNumber";
            lblCCNumber.Size = new System.Drawing.Size(102, 13);
            lblCCNumber.TabIndex = 4;
            lblCCNumber.Text = "Credit Card Number:";
            // 
            // lblPaymentMethod
            // 
            lblPaymentMethod.AutoSize = true;
            lblPaymentMethod.Location = new System.Drawing.Point(21, 92);
            lblPaymentMethod.Name = "lblPaymentMethod";
            lblPaymentMethod.Size = new System.Drawing.Size(90, 13);
            lblPaymentMethod.TabIndex = 6;
            lblPaymentMethod.Text = "Payment Method:";
            // 
            // lblExpiration
            // 
            lblExpiration.AutoSize = true;
            lblExpiration.Location = new System.Drawing.Point(21, 145);
            lblExpiration.Name = "lblExpiration";
            lblExpiration.Size = new System.Drawing.Size(56, 13);
            lblExpiration.TabIndex = 8;
            lblExpiration.Text = "Expiration:";
            // 
            // lblSecurityCode
            // 
            lblSecurityCode.AutoSize = true;
            lblSecurityCode.Location = new System.Drawing.Point(21, 171);
            lblSecurityCode.Name = "lblSecurityCode";
            lblSecurityCode.Size = new System.Drawing.Size(76, 13);
            lblSecurityCode.TabIndex = 10;
            lblSecurityCode.Text = "Security Code:";
            // 
            // lblBillingZip
            // 
            lblBillingZip.AutoSize = true;
            lblBillingZip.Location = new System.Drawing.Point(21, 197);
            lblBillingZip.Name = "lblBillingZip";
            lblBillingZip.Size = new System.Drawing.Size(83, 13);
            lblBillingZip.TabIndex = 12;
            lblBillingZip.Text = "Billing Zip Code:";
            // 
            // lblMembershipLevels
            // 
            this.lblMembershipLevels.AutoSize = true;
            this.lblMembershipLevels.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMembershipLevels.Location = new System.Drawing.Point(13, 13);
            this.lblMembershipLevels.Name = "lblMembershipLevels";
            this.lblMembershipLevels.Size = new System.Drawing.Size(210, 24);
            this.lblMembershipLevels.TabIndex = 0;
            this.lblMembershipLevels.Text = "Membership Levels...";
            // 
            // radBasic
            // 
            this.radBasic.AutoSize = true;
            this.radBasic.Location = new System.Drawing.Point(17, 55);
            this.radBasic.Name = "radBasic";
            this.radBasic.Size = new System.Drawing.Size(66, 17);
            this.radBasic.TabIndex = 1;
            this.radBasic.TabStop = true;
            this.radBasic.Text = "Basic $$";
            this.radBasic.UseVisualStyleBackColor = true;
            // 
            // radPremium
            // 
            this.radPremium.AutoSize = true;
            this.radPremium.Location = new System.Drawing.Point(132, 55);
            this.radPremium.Name = "radPremium";
            this.radPremium.Size = new System.Drawing.Size(86, 17);
            this.radPremium.TabIndex = 2;
            this.radPremium.TabStop = true;
            this.radPremium.Text = "Premium $$$";
            this.radPremium.UseVisualStyleBackColor = true;
            // 
            // candidateBindingSource
            // 
            this.candidateBindingSource.DataMember = "Candidate";
            // 
            // txtCCNumber
            // 
            this.txtCCNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.candidateBindingSource, "candidateID", true));
            this.txtCCNumber.Location = new System.Drawing.Point(132, 116);
            this.txtCCNumber.Name = "txtCCNumber";
            this.txtCCNumber.Size = new System.Drawing.Size(121, 20);
            this.txtCCNumber.TabIndex = 5;
            // 
            // cboPaymentMethod
            // 
            this.cboPaymentMethod.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.candidateBindingSource, "paymentMethod", true));
            this.cboPaymentMethod.FormattingEnabled = true;
            this.cboPaymentMethod.Location = new System.Drawing.Point(132, 89);
            this.cboPaymentMethod.Name = "cboPaymentMethod";
            this.cboPaymentMethod.Size = new System.Drawing.Size(75, 21);
            this.cboPaymentMethod.TabIndex = 7;
            // 
            // txtExpiration
            // 
            this.txtExpiration.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.candidateBindingSource, "expiration", true));
            this.txtExpiration.Location = new System.Drawing.Point(132, 142);
            this.txtExpiration.Name = "txtExpiration";
            this.txtExpiration.Size = new System.Drawing.Size(121, 20);
            this.txtExpiration.TabIndex = 9;
            // 
            // txtSecurityCode
            // 
            this.txtSecurityCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.candidateBindingSource, "securityCode", true));
            this.txtSecurityCode.Location = new System.Drawing.Point(132, 168);
            this.txtSecurityCode.Name = "txtSecurityCode";
            this.txtSecurityCode.Size = new System.Drawing.Size(75, 20);
            this.txtSecurityCode.TabIndex = 11;
            // 
            // txtBillingZip
            // 
            this.txtBillingZip.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.candidateBindingSource, "billingZipCode", true));
            this.txtBillingZip.Location = new System.Drawing.Point(132, 194);
            this.txtBillingZip.Name = "txtBillingZip";
            this.txtBillingZip.Size = new System.Drawing.Size(121, 20);
            this.txtBillingZip.TabIndex = 13;
            // 
            // btnSubmitPayment
            // 
            this.btnSubmitPayment.Location = new System.Drawing.Point(92, 237);
            this.btnSubmitPayment.Name = "btnSubmitPayment";
            this.btnSubmitPayment.Size = new System.Drawing.Size(105, 23);
            this.btnSubmitPayment.TabIndex = 14;
            this.btnSubmitPayment.Text = "Submit Payment";
            this.btnSubmitPayment.UseVisualStyleBackColor = true;
            this.btnSubmitPayment.Click += new System.EventHandler(this.btnSubmitPayment_Click);
            // 
            // frmMembershipLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 287);
            this.Controls.Add(this.btnSubmitPayment);
            this.Controls.Add(lblCCNumber);
            this.Controls.Add(this.txtCCNumber);
            this.Controls.Add(lblPaymentMethod);
            this.Controls.Add(this.cboPaymentMethod);
            this.Controls.Add(lblExpiration);
            this.Controls.Add(this.txtExpiration);
            this.Controls.Add(lblSecurityCode);
            this.Controls.Add(this.txtSecurityCode);
            this.Controls.Add(lblBillingZip);
            this.Controls.Add(this.txtBillingZip);
            this.Controls.Add(this.radPremium);
            this.Controls.Add(this.radBasic);
            this.Controls.Add(this.lblMembershipLevels);
            this.Name = "frmMembershipLevel";
            this.Text = "JobFinder";
            ((System.ComponentModel.ISupportInitialize)(this.candidateBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMembershipLevels;
        private System.Windows.Forms.RadioButton radBasic;
        private System.Windows.Forms.RadioButton radPremium;
        private System.Windows.Forms.BindingSource candidateBindingSource;
        private System.Windows.Forms.TextBox txtCCNumber;
        private System.Windows.Forms.ComboBox cboPaymentMethod;
        private System.Windows.Forms.TextBox txtExpiration;
        private System.Windows.Forms.TextBox txtSecurityCode;
        private System.Windows.Forms.TextBox txtBillingZip;
        private System.Windows.Forms.Button btnSubmitPayment;
    }
}