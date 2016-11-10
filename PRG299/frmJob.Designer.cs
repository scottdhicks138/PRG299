namespace PRG299
{
    partial class frmJob
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
            System.Windows.Forms.Label lblContact;
            System.Windows.Forms.Label lblJobTitle;
            System.Windows.Forms.Label lblJobDescription;
            System.Windows.Forms.Label lblNotes;
            System.Windows.Forms.Label lblJobSource;
            this.jobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtJobTitle = new System.Windows.Forms.TextBox();
            this.txtJobDescription = new System.Windows.Forms.TextBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.txtJobSource = new System.Windows.Forms.TextBox();
            this.lblNewJob = new System.Windows.Forms.Label();
            this.cboContact = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            lblContact = new System.Windows.Forms.Label();
            lblJobTitle = new System.Windows.Forms.Label();
            lblJobDescription = new System.Windows.Forms.Label();
            lblNotes = new System.Windows.Forms.Label();
            lblJobSource = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Location = new System.Drawing.Point(14, 97);
            lblContact.Name = "lblContact";
            lblContact.Size = new System.Drawing.Size(47, 13);
            lblContact.TabIndex = 3;
            lblContact.Text = "Contact:";
            // 
            // lblJobTitle
            // 
            lblJobTitle.AutoSize = true;
            lblJobTitle.Location = new System.Drawing.Point(14, 70);
            lblJobTitle.Name = "lblJobTitle";
            lblJobTitle.Size = new System.Drawing.Size(50, 13);
            lblJobTitle.TabIndex = 5;
            lblJobTitle.Text = "Job Title:";
            // 
            // lblJobDescription
            // 
            lblJobDescription.AutoSize = true;
            lblJobDescription.Location = new System.Drawing.Point(14, 44);
            lblJobDescription.Name = "lblJobDescription";
            lblJobDescription.Size = new System.Drawing.Size(63, 13);
            lblJobDescription.TabIndex = 7;
            lblJobDescription.Text = "Description:";
            // 
            // lblNotes
            // 
            lblNotes.AutoSize = true;
            lblNotes.Location = new System.Drawing.Point(16, 150);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new System.Drawing.Size(38, 13);
            lblNotes.TabIndex = 9;
            lblNotes.Text = "Notes:";
            // 
            // lblJobSource
            // 
            lblJobSource.AutoSize = true;
            lblJobSource.Location = new System.Drawing.Point(16, 124);
            lblJobSource.Name = "lblJobSource";
            lblJobSource.Size = new System.Drawing.Size(64, 13);
            lblJobSource.TabIndex = 11;
            lblJobSource.Text = "Job Source:";
            // 
            // jobBindingSource
            // 
            this.jobBindingSource.DataMember = "Job";
            // 
            // txtJobTitle
            // 
            this.txtJobTitle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobBindingSource, "jobName", true));
            this.txtJobTitle.Location = new System.Drawing.Point(83, 67);
            this.txtJobTitle.Name = "txtJobTitle";
            this.txtJobTitle.Size = new System.Drawing.Size(189, 20);
            this.txtJobTitle.TabIndex = 6;
            // 
            // txtJobDescription
            // 
            this.txtJobDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobBindingSource, "jobDescription", true));
            this.txtJobDescription.Location = new System.Drawing.Point(83, 41);
            this.txtJobDescription.Name = "txtJobDescription";
            this.txtJobDescription.Size = new System.Drawing.Size(189, 20);
            this.txtJobDescription.TabIndex = 8;
            // 
            // txtNotes
            // 
            this.txtNotes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobBindingSource, "notes", true));
            this.txtNotes.Location = new System.Drawing.Point(83, 147);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(189, 20);
            this.txtNotes.TabIndex = 10;
            // 
            // txtJobSource
            // 
            this.txtJobSource.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobBindingSource, "jobSource", true));
            this.txtJobSource.Location = new System.Drawing.Point(83, 121);
            this.txtJobSource.Name = "txtJobSource";
            this.txtJobSource.Size = new System.Drawing.Size(120, 20);
            this.txtJobSource.TabIndex = 12;
            // 
            // lblNewJob
            // 
            this.lblNewJob.AutoSize = true;
            this.lblNewJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewJob.Location = new System.Drawing.Point(13, 13);
            this.lblNewJob.Name = "lblNewJob";
            this.lblNewJob.Size = new System.Drawing.Size(190, 20);
            this.lblNewJob.TabIndex = 13;
            this.lblNewJob.Text = "New Job Opportunity...";
            // 
            // cboContact
            // 
            this.cboContact.FormattingEnabled = true;
            this.cboContact.Location = new System.Drawing.Point(83, 94);
            this.cboContact.Name = "cboContact";
            this.cboContact.Size = new System.Drawing.Size(121, 21);
            this.cboContact.TabIndex = 14;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(103, 208);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 15;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // frmJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cboContact);
            this.Controls.Add(this.lblNewJob);
            this.Controls.Add(lblContact);
            this.Controls.Add(lblJobTitle);
            this.Controls.Add(this.txtJobTitle);
            this.Controls.Add(lblJobDescription);
            this.Controls.Add(this.txtJobDescription);
            this.Controls.Add(lblNotes);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(lblJobSource);
            this.Controls.Add(this.txtJobSource);
            this.Name = "frmJob";
            this.Text = "JobFinder - Job";
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource jobBindingSource;
        private System.Windows.Forms.TextBox txtJobTitle;
        private System.Windows.Forms.TextBox txtJobDescription;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.TextBox txtJobSource;
        private System.Windows.Forms.Label lblNewJob;
        private System.Windows.Forms.ComboBox cboContact;
        private System.Windows.Forms.Button btnSubmit;
    }
}