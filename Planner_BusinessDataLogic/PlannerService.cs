using PlannerDataService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlannerCommon;
using System.Xml.Linq;
using System.ComponentModel;
using System.Reflection;


namespace PlannerService
{
    public class PlannerService
    {
        private static PlannerProfile currentProfile;
        private IPlannerDataService _dataService;
        private readonly EmailService _emailService;
        public PlannerService(EmailService emailService)
        {
            _emailService = emailService;
        }
        public void AddAccount(string userEmail, string firstName, string lastName, int age, IPlannerDataService dataService)
        {

            _dataService = dataService;

            var allProfiles = dataService.GetProfiles();
            currentProfile = allProfiles.FirstOrDefault(p => p.Email == userEmail);
            if (currentProfile == null)
            {
                currentProfile = new PlannerProfile
                {
                    Email = userEmail,
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age,
                    Plannings = new List<Planning>()

                };
                dataService.AddProfile(currentProfile);
            }

        }

        //public PlannerService(string email, string firstName, string lastName, int age, IPlannerDataService dataService)
        //{
        //}

        public List<Planning> GetPlans()
        {
            return currentProfile.Plannings;
        }

        public void AddPlan(string description, string time)
        {
            if (string.IsNullOrWhiteSpace(description) || string.IsNullOrWhiteSpace(time))
                return;

              //currentProfile.Plannings.Add(new Planning { Description = description, Time = time });
            //_dataService.UpdateProfile(currentProfile);
            _emailService.SendEmail("RaphaelBautista@gmail.com", "John Raphael", "Bautista");
        }

        public void RemovePlan(int index)
        {
            if (index < 0 || index >= currentProfile.Plannings.Count)
                return;

            currentProfile.Plannings.RemoveAt(index);
            _dataService.UpdateProfile(currentProfile);
        }

        public void UpdatePlan(int index, string description, string time)
        {
            if (index < 0 || index >= currentProfile.Plannings.Count)
                return;

            if (string.IsNullOrWhiteSpace(description) || string.IsNullOrWhiteSpace(time))
                return;

            currentProfile.Plannings[index].Description = description;
            currentProfile.Plannings[index].Time = time;
            _dataService.UpdateProfile(currentProfile);
        }

        public void GetPlan()
        {
            if (currentProfile.Plannings == null || currentProfile.Plannings.Count == 0)
            {
                Console.WriteLine("No plans found.");
                return;
            }

            int i = 1;
            foreach (var plan in currentProfile.Plannings)
            {
                Console.WriteLine($"{i++}. {plan.Description} at {plan.Time}");
            }
        }
    }
}

