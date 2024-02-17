using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProjectLab.Entityes
{
    public class Department
    {
        static int count = 0;
        public int Id { get; private set; }
        public string? Name { get; set; }
        public double MaxSalary { get; set; }
        public int Capacity { get; set; }
        public List<Employee>? Employees { get; set; }

        public Department()
        {
            this.Id = ++count;
        }


    }
}
