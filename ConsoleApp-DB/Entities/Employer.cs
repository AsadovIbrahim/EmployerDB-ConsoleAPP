using System;
using System.Collections.Generic;

namespace ConsoleApp_DB.Entities
{
    public class Employer
    {
        private static int _Id;
        
        public int Id { get; set; } = 0;
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public byte Age { get; set; }
        public int DepartmentNo { get; set; }
        public double Salary { get; set; }

        public Employer(string name, string surname, byte age, int departmentNo, double salary)
        {
            Name = name;
            Surname = surname;
            Age = age;
            DepartmentNo = departmentNo;
            Salary = salary;
        }
        
        public override string ToString()
        {
            return $"Id:{Id}\nName:{Name}\nSurname:{Surname}\nAge:{Age}\nDepartmentNo:{DepartmentNo}\nSalary:{Salary}";
        }
    }
}
