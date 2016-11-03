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

        private void candidateBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.candidateBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.jobFinderDataSet);

        }

        private void candidateBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.candidateBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.jobFinderDataSet);

        }

        private void frmMembershipLevel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jobFinderDataSet.Candidate' table. You can move, or remove it, as needed.
            this.candidateTableAdapter.Fill(this.jobFinderDataSet.Candidate);

        }

        private void btnSubmitPayment_Click(object sender, EventArgs e)
        {
            /* Validate information entered by user */

            /* If valid, update the fields for the candidate record */

            /* If not valid, show error messages */
        }
    }
}
