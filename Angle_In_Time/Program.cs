﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angle_In_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleService consoleService = new ConsoleService();

            consoleService.PrintMessage(Constants.MenuMessage);
            consoleService.ProcessInput();
            Console.ReadKey();
        }
    }
}
