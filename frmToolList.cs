using SQLController;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolRentals {
    public partial class frmToolList : Form {
        #region Constructors

        /// <summary>
        /// Initialize the frame
        /// </summary>
        public frmToolList() {
            // Initialize the frame components
            InitializeComponent();
        }

        #endregion

        #region Button Events

        private void btnClose_Click(object sender, EventArgs e) {
            // Start a new thread frmMenu
            ThreadStart(new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProcMenu)));
        }
        private void inkAddTool_Click(object sender, EventArgs e) {
            // Initialize a new frmTool
            frmTool frm = new frmTool();
            // Show the new form
            // If the form returns the DialogResult OK
            // Populate the DataGridView
            if (frm.ShowDialog() == DialogResult.OK) {
                PopulateGrid();
            }
        }

        #endregion

        #region Form Events

        private void frmMovieList_Paint(object sender, PaintEventArgs e) {
            // Change the frame background colour to the ColorTheme in the project settings
            BackColor = Properties.Settings.Default.ColorTheme;
        }

        private void frmToolList_Load(object sender, EventArgs e) {
            // Populate the DataGridView
            PopulateGrid();
        }

        #endregion

        #region DataGridView Events

        private void dgvTools_DoubleClick(object sender, EventArgs e) {
            // Check if a cell has been selected in the DataGridView
            // If not stop the method
            if (dgvTools.CurrentCell == null) {
                return;
            }

            // Create and assign the primary key of the DataGridView
            long pkID = long.Parse(dgvTools[0, dgvTools.CurrentCell.RowIndex].Value.ToString());

            // Create a new instance of frmTool (with the Primary Key)
            frmTool frm = new frmTool(pkID);
            // Show the form
            // If the form returns DialogResult OK
            // Populate the DataGridView
            if (frm.ShowDialog() == DialogResult.OK) {
                PopulateGrid();
            }
        }

        private void DgvTools_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e) {
            // Delete the row
            Context.DeleteRecord("Tool", "ToolID", e.Row.Cells[0].Value.ToString());
        }

        #endregion

        #region Helper Method

        /// <summary>
        /// Create a new Form
        /// </summary>
        public static void ThreadProcMenu() {
            Application.Run(new frmMenu());
        }
        /// <summary>
        /// Starts the new thread
        /// </summary>
        /// <param name="thread">The new thread</param>
        public void ThreadStart(System.Threading.Thread thread) {
            // Start the thread
            // Close the current frame
            thread.Start();
            Close();
        }

        /// <summary>
        /// Populate the DataGridView
        /// </summary>
        private void PopulateGrid() {
            // Create and assign a new Tool DataTable
            // Assign the DataGridView with the new DataTable
            DataTable dtable = Context.GetDataTable("Tool");
            dgvTools.DataSource = dtable;
        }

        #endregion
    }
}
