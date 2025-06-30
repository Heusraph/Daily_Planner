using PlannerDataService;
using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.Intrinsics.X86;
using System.Threading.Tasks;
using PlannerCommon;
using PlannerService;


namespace Daily_Planner
{
    internal class Program
    {
        static string[] actions = new string[] { 
       " Add Plan ", " Remove Plan ", " View Plan ", " Update Plan ", " Exit " };
        static string currentUserEmail = string.Empty;
        static string currentProfile = string.Empty;
        static PlannerService.PlannerService plannerService;
        
        static void Main(string[] args)
           
        {
            
            Console.WriteLine("YOKOSO to Daily Planner");

            Console.Write("Enter your Email: ");
            currentUserEmail = Console.ReadLine();

            Console.Write("Enter your First Name: ");
            string fname = Console.ReadLine();

            Console.Write("Enter your Last Name: ");
            string lname = Console.ReadLine();

            Console.Write("Enter your Age: ");
            
            int age;
            while (true)
            {
                string ageInput = Console.ReadLine();
                if (int.TryParse(ageInput, out age))
                {
                    break; 
                }
                else
                {
                    Console.Write("Invalid input. Please enter a valid age: ");
                }
            }
            
            var dataManager = new PlannerDataService.PlannerDataService();
            plannerService = new PlannerService.PlannerService(currentUserEmail, fname, lname, age, dataManager.GetDataService());
      
            while (true)
            {                             
                Console.WriteLine("\nWelcome to Daily Planner! Please select an action:");
                for (int i = 0; i < actions.Length; i++)
                {
                    Console.WriteLine($"[{i + 1}] {actions[i]}");
                }
                Console.WriteLine("---------------------");

                int userInput = GetUserInput();

                switch ((PlannerAction)userInput)
                {
                    case PlannerAction.Add:
                        Console.Write("What will be your plan?: ");
                        string plan = Console.ReadLine();

                        Console.Write("Enter the time for your plan: ");
                        string time = Console.ReadLine();

                        plannerService.AddPlan(plan, time);
                        Console.WriteLine("Plan added successfully!");
                        break;

                    case PlannerAction.Remove:
                        RemovePlan();
                        break;

                    case PlannerAction.View:
                        ViewPlan();
                        break;

                    case PlannerAction.Update:
                        UpdatePlan();
                        break;

                    case PlannerAction.Exit:
                        Console.WriteLine("Hope to see you again!");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
                
            }
      


        }
        static int GetUserInput()
        {
            Console.WriteLine("[User Input]: ");
            int option;
            while (!int.TryParse(Console.ReadLine(), out option) || option < 1 || option > actions.Length)
                {
                    Console.Write("Invalid input. Try again: ");
                }
            return option;

        }
        static void ViewPlan()
        {
            var plans = plannerService.GetPlans();
            if (plans.Count == 0)
            {
                Console.WriteLine("No tasks available.");
                return;
            }

            Console.WriteLine("Plans:");
            for (int i = 0; i < plans.Count; i++)
            {
                Console.WriteLine($"[{i + 1}] {plans[i].Description} at {plans[i].Time}");
            }
        }

        static void RemovePlan()
        {
            var plans = plannerService.GetPlans();
            if (plans.Count == 0)
            {
                Console.WriteLine("No plans to remove.");
                return;
            }
            ViewPlan();
            Console.Write("Enter the number of the plan to remove: ");
            int index; 

            while(!int.TryParse(Console.ReadLine(), out index) || index < 1 || index > plans.Count)
            {
                Console.WriteLine("Invalid Input");
            }

            index -= 1;
            plannerService.RemovePlan(index);
            Console.WriteLine("Plan removed successfully.");
         
        }

        static void UpdatePlan()
        {
            var plans = plannerService.GetPlans();
            if (plans.Count == 0)
            {
                Console.WriteLine("No plans to update.");
                return;
            }

            ViewPlan();
            Console.Write("Enter the number of the plan to update: ");
            int index;
            
            while (!int.TryParse(Console.ReadLine(), out index) || index < 1 || index > plans.Count)
            {
                Console.WriteLine("Invalid Input");
            }

            index -= 1;   

            Console.Write("Enter new plan: ");
            string newDesc = Console.ReadLine();
            Console.Write("Enter new time: ");
            string newTime = Console.ReadLine();

            plannerService.UpdatePlan(index, newDesc, newTime);
                Console.WriteLine("Plan updated.");
        
        }
    }
}
