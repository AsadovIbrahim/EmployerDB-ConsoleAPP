using ConsoleApp_DB.Contexts;
using System;
using System.Collections.Generic;

namespace ConsoleApp_DB.Entities
{
    public class Department
    {
        public EmployerDBContext Context { get; set; } = new();
        public int Id { get; set; }
        public ICollection<Employer>? Employers { get; set; }
        public Employer employer { get; set; }

        public Department()
        {
            Employers = new List<Employer>();
        }

        public Department(ICollection<Employer> employers)
        {
            Employers = employers;
        }
        public void ShowAllInfo()
        {
            foreach (var item in Context.Employers)
            {
                Console.WriteLine(item);
                Console.WriteLine("------------");
            }
        }
        public void RemoveEmployee(int id)
        {
            if (Context.Employers == null)
            {
                Console.WriteLine("NOTHING TO REMOVE!!");
                return;
            }
            var employerToRemove=Context.Employers.FirstOrDefault(e=>e.Id == id);

            if (employerToRemove != null)
            {
                Context.Remove(employerToRemove);
                Console.WriteLine($"{id} Employer Succesfully Removed!!");
            }
            else
            {
                Console.WriteLine($"Employer with this {id} not found!");
            }
            Context.SaveChanges();
        }
        public void ClearAllEmployee()
        {
            var allEmployers = Context.Employers!.ToList();
            Context.Employers!.RemoveRange(allEmployers);
            Console.WriteLine("All Employers Deleted Successfully!!");
            Context.SaveChanges();

        }
    }
}

