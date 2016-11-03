/* JobFinder by Scott Hicks */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG299
{
    public partial class frmCandidate : Form
    {
        public frmCandidate()
        {
            InitializeComponent();
        }

        private void personBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.jobFinderDataSet);

        }

        private void frmCandidate_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jobFinderDataSet.Candidate' table. You can move, or remove it, as needed.
            this.candidateTableAdapter.Fill(this.jobFinderDataSet.Candidate);
            // TODO: This line of code loads data into the 'jobFinderDataSet.Phone' table. You can move, or remove it, as needed.
            this.phoneTableAdapter.Fill(this.jobFinderDataSet.Phone);
            // TODO: This line of code loads data into the 'jobFinderDataSet.Email' table. You can move, or remove it, as needed.
            this.emailTableAdapter.Fill(this.jobFinderDataSet.Email);
            // TODO: This line of code loads data into the 'jobFinderDataSet.Address' table. You can move, or remove it, as needed.
            this.addressTableAdapter.Fill(this.jobFinderDataSet.Address);
            // TODO: This line of code loads data into the 'jobFinderDataSet.Person' table. You can move, or remove it, as needed.
            this.personTableAdapter.Fill(this.jobFinderDataSet.Person);

        }

        private void btnMembershipLevel_Click(object sender, EventArgs e)
        {
            /* Validate Candidate personal information */

            /* If valid, write records to Person, Address, Email, and Phone tables */
            /* Create a new Candidate record (ID only). The other fields will be populated later */

            /* Display Membership Level screen */

            /* if not valid, show error messages */

        }
    }
}
