using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Employees_Management
{
   public class Program
    {
        static void Main(string[] args)
        {
            int countOfEmployees = int.Parse(Console.ReadLine());

            var employees = new List<Employee>();

            for (int i = 0; i < countOfEmployees; i++)
            {
                string str = Console.ReadLine();
                string[] strArr = str.Split(' ');
                employees.Add(new Employee
                {
                    FirstName = strArr[0],
                    LastName = strArr[1],
                    Company = strArr[2],
                    Age = int.Parse(strArr[3])
                });
            }

            foreach (var emp in AverageAgeForEachCompany(employees))
            {
                Console.WriteLine($"The average age for company {emp.Key} is {emp.Value}");
            }

            foreach (var emp in CountOfEmployeesForEachCompany(employees))
            {
                Console.WriteLine($"The count of employees for company {emp.Key} is {emp.Value}");
            }

            foreach (var emp in OldestAgeForEachCompany(employees))
            {
                Console.WriteLine($"The oldest employee of company {emp.Key} is {emp.Value.FirstName} {emp.Value.LastName} having age {emp.Value.Age}");
            }
        }

        public static Dictionary<string, int> AverageAgeForEachCompany(List<Employee> employees)
        {
            var dict = new Dictionary<string, int>();
            foreach (var emp in employees)
            {
                if (!dict.ContainsKey(emp.Company))
                {
                    string company = emp.Company;
                    int avgAge = (int)Math.Round(employees.Where(e => e.Company == company).Average(e => e.Age));
                    dict.Add(company, avgAge);
                }
            }

            return dict.OrderBy(a => a.Key).ToDictionary(a => a.Key, a => a.Value); 
        }

        public static Dictionary<string, int> CountOfEmployeesForEachCompany(List<Employee> employees)
        {
            var dict = new Dictionary<string, int>();
            foreach (var emp in employees)
            {
                string company = emp.Company;
                if (!dict.ContainsKey(company))
                {
                    int count = employees.Where(e => e.Company == company).ToList().Count();
                    dict.Add(company, count);
                }
            }

            return dict.OrderBy(a=>a.Key).ToDictionary(a=>a.Key, a=>a.Value);
        }

        public static Dictionary<string, Employee> OldestAgeForEachCompany(List<Employee> employees)
        {
            var dict = new Dictionary<string, Employee>();
            foreach (var emp in employees)
            {
                string company = emp.Company;
                if (!dict.ContainsKey(company))
                {
                    Employee oldestAge = employees.Where(e => e.Company == company).OrderByDescending(e => e.Age).First()
                        ;

                    dict.Add(company,oldestAge);
                }
            }

            return dict.OrderBy(a => a.Key).ToDictionary(a => a.Key, a => a.Value); ;
        }
    }

    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
        public int  Age { get; set; }
    }
}
