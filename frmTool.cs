using SQLController;
using System;
using System.Data;
using System.Windows.Forms;

namespace ToolRentals {
    public partial class frmTool : Form {
        #region Global Variables

        // Create a variable for the Primary Key
        // Create a variable for the DataTable
        // Create a variable for a New DataTable
        long _pkID = 0;
        DataTable _dtable = null;
        bool _isNew = false;

        #endregion

        #region Constructors

        /// <summary>
        /// A new instance of frmTool
        /// If no Primary Key was provided
        /// </summary>
        public frmTool() {
            // Initialize the frame components
            // Assign true to _isNew
            // Initialize the form contents
            InitializeComponent();
            _isNew = true;
            InitializeForm();
        }
        /// <summary>
        /// Create a new instance of frmTool
        /// If the Primary Key was provided
        /// </summary>
        /// <param name="pkID">The provided Primary Key</param>
        public frmTool(long pkID) {
            // Initialize the frame components
            // Assign the Primary Key to the Global Variable
            // Initalize the Form
            InitializeComponent();
            _pkID = pkID;
            InitializeForm();
        }

        /// <summary>
        /// Initializes the Form
        /// </summary>
        private void InitializeForm() {
            // Initializes the DataTable
            // Binds the frame components with data
            InitializeDatatable();
            BindControls();
        }

        #endregion

        #region Button Events

        private void btnClose_Click(object sender, EventArgs e) {
            // Close the form
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e) {
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

        private void frmTool_Paint(object sender, PaintEventArgs e) {
            // Assign the form background colour with ColorTheme from the project settings
            BackColor = Properties.Settings.Default.ColorTheme;
        }

        #endregion

        #region Helper Methods

        /// <summary>
        /// Initalizes the Data Table
        /// </summary>
        private void InitializeDatatable() {
            // Create and assign a new SQL Query
            // Assign the DataTable with the Tool DataTable
            string sqlQuery = $"SELECT * FROM Tool WHERE ToolID = {_pkID}";
            _dtable = Context.GetDataTable(sqlQuery, "Tool");

            // Check if _isNew is true
            if (_isNew) {
                // Create and assign a new DataRow
                // Assign an empty row to the DataTable
                DataRow row = _dtable.NewRow();
                _dtable.Rows.Add(row);
            }
        }

        /// <summary>
        /// Binding textboxes with the Data Table
        /// </summary>
        private void BindControls() {
            // Bind txtToolID with the ToolID
            // Bind txtToolDescription with the Description
            // Bind txtToolBrand with the Brand
            // Bind txtToolComments with the Comments
            // Bind cbActive with the Status
            txtToolID.DataBindings.Add("Text", _dtable, "ToolID");
            txtToolDescription.DataBindings.Add("Text", _dtable, "Description");
            txtToolBrand.DataBindings.Add("Text", _dtable, "Brand");
            txtToolComments.DataBindings.Add("Text", _dtable, "Comments");
            cbActive.DataBindings.Add("Checked", _dtable, "Status");
        }

        #endregion
    }
}
