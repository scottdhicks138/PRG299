namespace PRG299
{
    partial class frmBusiness
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
            System.Windows.Forms.Label lblBusinessName;
            System.Windows.Forms.Label lblBusinessWebsite;
            this.jobFinderDataSet = new PRG299.JobFinderDataSet();
            this.businessBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.businessTableAdapter = new PRG299.JobFinderDataSetTableAdapters.BusinessTableAdapter();
            this.tableAdapterManager = new PRG299.JobFinderDataSetTableAdapters.TableAdapterManager();
            this.txtBusinessName = new System.Windows.Forms.TextBox();
            this.txtBusinessWebsite = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            lblBusinessName = new System.Windows.Forms.Label();
            lblBusinessWebsite = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.jobFinderDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBusinessName
            // 
            lblBusinessName.AutoSize = true;
            lblBusinessName.Location = new System.Drawing.Point(11, 47);
            lblBusinessName.Name = "lblBusinessName";
            lblBusinessName.Size = new System.Drawing.Size(83, 13);
            lblBusinessName.TabIndex = 3;
            lblBusinessName.Text = "Business Name:";
            // 
            // lblBusinessWebsite
            // 
            lblBusinessWebsite.AutoSize = true;
            lblBusinessWebsite.Location = new System.Drawing.Point(12, 73);
            lblBusinessWebsite.Name = "lblBusinessWebsite";
            lblBusinessWebsite.Size = new System.Drawing.Size(94, 13);
            lblBusinessWebsite.TabIndex = 7;
            lblBusinessWebsite.Text = "Business Website:";
            // 
            // jobFinderDataSet
            // 
            this.jobFinderDataSet.DataSetName = "JobFinderDataSet";
            this.jobFinderDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // businessBindingSource
            // 
            this.businessBindingSource.DataMember = "Business";
            this.businessBindingSource.DataSource = this.jobFinderDataSet;
            // 
            // businessTableAdapter
            // 
            this.businessTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ActivityTableAdapter = null;
            this.tableAdapterManager.AddressTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BusinessTableAdapter = this.businessTableAdapter;
            this.tableAdapterManager.CandidateTableAdapter = null;
            this.tableAdapterManager.EmailTableAdapter = null;
            this.tableAdapterManager.JobTableAdapter = null;
            this.tableAdapterManager.PersonTableAdapter = null;
            this.tableAdapterManager.PhoneTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PRG299.JobFinderDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txtBusinessName
            // 
            this.txtBusinessName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.businessBindingSource, "businessName", true));
            this.txtBusinessName.Location = new System.Drawing.Point(110, 44);
            this.txtBusinessName.Name = "txtBusinessName";
            this.txtBusinessName.Size = new System.Drawing.Size(162, 20);
            this.txtBusinessName.TabIndex = 4;
            // 
            // txtBusinessWebsite
            // 
            this.txtBusinessWebsite.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.businessBindingSource, "businessWebsite", true));
            this.txtBusinessWebsite.Location = new System.Drawing.Point(110, 70);
            this.txtBusinessWebsite.Name = "txtBusinessWebsite";
            this.txtBusinessWebsite.Size = new System.Drawing.Size(162, 20);
            this.txtBusinessWebsite.TabIndex = 8;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(91, 118);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // frmBusiness
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 168);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(lblBusinessName);
            this.Controls.Add(this.txtBusinessName);
            this.Controls.Add(lblBusinessWebsite);
            this.Controls.Add(this.txtBusinessWebsite);
            this.Name = "frmBusiness";
            this.Text = "JobFinder - Business";
            this.Load += new System.EventHandler(this.frmBusiness_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jobFinderDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private JobFinderDataSet jobFinderDataSet;
        private System.Windows.Forms.BindingSource businessBindingSource;
        private JobFinderDataSetTableAdapters.BusinessTableAdapter businessTableAdapter;
        private JobFinderDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtBusinessName;
        private System.Windows.Forms.TextBox txtBusinessWebsite;
        private System.Windows.Forms.Button btnSubmit;
    }
}