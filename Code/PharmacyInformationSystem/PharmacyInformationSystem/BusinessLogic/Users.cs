using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyInformationSystem.BusinessLogic
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdCard { get; set; }
        public int EmployeeID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public double Salary { get; set; }
        public int RoleID { get; set; }
        public List<string> PhoneNumbers { get; set; }
    
        public User(string FirstName, string LastName, string IdCard, int EmployeeID, string Username, string Password, int RoleID, List<string> PhoneNumbers, double Salary)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.IdCard = IdCard;
            this.EmployeeID = EmployeeID;
            this.Username = Username;
            this.Password = Password;
            this.RoleID = RoleID;
            this.PhoneNumbers = PhoneNumbers;
            this.Salary = Salary;
        }
    }

    public class Administrator : User
    {
        internal DatabaseHandler Database { get; private set; }
        public Administrator(string FirstName, string LastName, string IdCard, int EmployeeID, string Username, string Password, int RoleID, List<string> PhoneNumbers, double Salary) :base(FirstName, LastName, IdCard, EmployeeID, Username, Password, RoleID, PhoneNumbers, Salary)
        {
            Database = new DatabaseHandler();
        }

        public Administrator(User user) : base(user.FirstName, user.LastName, user.IdCard, user.EmployeeID, user.Username, user.Password, user.RoleID, user.PhoneNumbers, user.Salary) {
            Database = new DatabaseHandler();
        }

        /// <summary>
        /// Wrapper function for the DatabaseHandler
        /// </summary>
        /// <returns>The list with all the users from the database</returns>
        public List<User> GetAllUsers()
        {
            return Database.RetrieveUsers();
        }

        /// <summary>
        /// Wrapper function for the DatabaseHandler
        /// </summary>
        /// <param name="user">The user to be modified</param>
        /// <returns>True if the user was updated successfully</returns>
        public bool ModifyUser(User user)
        {
            return Database.ModifyUser(user);
        }

        /// <summary>
        /// Wrapper function for the DatabaseHandler
        /// </summary>
        /// <param name="user">The user to be added</param>
        /// <returns>True if the user was inserted successfully</returns>
        public bool InsertUser(User user)
        {
            return Database.InsertUser(user);
        }

        /// <summary>
        /// Wrapper function for the DatabaseHandler
        /// </summary>
        /// <param name="user">The user selected to be processed</param>
        /// <returns>True if the user was successfully removed from the database</returns>
        public bool DeleteUser(User user)
        {
            return Database.DeleteUser(user.EmployeeID, user.RoleID);
        }

        /// <summary>
        /// Generates a custom username based on the user's first and last name
        /// </summary>
        /// <param name="firstname">The user's first name</param>
        /// <param name="lastname">The user's last name</param>
        /// <returns>The auto generated username</returns>
        public string GenerateUsername(string firstname, string lastname)
        {
            string Generated = Sanitizer.SanitizeInput(Substitute(firstname.Substring(0, 2).ToLower()) + Substitute(lastname.Substring(0, 4).ToLower()));
            while (true)
            {
                if (Database.DoesUsernameExists(Generated))
                {
                    Random rand = new Random();
                    int pos = rand.Next(0, 6);
                    char randomChar = (char)(rand.Next(26) + 'a');
                    char[] arr = Generated.ToCharArray();
                    arr[pos] = randomChar;
                    Generated = string.Join("", arr);
                }
                else return Generated.ToLower();
            }
        }

        /// <summary>
        /// Helper function to substitute the greek alphabet with our custom alphabet
        /// </summary>
        /// <param name="toSubstitute">The input to substitute</param>
        /// <returns>The substituted letters.</returns>
        private string Substitute(string toSubstitute)
        {
            string greekAlphabet = "αάβγδεέζηήθιίκλμνξοόπρστυύφχψωώ";
            string ourAlphabet = "aabgdeezhh8iiklmn3ooprstuufxyww";
            string substituded = "";
            foreach (char c in toSubstitute)
            {
                int pos = greekAlphabet.IndexOf(c);
                if (pos < 0) continue; //Invalid character, keep it we don't care. Maybe it's already english
                substituded += ourAlphabet[pos];
            }
            return substituded;
        }
    }

    public class MarketingTeam : User
    {
        readonly DatabaseHandler Database;
        public MarketingTeam(string FirstName, string LastName, string IdCard, int EmployeeID, string Username, string Password, int RoleID, List<string> PhoneNumbers, double Salary) : base(FirstName, LastName, IdCard, EmployeeID, Username, Password, RoleID, PhoneNumbers, Salary)
        {
            Database = new DatabaseHandler();
        }
        public MarketingTeam(User user) : base(user.FirstName, user.LastName, user.IdCard, user.EmployeeID, user.Username, user.Password, user.RoleID, user.PhoneNumbers, user.Salary) 
        {
            Database = new DatabaseHandler(); 
        }

        /// <summary>
        /// Medicine's profit per day
        /// </summary>
        /// <param name="med"></param>
        /// <param name="unitSold"></param>
        /// <returns>Medicine's profit per day</returns>
        public double ProfitPerDay(Medicine med, int unitSold)
        {
            return (med.MedSellingValue - med.MedAcquisitionValue) * unitSold;
        }

        /// <summary>
        /// Medicine's profit per month
        /// </summary>
        /// <param name="med"></param>
        /// <param name="unitSold"></param>
        /// <returns>Medicine's profit per month</returns>
        public double ProfitPerMonth(Medicine med, int unitSold)
        {
            double ppM = 0;
            for (int day = 0; day < 22; day++)
            {
                ppM += ProfitPerDay(med, unitSold);
            }
            return ppM;
        }

        /// <summary>
        /// Medicine's profit per year
        /// </summary>
        /// <param name="med"></param>
        /// <param name="unitSold"></param>
        /// <returns>Medicine's profit per year</returns>
        public double ProfitPerYear(Medicine med, int unitSold)
        {
            double ppY = 0;
            for (int month = 0; month < 12; month++)
            {
                ppY += ProfitPerMonth(med, unitSold);
            }
            return ppY;
        }

        /// <summary>
        /// Company's profit per month
        /// </summary>
        /// <param name="medCount"></param>
        /// <param name="med"></param>
        /// <param name="unitSold"></param>
        /// <returns>Company's profit per month</returns>
        public double CompanyPerMonth(int medCount, Medicine med, int unitSold)
        {
            double cpM = 0;
            for (int count = 0; count < medCount; count++)
            {
                cpM += ProfitPerMonth(med, unitSold);
            }
            return cpM;
        }

        /// <summary>
        /// Company's profit per year
        /// </summary>
        /// <param name="medCount"></param>
        /// <param name="med"></param>
        /// <param name="unitSold"></param>
        /// <returns>Company's profit per year</returns>
        public double CompanyPerYear(int medCount, Medicine med, int unitSold)
        {
            double cpΥ = 0;
            for (int count = 0; count < 12; count++)
            {
                cpΥ += CompanyPerMonth(medCount, med, unitSold);
            }
            return cpΥ;
        }
    }

    public class StoreKeeper : User
    {
        readonly DatabaseHandler Database;
        public StoreKeeper(string FirstName, string LastName, string IdCard, int EmployeeID, string Username, string Password, int RoleID, List<string> PhoneNumbers, double Salary) : base(FirstName, LastName, IdCard, EmployeeID, Username, Password, RoleID, PhoneNumbers, Salary)
        {
            Database = new DatabaseHandler();
        }
        public StoreKeeper(User user) : base(user.FirstName, user.LastName, user.IdCard, user.EmployeeID, user.Username, user.Password, user.RoleID, user.PhoneNumbers, user.Salary) { 
            Database = new DatabaseHandler(); 
        }

        /// <summary>
        /// Adds a medicine
        /// </summary>
        /// <param name="medicine"></param>
        /// <returns>True if medicine was added successfully</returns>
        public Medicine AddMedicine(Medicine medicine)
        {
            return Database.AddMedicine(medicine);
        }

        /// <summary>
        /// Removes a specific medicine
        /// </summary>
        /// <param name="medicine"></param>
        /// <returns>True if medicine was delete successfully</returns>
        public bool RemoveMedicine(int MedID)
        {
            return Database.RemoveMedicine(MedID);
        }

        /// <summary>
        /// Update a specific medicine
        /// </summary>
        /// <param name="medicine"></param>
        /// <returns>True if medicine info was updated successfully</returns>
        public bool UpdateMedicine(Medicine medicine)
        {
            return Database.UpdateMedicine(medicine);
        }

        /// <summary>
        /// Displays all medicines
        /// </summary>
        /// <returns>The list with all the medicine from the database</returns>
        public List<Medicine> GetMedicines()
        {
            return Database.DisplayMedicines();
        }
    }

    public class Seller : User
    {
        readonly DatabaseHandler Database;
        public Seller(string FirstName, string LastName, string IdCard, int EmployeeID, string Username, string Password, int RoleID, List<string> PhoneNumbers, double Salary) : base(FirstName, LastName, IdCard, EmployeeID, Username, Password, RoleID, PhoneNumbers, Salary)
        {
            Database = new DatabaseHandler();
        }
        public Seller(User user) : base(user.FirstName, user.LastName, user.IdCard, user.EmployeeID, user.Username, user.Password, user.RoleID, user.PhoneNumbers, user.Salary) { Database = new DatabaseHandler(); }
        
        /// <summary>
        /// Displays all medicines
        /// </summary>
        /// <returns>The list with all the medicine from the database</returns>
        public List<Medicine> GetMedicines()
        {   
            return Database.DisplayMedicines();
        }

        /// <summary>
        /// Return every order for this specific seller
        /// </summary>
        /// <returns>All the orders that match with the seller's id</returns>
        public List<Order> GetOrders()
        {
            return Database.RetrieveOrders(EmployeeID);
        }

        /// <summary>
        /// Return all the Pharmacists binded to this Seller
        /// </summary>
        /// <returns>All the binded pharmacists</returns>
        public List<Pharmacist> GetPharmacists()
        {
            return Database.RetrievePharmacist(EmployeeID);
        }

        /// <summary>
        /// Adds a Pharmacist to the list of pharmacists for the specified seller
        /// </summary>
        /// <param name="pharmacist">The pharmacist to add</param>
        /// <returns>True if the pharmacist was inserted successfully</returns>
        public bool AddPharmacist(Pharmacist pharmacist)
        {
            pharmacist.PSellerID = EmployeeID;
            return Database.InsertPharmacist(pharmacist);
        }

        /// <summary>
        /// Modify Pharmacist's information
        /// </summary>
        /// <param name="pharmacist">The Pharmacist details</param>
        /// <returns>True if modification was successfull</returns>
        public bool ModifyPharmacist(Pharmacist pharmacist)
        {
            pharmacist.PSellerID = EmployeeID;
            return Database.ModifyPharmacist(pharmacist);
        }

        /// <summary>
        /// Removes the pharmacist from the database
        /// </summary>
        /// <param name="PharmacistID">The Pharmacist id to remove</param>
        /// <returns>True if modification was successfull</returns>
        public bool RemovePharmacist(int PharmacistID)
        {
            return Database.DeletePharmacist(PharmacistID);
        }

        /// <summary>
        /// Adds a pending order to the database
        /// </summary>
        /// <param name="order">The order to be added</param>
        /// <returns>True if addition was successful</returns>
        public bool GetOrder(Order order)
        {
            return Database.InsertOrder(order);
        }

    }
}
