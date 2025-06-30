using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PlannerCommon;
using PlannerService;

namespace WebApplicationDP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DailyPlannerController : ControllerBase
    {
        PlannerService.PlannerService plannerService = new PlannerService.PlannerService(
            "raph@gmail.com", "Raph", "Bautista", 22,
             new PlannerDataService.PlannerDataService().GetDataService()
         );


        [HttpGet]
        public IEnumerable<Planning> GetProfiles()
        {
            return plannerService.GetPlans();
        }


        [HttpPost]
        public void AddPlan(string description, string time)
        {
            plannerService.AddPlan(description, time);
            
        }

        [HttpDelete]
        public void RemovePlan(int index)
        {
            plannerService.RemovePlan(index);
        }

        [HttpPatch]
        public void UpdatePlan(int index, string description, string time)
        {
            plannerService.UpdatePlan(index, description, time);
        }
    }
}
    