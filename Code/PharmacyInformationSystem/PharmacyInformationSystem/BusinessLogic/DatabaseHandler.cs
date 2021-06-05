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
    class DatabaseHandler
    {
        private static readonly string AppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        private static readonly string FolderPath = System.IO.Path.Combine(AppData + "/PharmacyInformationSystem");
        public static readonly string DatabaseName = System.IO.Path.Combine(FolderPath, "Pharmacy.db");
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
        private const string SalaryField = "Salary";
        #endregion
            
        #region Role Table
        private const string RolesTableName = "UserRole";
        private const string DescriptionField = "Description";
        #endregion

        #region PhoneNumber Table
        private const string PhoneNumberTableName = "PhoneNumber";
        private const string PhoneNumberField = "PhoneNumber";
        #endregion

        #region Medicine Table
        private const string MedicineTableName = "MedicineParaphar";
        private const string MedicineID = "ID";
        private const string MedicineName = "Name";
        private const string MedicineCategory = "Category";
        private const string MedicineManufacturingCompany = "ManufacturingCompany";
        private const string MedicineStock = "Stock";
        private const string MedicineMinStock = "MinStock";
        private const string MedicineDueDate =  "DueDate";
        private const string MedicineAcquisitionValue = "AcquisitionValue";
        private const string MedicineSellingPrice = "SellingPrice";
        private const string MedicineQuality = "Quality";
        private const string MedicineType = "Type";
        #endregion

        #region Pharmacist Table
        private const string PharmacistTableName = "Pharmacist";
        private const string PharmacistID = "PharmacistID";
        private const string PharmacistFirstName = "FirstName";
        private const string PharmacistLastName = "LastName";
        private const string PharmacistAFM = "AFM";
        private const string PharmacistPhone = "Phone";
        private const string PharmacistANumber = "AddressNumber";
        private const string PharmacistAStreet = "AddressStreet";
        private const string PharmacistATown = "AddressTown";
        private const string PharmacistAPostalCode = "PostalCode";
        private const string PharmacistSellerID = "SellerID";
        #endregion
        
        #region Order Table
        private const string OrderTableName = "OrderTable";
        private const string OrderIDField = "OrderID";
        private const string SellerIDOrderField = "SellerID";
        private const string PharmacistIDOrder = "PharmacistID";
        private const string TotalCostField = "TotalCost";
        private const string OrderDateField = "OrderDate";
        #endregion

        #region OrderLine Table
        private const string OrderLineTableName = "OrderLine";
        private const string OrdIDField = "OrderID";
        private const string MediID = "MedicineID";
        private const string ProductQuantity = "ProductQuanftity";
        private const string TotalProductCost = "TotalProductCost";
        #endregion
        
        /// <summary>
        /// Initializes and creates the database if it doesn't already exist
        /// </summary>
        public DatabaseHandler()
        {
            System.IO.Directory.CreateDirectory(FolderPath);
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
                $" {SalaryField} REAL NOT NULL, FOREIGN KEY({RoleIDField}) REFERENCES {RolesTableName}({RoleIDField}))", conn).ExecuteNonQuery();

            new SQLiteCommand($"CREATE TABLE IF NOT EXISTS {PhoneNumberTableName}({EmployeeIDField} INTEGER," +
                $" {PhoneNumberField} CHAR(10) NOT NULL, PRIMARY KEY({EmployeeIDField}, {PhoneNumberField}), FOREIGN KEY({EmployeeIDField}) REFERENCES {UsersTableName}({EmployeeIDField}))", conn).ExecuteNonQuery();

            new SQLiteCommand($"CREATE TABLE IF NOT EXISTS {MedicineTableName}({MedicineID} INTEGER PRIMARY KEY AUTOINCREMENT," +
                $"{MedicineName} STRING NOT NULL UNIQUE, {MedicineCategory} STRING NOT NULL, {MedicineManufacturingCompany} STRING NOT NULL," +
                $"{MedicineStock} INTEGER NOT NULL, {MedicineMinStock} INTEGER NOT NULL, {MedicineDueDate} STRING NOT NULL," +
                $"{MedicineAcquisitionValue} REAL NOT NULL, {MedicineSellingPrice} REAL NOT NULL, " +
                $"{MedicineQuality} CHAR(1) NOT NULL, {MedicineType} CHAR(1) NOT NULL)",conn).ExecuteNonQuery();

            new SQLiteCommand($"CREATE TABLE IF NOT EXISTS {PharmacistTableName}({PharmacistID} INTEGER PRIMARY KEY AUTOINCREMENT," +
                $"{PharmacistFirstName} STRING NOT NULL,{PharmacistLastName} STRING NOT NULL,{PharmacistAFM} CHAR(9) NOT NULL UNIQUE" +
                $",{PharmacistPhone} CHAR(10) NOT NULL UNIQUE," +
                $"{PharmacistANumber} STRING NOT NULL,{PharmacistAStreet} STRING NOT NULL,{PharmacistATown} STRING NOT NULL," +
                $"{PharmacistAPostalCode} CHAR(5) NOT NULL,{PharmacistSellerID} INTEGER NOT NULL, " +
                $"FOREIGN KEY({PharmacistSellerID}) REFERENCES {UsersTableName}({EmployeeIDField}))", conn).ExecuteNonQuery();

            Console.WriteLine($"CREATE TABLE IF NOT EXISTS {OrderTableName}({OrderIDField} INTEGER PRIMARY KEY AUTOINCREMENT," +
                $"{SellerIDOrderField} INTEGER NOT NULL," +
                $"{PharmacistID} INTEGER NOT NULL," +
                $"{TotalCostField} DOUBLE NOT NULL,{OrderDateField} STRING NOT NULL," +
                $"FOREIGN KEY({PharmacistID}) REFERENCES {PharmacistTableName}({PharmacistID})," +
                $"FOREIGN KEY({SellerIDOrderField}) REFERENCES {UsersTableName}({EmployeeIDField}))");
            new SQLiteCommand($"CREATE TABLE IF NOT EXISTS {OrderTableName}({OrderIDField} INTEGER PRIMARY KEY AUTOINCREMENT," +
                $"{SellerIDOrderField} INTEGER NOT NULL," +
                $"{PharmacistID} INTEGER NOT NULL," +
                $"{TotalCostField} DOUBLE NOT NULL,{OrderDateField} STRING NOT NULL," +
                $"FOREIGN KEY({PharmacistID}) REFERENCES {PharmacistTableName}({PharmacistID})," +
                $"FOREIGN KEY({SellerIDOrderField}) REFERENCES {UsersTableName}({EmployeeIDField}))", conn).ExecuteNonQuery();

            new SQLiteCommand($"CREATE TABLE IF NOT EXISTS {OrderLineTableName}(" +
                $"{OrdIDField} INTEGER NOT NULL," +
                $"{MediID} INTEGER NOT NULL," +
                $"{ProductQuantity} INTEGER NOT NULL,{TotalProductCost} INTEGER NOT NULL, " +
                $"PRIMARY KEY({OrdIDField},{MediID}), FOREIGN KEY({OrdIDField}) REFERENCES {OrderTableName}({OrderIDField})," +
                $"FOREIGN KEY({MediID}) REFERENCES {MedicineTableName}({MedicineID}))",conn).ExecuteNonQuery();

            //To-Do insert default role id values and default administator data
            new SQLiteCommand($"INSERT INTO {RolesTableName}({RoleIDField},{DescriptionField}) VALUES ('0', 'Administrator')", conn).ExecuteNonQuery();
            new SQLiteCommand($"INSERT INTO {RolesTableName}({RoleIDField},{DescriptionField}) VALUES ('1', 'StoreKeeper')", conn).ExecuteNonQuery();
            new SQLiteCommand($"INSERT INTO {RolesTableName}({RoleIDField},{DescriptionField}) VALUES ('2', 'Seller')", conn).ExecuteNonQuery();
            new SQLiteCommand($"INSERT INTO {RolesTableName}({RoleIDField},{DescriptionField}) VALUES ('3', 'Marketing Team')", conn).ExecuteNonQuery();

            new SQLiteCommand($"INSERT INTO {UsersTableName}({FirstNameField},{LastNameField}," +
                $"{IdCardField}, {UsernameField}, {PasswordField}, {RoleIDField}, {SalaryField}) VALUES " +
                $"('Admin', 'Admin', 'Dummy', 'admin', '{Hashing.ComputeHash("Password123")}', '0', '1500.50')", conn).ExecuteNonQuery();


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
                                PhoneNumbers: null,
                                Salary: double.Parse(reader[7].ToString())

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
                                PhoneNumbers: phoneNumbers,
                                Salary: double.Parse(reader[7].ToString())
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
                    $"{LastNameField}, {IdCardField}, {UsernameField}, {PasswordField}, {RoleIDField}, {SalaryField}) VALUES (" +
                    $"'{user.FirstName}','{user.LastName}','{user.IdCard}','{user.Username}" +
                    $"','{Hashing.ComputeHash(user.Password)}','{user.RoleID}', '{user.Salary}')", conn);
                try { if (insertUserData.ExecuteNonQuery() < 0) return false; } catch { return false; }
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
        /// <returns>True if phone number was deleted successfully</returns>
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
        /// <returns>True if phone number was inserted successfully</returns>
        private bool InsertPhoneNumber(SQLiteConnection conn, int employeeId, string phoneNumber)
        {
            try
            {
                SQLiteCommand insertPhoneNumber = new SQLiteCommand($"INSERT INTO {PhoneNumberTableName}({EmployeeIDField}," +
                    $"{PhoneNumberField}) VALUES ('{employeeId}','{phoneNumber}')", conn);
                return insertPhoneNumber.ExecuteNonQuery() > 0;
            }
            catch { return false; }
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
                        $"{IdCardField}='{user.IdCard}'," +
                        $"{SalaryField}='{user.Salary}' WHERE {EmployeeIDField} = '{user.EmployeeID}'";
                else
                    modifyUser.CommandText = $"UPDATE {UsersTableName} SET " +
                        $"{FirstNameField}='{Sanitizer.SanitizeInput(user.FirstName)}'," +
                        $"{LastNameField}='{Sanitizer.SanitizeInput(user.LastName)}'," +
                        $"{UsernameField}='{Sanitizer.SanitizeInput(user.Username)}'," +
                        $"{RoleIDField}='{user.RoleID}'," +
                        $"{IdCardField}='{user.IdCard}'," +
                        $"{PasswordField}='{Hashing.ComputeHash(user.Password)}'," +
                        $"{SalaryField}='{user.Salary}' WHERE {EmployeeIDField} = '{user.EmployeeID}'";
                try { if (!(modifyUser.ExecuteNonQuery() > 0)) return false; } catch { return false; }

                DeletePhoneNumbers(conn, user.EmployeeID);
                foreach(string number in user.PhoneNumbers)
                {
                    InsertPhoneNumber(conn, user.EmployeeID, number);
                }
                return true;
            }
        }

        /// <summary>
        /// Adds Medicine's Data 
        /// </summary>
        /// <param name="medicine"></param>
        /// <returns>True if medicine was inserted successfully</returns>
        internal Medicine AddMedicine(Medicine medicine)
        {
            using(SQLiteConnection conn = new SQLiteConnection(ConnName))
            {
                conn.Open();
                //Insert Medicine Data
                SQLiteCommand insertMedData = new SQLiteCommand($"INSERT INTO {MedicineTableName}({MedicineName}," +
                    $"{MedicineCategory},{MedicineManufacturingCompany},{MedicineStock},{MedicineMinStock},{MedicineDueDate}," +
                    $"{MedicineAcquisitionValue},{MedicineSellingPrice},{MedicineQuality},{MedicineType}) VALUES ('{medicine.MedName}'," +
                    $"'{medicine.MedCategory}','{medicine.MedManfactureComp}','{medicine.MedStockCount}','{medicine.MedMinStock}'," +
                    $"'{medicine.MedDueDate}','{medicine.MedAcquisitionValue}','{medicine.MedSellingValue}'," +
                    $"'{medicine.MedQuality}','{medicine.MedType}')",conn);
                try
                {
                    if (insertMedData.ExecuteNonQuery() < 0)
                        return null;
                }
                catch { throw new SellerFunctionality.SQLConstraintException("Υπάρχει ήδη φάρμακο με αυτό το όνομα"); }
                //Get the new MedID of the medicine
                insertMedData.CommandText = $"SELECT {MedicineID} FROM {MedicineTableName} WHERE" +
                    $" {MedicineName} = '{medicine.MedName}' AND {MedicineDueDate} = '{medicine.MedDueDate}'";
                using (var reader = insertMedData.ExecuteReader())
                {
                    int medid = 0;
                    while (reader.Read())
                    {
                        bool success = int.TryParse(reader[0].ToString(), out medid);
                        //Something went wrong? Who got have imagined! Good luck figuring it out!
                        if (!success) return null;
                    }
                    medicine.MedID = medid;
                }
            }
            return medicine;
        }
        
        /// <summary>
        /// Removes a specific medicine
        /// </summary>
        /// <param name="medId"></param>
        /// <returns>True if medicine was deleted successfully</returns>
        internal bool RemoveMedicine(int medID)
        {
            using (SQLiteConnection conn = new SQLiteConnection(ConnName))
            {
                conn.Open();
                SQLiteCommand deleteMedicine = new SQLiteCommand(conn)
                {
                    //Remove the medicine from Medicines table
                    CommandText = $"DELETE FROM {MedicineTableName} WHERE {MedicineID} = '{medID}'"
                };
                return deleteMedicine.ExecuteNonQuery() > 0;
            }
        }

        /// <summary>
        /// Update medicine's info
        /// </summary>
        /// <param name="medicine"></param>
        /// <returns>True if medicine's data was updated successfully</returns>
        internal bool UpdateMedicine(Medicine medicine)
        {
            using (SQLiteConnection conn = new SQLiteConnection(ConnName))
            {
                conn.Open();
                SQLiteCommand updateMedicine = new SQLiteCommand(conn)
                {
                    CommandText = $"UPDATE {MedicineTableName} SET " +
                    $"{MedicineName}='{medicine.MedName}', {MedicineCategory}='{medicine.MedCategory}'," +
                    $"{MedicineStock}='{medicine.MedStockCount}', {MedicineMinStock}='{medicine.MedMinStock}', " +
                    $"{MedicineAcquisitionValue}='{medicine.MedAcquisitionValue}'," +
                    $" {MedicineSellingPrice}='{medicine.MedSellingValue}', {MedicineDueDate}='{medicine.MedDueDate}' WHERE {MedicineID}='{medicine.MedID}'"
                };
                try
                {
                    return updateMedicine.ExecuteNonQuery() > 0;
                }
                catch
                {
                    throw new SellerFunctionality.SQLConstraintException("Υπάρχει ήδη φάρμακο με αυτό το όνομα");
                }
            }
        }

        /// <summary>
        /// Update medicine's stock
        /// </summary>
        /// <param name="medicine"></param>
        /// <returns>True if medicine's data was updated successfully</returns>
        internal bool UpdateMedicineStock(Medicine medicine)
        {
            using (SQLiteConnection conn = new SQLiteConnection(ConnName))
            {
                conn.Open();
                SQLiteCommand updateMedicine = new SQLiteCommand(conn)
                {
                    CommandText = $"UPDATE {MedicineTableName} SET " +
                    $"{MedicineStock}='{medicine.MedStockCount}'" +
                    $" WHERE {MedicineID}='{medicine.MedID}'"
                };
                try
                {
                    return updateMedicine.ExecuteNonQuery() > 0;
                }
                catch
                {
                    throw new SellerFunctionality.SQLConstraintException("Υπάρχει ήδη φάρμακο με αυτό το όνομα");
                }
            }
        }

        /// <summary>
        /// Display all Medicines
        /// </summary>
        /// <returns>All medicines and their associated data from the database</returns>
        internal List<Medicine> DisplayMedicines()
        {
            using (SQLiteConnection conn = new SQLiteConnection(ConnName))
            {
                conn.Open();

                SQLiteCommand command = new SQLiteCommand($"SELECT * FROM {MedicineTableName}", conn);
                using (var reader = command.ExecuteReader())
                {
                    List<Medicine> medicine = new List<Medicine>();
                    //Get the Medicines
                    while (reader.Read())
                    {

                        //add the medicine to the list
                        medicine.Add(new Medicine(

                                medID: int.Parse(reader[0].ToString()),
                                medName: reader[1].ToString(),
                                medCategory: reader[2].ToString(),
                                medManfactureComp: reader[3].ToString(),
                                medStockCount: int.Parse(reader[4].ToString()),
                                medMinStock: int.Parse(reader[5].ToString()),
                                medDueDate: reader[6].ToString(),
                                medAcquisitionValue: double.Parse(reader[7].ToString()),
                                medSellingValue: double.Parse(reader[8].ToString()),
                                medQuality: Char.Parse(reader[9].ToString()),
                                medType: Char.Parse(reader[10].ToString())
                            )) ;
                    }
                    return medicine;
                }
            }
        }

        /// <summary>
        /// Inserts a new pharmacist
        /// </summary>
        /// <param name="pharmacist"></param>
        /// <returns>The Inserted pharmacist with the assigned id</returns>
        internal Pharmacist InsertPharmacist(Pharmacist pharmacist)
        {
            using (SQLiteConnection conn = new SQLiteConnection(ConnName))
            {
                conn.Open();
                //Insert Pharmacist Data first
                SQLiteCommand insertPharmacistData = new SQLiteCommand($"INSERT INTO {PharmacistTableName}({PharmacistFirstName}, " +
                    $"{PharmacistLastName}, {PharmacistAFM}, {PharmacistPhone}, {PharmacistANumber}, {PharmacistAStreet}, " +
                    $"{PharmacistATown}, {PharmacistAPostalCode},{PharmacistSellerID}) VALUES (" +
                    $"'{Sanitizer.SanitizeInput(pharmacist.FirstName)}','{Sanitizer.SanitizeInput(pharmacist.LastName)}','{Sanitizer.SanitizeInput(pharmacist.AFM)}','{Sanitizer.SanitizeInput(pharmacist.Phone)}','{Sanitizer.SanitizeInput(pharmacist.PANumber)}" +
                    $"','{Sanitizer.SanitizeInput(pharmacist.PAStreet)}', '{Sanitizer.SanitizeInput(pharmacist.PATown)}' ,'{Sanitizer.SanitizeInput(pharmacist.PAPostalCode)}', '{pharmacist.PSellerID}')", conn);
                try { if (insertPharmacistData.ExecuteNonQuery() < 0) return null; } catch { throw new SellerFunctionality.SQLConstraintException("Υπάρχει ήδη φαρμακοποιός με αυτό το ΑΦΜ"); }
                //Get the new PharmacistId of the pharmacist
                insertPharmacistData.CommandText = $"SELECT * FROM {PharmacistTableName} WHERE {PharmacistAFM} = '{pharmacist.AFM}'";
                Pharmacist ph = null;
                using (var reader = insertPharmacistData.ExecuteReader())
                {
                    //Well done finding this easter egg!
                    while (reader.Read())
                    {
                        ph = new Pharmacist(
                            pharmacistID: int.Parse(reader[0].ToString()),
                            lastName: reader[1].ToString(),
                            firstName: reader[2].ToString(),
                            AFM: reader[3].ToString(),
                            phone: reader[4].ToString(),
                            pANumber: reader[5].ToString(),
                            pAStreet: reader[6].ToString(),
                            pATown: reader[7].ToString(),
                            pAPostalCode: reader[8].ToString(),
                            pSellerID: int.Parse(reader[9].ToString()));
                    }
                    //User was not added/found something went completely wrong

                    return ph;
                }
            }
        }

        /// <summary>
        /// Modify existing pharmacist
        /// </summary>
        /// <param name="pharmacist"></param>
        /// <returns>True if pharmacist's data was modified successfully</returns>
        internal bool ModifyPharmacist(Pharmacist pharmacist)
        {
            using (SQLiteConnection conn = new SQLiteConnection(ConnName))
            {
                try
                {
                    conn.Open();
                    SQLiteCommand modifyPharmacist = new SQLiteCommand(conn)
                    {
                        CommandText = $"UPDATE {PharmacistTableName} SET " +
                        $"{PharmacistFirstName}='{Sanitizer.SanitizeInput(pharmacist.FirstName)}'," +
                        $"{PharmacistLastName}='{Sanitizer.SanitizeInput(pharmacist.LastName)}'," +
                        $"{PharmacistAFM}='{pharmacist.AFM}'," +
                        $"{PharmacistPhone}='{pharmacist.Phone}'," +
                        $"{PharmacistANumber}='{pharmacist.PANumber}'," +
                        $"{PharmacistAStreet}='{Sanitizer.SanitizeInput(pharmacist.PAStreet)}'," +
                        $"{PharmacistATown}='{Sanitizer.SanitizeInput(pharmacist.PATown)}'," +
                        $"{PharmacistAPostalCode}='{pharmacist.PAPostalCode}'," +
                        $"{PharmacistSellerID}='{pharmacist.PSellerID}' WHERE {PharmacistID}='{pharmacist.PharmacistID}'"
                    };
                    return modifyPharmacist.ExecuteNonQuery() > 0;
                }
                catch
                {
                    throw new SellerFunctionality.SQLConstraintException("Υπάρχει ήδη ένας φαρμακοποιός με αυτό το ΑΦΜ");
                }
            }
        }

        /// <summary>
        /// Deletes all order lines
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="orderID"></param>
        /// <returns>True if order line was deleted successfully</returns>
        private bool DeleteOrderLine(SQLiteConnection conn, int orderID)
        {
            SQLiteCommand deleteOrderLine = new SQLiteCommand($"DELETE FROM {OrderLineTableName} WHERE {OrderIDField} = '{orderID}'", conn);
            return deleteOrderLine.ExecuteNonQuery() > 0;
        }

        /// <summary>
        /// Deletes or cancels an order
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="druggistID"></param>
        /// <param name="orderID"></param>
        /// <returns>True if order was deleted successfully</returns>
        
        internal bool DeleteOrder(Order order)
        {
            using (SQLiteConnection conn = new SQLiteConnection(ConnName))
            {
                conn.Open();
                foreach(var o in order.OrderList)
                {
                    o.Medicine.MedStockCount += o.ProductQuantity;
                    UpdateMedicineStock(o.Medicine);
                }
                DeleteOrderLine(conn, order.OrderID);
                SQLiteCommand deleteOrder = new SQLiteCommand($"DELETE FROM {OrderTableName} WHERE {PharmacistIDOrder} = '{order.Pharmacist.PharmacistID}'", conn);
                return deleteOrder.ExecuteNonQuery() > 0;
            }
        }

        /// <summary>
        /// Updates a Pharmacist to Inactive (Never truly deletes them)
        /// </summary>
        /// <param name="druggistID">The Drugist id to change</param>
        /// <returns>True if record was deleted successfully</returns>
        internal bool DeletePharmacist(int druggistIDr)
        {
            using (SQLiteConnection conn = new SQLiteConnection(ConnName))
            {
                conn.Open();
                //Finally remove the pharmacist from the Pharmacists table
                SQLiteCommand modifyPharmacist = new SQLiteCommand(conn)
                {
                    CommandText = $"UPDATE {PharmacistTableName} SET " +
                    $"{PharmacistANumber}=''," +
                    $"{PharmacistAStreet}=''," +
                    $"{PharmacistATown}=''," +
                    $"{PharmacistAPostalCode}=''" +
                    $" WHERE {PharmacistID}='{druggistIDr}'"
                };
                return modifyPharmacist.ExecuteNonQuery() > 0;
            }
        }

        /// <summary>
        /// Inserts a new line in an order
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="oID"></param>
        /// <param name="medicine"></param>
        /// <param name="quantity"></param>
        /// <returns>True if record was inserted successfully</returns>
        private bool InsertOrderLine(SQLiteConnection conn, OrderLine orderline)
        {
            try
            {
                SQLiteCommand insertOrderLine = new SQLiteCommand($"INSERT INTO {OrderLineTableName}({OrdIDField}," +
                    $"{MediID},{ProductQuantity},{TotalProductCost}) VALUES ('{orderline.OrdID}','{orderline.Medicine.MedID}'," +
                    $"'{orderline.ProductQuantity}','{orderline.ProductQuantity*orderline.Medicine.MedSellingValue}')", conn);
                return insertOrderLine.ExecuteNonQuery() > 0;
            }
            catch { return false; }
        }
        /// <summary>
        /// Insert order
        /// </summary>
        /// <param name="order"></param>
        /// <returns>True if order was inserted successfully</returns>
        internal bool InsertOrder(Order order)
        {
            using (SQLiteConnection conn = new SQLiteConnection(ConnName))
            {
                conn.Open();
                //Insert User Data first
                SQLiteCommand insertOrderData = new SQLiteCommand($"INSERT INTO {OrderTableName}({OrderIDField},{SellerIDOrderField}, " +
                    $"{PharmacistIDOrder}," +
                    $"{OrderDateField}, {TotalCostField}) VALUES (" +
                    $"'{order.OrderID}','{order.Seller.EmployeeID}','{order.Pharmacist.PharmacistID}','{order.OrderDate}','{order.TotalCost}')", conn);
                try 
                {
                    if (insertOrderData.ExecuteNonQuery() < 0) return false;
                } catch 
                { 
                    return false; 
                }
                //Get the new OrderId of the order
                insertOrderData.CommandText = $"SELECT {OrderIDField} FROM {OrderTableName} WHERE {SellerIDOrderField} = '{order.Seller.EmployeeID}' " +
                    $"AND {PharmacistIDOrder} ='{order.Pharmacist.PharmacistID}' AND {OrderDateField} ='{order.OrderDate}' AND {TotalCostField} = '{order.TotalCost}'";
                using (var reader = insertOrderData.ExecuteReader())
                {
                    int orid = -1;
                    while (reader.Read())
                    {
                        orid = int.Parse(reader[0].ToString());
                    }
                    //Order was not added/found something went completely wrong
                    if (orid == -1) return false;
                }
                //Insert OrderDetails
                foreach(var o in order.OrderList)
                {
                    InsertOrderLine(conn, o);
                }
                return true;
            }
        }

        internal List<Order> RetrieveOrders(int SellerId)
        {
            using(SQLiteConnection conn = new SQLiteConnection(ConnName))
            {
                conn.Open();
                SQLiteCommand get = new SQLiteCommand($"SELECT * FROM {OrderTableName} WHERE {SellerIDOrderField} = '{SellerId}'", conn);
                List<Order> orders = new List<Order>();
                using (var reader = get.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        orders.Add(new Order(int.Parse(reader[0].ToString()),
                                GetUserData(conn, int.Parse(reader[1].ToString())), RetrievePharmacist(conn, int.Parse(reader[2].ToString())),
                                double.Parse(reader[3].ToString()), reader[4].ToString(), RetrieveOrderLines(conn, int.Parse(reader[1].ToString()))
                            ));
                    }
                }
                return orders;
            }
        }

        private List<OrderLine> RetrieveOrderLines(SQLiteConnection conn, int orderID) {
            SQLiteCommand get = new SQLiteCommand($"SELECT * FROM {OrderLineTableName} WHERE {OrderIDField} = '{orderID}'", conn);
            using (var reader = get.ExecuteReader())
            {
                List<OrderLine> orderline = new List<OrderLine>();
                while (reader.Read())
                {
                    orderline.Add(new OrderLine(orderID, RetrieveMedicines(conn, int.Parse(reader[1].ToString())), int.Parse(reader[2].ToString()), double.Parse(reader[3].ToString())));
                }
                return orderline;
            }
        }

        /// <summary>
        /// Retrive pharmacists from Database
        /// </summary>
        /// <returns>All pharmacist for a particular seller and their associated data from the database</returns>
        internal List<Pharmacist> RetrievePharmacist(int SellerID)
        {
            using (SQLiteConnection conn = new SQLiteConnection(ConnName))
            {
                conn.Open();

                SQLiteCommand command = new SQLiteCommand($"SELECT * FROM {PharmacistTableName} WHERE {PharmacistSellerID} = '{SellerID}'", conn);
                using (var reader = command.ExecuteReader())
                {
                    List<Pharmacist> pharmacists = new List<Pharmacist>();
                    //Get the Pharmacists
                    while (reader.Read())
                    {
                        //add the pharmacist to the list
                        pharmacists.Add(new Pharmacist(
                            pharmacistID: int.Parse(reader[0].ToString()),
                            lastName: reader[1].ToString(),
                            firstName: reader[2].ToString(),
                            AFM: reader[3].ToString(),
                            phone: reader[4].ToString(),
                            pANumber: reader[5].ToString(),
                            pAStreet: reader[6].ToString(),
                            pATown: reader[7].ToString(),
                            pAPostalCode: reader[8].ToString(),
                            pSellerID: int.Parse(reader[9].ToString())
                            ));
                    }
                    return pharmacists;
                }
            }
        }

        private Pharmacist RetrievePharmacist(SQLiteConnection conn, int PharmID)
        {
            SQLiteCommand command = new SQLiteCommand($"SELECT * FROM {PharmacistTableName} WHERE {PharmacistID} = '{PharmID}'", conn);
            using (var reader = command.ExecuteReader())
            {
                //Get the Pharmacists
                while (reader.Read())
                {
                    //add the pharmacist to the list
                    return new Pharmacist(
                            pharmacistID: int.Parse(reader[0].ToString()),
                            lastName: reader[1].ToString(),
                            firstName: reader[2].ToString(),
                            AFM: reader[3].ToString(),
                            phone: reader[4].ToString(),
                            pANumber: reader[5].ToString(),
                            pAStreet: reader[6].ToString(),
                            pATown: reader[7].ToString(),
                            pAPostalCode: reader[8].ToString(),
                            pSellerID: int.Parse(reader[9].ToString())
                            );
                }
                return null;
            }

        }

        /// <summary>
        /// Grab specific med information
        /// </summary>
        /// <returns>The medicine information</returns>
        private Medicine RetrieveMedicines(SQLiteConnection conn, int medid)
        {
            SQLiteCommand command = new SQLiteCommand($"SELECT * FROM {MedicineTableName} WHERE {MedicineID}='{medid}'", conn);
            using (var reader = command.ExecuteReader())
            {
                //Get the Medicines
                while (reader.Read())
                {

                    //add the medicine to the list
                    return new Medicine(

                            medID: int.Parse(reader[0].ToString()),
                            medName: reader[1].ToString(),
                            medCategory: reader[2].ToString(),
                            medManfactureComp: reader[3].ToString(),
                            medStockCount: int.Parse(reader[4].ToString()),
                            medMinStock: int.Parse(reader[5].ToString()),
                            medDueDate: reader[6].ToString(),
                            medAcquisitionValue: double.Parse(reader[7].ToString()),
                            medSellingValue: double.Parse(reader[8].ToString()),
                            medQuality: Char.Parse(reader[9].ToString()),
                            medType: Char.Parse(reader[10].ToString())
                        );
                }
                return null;
            }

        }

        private Seller GetUserData(SQLiteConnection conn, int sellerid)
        {

            SQLiteCommand command = new SQLiteCommand($"SELECT * FROM {UsersTableName} WHERE {EmployeeIDField} = '{sellerid}'", conn);
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
                            PhoneNumbers: null,
                            Salary: double.Parse(reader[7].ToString())

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
                return new Seller(user);
            }
            
        }

        internal int GetNewOrderID()
        {
            using (SQLiteConnection conn = new SQLiteConnection(ConnName))
            {
                conn.Open();
                SQLiteCommand command = new SQLiteCommand($"SELECT MAX({OrderIDField}) FROM {OrderTableName}", conn);
                using(var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var i = reader[0].ToString();
                        if (i == "") return 1;
                        return int.Parse(i) + 1;
                    }
                    return -1;
                }
            }
        }

    }
}
