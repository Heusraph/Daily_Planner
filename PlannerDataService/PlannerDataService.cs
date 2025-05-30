﻿using PlannerCommon;


namespace PlannerDataService
{
    public class PlannerDataService
    {
        private IPlannerDataService plannerDataService;
        public IPlannerDataService DataService => plannerDataService;

        public PlannerDataService()
        {
            
            // plannerDataService = new InMemoryDataService();
            // plannerDataService = new TextFileDataService();
            plannerDataService = new JsonFileDataService();
        }

        public IPlannerDataService GetDataService()
        {
            return plannerDataService;
        }
        public List<PlannerProfile> GetAllProfiles()
        {
            return plannerDataService.GetProfiles();
        }

        public void AddProfile(PlannerProfile profile)
        {
            plannerDataService.AddProfile(profile);
        }
        public void UpdateProfile(PlannerProfile profile)
        {
            plannerDataService.UpdateProfile(profile);
        }


        public void RemoveProfile(PlannerProfile profile)
        {
            plannerDataService.RemoveProfile(profile);
        }
    }
}