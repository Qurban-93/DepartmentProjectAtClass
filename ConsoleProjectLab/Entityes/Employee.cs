using ConsoleProjectLab.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProjectLab.Entityes
{
    public class Employee
    {
        static int count = 0;

        public int Id { get;private set; }
        public string FullName { get; set; }
        public double Salary { get; set; }
        public Position Position { get; set; }
        public Department Department { get; set; }


        public Employee()
        {
            this.Id = ++count;
        }

    }
}
