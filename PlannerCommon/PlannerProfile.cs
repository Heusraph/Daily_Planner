using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannerCommon
{
    public class PlannerProfile
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public List<Planning> Plannings { get; set; } = new List<Planning>();

    }

    public class Planning
    {
        public string Description { get; set; }
        public string Time { get; set; }
   
    } 
}