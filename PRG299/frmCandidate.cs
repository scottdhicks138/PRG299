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
    public partial class frmCandidate : Form
    {
        public frmCandidate()
        {
            InitializeComponent();
        }
               
        private void btnMembershipLevel_Click(object sender, EventArgs e)
        {
            /* Validate Candidate personal information using the Validator class*/

            /* VALID: */

            /* Call Constructor to create a new Candidate object. */
            /* Call the method to write a record to the Candidate table. This method returns the assigned ID. */
            /* Use the properties to populate Candidate ID. The other fields will be populated later. */ 

            /* Call Constructor to create new Person object. */
            /* Call the method to write a record to the Person table. This method returns the assigned ID. */
            /* Use the properties to populate the Person object. */
            /* Pass the object to the method that updates the Person record. */

            /* Call Constructor to create a new Address object. */
            /* Use the properties to populate the Address object. */
            /* Pass the object to the method that writes an Address record. */

            /* Call Constructor to create a new Email object. */
            /* Use the properties to populate the Email object. */
            /* Pass the object to the method that writes an Email record. */

            /* Call Constructor to create a new Phone record. */
            /* Use the properties to populate the Phone object. */
            /* Pass the object to the method that writes a Phone record. */

            /* Display Membership Level screen */

            /* NOT VALID: Show error messages */

        }
    }
}
