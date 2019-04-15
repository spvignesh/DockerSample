using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp1.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }

        public static List<Employee> GetEmployees()
        {
            var employees = new List<Employee> {
            new Employee{ ID = 1,Name = "John", City ="Los Angeles"},
            new Employee { ID = 2, Name ="Peter", City ="California"},
            new Employee { ID=3, Name="Henry", City ="New York City"},
            new Employee{ ID=4, Name = "Antony", City ="Boston"},
            new Employee{ ID=5, Name = "Alex", City ="San Francisco"} };

            return employees;
        }
    }
}