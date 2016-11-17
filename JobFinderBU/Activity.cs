/* JobFinder by Scott Hicks */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobFinderBU
{
    public class Activity
    {
        /* * * D A T A   M E M B E R S * * */

        private int candidateID;
        private DateTime activityDateTime;
        private string notes;
        private char scheduleFlag;
        private string contactMethod;
        private int jobID;
        private int contactID;

        /* * * C O N S T R U C T O R S * * */

        public Activity()
        {

        }

        /* * * P R O P E R T I E S * * */

        public int CandidateID
        {
            get
            {
                return candidateID;
            }
            set
            {
                candidateID = value;
            }
        }

        public DateTime ActivityDateTime
        {
            get
            {
                return activityDateTime;
            }
            set
            {
                activityDateTime = value;
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

        public char ScheduleFlag
        {
            get
            {
                return scheduleFlag;
            }
            set
            {
                scheduleFlag = value;
            }
        }

        public string ContactMethod
        {
            get
            {
                return contactMethod;
            }
            set
            {
                contactMethod = value;
            }
        }

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

        /* * * I N S T A N C E   M E T H O D S * * */

        public override string ToString()
        {
            return base.ToString();
        }
    }
}