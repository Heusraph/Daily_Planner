using PlannerCommon;
using Microsoft.Data.Sql;
using Microsoft.Data.SqlClient;

namespace PlannerDataService
{
    class DBDataService : IPlannerDataService
    {
        //connectionString
        static string connectionString
       = "Data Source =BAUTISTA\\SQLEXPRESS; Initial Catalog = ATM; Integrated Security = True; TrustServerCertificate=True;";

        static SqlConnection sqlConnection;

        public void AddProfile(PlannerProfile profile)
        {
            throw new NotImplementedException();
        }

        public List<PlannerProfile> GetProfiles()
        {
            throw new NotImplementedException();
        }

        public void RemoveProfile(PlannerProfile profileId)
        {
            throw new NotImplementedException();
        }

        public void UpdateProfile(PlannerProfile profile)
        {
            throw new NotImplementedException();
        }
    }
}
