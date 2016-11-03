using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobFinderBU
{
    public class Person
    {
        /* * * D A T A   M E M B E R S * * */

        private int contactID;
        private string contactLastName;
        private string contactFirstName;
        private string contactMiddleName;
        private int businessID;
        private int addressID;
        private int candidateID;
        private string contactType;
        private string contactNotes;

        /* * * C O N S T R U C T O R S * * */

        public Person()
        {

        }

        /* * * P R O P E R T I E S * * */

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

        public string ContactLastName
        {
            get
            {
                return contactLastName;
            }
            set
            {
                contactLastName = value;
            }
        }

        public string ContactFirstName
        {
            get
            {
                return contactFirstName;
            }
            set
            {
                contactFirstName = value;
            }
        }

        public string ContactMiddleName
        {
            get
            {
                return contactMiddleName;
            }
            set
            {
                contactMiddleName = value;
            }
        }

        public int BusinessID
        {
            get
            {
                return businessID;
            }
            set
            {
                businessID = value;
            }
        }

        public int AddressID
        {
            get
            {
                return addressID;
            }
            set
            {
                addressID = value;
            }
        }

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

        public string ContactType
        {
            get
            {
                return contactNotes;
            }
            set
            {
                contactNotes = value;
            }
        }

        public string ContactNotes
        {
            get
            {
                return contactNotes;
            }
            set
            {
                contactNotes = value;
            }
        }

        /* * * I N S T A N C E   M E T H O D S * * */

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
