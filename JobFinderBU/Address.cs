using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobFinderBU
{
    public class Address
    {
        /* * * D A T A   M E M B E R S * * */

        private int addressID;
        private string streetAddress;
        private string city;
        private string state;
        private string postalCode;
        private int businessID;

        /* * * C O N S T R U C T O R S * * */

        public Address()
        {

        }

        /* * * P R O P E R T I E S * * */

        private int AddressID
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

        private string StreetAddress
        {
            get
            {
                return streetAddress;
            }
            set
            {
                streetAddress = value;
            }
        }

        private string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }

        private string State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
            }
        }

        private string PostalCode
        {
            get
            {
                return postalCode;
            }
            set
            {
                postalCode = value;
            }
        }

        private int BusinessID
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

        /* * * I N S T A N C E   M E T H O D S * * */

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
