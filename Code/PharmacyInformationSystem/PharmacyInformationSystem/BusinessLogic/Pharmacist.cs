using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyInformationSystem.BusinessLogic
{
    public class Pharmacist
    {
        public int PharmacistID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string AFM { get; set; }
        public string Phone { get; set; }
        public string PANumber { get; set; }
        public string PAStreet { get; set; }
        public string PATown { get; set; }
        public string PAPostalCode { get; set; }
        public string PSellerID { get; set; }

        public Pharmacist(int pharmacistID, string lastName, string firstName, string phone, string pANumber, string pAStreet, string pATown, string pAPostalCode, string pSellerID)
        {
            PharmacistID = pharmacistID;
            LastName = lastName;
            FirstName = firstName;
            Phone = phone;
            PANumber = pANumber;
            PAStreet = pAStreet;
            PATown = pATown;
            PAPostalCode = pAPostalCode;
            PSellerID = pSellerID;
        }

        public Pharmacist(string lastName, string firstName, string phone, string pANumber, string pAStreet, string pATown, string pAPostalCode, string pSellerID)
        {
            LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
            FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
            Phone = phone ?? throw new ArgumentNullException(nameof(phone));
            PANumber = pANumber ?? throw new ArgumentNullException(nameof(pANumber));
            PAStreet = pAStreet ?? throw new ArgumentNullException(nameof(pAStreet));
            PATown = pATown ?? throw new ArgumentNullException(nameof(pATown));
            PAPostalCode = pAPostalCode ?? throw new ArgumentNullException(nameof(pAPostalCode));
            PSellerID = pSellerID ?? throw new ArgumentNullException(nameof(pSellerID));
        }
    }
}
