using ConsoleProjectLab.Entityes;
using ConsoleProjectLab.Enums;
using ConsoleProjectLab.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProjectLab.Services
{
    public class EmployeeService : IEmployeeService
    {
        List<Employee> employees;

        public EmployeeService()
        {
           employees = new List<Employee>();
        }
        public void AddEmployee(string fullName, double salary, Department department,Position position)
        {
            if (!SubService.CheckDepartmnet())
            {
                Console.WriteLine("Department siyahisi boshdur!");
                return;
            }

            Employee employee = new Employee();
            employee.FullName = fullName;
            employee.Salary = salary;
            employee.Department = department;
            employee.Position = position; 

            employees.Add(employee);
            Console.WriteLine("\nUgurla elave edildi!\n");

        }
    }
}
