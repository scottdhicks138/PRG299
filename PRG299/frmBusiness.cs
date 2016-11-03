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
    public partial class frmBusiness : Form
    {
        public frmBusiness()
        {
            InitializeComponent();
        }

        private void businessBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.businessBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.jobFinderDataSet);

        }

        private void frmBusiness_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jobFinderDataSet.Business' table. You can move, or remove it, as needed.
            this.businessTableAdapter.Fill(this.jobFinderDataSet.Business);

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            /* Validate information entered by user. Show appropriate error messages. */

            /* If valid, write a record to the Business table. */
        }
    }
}
