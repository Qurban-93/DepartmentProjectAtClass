using ConsoleProjectLab.Helper;
using ConsoleProjectLab.Services;

namespace ConsoleProjectLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choose;
            bool state = true;
            do
            {
                Console.WriteLine("\n0: Close proqram");
                Console.WriteLine("1: Department elave etmek");
                Console.WriteLine("2: Department deyisim etmek");
                Console.WriteLine("3: Department silmek ");
                Console.WriteLine("4: Butun departmentleri goster");
                Console.WriteLine("5: Ishci elave etmek");

                choose = Extension.ReadInt("Siyahidan secin", "Sehv daxil etdiniz");

                switch (choose)
                {
                    case 0:
                        state = false;
                        break;
                    case 1:
                        SubService.AddDepartment();
                        break;
                    case 2:
                        SubService.EditDepartment();
                        break;
                    case 3:
                        SubService.DeleteDepartment();
                        break;
                    case 4:
                        SubService.GetAllDepartments();
                        break;
                    case 5:
                        SubService.AddEmployee();
                        break;
                    default:
                        break;
                }

            } while (state);


        }
    }
}
