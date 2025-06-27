using PlannerCommon;
using Microsoft.Data.Sql;
using Microsoft.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Numerics;
using System.ComponentModel;

namespace PlannerDataService
{
    class DBDataService : IPlannerDataService
    {
        //connectionString
        static string connectionString
        = "Data Source=HEUSRAPH\\SQLEXPRESS; Initial Catalog = Daily_Planner; " +
            "Integrated Security = True; TrustServerCertificate=True;";

        static SqlConnection sqlConnection;

        public DBDataService()
        {
            sqlConnection = new SqlConnection(connectionString);
        }
       
       public void AddProfile(PlannerProfile profile)
        {
            var insertStatement = "INSERT INTO PlannerProfiles (FirstName, LastName, Age, Email) " +
                          "VALUES (@FirstName, @LastName, @Age, @Email)";

            SqlCommand insertCommand = new SqlCommand(insertStatement, sqlConnection);

            insertCommand.Parameters.AddWithValue("@FirstName", profile.FirstName);
            insertCommand.Parameters.AddWithValue("@LastName", profile.LastName);
            insertCommand.Parameters.AddWithValue("@Age", profile.Age);
            insertCommand.Parameters.AddWithValue("@Email", profile.Email);

            sqlConnection.Open();
            insertCommand.ExecuteNonQuery();
            sqlConnection.Close();
        } 

        public List<PlannerProfile> GetProfiles()
        {
            string selectStatement = "SELECT FirstName, LastName, Age, Email FROM PlannerProfiles";
            SqlCommand selectCommand = new SqlCommand(selectStatement, sqlConnection);

            sqlConnection.Open();
            SqlDataReader reader = selectCommand.ExecuteReader();

            var plannerProfiles = new List<PlannerProfile>();

            while (reader.Read())
            {
                PlannerProfile profile = new PlannerProfile
                {
                    FirstName = reader["FirstName"].ToString(),
                    LastName = reader["LastName"].ToString(),
                    Age = Convert.ToInt32(reader["Age"]),
                    Email = reader["Email"].ToString()
                };
                plannerProfiles.Add(profile);
            }

            sqlConnection.Close();
            return plannerProfiles;

        }

        public void RemoveProfile(PlannerProfile profile)
        {
            sqlConnection.Open();

            var deleteStatement = $"DELETE FROM ProfileDetails WHERE Email = @Email";
            SqlCommand updateCommand = new SqlCommand(deleteStatement, sqlConnection);
            updateCommand.Parameters.AddWithValue("@Email", profile.Email);

            updateCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }

        public void UpdateProfile(PlannerProfile profile)
        {
            sqlConnection.Open();
            var updateStatement = "UPDATE PlannerProfiles SET FirstName = @FirstName, LastName = @LastName, Age = @Age WHERE Email = @Email";
            SqlCommand updateCommand = new SqlCommand(updateStatement, sqlConnection);

            updateCommand.Parameters.AddWithValue("@FirstName", profile.FirstName);
            updateCommand.Parameters.AddWithValue("@LastName", profile.LastName);
            updateCommand.Parameters.AddWithValue("@Age", profile.Age);
            updateCommand.Parameters.AddWithValue("@Email", profile.Email);

            
            updateCommand.ExecuteNonQuery();
            sqlConnection.Close();
        } 
    }
}
