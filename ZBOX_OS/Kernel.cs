using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace ZBOX_OS
{
    public class Kernel : Sys.Kernel
    {

        protected override void BeforeRun()
        {
            Console.Clear();
            Console.WriteLine("Welcome to");
            Console.WriteLine("--------------------");
            Console.WriteLine("       ZBOX OS");
            Console.WriteLine("--------------------");
            Console.WriteLine("\nSelect an option:");
            Console.WriteLine("1) Boot into ZBOX");
            Console.WriteLine("2) Troubleshoot");
            Console.WriteLine("3) Restart machine");
            Console.WriteLine("4) Shutdown");
            Console.WriteLine();
            Console.Write("\nYour choice: ");
            string nextKey = Console.ReadLine();
            switch (nextKey)
            {
                case "3":
                    Sys.Power.Reboot();
                    break;
                case "4":
                    Sys.Power.Shutdown();
                    break;
                
            }
        }

        protected override void Run()
        {
            
        }
    }
}
