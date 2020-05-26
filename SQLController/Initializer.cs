using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLConnection;

/// <summary>
/// The SQL Controller
/// Connects to SQL Connection to
/// Create the Database, Tables and Seed some data
/// </summary>
namespace SQLController {
    public static class Initializer {
        #region Global Variables

        // Create a new instance of SQL
        static SQL _sql = new SQL();

        #endregion

        #region Initalize Database

        /// <summary>
        /// Initalize the Database
        /// </summary>
        public static void InitalizeDatabase() {
            // Create the Database
            _sql.CreateDatabase();
            // Create the Tables
            // Seed data into the tables
            CreateDatabaseTables();
            SeedDatabaseTables();
        }

        /// <summary>
        /// Creates the database tables
        /// </summary>
        private static void CreateDatabaseTables() {
            // Create the Movie Table
            // Create the Customer Table
            // Create the Rental Table
            // Create RentalItem Table
            CreateToolTable();
            CreateCustomerTable();
            CreateRentalTable();
            CreateRentalItemTable();
        }

        /// <summary>
        /// Creates Tool table
        /// </summary>
        private static void CreateToolTable() {
            // Create and assign the Schema
            string schema =
                "ToolID int IDENTITY(1,1) PRIMARY KEY, " +
                "Description VARCHAR(60), " +
                "Brand VARCHAR(60), " +
                "Status bit, " +
                "Comments VARCHAR(120)";
            // Create the Tool Table with the Schema
            _sql.CreateDatabaseTable("Tool", schema);
        }

        /// <summary>
        /// Creates customer table
        /// </summary>
        private static void CreateCustomerTable() {
            // Create and assign the Schema
            string schema =
                "CustomerID int IDENTITY(1,1) PRIMARY KEY, " +
                "CustomerName VARCHAR(120), " +
                "CustomerPhone VARCHAR(10)";
            // Create the Customer Table with the Schema
            _sql.CreateDatabaseTable("Customer", schema);
        }

        /// <summary>
        /// Creates rental table
        /// </summary>
        private static void CreateRentalTable() {
            // Create and assign the Schema
            string schema =
                "RentalID int IDENTITY(1,1) PRIMARY KEY, " +
                "CustomerID int NOT NULL, " +
                "Workshop VARCHAR(60) NOT NULL, " +
                "DateRented DATE NOT NULL, " +
                "DateReturned DATE NULL,";
            // Create the Rental Table with the Schema
            _sql.CreateDatabaseTable("Rental", schema);
        }

        /// <summary>
        /// Creates rental items table
        /// </summary>
        private static void CreateRentalItemTable() {
            // Create and assign the Schema
            string schema =
                "RentalItemID int IDENTITY(1,1) PRIMARY KEY, " +
                "RentalID int NOT NULL, " +
                "ToolID int NOT NULL";
            // Create the RentalItem Table with the Schema
            _sql.CreateDatabaseTable("RentalItem", schema);
        }

        #endregion

        #region Seed Database Tables

        /// <summary>
        /// Start the seeding process
        /// </summary>
        private static void SeedDatabaseTables() {
            // Seed the Movie Table
            // Seed the Customer Table
            // Seed the Rental Table
            // Seed the RentalItem Table
            SeedToolTable();
            SeedCustomerTable();
            SeedRentalTable();
            SeedRentalItemTable();
        }

        /// <summary>
        /// Seed the Tool Table
        /// </summary>
        private static void SeedToolTable() {
            // Create and assign a new String List
            // TOOLID, DESCRIPTION, BRAND, STATUS, COMMENTS
            List<string> columnValues = new List<string> {
                "1, 'Soldering Iron', 'Generic', 0, 'No Comment'",
                "2, 'Cordless Drill', 'Generic', 0, 'Batteries getting weak'",
                "3, 'Circular Saw', 'Generic', 1, 'Grip on handle cracking'"
            };
            // Create and assign column names
            string columnNames = "ToolID, Description, Brand, Status, Comments";

            // For each values in the list
            foreach (string value in columnValues) {
                // Insert a new record with the value
                _sql.InsertRecord("Tool", columnNames, value);
            }
        }

        /// <summary>
        /// Seed the Customer Table
        /// </summary>
        private static void SeedCustomerTable() {
            // Create and assign a new String List
            // CUSTOMERID, CUSTOMERNAME, CUSTOMERPHONE
            List<string> columnValues = new List<string> {
                "1, 'Andy Myers', '0417703977'",
                "2, 'Jack Liger', '0478367472'",
                "3, 'Lance Timothy', '0435454472'"
            };
            // Create and assign new column names
            string columnNames = "CustomerID, CustomerName, CustomerPhone";

            // For each value in the list
            foreach (string value in columnValues) {
                // Insert a new record with the list
                _sql.InsertRecord("Customer", columnNames, value);
            }
        }

        /// <summary>
        /// Seed the Rental Table
        /// </summary>
        private static void SeedRentalTable() {
            // Create and assign a new String List
            // RENTALID, CUSTOMERID, WORKSHOP, DATERENTED, DATERETURNED
            List<string> columnValues = new List<string> {
                $"1, 2, 'Workshop 4', '01-17-2017', null",
                $"2, 3, 'Workshop 4', '06-30-2017', null",
                $"3, 1, 'Studio 3', '06-06-2017', '06-07-2017'"
            };
            // Create and assign new column names
            string columnNames = "RentalID, CustomerID, Workshop, DateRented, DateReturned";

            // For each value in the list
            foreach (string value in columnValues) {
                // Insert a new record with the list
                _sql.InsertRecord("Rental", columnNames, value);
            }
        }

        /// <summary>
        /// Seed the RentalItem Table
        /// </summary>
        private static void SeedRentalItemTable() {
            // Create and assign a new String List
            // RENTALITEMID, RENTALID, TOOLID
            List<string> columnValues = new List<string> {
                "1, 1, 2",
                "2, 1, 1",
                "3, 3, 3"
            };
            // Create and assign new column names
            string columnNames = "RentalItemID, RentalID, ToolID";

            // For each value in the list
            foreach (string value in columnValues) {
                // Insert a new record with the value
                _sql.InsertRecord("RentalItem", columnNames, value);
            }
        }

        #endregion
    }
}
