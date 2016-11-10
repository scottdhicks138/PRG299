using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobFinderBU
{
    public class Candidate
    {
        /* * * D A T A   M E M B E R S * * */

        private int candidateID;
        private string paymentMethod;
        private string ccNumber;
        private int expiration;
        private int securityCode;
        private int billingZipCode;
        private string membershipLevel;

        /* * * C O N S T R U C T O R S * * */

        public Candidate()
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

        public string PaymentMethod
        {
            get
            {
                return paymentMethod;
            }

            set
            {
                paymentMethod = value;
            }
        }

        public string CcNumber
        {
            get
            {
                return ccNumber;
            }
            set
            {
                ccNumber = value;
            }
        }

        public int Expiration
        {
            get
            {
                return expiration;
            }
            set
            {
                expiration = value;
            }
        }

        public int SecurityCode
        {
            get
            {
                return securityCode;
            }
            set
            {
                securityCode = value;
            }
        }

        public int BillingZipCode
        {
            get
            {
                return billingZipCode;
            }
            set
            {
                billingZipCode = value;
            }
        }

        public string MembershipLevel
        {
            get
            {
                return membershipLevel;
            }
            set
            {
                membershipLevel = value;
            }
        }
        
        /* * * I N S T A N C E   M E T H O D S * * */

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
