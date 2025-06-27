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
       public void RemoveProfile(PlannerProfile profile);
      
    }
}