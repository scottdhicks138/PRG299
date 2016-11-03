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
    public partial class frmSignIn : Form
    {
        public frmSignIn()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            /* Show New Candidate screen */
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            /* Validate Username and Password. The combination of Username and Password must exist in the Up table. */

            /* If valid, display Activity screen. Not valid, show error message */ 
        }

    }
}
