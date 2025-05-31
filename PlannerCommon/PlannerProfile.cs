using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannerCommon
{
    public class Plan
    {
        public string Description { get; set; }
        public string Time { get; set; }
    }
    public class PlannerProfile
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public List<Plan> Plans { get; set; } = new List<Plan>();

        public string UserSummary()
        {
            return $"Name: {FirstName} {LastName}\nAge: {Age}\nEmail: {Email}";
        }
    }
}