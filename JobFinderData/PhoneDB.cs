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
    public static class PhoneDB
    {
        public static void NewPhone(Phone newPhone)
        {
            /* Connect to Local Copy */

            SqlConnection connection = JobFinderDB.GetLocalConnection();

            /* Write record to Phone table */

            string insertStatement = "INSERT INTO Phone VALUES (PhoneNumber, Description, ContactID)";
                                                                
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

        public static void EditPhone(Phone editPhone)
        {
            /* Connect to Local Copy */

            SqlConnection connection = JobFinderDB.GetLocalConnection();

            /* Modify record in Phone table */

            string updateStatement = "UPDATE Phone " +
                                     "SET phone = PhoneNumber, description = Description " +
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

        public static void DeletePhone(Phone deletePhone)
        {
            /* Connect to Local Copy */

            SqlConnection connection = JobFinderDB.GetLocalConnection();

            /* Delete record in Phone table */

            string deleteStatement = "DELETE FROM Phone " +
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
