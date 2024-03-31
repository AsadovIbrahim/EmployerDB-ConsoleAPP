using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_DB.Functions
{
    public class Function
    {
        public static void Logo()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
                      
                                         _       __     __                        
                                        | |     / /__  / /________  ____ ___  ___ 
                                        | | /| / / _ \/ / ___/ __ \/ __ `__ \/ _ \
                                        | |/ |/ /  __/ / /__/ /_/ / / / / / /  __/
                                        |__/|__/\___/_/\___/\____/_/ /_/ /_/\___/ ");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void SetConsoleColor(string option)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine(option);
            Console.BackgroundColor = ConsoleColor.Black;
        }
        public static void PressAnyKey()
        {
            Console.Write("\nPress any key to continue . . .");
            Console.ReadKey();
        }
    }
}
