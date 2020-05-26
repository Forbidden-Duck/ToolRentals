namespace ToolRentals {
    partial class frmRentalItem {
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
            this.btnSave = new System.Windows.Forms.Button();
            this.cboTools = new System.Windows.Forms.ComboBox();
            this.txtRentalD = new System.Windows.Forms.TextBox();
            this.lblTool = new System.Windows.Forms.Label();
            this.lblRentalID = new System.Windows.Forms.Label();
            this.lblRentalItem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(288, 120);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 28);
            this.btnClose.TabIndex = 30;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(202, 120);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 28);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // cboTools
            // 
            this.cboTools.FormattingEnabled = true;
            this.cboTools.Location = new System.Drawing.Point(110, 83);
            this.cboTools.Name = "cboTools";
            this.cboTools.Size = new System.Drawing.Size(253, 21);
            this.cboTools.TabIndex = 28;
            this.cboTools.SelectedIndexChanged += new System.EventHandler(this.CboMovies_SelectedIndexChanged);
            // 
            // txtRentalD
            // 
            this.txtRentalD.Enabled = false;
            this.txtRentalD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRentalD.Location = new System.Drawing.Point(110, 53);
            this.txtRentalD.Name = "txtRentalD";
            this.txtRentalD.Size = new System.Drawing.Size(100, 20);
            this.txtRentalD.TabIndex = 27;
            // 
            // lblTool
            // 
            this.lblTool.AutoSize = true;
            this.lblTool.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTool.Location = new System.Drawing.Point(13, 83);
            this.lblTool.Name = "lblTool";
            this.lblTool.Size = new System.Drawing.Size(57, 20);
            this.lblTool.TabIndex = 26;
            this.lblTool.Text = "Tools:";
            // 
            // lblRentalID
            // 
            this.lblRentalID.AutoSize = true;
            this.lblRentalID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentalID.Location = new System.Drawing.Point(13, 53);
            this.lblRentalID.Name = "lblRentalID";
            this.lblRentalID.Size = new System.Drawing.Size(91, 20);
            this.lblRentalID.TabIndex = 25;
            this.lblRentalID.Text = "Rental ID:";
            // 
            // lblRentalItem
            // 
            this.lblRentalItem.AutoSize = true;
            this.lblRentalItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentalItem.Location = new System.Drawing.Point(12, 11);
            this.lblRentalItem.Name = "lblRentalItem";
            this.lblRentalItem.Size = new System.Drawing.Size(131, 25);
            this.lblRentalItem.TabIndex = 24;
            this.lblRentalItem.Text = "Rental Item";
            // 
            // frmRentalItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 158);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cboTools);
            this.Controls.Add(this.txtRentalD);
            this.Controls.Add(this.lblTool);
            this.Controls.Add(this.lblRentalID);
            this.Controls.Add(this.lblRentalItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmRentalItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rental Item";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmRentalItem_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cboTools;
        private System.Windows.Forms.TextBox txtRentalD;
        private System.Windows.Forms.Label lblTool;
        private System.Windows.Forms.Label lblRentalID;
        private System.Windows.Forms.Label lblRentalItem;
    }
}