using ConsoleProjectLab.Entityes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProjectLab.Interfaces
{
    public interface IDepartmentService
    {
        public void AddDepartment(string name,double maxSalary,int capacity);
        public void EditDepartment(int id, string name, double maxSalary, int capacity);
        public void DeleteDepartment(int id);
        public List<Department> GetAllDepartments();

        public bool CheckDepartments();
    }
}
