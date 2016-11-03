using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobFinderBU
{
    public class Job
    {
        /* * * D A T A   M E M B E R S * * */

        private int jobID;
        private int contactID;
        private string jobName;
        private string jobDescription;
        private string notes;
        private string jobSource;

        /* * * C O N S T R U C T O R S * * */

        public Job()
        {

        }

        /* * * P R O P E R T I E S * * */

        public int JobID
        {
            get
            {
                return jobID;
            }
            set
            {
                jobID = value;
            }
        }

        public int ContactID
        {
            get
            {
                return contactID;
            }
            set
            {
                contactID = value;
            }
        }

        public string JobName
        {
            get
            {
                return jobName;
            }
            set
            {
                jobName = value;
            }
        }

        public string JobDescription
        {
            get
            {
                return jobDescription;
            }
            set
            {
                jobDescription = value;
            }
        }

        public string Notes
        {
            get
            {
                return notes;
            }
            set
            {
                notes = value;
            }
        }

        public string JobSource
        {
            get
            {
                return jobSource;
            }
            set
            {
                jobSource = value;
            }
        }

        /* * * I N S T A N C E   M E T H O D S * * */

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
