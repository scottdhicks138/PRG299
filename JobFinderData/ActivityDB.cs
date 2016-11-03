﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using JobFinderBU;

namespace JobFinderData
{
    public static class ActivityDB
    {
        public static List<Activity> GetActivities()
        {
            List<Activity> activityList = new List<Activity>();

            // Connect to Server
            //SqlConnection connection = JobFinderDB.GetConnection();

            // Connect to Local Copy
            SqlConnection connection = JobFinderDB.GetLocalConnection();

            string selectStatement = "SELECT candidateID, activityDateTime, notes, scheduleFlag, contactMethod, " +
                                            "jobID, contactID FROM Activity ";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = selectCommand.ExecuteReader();

                int ordCandidateID = reader.GetOrdinal("candidateID");
                int ordActivityDateTime = reader.GetOrdinal("activityDateTime");
                int ordNotes = reader.GetOrdinal("notes");
                int ordScheduleFlag = reader.GetOrdinal("scheduleFlag");
                int ordContactMethod = reader.GetOrdinal("contactMethod");
                int ordJobID = reader.GetOrdinal("jobID");
                int ordContactID = reader.GetOrdinal("contactID");

                while (reader.Read())
                {
                    Activity activity = new Activity();
                    activity.CandidateID = (int)reader[ordCandidateID];
                    activity.ActivityDateTime = (DateTime)reader[ordActivityDateTime];
                    if (reader[ordNotes] == null) activity.Notes = " ";
                    else activity.Notes = reader[ordNotes].ToString();
                    activity.ScheduleFlag = reader[ordScheduleFlag].ToString()[0];
                    if (reader[ordContactMethod] == null) activity.ContactMethod = " ";
                    else activity.ContactMethod = reader[ordContactMethod].ToString();
                    if (activity.JobID != 0) activity.JobID = (int)reader[ordJobID];
                    if (activity.ContactID != 0) activity.ContactID = (int)reader[ordContactID];
                    activityList.Add(activity);
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }

            return activityList;
        }

        public static void NewActivity()
        {
            /* Write record to Activity table */
        }

        public static void EditActivity()
        {
            /* Modify record in Activity table */
        }

        public static void DeleteActivity()
        {
            /* Delete record in Activity table */
        }
    }
}
