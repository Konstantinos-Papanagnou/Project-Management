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
        public int RoleID { get; set; }
        public List<string> PhoneNumbers { get; set; }
    
        public User(string FirstName, string LastName, string IdCard, int EmployeeID, string Username, string Password, int RoleID, List<string> PhoneNumbers)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.IdCard = IdCard;
            this.EmployeeID = EmployeeID;
            this.Username = Username;
            this.Password = Password;
            this.RoleID = RoleID;
            this.PhoneNumbers = PhoneNumbers;
        }
    }

    public class Administrator : User
    {
        public DatabaseHandler Database { get; private set; }
        public Administrator(string FirstName, string LastName, string IdCard, int EmployeeID, string Username, string Password, int RoleID, List<string> PhoneNumbers) :base(FirstName, LastName, IdCard, EmployeeID, Username, Password, RoleID, PhoneNumbers)
        {
            Database = new DatabaseHandler();
        }

        public Administrator(User user) : base(user.FirstName, user.LastName, user.IdCard, user.EmployeeID, user.Username, user.Password, user.RoleID, user.PhoneNumbers) {
            Database = new DatabaseHandler();
        }
        public List<User> GetAllUsers()
        {
            return Database.RetrieveUsers();
        }

        public bool ModifyUser(User user)
        {
            return Database.ModifyUser(user);
        }

        public bool InsertUser(User user)
        {
            return Database.InsertUser(user);
        }

        public bool DeleteUser(User user)
        {
            return Database.DeleteUser(user.EmployeeID, user.RoleID);
        }

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

        private string Substitute(string toSubstitute)
        {
            string greekAlphabet = "αβγδεζηθικλμνξοπρστυφχψω";
            string ourAlphabet = "abgdezh8iklmn3oprstufxyw";
            string substituded = "";
            foreach (char c in toSubstitute)
            {
                int pos = greekAlphabet.IndexOf(c);
                substituded += ourAlphabet[pos];
            }
            return substituded;
        }
    }

    public class MarketingTeam : User
    {
        public MarketingTeam(string FirstName, string LastName, string IdCard, int EmployeeID, string Username, string Password, int RoleID, List<string> PhoneNumbers) : base(FirstName, LastName, IdCard, EmployeeID, Username, Password, RoleID, PhoneNumbers)
        {

        }
        public MarketingTeam(User user) : base(user.FirstName, user.LastName, user.IdCard, user.EmployeeID, user.Username, user.Password, user.RoleID, user.PhoneNumbers) { }

    }

    public class StoreKeeper : User
    {
        public StoreKeeper(string FirstName, string LastName, string IdCard, int EmployeeID, string Username, string Password, int RoleID, List<string> PhoneNumbers) : base(FirstName, LastName, IdCard, EmployeeID, Username, Password, RoleID, PhoneNumbers)
        {

        }
        public StoreKeeper(User user) : base(user.FirstName, user.LastName, user.IdCard, user.EmployeeID, user.Username, user.Password, user.RoleID, user.PhoneNumbers) { }

    }

    public class Seller : User
    {
        public Seller(string FirstName, string LastName, string IdCard, int EmployeeID, string Username, string Password, int RoleID, List<string> PhoneNumbers) : base(FirstName, LastName, IdCard, EmployeeID, Username, Password, RoleID, PhoneNumbers)
        {

        }
        public Seller(User user) : base(user.FirstName, user.LastName, user.IdCard, user.EmployeeID, user.Username, user.Password, user.RoleID, user.PhoneNumbers) { }

    }
}
