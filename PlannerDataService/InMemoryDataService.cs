using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlannerCommon;

namespace PlannerDataService
{
    public class InMemoryPlannerDataService : IPlannerDataService
    {
        private List<PlannerProfile> profiles = new List<PlannerProfile>();
       

        public InMemoryPlannerDataService()
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
                Email = "raphael@gmail.com"
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

      /*  public void AddPlan(string description, string time)
        {
            plans.Add(new Planner_BusinessDataLogic.PlannerSupport { Description = description, Time = time });
        }

        public bool RemovePlan(int index)
        {
            if (index < 0 || index >= plans.Count)
                return false;

            plans.RemoveAt(index);
            return true;
        }

        public bool UpdatePlan(string profileId, int index, string newDesc, string newTime)
        {
            if (index < 0 || index >= plans.Count)
                return false;

            plans[index].Description = newDesc;
            plans[index].Time = newTime;
            return true;
        } */
    }
}