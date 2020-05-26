namespace ToolRentals {
    partial class frmRental {
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
            this.gbRentalItems = new System.Windows.Forms.GroupBox();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.dgvRentalItems = new System.Windows.Forms.DataGridView();
            this.btnInsertItem = new System.Windows.Forms.Button();
            this.dtpDateReturned = new System.Windows.Forms.DateTimePicker();
            this.lblDateReturned = new System.Windows.Forms.Label();
            this.dtpDateRented = new System.Windows.Forms.DateTimePicker();
            this.lblDateRented = new System.Windows.Forms.Label();
            this.cboCustomer = new System.Windows.Forms.ComboBox();
            this.txtRentalD = new System.Windows.Forms.TextBox();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblRentalID = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblRental = new System.Windows.Forms.Label();
            this.btnCreateRental = new System.Windows.Forms.Button();
            this.txtWorkshop = new System.Windows.Forms.TextBox();
            this.lblWorkshop = new System.Windows.Forms.Label();
            this.gbRentalItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentalItems)).BeginInit();
            this.SuspendLayout();
            // 
            // gbRentalItems
            // 
            this.gbRentalItems.Controls.Add(this.btnDeleteItem);
            this.gbRentalItems.Controls.Add(this.dgvRentalItems);
            this.gbRentalItems.Controls.Add(this.btnInsertItem);
            this.gbRentalItems.Enabled = false;
            this.gbRentalItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRentalItems.Location = new System.Drawing.Point(12, 202);
            this.gbRentalItems.Name = "gbRentalItems";
            this.gbRentalItems.Size = new System.Drawing.Size(358, 192);
            this.gbRentalItems.TabIndex = 36;
            this.gbRentalItems.TabStop = false;
            this.gbRentalItems.Text = "Rental Items";
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteItem.Location = new System.Drawing.Point(259, 158);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(93, 28);
            this.btnDeleteItem.TabIndex = 23;
            this.btnDeleteItem.Text = "Delete Item";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.BtnDeleteItem_Click);
            // 
            // dgvRentalItems
            // 
            this.dgvRentalItems.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dgvRentalItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRentalItems.Location = new System.Drawing.Point(3, 18);
            this.dgvRentalItems.Name = "dgvRentalItems";
            this.dgvRentalItems.Size = new System.Drawing.Size(349, 134);
            this.dgvRentalItems.TabIndex = 22;
            this.dgvRentalItems.DoubleClick += new System.EventHandler(this.DgvRentalItems_DoubleClick);
            // 
            // btnInsertItem
            // 
            this.btnInsertItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertItem.Location = new System.Drawing.Point(160, 158);
            this.btnInsertItem.Name = "btnInsertItem";
            this.btnInsertItem.Size = new System.Drawing.Size(93, 28);
            this.btnInsertItem.TabIndex = 22;
            this.btnInsertItem.Text = "Insert Item";
            this.btnInsertItem.UseVisualStyleBackColor = true;
            this.btnInsertItem.Click += new System.EventHandler(this.BtnInsertItem_Click);
            // 
            // dtpDateReturned
            // 
            this.dtpDateReturned.CustomFormat = "dd-MMM-yyyy";
            this.dtpDateReturned.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateReturned.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateReturned.Location = new System.Drawing.Point(151, 171);
            this.dtpDateReturned.Name = "dtpDateReturned";
            this.dtpDateReturned.Size = new System.Drawing.Size(114, 22);
            this.dtpDateReturned.TabIndex = 35;
            this.dtpDateReturned.ValueChanged += new System.EventHandler(this.DtpDateReturned_ValueChanged);
            // 
            // lblDateReturned
            // 
            this.lblDateReturned.AutoSize = true;
            this.lblDateReturned.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateReturned.Location = new System.Drawing.Point(12, 169);
            this.lblDateReturned.Name = "lblDateReturned";
            this.lblDateReturned.Size = new System.Drawing.Size(133, 20);
            this.lblDateReturned.TabIndex = 34;
            this.lblDateReturned.Text = "Date Returned:";
            // 
            // dtpDateRented
            // 
            this.dtpDateRented.CustomFormat = "dd-MMM-yyyy";
            this.dtpDateRented.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateRented.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateRented.Location = new System.Drawing.Point(151, 139);
            this.dtpDateRented.Name = "dtpDateRented";
            this.dtpDateRented.Size = new System.Drawing.Size(114, 22);
            this.dtpDateRented.TabIndex = 33;
            // 
            // lblDateRented
            // 
            this.lblDateRented.AutoSize = true;
            this.lblDateRented.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateRented.Location = new System.Drawing.Point(12, 139);
            this.lblDateRented.Name = "lblDateRented";
            this.lblDateRented.Size = new System.Drawing.Size(117, 20);
            this.lblDateRented.TabIndex = 32;
            this.lblDateRented.Text = "Date Rented:";
            // 
            // cboCustomer
            // 
            this.cboCustomer.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboCustomer.FormattingEnabled = true;
            this.cboCustomer.Location = new System.Drawing.Point(151, 82);
            this.cboCustomer.Name = "cboCustomer";
            this.cboCustomer.Size = new System.Drawing.Size(219, 21);
            this.cboCustomer.TabIndex = 31;
            // 
            // txtRentalD
            // 
            this.txtRentalD.Enabled = false;
            this.txtRentalD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRentalD.Location = new System.Drawing.Point(151, 53);
            this.txtRentalD.MaxLength = 8;
            this.txtRentalD.Name = "txtRentalD";
            this.txtRentalD.Size = new System.Drawing.Size(100, 20);
            this.txtRentalD.TabIndex = 30;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(12, 83);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(91, 20);
            this.lblCustomer.TabIndex = 29;
            this.lblCustomer.Text = "Customer:";
            // 
            // lblRentalID
            // 
            this.lblRentalID.AutoSize = true;
            this.lblRentalID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentalID.Location = new System.Drawing.Point(12, 53);
            this.lblRentalID.Name = "lblRentalID";
            this.lblRentalID.Size = new System.Drawing.Size(91, 20);
            this.lblRentalID.TabIndex = 28;
            this.lblRentalID.Text = "Rental ID:";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(295, 404);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 28);
            this.btnClose.TabIndex = 27;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(209, 404);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 28);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // lblRental
            // 
            this.lblRental.AutoSize = true;
            this.lblRental.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRental.Location = new System.Drawing.Point(12, 11);
            this.lblRental.Name = "lblRental";
            this.lblRental.Size = new System.Drawing.Size(80, 25);
            this.lblRental.TabIndex = 25;
            this.lblRental.Text = "Rental";
            // 
            // btnCreateRental
            // 
            this.btnCreateRental.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateRental.Location = new System.Drawing.Point(12, 404);
            this.btnCreateRental.Name = "btnCreateRental";
            this.btnCreateRental.Size = new System.Drawing.Size(111, 28);
            this.btnCreateRental.TabIndex = 37;
            this.btnCreateRental.Text = "Create Rental";
            this.btnCreateRental.UseVisualStyleBackColor = true;
            this.btnCreateRental.Click += new System.EventHandler(this.BtnCreateRental_Click);
            // 
            // txtWorkshop
            // 
            this.txtWorkshop.Location = new System.Drawing.Point(151, 112);
            this.txtWorkshop.MaxLength = 8;
            this.txtWorkshop.Name = "txtWorkshop";
            this.txtWorkshop.Size = new System.Drawing.Size(219, 20);
            this.txtWorkshop.TabIndex = 39;
            // 
            // lblWorkshop
            // 
            this.lblWorkshop.AutoSize = true;
            this.lblWorkshop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkshop.Location = new System.Drawing.Point(12, 112);
            this.lblWorkshop.Name = "lblWorkshop";
            this.lblWorkshop.Size = new System.Drawing.Size(94, 20);
            this.lblWorkshop.TabIndex = 38;
            this.lblWorkshop.Text = "Workshop:";
            // 
            // frmRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 441);
            this.Controls.Add(this.txtWorkshop);
            this.Controls.Add(this.lblWorkshop);
            this.Controls.Add(this.gbRentalItems);
            this.Controls.Add(this.dtpDateReturned);
            this.Controls.Add(this.lblDateReturned);
            this.Controls.Add(this.dtpDateRented);
            this.Controls.Add(this.lblDateRented);
            this.Controls.Add(this.cboCustomer);
            this.Controls.Add(this.txtRentalD);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.lblRentalID);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblRental);
            this.Controls.Add(this.btnCreateRental);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmRental";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rental";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmRental_Paint);
            this.gbRentalItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentalItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRentalItems;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.DataGridView dgvRentalItems;
        private System.Windows.Forms.Button btnInsertItem;
        private System.Windows.Forms.DateTimePicker dtpDateReturned;
        private System.Windows.Forms.Label lblDateReturned;
        private System.Windows.Forms.DateTimePicker dtpDateRented;
        private System.Windows.Forms.Label lblDateRented;
        private System.Windows.Forms.ComboBox cboCustomer;
        private System.Windows.Forms.TextBox txtRentalD;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblRentalID;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblRental;
        private System.Windows.Forms.Button btnCreateRental;
        private System.Windows.Forms.TextBox txtWorkshop;
        private System.Windows.Forms.Label lblWorkshop;
    }
}