using ConsoleProjectLab.Entityes;
using ConsoleProjectLab.Enums;
using ConsoleProjectLab.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.XPath;

namespace ConsoleProjectLab.Services
{
    public class SubService
    {
        private static DepartmentService departmentService = new DepartmentService();
        private static EmployeeService employeeService = new EmployeeService();

        public static void AddDepartment()
        {
            string name = Extension.ReadString("Departmentin adini daxil edin: ","Sehv daxil etdiniz");
            int capacity = Extension.ReadInt("Departmentin maksimal ishci sayini daxil edin: ", "Sehv daxil etdiniz");
            double maxSalary = Extension.ReadDouble("Maksimum maash limitini daxil edin:", "Sehv daxil etdiniz");

            departmentService.AddDepartment(name, maxSalary, capacity);
        }

        public static void EditDepartment()
        {
            int id = Extension.ReadInt("Departmentin Id-sini daxil edin: ","Sehv daxil etmisiz!");
            string name = Extension.ReadString("Departmentin yeni adini daxil edin: ", "Sehv daxil etdiniz");
            int capacity = Extension.ReadInt("Departmentin yeni maksimal ishci sayini daxil edin: ", "Sehv daxil etdiniz");
            double maxSalary = Extension.ReadDouble("Yeni maksimum maash limitini daxil edin:", "Sehv daxil etdiniz");

            departmentService.EditDepartment(id,name, maxSalary, capacity);
        }

        public static void DeleteDepartment()
        {
            int id = Extension.ReadInt("Departmentin Id-sini daxil edin: ", "Sehv daxil etmisiz!");
            departmentService.DeleteDepartment(id);

        }

        public static void GetAllDepartments()
        {
            foreach (var item in departmentService.GetAllDepartments())
            {
                Console.WriteLine($"ID -{item.Id} Name --{item.Name}  Capacity--{item.Capacity}  Max massh limiti: {item.MaxSalary} ");
            }
        }

        public static bool CheckDepartmnet()
        {
           return departmentService.CheckDepartments();
        } 

        public static void AddEmployee()
        {
            int departmentId;
            string fullName = Extension.ReadString("Full adini daxil edin: ", "Sehv daxil etdiniz");
            double salary = Extension.ReadDouble("Maasi daxil edin:", "Sehv daxil etdiniz");
            GetAllDepartments();
            l1:
            departmentId = Extension.ReadInt("Deaprtmentin ID-sini daxil edin!", "Sehv daxil etdiniz!");
            Department department = departmentService.GetAllDepartments().FirstOrDefault(d => d.Id == departmentId);
            if (department == null)
            {
                Console.WriteLine("Bu Id ile department movcud deil!");
                return;
            }
            Position position = Extension.ChooseOption<Position>("Positionu secin:");

            employeeService.AddEmployee(fullName, salary,department,position);

        }




    }
}
