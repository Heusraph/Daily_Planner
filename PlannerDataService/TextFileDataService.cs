using PlannerDataService;
using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using PlannerCommon;

namespace PlannerDataService
{
    public class TextFileDataService : IPlannerDataService
    {
       
        public List<PlannerProfile> Profiles = new List<PlannerProfile>();
        private string dataFilePath = "planner_data.txt";

        public TextFileDataService()
        {
            LoadDataFromFile();
        }

        private void LoadDataFromFile()
        {
            if (!File.Exists(dataFilePath))

                return;

            var lines = File.ReadAllLines(dataFilePath);
            Profiles.Clear();

            foreach (var line in lines)
            {
                var parts = line.Split('|');
                if (parts.Length < 6 || parts[0] != "PROFILE") continue;

                if (int.TryParse(parts[3], out int age))
                {
                    var profile = new PlannerProfile
                    {
                        Email = parts[1],
                        FirstName = parts[2],
                        LastName = parts[3],
                        Age = age,
                       
                    };

                    var planPart = parts[5].Replace("PLANS:", "");
                    var plansItem = planPart.Split(';', StringSplitOptions.RemoveEmptyEntries);

                    foreach (var item in plansItem)
                    {
                        var planparts = item.Split('@');
                        if (planparts.Length == 2)
                        {
                            profile.Plannings.Add(new Planning
                            {
                                Description = planparts[0],
                                Time = planparts[1]
                            });
                        }
                    }
                    Profiles.Add(profile); 
                }
            }
        }

        private void SaveDataToFile()
        {
            var lines = new List<string>();

            foreach (var profile in Profiles)
            {
                var planStrings = profile.Plannings.Select(p => $"{p.Description}@{p.Time}");
                string plansCombined = string.Join('|', planStrings);
                lines.Add($"PROFILE|{profile.Email}|{profile.FirstName}|{profile.LastName}|{profile.Age}");
                lines.Add($"PLANS:{plansCombined}");
            }

            File.WriteAllLines(dataFilePath, lines);
        }

        public List<PlannerProfile> GetProfiles()
        {
            return Profiles;
        }

        public void AddProfile(PlannerProfile profile)
        {
            Profiles.Add(profile);
            SaveDataToFile();
        }

        public void UpdateProfile(PlannerProfile profile)
        {
            var existing = Profiles.Find(p => p.Email == profile.Email);
            if (existing != null)
            {
                existing.FirstName = profile.FirstName;
                existing.LastName = profile.LastName;
                existing.Age = profile.Age;
                existing.Plannings = profile.Plannings;
                
                SaveDataToFile();   
            }
           
        }

        public void RemoveProfile(PlannerProfile profile)
        {
            var existing = Profiles.Find(p => p.Email == profile.Email);
            if (existing != null)
            {
                Profiles.Remove(existing);
                SaveDataToFile();
            }
        }

    }
}

