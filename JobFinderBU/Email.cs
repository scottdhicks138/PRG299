using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobFinderBU
{
    public class Email
    {
        /* * * D A T A   M E M B E R S * * */

        private string email;
        private string description;
        private int contactID;

        /* * * C O N S T R U C T O R S * * */

        public Email()
        {

        }

        /* * * P R O P E R T I E S * * */

        public string EmailAddress
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
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
