using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobFinderBU
{
    public class Business
    {
        /* * * D A T A   M E M B E R S * * */

        private int businessID;
        private string businessName;
        private int addressID;
        private string businessWebsite;

        /* * * C O N S T R U C T O R S * * */

        public Business()
        {

        }

        /* * * P R O P E R T I E S * * */

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

        public string BusinessName
        {
            get
            {
                return businessName;
            }
            set
            {
                businessName = value;
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

        public string BusinessWebsite
        {
            get
            {
                return businessWebsite;
            }
            set
            {
                businessWebsite = value;
            }
        }

        /* * * I N S T A N C E   M E T H O D S * * */

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
