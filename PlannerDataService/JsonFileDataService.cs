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
    }
}
