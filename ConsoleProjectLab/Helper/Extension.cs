﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProjectLab.Helper
{
    public static class Extension
    {
        public static void Print(string message)
        {
            var backupColor = Console.ForegroundColor;
            var backupBgColor = Console.BackgroundColor;

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine(message);

            Console.ForegroundColor = backupColor;
            Console.BackgroundColor = backupBgColor;
        }

        public static int ReadInt(string caption, string errorMessage)
        {
            var backupColor = Console.ForegroundColor;

        l1:
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(caption);
            Console.ForegroundColor = backupColor;

            string aStr = Console.ReadLine();

            bool state = int.TryParse(aStr, out int a);

            if (!state)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(errorMessage);
                Console.ForegroundColor = backupColor;
                goto l1;
            }

            return a;
        }

        public static string ReadString(string caption, string errorMessage)
        {
            var backupColor = Console.ForegroundColor;

        l1:
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(caption);
            Console.ForegroundColor = backupColor;

            string value = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(value))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(errorMessage);
                Console.ForegroundColor = backupColor;
                goto l1;
            }

            return value;
        }

        public static double ReadDouble(string caption, string errorMessage)
        {
            var backupColor = Console.ForegroundColor;

        l1:
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(caption);
            Console.ForegroundColor = backupColor;

            string aStr = Console.ReadLine();

            bool state = double.TryParse(aStr, out double a);

            if (!state)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(errorMessage);
                Console.ForegroundColor = backupColor;
                goto l1;
            }

            return a;
        }

        public static T ChooseOption<T>(this string caption, string? message = null)
            where T : Enum
        {
            if (string.IsNullOrWhiteSpace(message))
                message = "Option must be choose from list";

            Type type = typeof(T);
            Type uType = Enum.GetUnderlyingType(type);

            var backupColor = Console.ForegroundColor;
            Console.WriteLine("===============CHOOSE OPTION==============");
            Console.ForegroundColor = ConsoleColor.Yellow;
            foreach (var item in Enum.GetValues(type))
            {
                var orderNo = Convert.ChangeType(item, uType);

                Console.WriteLine($"{orderNo}. {item}");
            }
            Console.ForegroundColor = backupColor;
            Console.WriteLine("==========================================");

        l1:
            Print(caption);
            if (!Enum.TryParse(type, Console.ReadLine(), true, out object enumValue) || !Enum.IsDefined(type, enumValue))
            {
                Print(message);
                goto l1;
            }

            return (T)enumValue;
        }
    }
}
