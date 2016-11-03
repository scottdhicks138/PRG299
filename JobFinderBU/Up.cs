using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobFinderBU
{
    class Up
    {
        /* * * D A T A   M E M B E R S * * */

        private string username;
        private string password;
        private int candidateID;

        /* * * C O N S T R U C T O R S * * */

        public Up()
        {

        }

        /* * * P R O P E R T I E S * * */

        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
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

        /* * * I N S T A N C E   M E T H O D S * * */

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
