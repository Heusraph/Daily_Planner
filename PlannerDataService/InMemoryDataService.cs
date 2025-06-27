using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using PlannerCommon;

namespace PlannerDataService
{
    public class InMemoryDataService : IPlannerDataService
    {
        private List<PlannerProfile> profiles = new List<PlannerProfile>();
       

        public InMemoryDataService()
        {
            CreateDummyProfile();
        }

        private void CreateDummyProfile()
        {
            profiles.Add(new PlannerProfile
            {
                FirstName = "Sasuke",
                LastName = "Uchiha",
                Age = 21,
                Email = "raphael@gmail.com",
                Plannings = new List<Planning>
                {
                    new Planning { Description = "Train Sharingan", Time = "08:00 AM" },
                    new Planning { Description = "Seek Itachi", Time = "03:00 PM" }
                }
            });
        }
        public List<PlannerProfile> GetProfiles()
        {
            return profiles;
        }

        public void AddProfile(PlannerProfile profile)
        {
            profiles.Add(profile);
        }

        public void UpdateProfile(PlannerProfile profile)
        {
            var existing = profiles.Find(p => p.Email == profile.Email);
            if (existing != null)
            {
                existing.FirstName = profile.FirstName;
                existing.LastName = profile.LastName;
                existing.Age = profile.Age;
            }
        }

        public void RemoveProfile(PlannerProfile profile)
        {
            profiles.RemoveAll(p => p.Email == profile.Email);
        }

    }
}