namespace ToolRentals {
    partial class frmRentalList {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvRentals = new System.Windows.Forms.DataGridView();
            this.lblRentalList = new System.Windows.Forms.Label();
            this.inkAddRental = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentals)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(490, 416);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 28);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvRentals
            // 
            this.dgvRentals.AllowUserToAddRows = false;
            this.dgvRentals.AllowUserToResizeColumns = false;
            this.dgvRentals.AllowUserToResizeRows = false;
            this.dgvRentals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRentals.Location = new System.Drawing.Point(17, 84);
            this.dgvRentals.Name = "dgvRentals";
            this.dgvRentals.ReadOnly = true;
            this.dgvRentals.Size = new System.Drawing.Size(548, 322);
            this.dgvRentals.TabIndex = 14;
            this.dgvRentals.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.DgvRentals_UserDeletingRow);
            this.dgvRentals.DoubleClick += new System.EventHandler(this.DgvRentals_DoubleClick);
            // 
            // lblRentalList
            // 
            this.lblRentalList.AutoSize = true;
            this.lblRentalList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentalList.Location = new System.Drawing.Point(12, 11);
            this.lblRentalList.Name = "lblRentalList";
            this.lblRentalList.Size = new System.Drawing.Size(125, 25);
            this.lblRentalList.TabIndex = 13;
            this.lblRentalList.Text = "Rental List";
            // 
            // inkAddRental
            // 
            this.inkAddRental.AutoSize = true;
            this.inkAddRental.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inkAddRental.Location = new System.Drawing.Point(13, 52);
            this.inkAddRental.Name = "inkAddRental";
            this.inkAddRental.Size = new System.Drawing.Size(161, 24);
            this.inkAddRental.TabIndex = 12;
            this.inkAddRental.TabStop = true;
            this.inkAddRental.Text = "Add New Rental";
            this.inkAddRental.Click += new System.EventHandler(this.inkAddRental_Click);
            // 
            // frmRentalList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 456);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvRentals);
            this.Controls.Add(this.lblRentalList);
            this.Controls.Add(this.inkAddRental);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmRentalList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rental List";
            this.Load += new System.EventHandler(this.frmRentalList_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmRentalList_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvRentals;
        private System.Windows.Forms.Label lblRentalList;
        private System.Windows.Forms.LinkLabel inkAddRental;
    }
}