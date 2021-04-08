using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using PharmacyInformationSystem.BusinessLogic.LoginFunctionality;

namespace PharmacyInformationSystem.BusinessLogic
{
    public class DatabaseHandler
    {
        public static readonly string DatabaseName = "Pharmacy.db";
        public static readonly string ConnName = "Data Source = " + DatabaseName + "; Version=3; foreign keys=true;";

        #region User Table
        private const string UsersTableName = "User";
        private const string FirstNameField = "FirstName";
        private const string LastNameField = "LastName";
        private const string EmployeeIDField = "EmployeeID";
        private const string UsernameField = "Username";
        private const string PasswordField = "Password";
        private const string IdCardField = "IDCard";
        private const string RoleIDField = "RoleID";
        #endregion

        #region Role Table
        private const string RolesTableName = "UserRole";
        private const string DescriptionField = "Description";
        #endregion

        #region PhoneNumber Table
        private const string PhoneNumberTableName = "PhoneNumber";
        private const string PhoneNumberField = "PhoneNumber";
        #endregion

        /// <summary>
        /// Initializes and creates the database if it doesn't already exist
        /// </summary>
        public DatabaseHandler()
        {
            if (File.Exists(DatabaseName))
                return;
            using (SQLiteConnection conn = new SQLiteConnection(ConnName))
            {
                conn.Open();
                CreateTables(conn);
            }
        }
        /// <summary>
        /// Initializes the database and creates the tables
        /// </summary>
        /// <param name="conn">The connection to the database</param>
        private void CreateTables(SQLiteConnection conn)
        {
            new SQLiteCommand($"CREATE TABLE IF NOT EXISTS {RolesTableName}({RoleIDField} INT," +
                $" {DescriptionField} STRING NOT NULL, PRIMARY KEY({RoleIDField}))", conn).ExecuteNonQuery();

            new SQLiteCommand($"CREATE TABLE IF NOT EXISTS {UsersTableName}({EmployeeIDField} INTEGER PRIMARY KEY AUTOINCREMENT," +
                $" {FirstNameField} STRING NOT NULL, {LastNameField} STRING NOT NULL, {IdCardField} CHAR(8) UNIQUE NOT NULL, " +
                $"{UsernameField} CHAR(6) UNIQUE NOT NULL, {PasswordField} CHAR(64) NOT NULL, {RoleIDField} INT NOT NULL," +
                $" FOREIGN KEY({RoleIDField}) REFERENCES {RolesTableName}({RoleIDField}))", conn).ExecuteNonQuery();

            new SQLiteCommand($"CREATE TABLE IF NOT EXISTS {PhoneNumberTableName}({EmployeeIDField} INTEGER," +
                $" {PhoneNumberField} CHAR(10) NOT NULL, PRIMARY KEY({EmployeeIDField}, {PhoneNumberField}), FOREIGN KEY({EmployeeIDField}) REFERENCES {UsersTableName}({EmployeeIDField}))", conn).ExecuteNonQuery();

            //To-Do insert default role id values and default administator data
            new SQLiteCommand($"INSERT INTO {RolesTableName}({RoleIDField},{DescriptionField}) VALUES ('0', 'Administrator')", conn).ExecuteNonQuery();
            new SQLiteCommand($"INSERT INTO {RolesTableName}({RoleIDField},{DescriptionField}) VALUES ('1', 'StoreKeeper')", conn).ExecuteNonQuery();
            new SQLiteCommand($"INSERT INTO {RolesTableName}({RoleIDField},{DescriptionField}) VALUES ('2', 'Seller')", conn).ExecuteNonQuery();
            new SQLiteCommand($"INSERT INTO {RolesTableName}({RoleIDField},{DescriptionField}) VALUES ('3', 'Marketing Team')", conn).ExecuteNonQuery();

            new SQLiteCommand($"INSERT INTO {UsersTableName}({FirstNameField},{LastNameField}," +
                $"{IdCardField}, {UsernameField}, {PasswordField}, {RoleIDField}) VALUES " +
                $"('Admin', 'Admin', 'Dummy', 'admini', '{Hashing.ComputeHash("Password123")}', '0')", conn).ExecuteNonQuery();


        }
        /// <summary>
        /// Checks to see in the database if the username is already occupied
        /// </summary>
        /// <param name="username">Username to check for</param>
        /// <returns>True if the username exists</returns>
        internal bool DoesUsernameExists(string username)
        {
            using (SQLiteConnection conn = new SQLiteConnection(ConnName))
            {
                conn.Open();
                SQLiteCommand command = new SQLiteCommand($"SELECT * FROM USER WHERE {UsernameField} = '{username}'", conn);
                using (var reader = command.ExecuteReader())
                    return reader.Read();
            }
        }
        /// <summary>
        /// Checks if there is a user with the credentials specified
        /// </summary>
        /// <param name="username">Username</param>
        /// <param name="password">Password</param>
        /// <returns>True if the authentication Succeeded</returns>
        internal bool CredentialCheck(string username, string password)
        {
            using (SQLiteConnection conn = new SQLiteConnection(ConnName))
            {
                conn.Open();
                SQLiteCommand command = new SQLiteCommand($"SELECT {EmployeeIDField} FROM {UsersTableName} WHERE {UsernameField} = '{Sanitizer.SanitizeInput(username)}' AND {PasswordField} = '{Hashing.ComputeHash(password)}'", conn);
                using (var reader = command.ExecuteReader())
                {
                    return reader.Read();
                }
            }
        }
        /// <summary>
        /// Retrieves the User Data
        /// </summary>
        /// <param name="username">Username</param>
        /// <returns>User Data</returns>
        internal User GetUserData(string username)
        {
            using (SQLiteConnection conn = new SQLiteConnection(ConnName))
            {
                conn.Open();

                SQLiteCommand command = new SQLiteCommand($"SELECT * FROM {UsersTableName} WHERE {UsernameField} = '{username}'", conn);
                using (var reader = command.ExecuteReader())
                {
                    User user = null;
                    //Get the user data (Should be one)
                    while (reader.Read())
                    {
                        user = new User(
                                FirstName: reader[1].ToString(),
                                LastName: reader[2].ToString(),
                                IdCard: reader[3].ToString(),
                                EmployeeID: int.Parse(reader[0].ToString()),
                                Username: reader[4].ToString(),
                                Password: reader[5].ToString(),
                                RoleID: int.Parse(reader[6].ToString()),
                                null
                            );
                        //Grab the phone numbers associated with him
                        SQLiteCommand grabPhones = new SQLiteCommand($"SELECT * FROM {PhoneNumberTableName} WHERE {EmployeeIDField} = '{user.EmployeeID}'", conn);
                        using (var phoneReader = grabPhones.ExecuteReader())
                        {
                            List<string> phoneNumbers = new List<string>();
                            while (phoneReader.Read())
                            {
                                phoneNumbers.Add(phoneReader[1].ToString());
                            }
                            //Add the phone numbers found to the user data and return 
                            user.PhoneNumbers = phoneNumbers;
                        }
                    }
                    switch (user.RoleID)
                    {
                        case 0: return new Administrator(user);
                        case 1: return new StoreKeeper(user);
                        case 2: return new Seller(user);
                        default: return new MarketingTeam(user);
                    }
                }
            }
        }
        /// <summary>
        /// Retrieves all users from the database
        /// </summary>
        /// <returns>All users and their associated data from the database</returns>
        internal List<User> RetrieveUsers()
        {
            using (SQLiteConnection conn = new SQLiteConnection(ConnName))
            {
                conn.Open();

                SQLiteCommand command = new SQLiteCommand($"SELECT * FROM {UsersTableName}", conn);
                using (var reader = command.ExecuteReader())
                {
                    List<User> users = new List<User>();
                    //Get the Users
                    while (reader.Read())
                    {
                        //foreach user get the phone numbers associated with
                        SQLiteCommand grabPhones = new SQLiteCommand($"SELECT * FROM {PhoneNumberTableName} WHERE {EmployeeIDField} = '{reader[0]}'", conn);
                        var phoneReader = grabPhones.ExecuteReader();
                        List<string> phoneNumbers = new List<string>();
                        while (phoneReader.Read())
                        {
                            phoneNumbers.Add(phoneReader[1].ToString());
                        }
                        //add the user to the list
                        users.Add(new User(
                                FirstName: reader[1].ToString(),
                                LastName: reader[2].ToString(),
                                IdCard: reader[3].ToString(),
                                EmployeeID: int.Parse(reader[0].ToString()),
                                Username: reader[4].ToString(),
                                Password: reader[5].ToString(),
                                RoleID: int.Parse(reader[6].ToString()),
                                PhoneNumbers: phoneNumbers
                            ));
                    }
                    return users;
                }
            }
        }

        /// <summary>
        /// Insert a user to the database along with his user data
        /// </summary>
        /// <param name="user">User object containing all the user information</param>
        /// <returns>True if the user was successfully inserted</returns>
        internal bool InsertUser(User user)
        {
            using(SQLiteConnection conn = new SQLiteConnection(ConnName))
            {
                conn.Open();
                //Insert User Data first
                SQLiteCommand insertUserData = new SQLiteCommand($"INSERT INTO {UsersTableName}({FirstNameField}, " +
                    $"{LastNameField}, {IdCardField}, {UsernameField}, {PasswordField}, {RoleIDField}) VALUES (" +
                    $"'{user.FirstName}','{user.LastName}','{user.IdCard}','{user.Username}" +
                    $"','{Hashing.ComputeHash(user.Password)}','{user.RoleID}')", conn);
                if (insertUserData.ExecuteNonQuery() < 0) return false;
                //Get the new EmployeeId of the user
                insertUserData.CommandText = $"SELECT {EmployeeIDField} FROM {UsersTableName} WHERE {UsernameField} = '{user.Username}'";
                using (var reader = insertUserData.ExecuteReader())
                {
                    int employeeid = 0;
                    while (reader.Read())
                    {
                        employeeid = int.Parse(reader[0].ToString());
                    }
                    //User was not added/found something went completely wrong
                    if (employeeid == 0) return false;
                    //Insert the phone numbers of the user one at a time
                    foreach (string number in user.PhoneNumbers)
                    {
                        InsertPhoneNumber(conn, employeeid, number);
                    }

                    return true;
                }
            }
        }

        /// <summary>
        /// Deleted the user specified from the databse
        /// </summary>
        /// <param name="employeeId">The user's employeeId to be deleted</param>
        /// <param name="roleid">The user's role to the application</param>
        /// <returns>True if the user was successfully removed from the database</returns>
        internal bool DeleteUser(int employeeId, int roleid)
        {
            using (SQLiteConnection conn = new SQLiteConnection(ConnName))
            {
                conn.Open();
                //First remove all the information of that user from the other tables.
                SQLiteCommand deleteUser = new SQLiteCommand(conn);
                DeletePhoneNumbers(conn, employeeId);
                //Each type of user has different entries to different tables along the database. 
                //So find those and delete them
                switch (roleid)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                }
                //Finally remove the user from the Users table
                deleteUser.CommandText = $"DELETE FROM {UsersTableName} WHERE {EmployeeIDField} = '{employeeId}'";
                return deleteUser.ExecuteNonQuery() > 0;
            }
        }

        /// <summary>
        /// Helper function to delete all phone numbers
        /// </summary>
        /// <param name="conn">The open connection to the database</param>
        /// <param name="employeeId">The employee id of the user to remove the number from</param>
        /// <returns></returns>
        private bool DeletePhoneNumbers(SQLiteConnection conn, int employeeId)
        {
            SQLiteCommand deleteUser = new SQLiteCommand($"DELETE FROM {PhoneNumberTableName} WHERE {EmployeeIDField} = '{employeeId}'", conn);
            return deleteUser.ExecuteNonQuery() > 0;
        }

        /// <summary>
        /// Helper function to Insert a new phoneNumber
        /// </summary>
        /// <param name="conn">The open connection to the database</param>
        /// <param name="employeeId">The employee id of the user associated with the number</param>
        /// <param name="phoneNumber">The phone number to insert</param>
        /// <returns></returns>
        private bool InsertPhoneNumber(SQLiteConnection conn, int employeeId, string phoneNumber)
        {
            SQLiteCommand insertPhoneNumber = new SQLiteCommand($"INSERT INTO {PhoneNumberTableName}({EmployeeIDField}," +
                $"{PhoneNumberField}) VALUES ('{employeeId}','{phoneNumber}')", conn);
            return insertPhoneNumber.ExecuteNonQuery() > 0;
        }

        /// <summary>
        /// Modifies User's Data
        /// </summary>
        /// <param name="user">new user data</param>
        /// <returns>True if the user was updated successfully</returns>
        internal bool ModifyUser(User user)
        {
            using(SQLiteConnection conn = new SQLiteConnection(ConnName))
            {
                conn.Open();
                SQLiteCommand modifyUser = new SQLiteCommand(conn);
                if (string.IsNullOrEmpty(user.Password))
                    modifyUser.CommandText = $"UPDATE {UsersTableName} SET " +
                        $"{FirstNameField}='{Sanitizer.SanitizeInput(user.FirstName)}'," +
                        $"{LastNameField}='{Sanitizer.SanitizeInput(user.LastName)}'," +
                        $"{UsernameField}='{Sanitizer.SanitizeInput(user.Username)}'," +
                        $"{RoleIDField}='{user.RoleID}'," +
                        $"{IdCardField}='{user.IdCard}' WHERE {EmployeeIDField} = '{user.EmployeeID}'";
                else
                    modifyUser.CommandText = $"UPDATE {UsersTableName} SET " +
                        $"{FirstNameField}='{Sanitizer.SanitizeInput(user.FirstName)}'," +
                        $"{LastNameField}='{Sanitizer.SanitizeInput(user.LastName)}'," +
                        $"{UsernameField}='{Sanitizer.SanitizeInput(user.Username)}'," +
                        $"{RoleIDField}='{user.RoleID}'," +
                        $"{IdCardField}='{user.IdCard}'," +
                        $"{PasswordField}='{Hashing.ComputeHash(user.Password)}'" +
                        $" WHERE {EmployeeIDField} = '{user.EmployeeID}'";
                if (!(modifyUser.ExecuteNonQuery() > 0)) return false;

                DeletePhoneNumbers(conn, user.EmployeeID);
                foreach(string number in user.PhoneNumbers)
                {
                    InsertPhoneNumber(conn, user.EmployeeID, number);
                }
                return true;
            }
        }
    }
}
