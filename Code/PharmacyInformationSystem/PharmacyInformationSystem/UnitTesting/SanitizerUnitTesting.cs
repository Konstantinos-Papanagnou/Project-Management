using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PharmacyInformationSystem.BusinessLogic;
using PharmacyInformationSystem.BusinessLogic.LoginFunctionality;

namespace PharmacyInformationSystem.UnitTesting
{
    public class SanitizerUnitTesting
    {
        public bool Test()
        {
            string hash = Hashing.ComputeHash("password123");
            string hash2 = Hashing.ComputeHash("password123");
            if (hash == hash2)
                Console.WriteLine("They are the same");
            Console.WriteLine(hash);
            Console.WriteLine(hash2);
            Console.WriteLine(hash.Length);
            //Console.WriteLine(Administrator.GenerateUsername("ΘΑΝΑΣΗΣ", "ΜΕΛΙΣΣΟΣ"));
            bool first = Sanitizer.CheckFirstName("Κωνσταντίνος");
            bool second = Sanitizer.CheckLastName("Παπανάγνου");
            bool third = Sanitizer.CheckIDCard("AM520530");
            bool fourth = Sanitizer.CheckEmployeeID(1);
            bool fifth = Sanitizer.CheckPassword("Password13");
            bool sixth = Sanitizer.CheckRoleID(2);
            bool seventh = Sanitizer.CheckPhoneNumber("6905324568");
            Console.WriteLine(Sanitizer.SanitizeInput("Hello there i'm here to DROP TABLE USER;"));
            return first && second && third && fourth && fifth && sixth && seventh;
        }
        
    }
}
