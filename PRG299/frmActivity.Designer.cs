namespace PRG299
{
    partial class frmActivity
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
            System.Windows.Forms.Label lblContactName;
            System.Windows.Forms.Label lblJob;
            System.Windows.Forms.Label lblMethod;
            System.Windows.Forms.Label lblNotes;
            this.grdActivity = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuActivity = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddActivity = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddContact = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddJob = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddBusiness = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditAccountInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditPaymentMethod = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSearchByDate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSearchByDescription = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSearchContactMethod = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSearchByJob = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSearchByContactName = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrintActivityReport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrintContactsList = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrintJobsReport = new System.Windows.Forms.ToolStripMenuItem();
            this.cboContactName = new System.Windows.Forms.ComboBox();
            this.cboJob = new System.Windows.Forms.ComboBox();
            this.txtMethod = new System.Windows.Forms.TextBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.tmDateTime = new System.Windows.Forms.DateTimePicker();
            this.btnNewActivity = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.picFilter = new System.Windows.Forms.PictureBox();
            this.btnNewSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.activityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.candidateIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activityDateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scheduleFlagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactMethodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkAddToCalendar = new System.Windows.Forms.CheckBox();
            lblContactName = new System.Windows.Forms.Label();
            lblJob = new System.Windows.Forms.Label();
            lblMethod = new System.Windows.Forms.Label();
            lblNotes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdActivity)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblContactName
            // 
            lblContactName.AutoSize = true;
            lblContactName.Location = new System.Drawing.Point(359, 338);
            lblContactName.Name = "lblContactName";
            lblContactName.Size = new System.Drawing.Size(78, 13);
            lblContactName.TabIndex = 14;
            lblContactName.Text = "Contact Name:";
            // 
            // lblJob
            // 
            lblJob.AutoSize = true;
            lblJob.Location = new System.Drawing.Point(81, 338);
            lblJob.Name = "lblJob";
            lblJob.Size = new System.Drawing.Size(27, 13);
            lblJob.TabIndex = 12;
            lblJob.Text = "Job:";
            // 
            // lblMethod
            // 
            lblMethod.AutoSize = true;
            lblMethod.Location = new System.Drawing.Point(62, 312);
            lblMethod.Name = "lblMethod";
            lblMethod.Size = new System.Drawing.Size(46, 13);
            lblMethod.TabIndex = 10;
            lblMethod.Text = "Method:";
            // 
            // lblNotes
            // 
            lblNotes.AutoSize = true;
            lblNotes.Location = new System.Drawing.Point(320, 279);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new System.Drawing.Size(63, 13);
            lblNotes.TabIndex = 6;
            lblNotes.Text = "Description:";
            // 
            // grdActivity
            // 
            this.grdActivity.AutoGenerateColumns = false;
            this.grdActivity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdActivity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.candidateIDDataGridViewTextBoxColumn,
            this.activityDateTimeDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn,
            this.scheduleFlagDataGridViewTextBoxColumn,
            this.contactMethodDataGridViewTextBoxColumn,
            this.jobIDDataGridViewTextBoxColumn,
            this.contactIDDataGridViewTextBoxColumn});
            this.grdActivity.DataSource = this.activityBindingSource;
            this.grdActivity.Location = new System.Drawing.Point(7, 111);
            this.grdActivity.Name = "grdActivity";
            this.grdActivity.Size = new System.Drawing.Size(645, 137);
            this.grdActivity.TabIndex = 1;
            this.grdActivity.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdActivity_CellClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuActivity});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(729, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuActivity
            // 
            this.mnuActivity.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAdd,
            this.mnuEdit,
            this.mnuSearch,
            this.mnuPrint});
            this.mnuActivity.Name = "mnuActivity";
            this.mnuActivity.Size = new System.Drawing.Size(50, 20);
            this.mnuActivity.Text = "Menu";
            // 
            // mnuAdd
            // 
            this.mnuAdd.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddActivity,
            this.mnuAddContact,
            this.mnuAddJob,
            this.mnuAddBusiness});
            this.mnuAdd.Name = "mnuAdd";
            this.mnuAdd.Size = new System.Drawing.Size(118, 22);
            this.mnuAdd.Text = "Add...";
            // 
            // mnuAddActivity
            // 
            this.mnuAddActivity.Name = "mnuAddActivity";
            this.mnuAddActivity.Size = new System.Drawing.Size(119, 22);
            this.mnuAddActivity.Text = "Activity";
            this.mnuAddActivity.Click += new System.EventHandler(this.mnuAddActivity_Click);
            // 
            // mnuAddContact
            // 
            this.mnuAddContact.Name = "mnuAddContact";
            this.mnuAddContact.Size = new System.Drawing.Size(119, 22);
            this.mnuAddContact.Text = "Contact";
            this.mnuAddContact.Click += new System.EventHandler(this.mnuAddContact_Click);
            // 
            // mnuAddJob
            // 
            this.mnuAddJob.Name = "mnuAddJob";
            this.mnuAddJob.Size = new System.Drawing.Size(119, 22);
            this.mnuAddJob.Text = "Job";
            this.mnuAddJob.Click += new System.EventHandler(this.mnuAddJob_Click);
            // 
            // mnuAddBusiness
            // 
            this.mnuAddBusiness.Name = "mnuAddBusiness";
            this.mnuAddBusiness.Size = new System.Drawing.Size(119, 22);
            this.mnuAddBusiness.Text = "Business";
            // 
            // mnuEdit
            // 
            this.mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEditAccountInfo,
            this.mnuEditPaymentMethod});
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(118, 22);
            this.mnuEdit.Text = "Edit...";
            // 
            // mnuEditAccountInfo
            // 
            this.mnuEditAccountInfo.Name = "mnuEditAccountInfo";
            this.mnuEditAccountInfo.Size = new System.Drawing.Size(166, 22);
            this.mnuEditAccountInfo.Text = "Account Info";
            this.mnuEditAccountInfo.Click += new System.EventHandler(this.mnuEditAccountInfo_Click);
            // 
            // mnuEditPaymentMethod
            // 
            this.mnuEditPaymentMethod.Name = "mnuEditPaymentMethod";
            this.mnuEditPaymentMethod.Size = new System.Drawing.Size(166, 22);
            this.mnuEditPaymentMethod.Text = "Payment Method";
            this.mnuEditPaymentMethod.Click += new System.EventHandler(this.mnuEditPaymentMethod_Click);
            // 
            // mnuSearch
            // 
            this.mnuSearch.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSearchByDate,
            this.mnuSearchByDescription,
            this.mnuSearchContactMethod,
            this.mnuSearchByJob,
            this.mnuSearchByContactName});
            this.mnuSearch.Name = "mnuSearch";
            this.mnuSearch.Size = new System.Drawing.Size(118, 22);
            this.mnuSearch.Text = "Search...";
            // 
            // mnuSearchByDate
            // 
            this.mnuSearchByDate.Name = "mnuSearchByDate";
            this.mnuSearchByDate.Size = new System.Drawing.Size(177, 22);
            this.mnuSearchByDate.Text = "by Date";
            this.mnuSearchByDate.Click += new System.EventHandler(this.mnuSearchByDate_Click);
            // 
            // mnuSearchByDescription
            // 
            this.mnuSearchByDescription.Name = "mnuSearchByDescription";
            this.mnuSearchByDescription.Size = new System.Drawing.Size(177, 22);
            this.mnuSearchByDescription.Text = "by Description";
            this.mnuSearchByDescription.Click += new System.EventHandler(this.mnuSearchByDescription_Click);
            // 
            // mnuSearchContactMethod
            // 
            this.mnuSearchContactMethod.Name = "mnuSearchContactMethod";
            this.mnuSearchContactMethod.Size = new System.Drawing.Size(177, 22);
            this.mnuSearchContactMethod.Text = "by Contact Method";
            this.mnuSearchContactMethod.Click += new System.EventHandler(this.mnuSearchContactMethod_Click);
            // 
            // mnuSearchByJob
            // 
            this.mnuSearchByJob.Name = "mnuSearchByJob";
            this.mnuSearchByJob.Size = new System.Drawing.Size(177, 22);
            this.mnuSearchByJob.Text = "by Job";
            this.mnuSearchByJob.Click += new System.EventHandler(this.mnuSearchByJob_Click);
            // 
            // mnuSearchByContactName
            // 
            this.mnuSearchByContactName.Name = "mnuSearchByContactName";
            this.mnuSearchByContactName.Size = new System.Drawing.Size(177, 22);
            this.mnuSearchByContactName.Text = "by Contact Name";
            this.mnuSearchByContactName.Click += new System.EventHandler(this.mnuSearchByContactName_Click);
            // 
            // mnuPrint
            // 
            this.mnuPrint.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPrintActivityReport,
            this.mnuPrintContactsList,
            this.mnuPrintJobsReport});
            this.mnuPrint.Name = "mnuPrint";
            this.mnuPrint.Size = new System.Drawing.Size(118, 22);
            this.mnuPrint.Text = "Print...";
            // 
            // mnuPrintActivityReport
            // 
            this.mnuPrintActivityReport.Name = "mnuPrintActivityReport";
            this.mnuPrintActivityReport.Size = new System.Drawing.Size(152, 22);
            this.mnuPrintActivityReport.Text = "Activity Report";
            this.mnuPrintActivityReport.Click += new System.EventHandler(this.mnuPrintActivityReport_Click);
            // 
            // mnuPrintContactsList
            // 
            this.mnuPrintContactsList.Name = "mnuPrintContactsList";
            this.mnuPrintContactsList.Size = new System.Drawing.Size(152, 22);
            this.mnuPrintContactsList.Text = "Contacts List";
            this.mnuPrintContactsList.Click += new System.EventHandler(this.mnuPrintContactsList_Click);
            // 
            // mnuPrintJobsReport
            // 
            this.mnuPrintJobsReport.Name = "mnuPrintJobsReport";
            this.mnuPrintJobsReport.Size = new System.Drawing.Size(152, 22);
            this.mnuPrintJobsReport.Text = "Jobs Report";
            this.mnuPrintJobsReport.Click += new System.EventHandler(this.mnuPrintJobsReport_Click);
            // 
            // cboContactName
            // 
            this.cboContactName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.activityBindingSource, "contactID", true));
            this.cboContactName.FormattingEnabled = true;
            this.cboContactName.Location = new System.Drawing.Point(452, 335);
            this.cboContactName.Name = "cboContactName";
            this.cboContactName.Size = new System.Drawing.Size(200, 21);
            this.cboContactName.TabIndex = 15;
            // 
            // cboJob
            // 
            this.cboJob.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.activityBindingSource, "jobID", true));
            this.cboJob.FormattingEnabled = true;
            this.cboJob.Location = new System.Drawing.Point(114, 335);
            this.cboJob.Name = "cboJob";
            this.cboJob.Size = new System.Drawing.Size(200, 21);
            this.cboJob.TabIndex = 13;
            // 
            // txtMethod
            // 
            this.txtMethod.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.activityBindingSource, "contactMethod", true));
            this.txtMethod.Location = new System.Drawing.Point(114, 309);
            this.txtMethod.Name = "txtMethod";
            this.txtMethod.Size = new System.Drawing.Size(200, 20);
            this.txtMethod.TabIndex = 11;
            // 
            // txtNotes
            // 
            this.txtNotes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.activityBindingSource, "notes", true));
            this.txtNotes.Location = new System.Drawing.Point(389, 280);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(263, 20);
            this.txtNotes.TabIndex = 7;
            // 
            // tmDateTime
            // 
            this.tmDateTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.activityBindingSource, "activityDateTime", true));
            this.tmDateTime.Location = new System.Drawing.Point(114, 277);
            this.tmDateTime.Name = "tmDateTime";
            this.tmDateTime.Size = new System.Drawing.Size(200, 20);
            this.tmDateTime.TabIndex = 5;
            // 
            // btnNewActivity
            // 
            this.btnNewActivity.Location = new System.Drawing.Point(202, 379);
            this.btnNewActivity.Name = "btnNewActivity";
            this.btnNewActivity.Size = new System.Drawing.Size(112, 23);
            this.btnNewActivity.TabIndex = 18;
            this.btnNewActivity.Text = "Enter New Activity";
            this.btnNewActivity.UseVisualStyleBackColor = true;
            this.btnNewActivity.Click += new System.EventHandler(this.btnNewActivity_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(12, 379);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(143, 23);
            this.btnModify.TabIndex = 19;
            this.btnModify.Text = "Modify Existing Record";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(362, 379);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // picFilter
            // 
            this.picFilter.BackgroundImage = global::PRG299.Properties.Resources.Filter;
            this.picFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picFilter.Location = new System.Drawing.Point(12, 27);
            this.picFilter.Name = "picFilter";
            this.picFilter.Size = new System.Drawing.Size(33, 53);
            this.picFilter.TabIndex = 20;
            this.picFilter.TabStop = false;
            // 
            // btnNewSearch
            // 
            this.btnNewSearch.Location = new System.Drawing.Point(65, 57);
            this.btnNewSearch.Name = "btnNewSearch";
            this.btnNewSearch.Size = new System.Drawing.Size(75, 23);
            this.btnNewSearch.TabIndex = 23;
            this.btnNewSearch.Text = "New Search";
            this.btnNewSearch.UseVisualStyleBackColor = true;
            this.btnNewSearch.Click += new System.EventHandler(this.btnNewSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(65, 27);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 24;
            this.txtSearch.Text = "Search...";
            // 
            // activityBindingSource
            // 
            this.activityBindingSource.DataSource = typeof(JobFinderBU.Activity);
            this.activityBindingSource.PositionChanged += new System.EventHandler(this.activityBindingSource_PositionChanged);
            // 
            // candidateIDDataGridViewTextBoxColumn
            // 
            this.candidateIDDataGridViewTextBoxColumn.DataPropertyName = "CandidateID";
            this.candidateIDDataGridViewTextBoxColumn.HeaderText = "CandidateID";
            this.candidateIDDataGridViewTextBoxColumn.Name = "candidateIDDataGridViewTextBoxColumn";
            // 
            // activityDateTimeDataGridViewTextBoxColumn
            // 
            this.activityDateTimeDataGridViewTextBoxColumn.DataPropertyName = "ActivityDateTime";
            this.activityDateTimeDataGridViewTextBoxColumn.HeaderText = "ActivityDateTime";
            this.activityDateTimeDataGridViewTextBoxColumn.Name = "activityDateTimeDataGridViewTextBoxColumn";
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            this.notesDataGridViewTextBoxColumn.HeaderText = "Notes";
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            // 
            // scheduleFlagDataGridViewTextBoxColumn
            // 
            this.scheduleFlagDataGridViewTextBoxColumn.DataPropertyName = "ScheduleFlag";
            this.scheduleFlagDataGridViewTextBoxColumn.HeaderText = "ScheduleFlag";
            this.scheduleFlagDataGridViewTextBoxColumn.Name = "scheduleFlagDataGridViewTextBoxColumn";
            // 
            // contactMethodDataGridViewTextBoxColumn
            // 
            this.contactMethodDataGridViewTextBoxColumn.DataPropertyName = "ContactMethod";
            this.contactMethodDataGridViewTextBoxColumn.HeaderText = "ContactMethod";
            this.contactMethodDataGridViewTextBoxColumn.Name = "contactMethodDataGridViewTextBoxColumn";
            // 
            // jobIDDataGridViewTextBoxColumn
            // 
            this.jobIDDataGridViewTextBoxColumn.DataPropertyName = "JobID";
            this.jobIDDataGridViewTextBoxColumn.HeaderText = "JobID";
            this.jobIDDataGridViewTextBoxColumn.Name = "jobIDDataGridViewTextBoxColumn";
            // 
            // contactIDDataGridViewTextBoxColumn
            // 
            this.contactIDDataGridViewTextBoxColumn.DataPropertyName = "ContactID";
            this.contactIDDataGridViewTextBoxColumn.HeaderText = "ContactID";
            this.contactIDDataGridViewTextBoxColumn.Name = "contactIDDataGridViewTextBoxColumn";
            // 
            // chkAddToCalendar
            // 
            this.chkAddToCalendar.AutoSize = true;
            this.chkAddToCalendar.Location = new System.Drawing.Point(12, 278);
            this.chkAddToCalendar.Name = "chkAddToCalendar";
            this.chkAddToCalendar.Size = new System.Drawing.Size(106, 17);
            this.chkAddToCalendar.TabIndex = 25;
            this.chkAddToCalendar.Text = "Add To Calendar";
            this.chkAddToCalendar.UseVisualStyleBackColor = true;
            // 
            // frmActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 428);
            this.Controls.Add(this.chkAddToCalendar);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnNewSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.picFilter);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnNewActivity);
            this.Controls.Add(this.tmDateTime);
            this.Controls.Add(lblNotes);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(lblMethod);
            this.Controls.Add(this.txtMethod);
            this.Controls.Add(lblJob);
            this.Controls.Add(this.cboJob);
            this.Controls.Add(lblContactName);
            this.Controls.Add(this.cboContactName);
            this.Controls.Add(this.grdActivity);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmActivity";
            this.Text = "JobFinder - Activity";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmActivity_FormClosed);
            this.Load += new System.EventHandler(this.frmActivity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdActivity)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource activityBindingSource;
        private System.Windows.Forms.DataGridView grdActivity;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuActivity;
        private System.Windows.Forms.ToolStripMenuItem mnuAdd;
        private System.Windows.Forms.ToolStripMenuItem mnuAddActivity;
        private System.Windows.Forms.ToolStripMenuItem mnuAddContact;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuEditAccountInfo;
        private System.Windows.Forms.ToolStripMenuItem mnuEditPaymentMethod;
        private System.Windows.Forms.ToolStripMenuItem mnuSearch;
        private System.Windows.Forms.ToolStripMenuItem mnuSearchByDate;
        private System.Windows.Forms.ToolStripMenuItem mnuSearchByDescription;
        private System.Windows.Forms.ToolStripMenuItem mnuSearchContactMethod;
        private System.Windows.Forms.ToolStripMenuItem mnuSearchByJob;
        private System.Windows.Forms.ToolStripMenuItem mnuSearchByContactName;
        private System.Windows.Forms.ComboBox cboContactName;
        private System.Windows.Forms.ComboBox cboJob;
        private System.Windows.Forms.TextBox txtMethod;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.DateTimePicker tmDateTime;
        private System.Windows.Forms.Button btnNewActivity;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.PictureBox picFilter;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ToolStripMenuItem mnuPrint;
        private System.Windows.Forms.ToolStripMenuItem mnuPrintActivityReport;
        private System.Windows.Forms.Button btnNewSearch;
        private System.Windows.Forms.ToolStripMenuItem mnuAddJob;
        private System.Windows.Forms.ToolStripMenuItem mnuAddBusiness;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ToolStripMenuItem mnuPrintContactsList;
        private System.Windows.Forms.ToolStripMenuItem mnuPrintJobsReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn candidateIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn activityDateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scheduleFlagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactMethodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.CheckBox chkAddToCalendar;
    }
}