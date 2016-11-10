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
    public partial class frmJob : Form
    {
        public frmJob()
        {
            InitializeComponent();
        }
                
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            /* Validate information entered by user using the Validator class. */

            /* VALID: */

            /* Call Constructor to create a new Job object. */
            /* Use the properties to populate the Job object. */
            /* Pass the object to the method that writes a Job record. */

            /* NOT VALID: Show error messages. */
        }
    }
}
