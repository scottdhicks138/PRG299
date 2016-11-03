using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace JobFinderData
{
    public static class JobFinderDB
    {
        public static SqlConnection GetConnection()
        {
            SqlConnection connection;
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "localhost\\MSSQLEXPRESS2014";
            builder.InitialCatalog = "JobFinder";
            builder.IntegratedSecurity = true;

            connection = new SqlConnection(builder.ConnectionString);

            return connection;
        }

        public static SqlConnection GetLocalConnection()
        {
            SqlConnection connection;
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "(localdb)\\ProjectsV13";
            builder.AttachDBFilename = "|DataDirectory|\\JobFinder.mdf";
            builder.IntegratedSecurity = true;

            connection = new SqlConnection(builder.ConnectionString);

            return connection;
        }
    }
}
