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

        private void jobBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.jobBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.jobFinderDataSet);

        }

        private void frmJob_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jobFinderDataSet.Job' table. You can move, or remove it, as needed.
            this.jobTableAdapter.Fill(this.jobFinderDataSet.Job);

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            /* Validate information entered by user. Show appropriate error messages. */

            /* If valid, write a record to the Job table. */
        }
    }
}
