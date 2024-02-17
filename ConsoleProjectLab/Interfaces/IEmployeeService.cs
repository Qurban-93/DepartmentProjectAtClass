using ConsoleProjectLab.Entityes;
using ConsoleProjectLab.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProjectLab.Interfaces
{
    public interface IEmployeeService
    {
        public void AddEmployee(string fullName,double salary,Department department,Position position);
    }
}
