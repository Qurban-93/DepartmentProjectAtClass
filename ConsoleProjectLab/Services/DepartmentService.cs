using ConsoleProjectLab.Entityes;
using ConsoleProjectLab.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProjectLab.Services
{
    public class DepartmentService : IDepartmentService
    {
        private List<Department> departmentList;

        public DepartmentService()
        {
            departmentList = new();
        }
        public void AddDepartment(string name, double maxSalary, int capacity)
        {
            Department department = new Department()
            {
                Name = name,
                Capacity = capacity,
                MaxSalary = maxSalary
            };
            departmentList.Add(department);
            Console.WriteLine("\nUgurla elave olundu!\n");
        }

        public bool CheckDepartments()
        {
            return departmentList.Count > 0;
        }

        public void DeleteDepartment(int id)
        {
            Department department = departmentList.FirstOrDefault(d => d.Id == id);
            if (department is null)
            {
                Console.WriteLine("\nBu Id-ile department yoxdur!\n");
                return;
            }
            departmentList.Remove(department);
            Console.WriteLine("\nUgurla silindi!\n");
        }

        public void EditDepartment(int id, string name, double maxSalary, int capacity)
        {
            Department department = departmentList.FirstOrDefault(d => d.Id == id);
            if (department is null)
            {
                Console.WriteLine("\nBu Id-ile department yoxdur!\n");
                return;
            }
            department.Name = name;
            department.MaxSalary = maxSalary;
            department.Capacity = capacity;
            Console.WriteLine("\nDeyisiklikler qeyde alindi!\n");
        }

        public List<Department> GetAllDepartments()
        {
            return departmentList;
        }
    }
}
