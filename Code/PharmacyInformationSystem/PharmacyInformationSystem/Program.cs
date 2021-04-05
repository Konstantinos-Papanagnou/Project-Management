﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PharmacyInformationSystem.UnitTesting;

namespace PharmacyInformationSystem
{
    static class Program
    {
        static bool UnitTesting = false;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!UnitTesting)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainScreen());
            }
            else
            {
                SanitizerUnitTesting test = new SanitizerUnitTesting();
                Console.WriteLine(test.Test().ToString());
            }
        }
    }
}
