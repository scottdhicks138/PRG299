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

        public static void NewPerson()
        {
            /* Write record to Person table */
        }

        public static void EditPerson()
        {
            /* Modify record in Person table */
        }

        public static void DeletePerson()
        {
            /* Delete record in Person table */
        }
    }
}
