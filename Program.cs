using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Vulnerability_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Do you want me to kill windows? [Y]es - [N]o:");
            Console.ForegroundColor = ConsoleColor.White;
            int x = Console.Read();
            try
            {
                char y = Convert.ToChar(x);
                if(y == 'Y' || y == 'y')
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Attempting to kill windows...");
                    Process.Start("CMD.exe", "/k taskkill /IM svchost.exe /F");
                }
                else if(y != 'Y' || y != 'y')
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Understandable, have a great day.");
                    System.Threading.Thread.Sleep(3000);
                    Environment.Exit(0);
                }
            }
            catch(Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Woops! We caught an exception! Message: {0}", ex.Message);
                Console.WriteLine("The program will exit in 10 seconds.");
                System.Threading.Thread.Sleep(10000);
                Environment.Exit(1);
            }
        }
    }
}
