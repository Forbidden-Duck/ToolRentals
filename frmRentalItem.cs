using SQLController;
using System;
using System.Data;
using System.Windows.Forms;

namespace ToolRentals {
    public partial class frmRentalItem : Form {
        #region Global Variables

        // Create a variable for the Primary Key
        // Create a variable for the Rental Primary Key
        // Create a variable for the DataTable and Tool DataTable
        // Create a variable for the New DataTable
        long _pkID = 0;
        long _rentalID = 0;
        DataTable _dtable = null, _itemTable = null;
        bool _isNew = false;

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new instance of frmRentalItem
        /// If a primary key was provided
        /// </summary>
        /// <param name="pkID"></param>
        public frmRentalItem(long pkID) {
            // Initialize the form components
            // Assign the Primary Key to the Global Variable
            // Initialize the form
            InitializeComponent();
            _pkID = pkID;
            InitializeForm();
        }

        /// <summary>
        /// Create a new instance of frmRentalItem
        /// If a Rental Primary Key was provided
        /// </summary>
        /// <param name="rentalID"></param>
        public frmRentalItem(string rentalID) {
            // Initialize the form components
            // Assign true to _isNew
            // Assign the Rental Primary Key to the Global Variable
            // Initialize the form
            InitializeComponent();
            _isNew = true;
            _rentalID = long.Parse(rentalID);
            InitializeForm();
        }

        /// <summary>
        /// Initialize the form
        /// </summary>
        private void InitializeForm() {
            // Initialize the DataTable
            // Initialize the Movie DataTable
            // Bind data to the form components
            InitializeDatatable();
            InitializeToolTable();
            BindControls();
        }

        #endregion

        #region Button Events

        private void BtnClose_Click(object sender, EventArgs e) {
            // Close the form
            Close();
        }

        private void BtnSave_Click(object sender, EventArgs e) {
            // Check if a cell has been selected in the DataGridView
            // If not show a MessageBox and stop the method
            if (cboTools.SelectedIndex == -1) {
                MessageBox.Show("No tool has been selected!",
                    Properties.Settings.Default.ProjectName,
                    MessageBoxButtons.OK);

                return;
            }

            /*
             * NOTE:
             * Make sure to end with EndEdit
             * Before saving the DataTable
             */
            // Save the DataTable
            _dtable.Rows[0].EndEdit();

            // Save the table
            Context.SaveDataBaseTable(_dtable);
        }

        #endregion

        #region Form Events

        private void frmRentalItem_Paint(object sender, PaintEventArgs e) {
            // Assign the form background colour with the ColorTheme from the project settings
            BackColor = Properties.Settings.Default.ColorTheme;
        }

        #endregion

        #region ComboBox Events

        private void CboMovies_SelectedIndexChanged(object sender, EventArgs e) {
            // Check if the Tools SelectedIndex is greater than 0
            // Assign the Tools SelectedValue to the DataTable ToolID
            if (cboTools.SelectedIndex > 0) {
                _dtable.Rows[0]["ToolID"] = cboTools.SelectedValue;
            }
        }

        #endregion

        #region Helper Methods

        /// <summary>
        /// Initialize the DataTable
        /// </summary>
        private void InitializeDatatable() {
            // Create and assign the SQL Query
            string sqlQuery = $"SELECT * FROM RentalItem WHERE RentalItemID='{_pkID}'";

            // Assign the DataTable with the RentalItem DataTable
            _dtable = Context.GetDataTable(sqlQuery, "RentalItem");

            // Check if _isNew is true
            if (_isNew) {
                // Create and assign a new DataRow
                // Assign the empty row to the DataTable
                DataRow row = _dtable.NewRow();
                _dtable.Rows.Add(row);
            }
        }

        /// <summary>
        /// Initialize the Movie DataTable
        /// </summary>
        private void InitializeToolTable() {
            // Create and assign a new SQL Query
            string sqlQuery = $"SELECT ToolID, Description FROM Tool";

            // Assign the Tool DataTable with the Tool DataTable
            // Create a new column with the ToolID and ToolName
            _itemTable = Context.GetDataTable(sqlQuery, "Tool");
            _itemTable.Columns.Add("Display", typeof(string), "ToolID + ' - ' + Description");
        }

        /// <summary>
        /// Bind data to the form components
        /// </summary>
        private void BindControls() {
            // Check if the Rental Primary Key is equal to 0
            // Assign the DataTable RentalID to the Rental Primary Key
            // Else assign the Rental Primary Key to the DataTable RentalID
            if (_rentalID == 0) {
                _rentalID = long.Parse(_dtable.Rows[0]["RentalID"].ToString());
            } else {
                _dtable.Rows[0]["RentalID"] = _rentalID;
            }

            // Bind txtRentalID with RentalID
            txtRentalD.DataBindings.Add("Text", _dtable, "RentalID");

            // Bind the ValueMember with the ToolID
            // Bind the DisplayMember with the column Display
            // Bind cboTools with the Tool DataTable
            // Bind the BindContext with the BindingContext
            cboTools.ValueMember = "ToolID";
            cboTools.DisplayMember = "Display";
            cboTools.DataSource = _itemTable;
            cboTools.BindingContext = BindingContext;

            // Check if _isNew is true
            // Set the Tools SelectedIndex to -1
            // Else set the Movies SelectedIndex to the DataTable ToolID (Subtract 1)
            if (_isNew) {
                cboTools.SelectedIndex = -1;
            } else {
                cboTools.SelectedIndex = int.Parse(_dtable.Rows[0]["ToolID"].ToString()) - 1;
            }
        }

        #endregion
    }
}
