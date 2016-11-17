using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using JobFinderBU;

namespace JobFinderData
{
    public static class JobDB
    {
        public static void NewJob(Job newJob)
        {
            /* Connect to Local Copy */

            SqlConnection connection = JobFinderDB.GetLocalConnection();

            /* Write record to Job table */

            string insertStatement = "INSERT INTO Job VALUES (ContactID, JobName, JobDescription, Notes, JobSource)";

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

        public static void EditJob(Job editJob)
        {
            /* Connect to Local Copy */

            SqlConnection connection = JobFinderDB.GetLocalConnection();

            /* Modify record in Job table */

            string updateStatement = "UPDATE Job " +
                                     "SET contactID = ContactID, jobName = JobName, jobDescription = JobDescription, " +
                                                     "notes = Notes, jobSource = JobSource " +
                                     "WHERE jobID = JobID";
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

        public static void DeleteJob(Job deleteJob)
        {
            /* Connect to Local Copy */

            SqlConnection connection = JobFinderDB.GetLocalConnection();

            /* Delete record in Job table */

            string deleteStatement = "DELETE FROM Job " +
                                     "WHERE jobID = JobID";
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
