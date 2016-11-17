/* JobFinder by Scott Hicks */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using JobFinderBU;

namespace JobFinderData
{
    public static class EmailDB
    {
        public static void NewEmail(Email newEmail)
        {
            /* Connect to Local Copy */

            SqlConnection connection = JobFinderDB.GetLocalConnection();

            /* Write record to Email table */

            string insertStatement = "INSERT INTO Email VALUES (EmailAddress, Description, ContactID)";
                                                                   
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

        public static void EditEmail(Email editEmail)
        {
            /* Connect to Local Copy */

            SqlConnection connection = JobFinderDB.GetLocalConnection();

            /* Modify record in Candidate table */

            string updateStatement = "UPDATE Email " +
                                     "SET email = EmailAddress, description = Description, " +
                                     "WHERE contactID = ContactID";
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

        public static void DeleteEmail(Email deleteEmail)
        {
            /* Connect to Local Copy */

            SqlConnection connection = JobFinderDB.GetLocalConnection();

            /* Delete record in Email table */

            string deleteStatement = "DELETE FROM Email " +
                                     "WHERE contactID = ContactID";
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
