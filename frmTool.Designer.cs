namespace ToolRentals {
    partial class frmTool {
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
            this.txtToolDescription = new System.Windows.Forms.TextBox();
            this.txtToolID = new System.Windows.Forms.TextBox();
            this.lblToolDescription = new System.Windows.Forms.Label();
            this.lblToolID = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblTool = new System.Windows.Forms.Label();
            this.txtToolBrand = new System.Windows.Forms.TextBox();
            this.lblToolBrand = new System.Windows.Forms.Label();
            this.txtToolComments = new System.Windows.Forms.TextBox();
            this.lblToolComments = new System.Windows.Forms.Label();
            this.lblToolStatus = new System.Windows.Forms.Label();
            this.cbActive = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtToolDescription
            // 
            this.txtToolDescription.Location = new System.Drawing.Point(129, 92);
            this.txtToolDescription.MaxLength = 30;
            this.txtToolDescription.Name = "txtToolDescription";
            this.txtToolDescription.Size = new System.Drawing.Size(284, 20);
            this.txtToolDescription.TabIndex = 16;
            // 
            // txtToolID
            // 
            this.txtToolID.Enabled = false;
            this.txtToolID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToolID.Location = new System.Drawing.Point(129, 53);
            this.txtToolID.MaxLength = 8;
            this.txtToolID.Name = "txtToolID";
            this.txtToolID.Size = new System.Drawing.Size(100, 20);
            this.txtToolID.TabIndex = 15;
            // 
            // lblToolDescription
            // 
            this.lblToolDescription.AutoSize = true;
            this.lblToolDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToolDescription.Location = new System.Drawing.Point(12, 92);
            this.lblToolDescription.Name = "lblToolDescription";
            this.lblToolDescription.Size = new System.Drawing.Size(105, 20);
            this.lblToolDescription.TabIndex = 14;
            this.lblToolDescription.Text = "Description:";
            // 
            // lblToolID
            // 
            this.lblToolID.AutoSize = true;
            this.lblToolID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToolID.Location = new System.Drawing.Point(12, 53);
            this.lblToolID.Name = "lblToolID";
            this.lblToolID.Size = new System.Drawing.Size(72, 20);
            this.lblToolID.TabIndex = 13;
            this.lblToolID.Text = "Tool ID:";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(337, 223);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 28);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(251, 223);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 28);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblTool
            // 
            this.lblTool.AutoSize = true;
            this.lblTool.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTool.Location = new System.Drawing.Point(12, 11);
            this.lblTool.Name = "lblTool";
            this.lblTool.Size = new System.Drawing.Size(58, 25);
            this.lblTool.TabIndex = 10;
            this.lblTool.Text = "Tool";
            // 
            // txtToolBrand
            // 
            this.txtToolBrand.Location = new System.Drawing.Point(129, 123);
            this.txtToolBrand.MaxLength = 30;
            this.txtToolBrand.Name = "txtToolBrand";
            this.txtToolBrand.Size = new System.Drawing.Size(284, 20);
            this.txtToolBrand.TabIndex = 18;
            // 
            // lblToolBrand
            // 
            this.lblToolBrand.AutoSize = true;
            this.lblToolBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToolBrand.Location = new System.Drawing.Point(13, 123);
            this.lblToolBrand.Name = "lblToolBrand";
            this.lblToolBrand.Size = new System.Drawing.Size(62, 20);
            this.lblToolBrand.TabIndex = 17;
            this.lblToolBrand.Text = "Brand:";
            // 
            // txtToolComments
            // 
            this.txtToolComments.Location = new System.Drawing.Point(128, 161);
            this.txtToolComments.MaxLength = 30;
            this.txtToolComments.Name = "txtToolComments";
            this.txtToolComments.Size = new System.Drawing.Size(284, 20);
            this.txtToolComments.TabIndex = 20;
            // 
            // lblToolComments
            // 
            this.lblToolComments.AutoSize = true;
            this.lblToolComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToolComments.Location = new System.Drawing.Point(12, 161);
            this.lblToolComments.Name = "lblToolComments";
            this.lblToolComments.Size = new System.Drawing.Size(99, 20);
            this.lblToolComments.TabIndex = 19;
            this.lblToolComments.Text = "Comments:";
            // 
            // lblToolStatus
            // 
            this.lblToolStatus.AutoSize = true;
            this.lblToolStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToolStatus.Location = new System.Drawing.Point(12, 190);
            this.lblToolStatus.Name = "lblToolStatus";
            this.lblToolStatus.Size = new System.Drawing.Size(67, 20);
            this.lblToolStatus.TabIndex = 21;
            this.lblToolStatus.Text = "Status:";
            // 
            // cbActive
            // 
            this.cbActive.AutoSize = true;
            this.cbActive.Location = new System.Drawing.Point(129, 194);
            this.cbActive.Name = "cbActive";
            this.cbActive.Size = new System.Drawing.Size(86, 17);
            this.cbActive.TabIndex = 22;
            this.cbActive.Text = "Tool Active?";
            this.cbActive.UseVisualStyleBackColor = true;
            // 
            // frmTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 264);
            this.Controls.Add(this.cbActive);
            this.Controls.Add(this.lblToolStatus);
            this.Controls.Add(this.txtToolComments);
            this.Controls.Add(this.lblToolComments);
            this.Controls.Add(this.txtToolBrand);
            this.Controls.Add(this.lblToolBrand);
            this.Controls.Add(this.txtToolDescription);
            this.Controls.Add(this.txtToolID);
            this.Controls.Add(this.lblToolDescription);
            this.Controls.Add(this.lblToolID);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblTool);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmTool";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tool";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmTool_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtToolDescription;
        private System.Windows.Forms.TextBox txtToolID;
        private System.Windows.Forms.Label lblToolDescription;
        private System.Windows.Forms.Label lblToolID;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblTool;
        private System.Windows.Forms.TextBox txtToolBrand;
        private System.Windows.Forms.Label lblToolBrand;
        private System.Windows.Forms.TextBox txtToolComments;
        private System.Windows.Forms.Label lblToolComments;
        private System.Windows.Forms.Label lblToolStatus;
        private System.Windows.Forms.CheckBox cbActive;
    }
}