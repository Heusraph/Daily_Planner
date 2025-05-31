using System;
using System.Collections.Generic;
using PlannerCommon;

namespace PlannerDataService
{
    public interface IPlannerDataService
    {
       public List<PlannerProfile> GetProfiles();
       public void AddProfile(PlannerProfile profile);
       public void UpdateProfile(PlannerProfile profile);
       public void RemoveProfile(PlannerProfile profileId);
       /*public void AddPlan(string profileId, string description, string time);
       public bool RemovePlan(string profileId, int index);
       public bool UpdatePlan(string profileId, int index, string newDesc, string newTime);*/
    }
}