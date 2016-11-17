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
    public static class BusinessDB
    {
        public static void NewBusiness(Business newBusiness)
        {
            /* Connect to Local Copy */

            SqlConnection connection = JobFinderDB.GetLocalConnection();

            /* Write record to Business table */

            string insertStatement = "INSERT INTO Business VALUES (BusinessName, AddressID, BusinessWebsite)";

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

        public static void EditBusiness(Business editBusiness)
        {
            /* Connect to Local Copy */

            SqlConnection connection = JobFinderDB.GetLocalConnection();

            /* Modify record in Business table */

            string updateStatement = "UPDATE Business " +
                                     "SET businessName = BusinessName, addressID = AddressID, " +
                                         "businessWebsite = BusinessWebsite " +
                                     "WHERE businessID = BusinessID";
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

        public static void DeleteBusiness(Business deleteBusiness)
        {
            /* Connect to Local Copy */

            SqlConnection connection = JobFinderDB.GetLocalConnection();

            /* Delete record in Business table */

            string deleteStatement = "DELETE FROM Business " +
                                     "WHERE businessID = BusinessID";
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
