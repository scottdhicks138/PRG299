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
    public partial class frmMembershipLevel : Form
    {
        public frmMembershipLevel()
        {
            InitializeComponent();
        }
                
        private void btnSubmitPayment_Click(object sender, EventArgs e)
        {
            /* Validate information entered by user using the Validator class. */

            /* VALID: */

            /* The CandidateID property has already been populated. */ 
            /* Use the properties to populate the rest of the Candidate object. */
            /* Pass the object to the method that updates the Candidate record. */

            /* NOT VALID: Show error messages. */
        }
    }
}
