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
using JobFinderBU;
using JobFinderData;

namespace PRG299
{
    public partial class frmActivity : Form
    {
        List<Activity> activityList = ActivityDB.GetActivities(" ");

        
        public frmActivity()
        {
            InitializeComponent();
        }

        private void frmActivity_Load(object sender, EventArgs e)
        {
            if (activityList.Count > 0)
            {
                // Grid was bound to activityBindingSource at design time.

                // Now bind grid to activityList.

                grdActivity.DataSource = activityList;

                // activityBindingSource can now be cleared and bound to detail view

                activityBindingSource.Clear();
                activityBindingSource.Add(activityList[0]);

                // txtMethod.Text = activityList[0].ContactMethod.ToString();
                  
                
            }
            else
            {
                MessageBox.Show("No records found");
                this.Close();
            }
        }

        private void grdActivity_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Clear activityBindingSource and bind to new detail view

            activityBindingSource.Clear();
            activityBindingSource.Add(activityList[grdActivity.CurrentCell.RowIndex]);
        }

        private void activityBindingSource_PositionChanged(object sender, EventArgs e)
        {
            CheckState();
        }
                
        private void CheckState()
        {
            if (this.grdActivity.CurrentRow.Cells[3].Value.ToString() == "Y")
            {
                this.chkAddToCalendar.Checked = true;
            }
            else this.chkAddToCalendar.Checked = false;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            /* Validate information entered by the user using the Validator class. */

            /* Check if user entered new info in Job combo box. If yes... */
                /* Show Job form prompting user to enter information. */
                /* Call Constructor to create a new Job object. */
                /* Use the properties to populate the Job object. */
                /* Pass the object to the method that writes a Job record. */

            /* Check if user entered new info in Contact Name combo box. If yes... */
                /* Modify the Candidate form to hide the Username and Password. */
                /* Modify the Candidate form to show Business Name and Website. */
                /* Show the Candidate form (modified to enter Contacts). */
                /* Validate information entered by using the Validator class. */
                /* Call Constructor to create a new Person object. */
                /* Use the properties to populate the Person object. */
                /* Pass the object to the method that writes a Person record. */
                /* Call Constructor to create a new Business object. */
                /* Use the properties to populate the Business object. */
                /* Pass the object to the method that writes a Business record. */

            /* If Activity info is valid... */
                /* Call Constructor to create a new Activity object. */

            Activity editActivity = new Activity();

                /* Use the properties to populate the Activity object. */

            // newActivity.CandidateID =
            editActivity.ActivityDateTime = tmDateTime.Value;
            editActivity.Notes = txtNotes.Text;

            if (chkAddToCalendar.Checked == true) editActivity.ScheduleFlag = 'Y';
            else editActivity.ScheduleFlag = 'N';

            editActivity.ContactMethod = txtMethod.Text;
            // newActivity.JobID = 0;
            // newActivity.ContactID = 0;
            
                /* Pass the object to the method that updates the Activity record. */

            ActivityDB.EditActivity(editActivity);

            /* Reload activityList 

            /* If not valid, show error messages */
        }

        private void btnNewActivity_Click(object sender, EventArgs e)
        {
            /* Validate information entered by the user using the Validator class. */

            /* VALID: */

            /* Call Constructor to create a new Activity object. */

            Activity newActivity = new Activity();

            /* Use the properties to populate the Activity object. */

            // candidateID
            // activityDateTime
            // notes
            // scheduleFlag
            // contactMethod
            // jobID
            // contactID
            
            /* Call the method to write a record to the Activity table. */

            ActivityDB.NewActivity(newActivity);

            /* NOT VALID: Show error messages */
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            /* Call Constructor to create a new Activity object. */
            /* Use the properties to populate the Activity object */
            /* Pass the object to the method that deletes the Activity record. */
        }

        private void btnNewSearch_Click(object sender, EventArgs e)
        {
            /* Clear the text box containing search criteria */

            /* Call method to retrieve list of all activities for that candidate. */
            /* Bind list to grid. */
               
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

        private void mnuEditAccountInfo_Click(object sender, EventArgs e)
        {
            /* Show the Candidate screen populated with information for that Candidate */

            /* Validate any modifications using the Validator class. */

            /* Update the Person, Address, Email, and Phone records accordingly. */
        }

        private void mnuEditPaymentMethod_Click(object sender, EventArgs e)
        {
            /* Show the Payment Method screen populated with information for that Candidate */

            /* Validate any modifications using the Validator class. */

            /* Update the Candidate table. */
        }

        private void mnuSearchByDate_Click(object sender, EventArgs e)
        {
            /* List Activities for specified date */
                /* Call method to build a list of activities for specified date. */
                /* Bind new list to grid. */
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
            /* Run table adapter method to fill report dataset with Activity records for that Candidate. */

            /* Run Activity report. */
        }

        private void mnuPrintContactsList_Click(object sender, EventArgs e)
        {
            /* Run table adapter method to fill report dataset with the Contact list for that Candidate. */
 
            /* Run Contact report. */
        }

        private void mnuPrintJobsReport_Click(object sender, EventArgs e)
        {
            /* Run table adapter method to fill report dataset with a list of Jobs for that candidate. */

            /* Run Jobs report. */
        }
                
        private void frmActivity_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
              
    }
}
