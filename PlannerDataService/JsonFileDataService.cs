using PlannerCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PlannerDataService
{
    class JsonFileDataService : IPlannerDataService
    {

        private List<PlannerProfile> Profiles = new List<PlannerProfile>();
        private static string jsonFilePath = "planner_data.json";

        public JsonFileDataService()
        {
            LoadDataFromFile();
        }

        private void LoadDataFromFile()
        {
            if (File.Exists(jsonFilePath))
            {
                string jsonText = File.ReadAllText(jsonFilePath);
                Profiles = JsonSerializer.Deserialize<List<PlannerProfile>>(jsonText,
                    new JsonSerializerOptions { PropertyNameCaseInsensitive = true }) ?? new List<PlannerProfile>();
            }
        }

        private void WriteJsonDataToFile()
        {
            string jsonString = JsonSerializer.Serialize(Profiles, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            File.WriteAllText(jsonFilePath, jsonString);
        }

      
        private int FindProfileIndex(string email)
        {
            for (int i = 0; i <Profiles.Count; i++)
            {
                if (Profiles[i].Email.Trim().ToLower() == email.Trim().ToLower())
                    return i;
            }
            return -1;
        }

        public List<PlannerProfile> GetProfiles()
        {
            return Profiles;
        }

        public void AddProfile(PlannerProfile profile)
        {
            Profiles.Add(profile);
            WriteJsonDataToFile();
        }

        public void UpdateProfile(PlannerProfile profile)
        {
            var existing = Profiles.FirstOrDefault(p => p.Email == profile.Email);
            if (existing != null)
            {
                existing.FirstName = profile.FirstName;
                existing.LastName = profile.LastName;
                existing.Age = profile.Age;
                existing.Email = profile.Email;
                existing.Plans = profile.Plans;

                WriteJsonDataToFile();
            }
        }

        public void RemoveProfile(PlannerProfile profile)
        {
            var existing = Profiles.FirstOrDefault(p => p.Email == profile.Email);
            if (existing != null)
            {
                Profiles.Remove(existing);
                WriteJsonDataToFile();
            }
        }

        /* public void AddPlan(string profileId, string description, string time)
       {
           var profile = Profiles.FirstOrDefault(p => p.Email == profileId);
           if (profile != null)
           {
               profile.Plans.Add(new PlannerSupport { Description = description, Time = time });
               WriteJsonDataToFile();
           }
       }
      */

        /*public bool RemovePlan(string profileId, int index)
         {
             var existing = Profiles.FirstOrDefault(p => p.Email == profileId);
             if (existing == null || index < 0 || index >=existing.Plans.Count)
                 return false;

             existing.Plans.RemoveAt(index);
             WriteJsonDataToFile();
             return true;
         }
         */


        /* public bool UpdatePlan(string profileId, int index, string newDesc, string newTime)
         {
             var exisiting = Profiles.FirstOrDefault(p => p.Email == profileId);
             if (exisiting == null || index < 0 || index >= exisiting.Plans.Count)
                 return false;

             exisiting.Plans[index].Description = newDesc;
             exisiting.Plans[index].Time = newTime;
             WriteJsonDataToFile();
             return true;
         }
        */

    }
}
