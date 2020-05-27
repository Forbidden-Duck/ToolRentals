using SQLController;
using System;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ToolRentals {
    public partial class frmReport : Form {
        #region Global Variables

        // Create a variable for the DataView
        DataView _dvHistory = null;

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new instance of frmReport
        /// </summary>
        public frmReport() {
            InitializeComponent();
        }

        #endregion

        #region Button Events

        private void btnClose_Click(object sender, EventArgs e) {
            // Create a new thread for frmMenu
            ThreadStart(new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProcMenu)));
        }

        private void BtnExport_Click(object sender, EventArgs e) {
            // Create and assign a new StringBuilder
            StringBuilder csv = new StringBuilder();
            // Set the query
            string sqlQuery;
            // Set the datatable
            DataTable tempTable;

            switch (cboExport.SelectedIndex) {
                case -1:
                    // Check if nothing is selected
                    MessageBox.Show("No export option chosen",
                        Properties.Settings.Default.ProjectName,
                        MessageBoxButtons.OK);
                    return;
                case 0:
                    // Check if checked out tools
                    // Set the query
                    sqlQuery =
                        "SELECT Tool.ToolID, Tool.Description, Tool.Brand, Rental.DateRented FROM Tool " +
                        "LEFT JOIN RentalItem ON Tool.ToolID = RentalItem.ToolID " +
                        "LEFT JOIN Rental ON RentalItem.RentalID = Rental.RentalID";
                    tempTable = Context.GetDataTable(sqlQuery, "Tool");
                    foreach (DataRow row in tempTable.Rows) {
                        // Append a line with Description, Brand, DateRented
                        csv.AppendLine(
                            $"{row["Description"].ToString()}," +
                            $"{row["Brand"].ToString()}," +
                            $"{DateTime.Parse(row["DateRented"].ToString()).ToString("dd/MM/yyyy")}");
                    }
                    break;
                case 1:
                    // Check if tool is active
                    // Set the query
                    sqlQuery =
                        "SELECT ToolID, Description, Brand, Status FROM Tool " +
                        "WHERE Status = 1";
                    tempTable = Context.GetDataTable(sqlQuery, "Tool");
                    foreach (DataRow row in tempTable.Rows) {
                        // Append a line with Description, Brand, DateRented
                        csv.AppendLine(
                            $"{row["Description"].ToString()}," +
                            $"{row["Brand"].ToString()}," +
                            $"{row["Status"].ToString()}");
                    }
                    break;
                case 2:
                    // Check if tool is active by brand
                    // Set the query
                    sqlQuery =
                        "SELECT ToolID, Description, Brand, Status FROM Tool " +
                        "WHERE Status = 1" +
                        "ORDER BY Brand";
                    tempTable = Context.GetDataTable(sqlQuery, "Tool");
                    foreach (DataRow row in tempTable.Rows) {
                        // Append a line with Description, Brand, DateRented
                        csv.AppendLine(
                            $"{row["Description"].ToString()}," +
                            $"{row["Brand"].ToString()}," +
                            $"{row["Status"].ToString()}");
                    }
                    break;
                case 3:
                    // Check if tool is retired
                    // Set the query
                    sqlQuery =
                        "SELECT ToolID, Description, Brand, Status FROM Tool " +
                        "WHERE Status = 0";
                    tempTable = Context.GetDataTable(sqlQuery, "Tool");
                    foreach (DataRow row in tempTable.Rows) {
                        // Append a line with Description, Brand, DateRented
                        csv.AppendLine(
                            $"{row["Description"].ToString()}," +
                            $"{row["Brand"].ToString()}," +
                            $"{row["Status"].ToString()}");
                    }
                    break;
                case 4:
                    // Check if tool is retired by brand
                    // Set the query
                    sqlQuery =
                        "SELECT ToolID, Description, Brand, Status FROM Tool " +
                        "WHERE Status = 0" +
                        "ORDER BY Brand";
                    tempTable = Context.GetDataTable(sqlQuery, "Tool");
                    foreach (DataRow row in tempTable.Rows) {
                        // Append a line with Description, Brand, DateRented
                        csv.AppendLine(
                            $"{row["Description"].ToString()}," +
                            $"{row["Brand"].ToString()}," +
                            $"{row["Status"].ToString()}");
                    }
                    break;
            }

            // Write the StringBuilder to the ToolRental CSV
            // Show a MessageBox
            File.WriteAllText(Application.StartupPath + $@"\ToolRentalsHistory{cboExport.SelectedIndex}.csv", csv.ToString());
            MessageBox.Show($"{cboExport.SelectedItem.ToString()} exported to CSV as \"ToolRentalsHistory{cboExport.SelectedIndex}.csv\"",
                Properties.Settings.Default.ProjectName);
        }

        #endregion

        #region Form Events

        private void frmReport_Paint(object sender, PaintEventArgs e) {
            // Assign the form background colour to the ColorTheme from the project settings
            BackColor = Properties.Settings.Default.ColorTheme;
        }

        private void FrmReport_Load(object sender, EventArgs e) {
            // Populate the DataGridView
            PopulateGrid();
        }

        #endregion

        #region TextBox Events

        private void TxtSearch_TextChanged(object sender, EventArgs e) {
            // Assign the DataView RowFilter
            _dvHistory.RowFilter =
                $"CustomerName LIKE '%{txtSearch.Text}%'" +
                $"OR Description LIKE '%{txtSearch.Text}%'";
        }

        #endregion

        #region Helper Methods

        /// <summary>
        /// Run the form
        /// </summary>
        public static void ThreadProcMenu() {
            Application.Run(new frmMenu());
        }

        /// <summary>
        /// Start the new thread
        /// </summary>
        /// <param name="thread">The new thread</param>
        public void ThreadStart(System.Threading.Thread thread) {
            // Start the thread
            // Close the current form
            thread.Start();
            Close();
        }

        /// <summary>
        /// Populate the DataGridView
        /// </summary>
        private void PopulateGrid() {
            // Create and assign a new SQL Query
            string sqlQuery =
                "SELECT Rental.DateRented, Customer.CustomerName, Tool.Description, Rental.Workshop, Rental.DateReturned " +
                "FROM Customer INNER JOIN " +
                "Rental ON Customer.CustomerID = Rental.CustomerID INNER JOIN " +
                "RentalItem ON Rental.RentalID = RentalItem.RentalID CROSS JOIN Tool " +
                "ORDER BY Rental.DateRented DESC";

            // Create and assign the DataTable with the ToolHistory DataTable
            // Assign the DataTable to the DataView
            // Assign the DataGridView with the DataView
            DataTable dtable = Context.GetDataTable(sqlQuery, "ToolHistory", true);
            _dvHistory = new DataView(dtable);
            dgvReport.DataSource = _dvHistory;
        }

        #endregion
    }
}
