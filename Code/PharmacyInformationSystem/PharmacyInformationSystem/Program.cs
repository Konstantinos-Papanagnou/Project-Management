using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PharmacyInformationSystem.UnitTesting;
using PharmacyInformationSystem.UIComponents;
using PharmacyInformationSystem.UIComponents.Login;

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
                Application.Run(new Login());
                //Application.Run(new MainScreen(new BusinessLogic.Administrator("admin", "admin", "TS502563", 50, "admini", "", 0, new List<string>() { "6950607090", "6956231478" })));
            }
            else
            {
                SanitizerUnitTesting test = new SanitizerUnitTesting();
                Console.WriteLine(test.Test().ToString());
            }
        }
    }
}
