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
        private const string OrderTableName = "Order";
        private const string OrderIDField = "OrderID";
        private const string SellerIDOrderField = "SellerID";
        private const string SellerFirstName = "SFirstName";
        private const string SellerLaststName = "SLastName";
        private const string PharmacistIDOrder = "PharmacistID";
        private const string PharmaFirstName = "PFirstName";
        private const string PharmaLastName = "PLastName";
        private const string PharmaAddressNumber = "PAddressNumber";
        private const string PharmaAddressStreet = "PAddressStreet";
        private const string PharmaAddressTown = "PAddressTown";
        private const string PharmaAddressPostalCode = "PAddressPostalCode";
        private const string PharmaPhoneNumber = "PPhoneNumber";
        private const string TotalCostField = "TotalCost";
        private const string OrderDateField = "OrderDate";
        private const string OrderLineField = "OrderLine";
        #endregion

        #region OrderLine Table
        private const string OrderLineTableName = "OrderLine";
        private const string OrdIDField = "OrderID";
        private const string MediID = "MedicineID";
        private const string MediName = "MedicineName";
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

            new SQLiteCommand($"CREATE TABLE IF NOT EXIST {PharmacistTableName}({PharmacistID} INTEGER PRIMARY KEY AUTOINCREMENT," +
                $"{PharmacistFirstName} STRING NOT NULL,{PharmacistLastName} STRING NOT NULL,{PharmacistAFM} CHAR(9) NOT NULL UNIQUE" +
                $",{PharmacistPhone} CHAR(10) NOT NULL UNIQUE," +
                $"{PharmacistANumber} STRING NOT NULL,{PharmacistAStreet} STRING NOT NULL,{PharmacistATown} STRING NOT NULL," +
                $"{PharmacistAPostalCode} CHAR(5) NOT NULL,{PharmacistSellerID} INTEGER NOT NULL, " +
                $"FOREIGN KEY({PharmacistSellerID}) REFERENCES {UsersTableName}({EmployeeIDField}))", conn).ExecuteNonQuery();

            new SQLiteCommand($"CREATE TABLE IF NOT EXISTS {OrderTableName}({OrderIDField} INTEGER PRIMARY KEY AUTOINCREMENT,"+
                $"{SellerIDOrderField} INTEGER NOT NULL REFERENCES {UsersTableName}({EmployeeIDField})," +
                $"{SellerFirstName} STRING NOT NULL REFERENCES {UsersTableName}({FirstNameField})," +
                $"{SellerLaststName} STRING NOT NULL REFERENCES {UsersTableName}({LastNameField})," +
                $"{PharmacistIDOrder} INTEGER NOT NULL REFERENCES {PharmacistTableName}({PharmacistID})," +
                $"{PharmaFirstName} STRING NOT NULL REFERENCES {PharmacistTableName}({PharmacistFirstName})," +
                $"{PharmaLastName} STRING NOT NULL REFERENCES {PharmacistTableName}({PharmacistLastName})," +
                $"{PharmaAddressNumber} STRING NOT NULL REFERENCES {PharmacistTableName}({PharmacistANumber})," +
                $"{PharmaAddressStreet} STRING NOT NULL REFERENCES {PharmacistTableName}({PharmacistAStreet})," +
                $"{PharmaAddressTown} STRING NOT NULL REFERENCES {PharmacistTableName}({PharmacistATown})," +
                $"{PharmaAddressPostalCode} CHAR(5) NOT NULL REFERENCES {PharmacistTableName}({PharmacistAPostalCode})," +
                $"{PharmaPhoneNumber} CHAR(10) NOT NULL UNIQUE REFERENCES {PharmacistTableName}({PharmacistPhone})," +
                $"{TotalCostField} DOUBLE NOT NULL,{OrderDateField} STRING NOT NULL," +
                $"{OrderLineField} STRING NOT NULL)", conn).ExecuteNonQuery();

            new SQLiteCommand($"CREATE IF NOT EXIST {OrderLineTableName}(" +
                $"{OrdIDField} INTEGER NOT NULL REFERENCES {OrderTableName}({OrderIDField}) ," +
                $"{MediID} INTEGER NOT NULL REFERENCES {MedicineTableName}({MedicineID})," +
                $"{MediName} STRING NOT NULL REFERENCES {MedicineTableName}({MedicineName})," +
                $"{ProductQuantity} INTEGER NOT NULL,{TotalProductCost} INTEGER NOT NULL, " +
                $"PRIMARY KEY({OrdIDField},{MediID})",conn).ExecuteNonQuery();

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
                        $"{PasswordField}='{Hashing.ComputeHash(user.Password)}'" +
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
        /// <returns></returns>
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

                if (insertMedData.ExecuteNonQuery() < 0)
                    return null;
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
        /// <returns></returns>
        internal bool RemoveMedicine(int medID)
        {
            using (SQLiteConnection conn = new SQLiteConnection(ConnName))
            {
                conn.Open();
                SQLiteCommand deleteMedicine = new SQLiteCommand(conn);
                //Remove the medicine from Medicines table
                deleteMedicine.CommandText = $"DELETE FROM {MedicineTableName} WHERE {MedicineID} = '{medID}'";
                return deleteMedicine.ExecuteNonQuery() > 0;
            }
        }

        /// <summary>
        /// Update medicine's info
        /// </summary>
        /// <param name="medicine"></param>
        /// <returns></returns>
        internal bool UpdateMedicine(Medicine medicine)
        {
            using (SQLiteConnection conn = new SQLiteConnection(ConnName))
            {
                conn.Open();
                SQLiteCommand updateMedicine = new SQLiteCommand(conn);
                updateMedicine.CommandText = $"UPDATE {MedicineTableName} SET " +
                    $"{MedicineName}='{medicine.MedName}', {MedicineCategory}='{medicine.MedCategory}'," +
                    $"{MedicineStock}='{medicine.MedStockCount}', {MedicineMinStock}='{medicine.MedMinStock}', " +
                    $"{MedicineAcquisitionValue}='{medicine.MedAcquisitionValue}'," +
                    $" {MedicineSellingPrice}='{medicine.MedSellingValue}', {MedicineDueDate}='{medicine.MedDueDate}' WHERE {MedicineID}='{medicine.MedID}'";
                return updateMedicine.ExecuteNonQuery() > 0;
            }
        }

        /// <summary>
        /// Display all Medicines
        /// </summary>
        /// <returns></returns>
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
        /// <returns></returns>
        internal bool InsertPharmacist(Pharmacist pharmacist)
        {
            using (SQLiteConnection conn = new SQLiteConnection(ConnName))
            {
                conn.Open();
                //Insert Pharmacist Data first
                SQLiteCommand insertPharmacistData = new SQLiteCommand($"INSERT INTO {PharmacistTableName}({PharmacistFirstName}, " +
                    $"{PharmacistLastName}, {PharmacistAFM}, {PharmacistPhone}, {PharmacistANumber}, {PharmacistAStreet}, " +
                    $"{PharmacistATown}, {PharmacistAPostalCode},{PharmacistSellerID}) VALUES (" +
                    $"'{pharmacist.FirstName}','{pharmacist.LastName}','{pharmacist.AFM}','{pharmacist.Phone}','{pharmacist.PANumber}" +
                    $"','{pharmacist.PAStreet}','{pharmacist.PAPostalCode}', '{pharmacist.PSellerID}')", conn);
                try { if (insertPharmacistData.ExecuteNonQuery() < 0) return false; } catch { return false; }
                //Get the new PharmacistId of the pharmacist
                insertPharmacistData.CommandText = $"SELECT {PharmacistID} FROM {PharmacistTableName} WHERE {PharmacistAFM} = '{pharmacist.AFM}'";
                using (var reader = insertPharmacistData.ExecuteReader())
                {
                    //Well done finding this easter egg!
                    int druggistID = 0;
                    while (reader.Read())
                    {
                        druggistID = int.Parse(reader[0].ToString());
                    }
                    //User was not added/found something went completely wrong
                    if (druggistID == 0) return false;

                    return true;
                }
            }
        }

        /// <summary>
        /// Modify existing pharmacist
        /// </summary>
        /// <param name="pharmacist"></param>
        /// <returns></returns>
        internal bool ModifyPharmacist(Pharmacist pharmacist)
        {
            using (SQLiteConnection conn = new SQLiteConnection(ConnName))
            {
                conn.Open();
                SQLiteCommand modifyPharmacist = new SQLiteCommand(conn);
                modifyPharmacist.CommandText = $"UPDATE {PharmacistTableName} SET " +
                    $"{PharmacistFirstName}='{Sanitizer.SanitizeInput(pharmacist.FirstName)}'," +
                    $"{PharmacistLastName}='{Sanitizer.SanitizeInput(pharmacist.LastName)}'," +
                    $"{PharmacistPhone}='{pharmacist.Phone}'," +
                    $"{PharmacistANumber}='{pharmacist.PANumber}'," +
                    $"{PharmacistAStreet}='{pharmacist.PAStreet}'," +
                    $"{PharmacistATown}='{pharmacist.PATown}'," +
                    $"{PharmacistAPostalCode}='{pharmacist.PAPostalCode}'," +
                    $"{PharmacistSellerID}='{pharmacist.PSellerID}' WHERE {PharmacistAFM}='{pharmacist.AFM}'";
                return true;
            }
        }

        /// <summary>
        /// Deletes all order lines
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="orderID"></param>
        /// <returns></returns>
        private bool DeleteOrderLine(SQLiteConnection conn, int orderID)
        {
            SQLiteCommand deleteOrderLine = new SQLiteCommand($"DELETE FROM {OrderLineTableName} WHERE {PharmacistIDOrder} = '{orderID}'", conn);
            return deleteOrderLine.ExecuteNonQuery() > 0;
        }

        /// <summary>
        /// Deletes or cancels an order
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="druggistID"></param>
        /// <param name="orderID"></param>
        /// <returns></returns>
        
        private bool DeleteOrder(SQLiteConnection conn, int druggistID, Order order)
        {
            DeleteOrderLine(conn, order.OrderID);
            SQLiteCommand deleteOrder = new SQLiteCommand($"DELETE FROM {OrderTableName} WHERE {PharmacistIDOrder} = '{druggistID}'", conn);
            return deleteOrder.ExecuteNonQuery() > 0;
        }

        /// <summary>
        /// Deletes a pharmacist
        /// </summary>
        /// <param name="druggistID"></param>
        /// <param name="order"></param>
        /// <returns></returns>
        internal bool DeletePharmacist(int druggistID, Order order)
        {
            using (SQLiteConnection conn = new SQLiteConnection(ConnName))
            {
                conn.Open();
                //First remove all the information of that pharmacist from the other tables.
                SQLiteCommand deletePharmacist = new SQLiteCommand(conn);
                DeleteOrder(conn, druggistID, order);
                //Finally remove the pharmacist from the Pharmacists table
                deletePharmacist.CommandText = $"DELETE FROM {PharmacistTableName} WHERE {PharmacistID} = '{druggistID}'";
                return deletePharmacist.ExecuteNonQuery() > 0;
            }
        }





    }
}
