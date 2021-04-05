using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

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

        public DatabaseHandler()
        {
            using (SQLiteConnection conn = new SQLiteConnection(ConnName))
            {
                conn.Open();
                CreateTables(conn);
            }
        }

        private void CreateTables(SQLiteConnection conn)
        {
            new SQLiteCommand($"CREATE TABLE IF NOT EXISTS {RolesTableName}({RoleIDField} INT," +
                $" {DescriptionField} STRING NOT NULL, PRIMARY KEY({RoleIDField}))", conn).ExecuteNonQuery();

            new SQLiteCommand($"CREATE TABLE IF NOT EXISTS {UsersTableName}({EmployeeIDField} INTEGER PRIMARY KEY AUTOINCREMENT," +
                $" {FirstNameField} STRING NOT NULL, {LastNameField} STRING NOT NULL, {IdCardField} CHAR(8) UNIQUE NOT NULL, " +
                $"{UsernameField} CHAR(6) NOT NULL, {PasswordField} CHAR(256) NOT NULL, {RoleIDField} INT NOT NULL," +
                $", FOREIGN KEY({RoleIDField}) REFERENCES {RolesTableName}({RoleIDField}))", conn).ExecuteNonQuery();

            new SQLiteCommand($"CREATE TABLE IF NOT EXISTS {PhoneNumberTableName}({EmployeeIDField} INTEGER," +
                $" {PhoneNumberField} CHAR(10) NOT NULL, PRIMARY KEY({EmployeeIDField}, {PhoneNumberField}), FOREIGN KEY({EmployeeIDField}) REFERENCES {UsersTableName}({EmployeeIDField}))", conn).ExecuteNonQuery();

        }

        internal bool DoesUsernameExists(string username)
        {
            SQLiteCommand command = new SQLiteCommand($"SELECT * FROM USER WHERE {UsernameField} = {username}");
            var reader = command.ExecuteReader();
            return reader.Read();
        }
        
    }
}
