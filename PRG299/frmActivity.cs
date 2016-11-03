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
    public partial class frmActivity : Form
    {
        public frmActivity()
        {
            InitializeComponent();
        }

        private void activityBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.activityBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.jobFinderDataSet);

        }

        private void frmActivity_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jobFinderDataSet.Activity' table. You can move, or remove it, as needed.
            this.activityTableAdapter.Fill(this.jobFinderDataSet.Activity);

        }
                
        private void btnModify_Click(object sender, EventArgs e)
        {
            /* Validate information entered by the user */

            /* Check if user entered new info in Job combo box. If yes, prepare to add Job record. */

            /* Check if user entered new info in Contact Name combo box. If yes, prepare to add new Person record. */

            /* If Activity info is valid, update the Activity record */

            /* If not valid, show error messages */
        }

        private void btnNewActivity_Click(object sender, EventArgs e)
        {
            /* Validate information entered by the user */

            /* If valid, write a new Activity record */

            /* If not valid, show error messages */
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            /* Delete Activity record */
        }

        private void btnNewSearch_Click(object sender, EventArgs e)
        {
            /* Clear the text box containing search criteria */

            /* Show all Activity records for that candidate */
        }

        private void mnuAddActivity_Click(object sender, EventArgs e)
        {
            /* Validate information entered by the user */

            /* If valid, write a new Activity record */

            /* If not valid, show error messages */
        }

        private void mnuAddContact_Click(object sender, EventArgs e)
        {
            /* Modify properties of Candidate screen to enable use for adding Contact */

            /* Show modified Candidate screen */
        }

        private void mnuAddJob_Click(object sender, EventArgs e)
        {
            /* Show Job screen */
        }

        private void mnuAddBusiness_Click(object sender, EventArgs e)
        {
            /* Show Business Screen */
        }

        private void mnuEditAccountInfo_Click(object sender, EventArgs e)
        {
            /* Show the Candidate screen populated with information for that Candidate */
        }

        private void mnuEditPaymentMethod_Click(object sender, EventArgs e)
        {
            /* Show the Payment Method screen populated with information for that Candidate */
        }

        private void mnuSearchByDate_Click(object sender, EventArgs e)
        {
            /* List Activities for specified date */
        }

        private void mnuSearchByDescription_Click(object sender, EventArgs e)
        {
            /* List Activities with specified description */
        }

        private void mnuSearchContactMethod_Click(object sender, EventArgs e)
        {
            /* List Activities with specified Contact Method */
        }

        private void mnuSearchByJob_Click(object sender, EventArgs e)
        {
            /* List Activities for specified Job */
        }

        private void mnuSearchByContactName_Click(object sender, EventArgs e)
        {
            /* List Activities with specified Contact Name */
        }

        private void mnuPrintActivityReport_Click(object sender, EventArgs e)
        {
           /* Print report of all activities for that candidate */
        }

        private void mnuPrintContactsList_Click(object sender, EventArgs e)
        {
            /* Print report of all contacts for that candidate */
        }

        private void mnuPrintJobsReport_Click(object sender, EventArgs e)
        {
            /* Print report of all jobs for that candidate */
        }
    }
}
