using PlannerDataService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlannerCommon;
using System.Xml.Linq;

namespace PlannerService
{
    public class PlannerService
    {
        private PlannerProfile currentProfile;
        private IPlannerDataService _dataService;

       
        public PlannerService(string userEmail, string firstName, string lastName, int age, IPlannerDataService dataService)
        {
            _dataService = dataService;
           var allProfiles = dataService.GetProfiles();
           this.currentProfile = allProfiles.FirstOrDefault(p => p.Email == userEmail);
          


            if (this.currentProfile == null)
            {
                currentProfile = new PlannerProfile
                {
                    Email = userEmail,
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age,
                    Plans = new List<Plan>()
                };
                dataService.AddProfile(this.currentProfile);
            }
        }

        public bool AddPlan(string description, string time)
        {
            if (string.IsNullOrWhiteSpace(description) || string.IsNullOrWhiteSpace(time))
                return false;

            currentProfile.Plans.Add(new Plan{ Description = description, Time = time });
            _dataService.UpdateProfile(currentProfile);
            return true;
        }

        public bool RemovePlan(int index)
        {
            if (index < 1 || index > currentProfile.Plans.Count)
                return false;

            currentProfile.Plans.RemoveAt(index - 1);
            _dataService.UpdateProfile(currentProfile);
            return true;
        }

        public bool UpdatePlan(int index, string newDescription, string newTime)
        {
            if (index < 1 || index > currentProfile.Plans.Count ||
                string.IsNullOrWhiteSpace(newDescription) || string.IsNullOrWhiteSpace(newTime))
                return false;

            var plan = currentProfile.Plans[index - 1];
            plan.Description = newDescription;
            plan.Time = newTime;
            _dataService.UpdateProfile(currentProfile);
            return true;
        }

        public List<Plan> GetPlans()
        {
            return currentProfile.Plans;
        }

        public string GetUserSummary()
        {
            return currentProfile.UserSummary();
        }
    }
}

