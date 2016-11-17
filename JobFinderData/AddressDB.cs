using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using JobFinderBU;

namespace JobFinderData
{
    public static class AddressDB
    {
        public static void NewAddress(Address newAddress)
        {
            /* Connect to Local Copy */

            SqlConnection connection = JobFinderDB.GetLocalConnection();

            /* Write record to Address table */

            string insertStatement = "INSERT INTO Address VALUES (StreetAddress, City, State, PostalCode, BusinessID)";
                                     
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

        public static void EditAddress(Address editAddress)
        {
            /* Connect to Local Copy */

            SqlConnection connection = JobFinderDB.GetLocalConnection();

            /* Modify record in Address table */

            string updateStatement = "UPDATE Address " +
                                     "SET streetAddress = StreetAddress, city = City, state = State, " +
                                         "postalCode = PostalCode, businessID = BusinessID " +
                                     "WHERE addressID = AddressID";
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

        public static void DeleteAddress(Address deleteAddress)
        {
            /* Connect to Local Copy */

            SqlConnection connection = JobFinderDB.GetLocalConnection();

            /* Delete record in Address table */

            string deleteStatement = "DELETE FROM Address " +
                                     "WHERE addressID = AddressID";
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
