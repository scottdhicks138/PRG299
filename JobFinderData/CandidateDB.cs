/* JobFinder by Scott Hicks */

/* The Candidate table contains the payment method(s) used by the candidate */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using JobFinderBU;

namespace JobFinderData
{
    public static class CandidateDB
    {
        public static void NewCandidate(Candidate newCandidate)
        {
            /* Connect to Local Copy */

            SqlConnection connection = JobFinderDB.GetLocalConnection();

            /* Write record to Candidate table */

            string insertStatement = "INSERT INTO Candidate VALUES (PaymentMethod, CcNumber, Expiration, " +
                                                                   "SecurityCode, BillingZipCode, MembershipLevel";
            try
            {
                connection.Open();

                SqlCommand selectCommand = new SqlCommand(insertStatement, connection);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        public static void EditCandidate(Candidate editCandidate)
        {
            /* Connect to Local Copy */

            SqlConnection connection = JobFinderDB.GetLocalConnection();

            /* Modify record in Candidate table */

            string updateStatement = "UPDATE Candidate " +
                                     "SET paymentMethod = PaymentMethod, ccNumber = CcNumber, expiration = Expiration, " +
                                         "securityCode = SecurityCode, billingZipCode = BillingZipCode, " +
                                         "membershipLevel = MembershipLevel " +
                                     "WHERE candidateID = CandidateID";
            try
            {
                connection.Open();

                SqlCommand selectCommand = new SqlCommand(updateStatement, connection);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        public static void DeleteCandidate(Candidate deleteCandidate)
        {
            /* Connect to Local Copy */

            SqlConnection connection = JobFinderDB.GetLocalConnection();

            /* Delete record in Candidate table */

            string deleteStatement = "DELETE FROM Candidate " +
                                     "WHERE candidateID = CandidateID";
            try
            {
                connection.Open();

                SqlCommand selectCommand = new SqlCommand(deleteStatement, connection);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
