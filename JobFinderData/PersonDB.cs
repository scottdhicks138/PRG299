using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using JobFinderBU;

namespace JobFinderData
{
    public static class PersonDB
    {
        public static List<Person> GetContacts()
        {
            List<Person> contactList = new List<Person>();
            return contactList;
        }

        public static void NewPerson(Person newPerson)
        {
            /* Connect to Local Copy */

            SqlConnection connection = JobFinderDB.GetLocalConnection();

            /* Write record to Person table */

            string insertStatement = "INSERT INTO Person VALUES (ContactLastName, ContactFirstName, ContactMiddleName, " +
                                                                "BusinessID, AddressID, CandidateID, ContactType, ContactNotes)";

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

        public static void EditPerson(Person editPerson)
        {
            /* Connect to Local Copy */

            SqlConnection connection = JobFinderDB.GetLocalConnection();

            /* Modify record in Person table */

            string updateStatement = "UPDATE Person " +
                                     "SET contactLastName = ContactLastName, contactFirstName = ContactFirstName, " +
                                         "contactMiddleName = ContactMiddleName, businessID = BusinessID, " +
                                         "addressID = AddressID, candidateID = CandidateID, contactType = ContactType, " +
                                         "contactNotes = ContactNotes " +
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

        public static void DeletePerson(Person deletePerson)
        {
            /* Connect to Local Copy */

            SqlConnection connection = JobFinderDB.GetLocalConnection();

            /* Delete record in Person table */

            string deleteStatement = "DELETE FROM Person " +
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
