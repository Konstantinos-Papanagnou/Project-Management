using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PharmacyInformationSystem.UnitTesting;

namespace PharmacyInformationSystem
{
    static class Program
    {
        static bool UnitTesting = true;
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
                Application.Run(new UIComponents.Login.Login());
            }
            else
            {
                SanitizerUnitTesting test = new SanitizerUnitTesting();
                Console.WriteLine(test.Test().ToString());
            }
        }
    }
}
