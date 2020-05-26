namespace ToolRentals {
    partial class frmToolList {
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
            this.dgvTools = new System.Windows.Forms.DataGridView();
            this.lblToolList = new System.Windows.Forms.Label();
            this.inkAddTool = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTools)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(493, 416);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 28);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvTools
            // 
            this.dgvTools.AllowUserToAddRows = false;
            this.dgvTools.AllowUserToResizeColumns = false;
            this.dgvTools.AllowUserToResizeRows = false;
            this.dgvTools.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTools.Location = new System.Drawing.Point(17, 84);
            this.dgvTools.Name = "dgvTools";
            this.dgvTools.ReadOnly = true;
            this.dgvTools.Size = new System.Drawing.Size(551, 322);
            this.dgvTools.TabIndex = 6;
            this.dgvTools.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.DgvTools_UserDeletingRow);
            this.dgvTools.DoubleClick += new System.EventHandler(this.dgvTools_DoubleClick);
            // 
            // lblToolList
            // 
            this.lblToolList.AutoSize = true;
            this.lblToolList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToolList.Location = new System.Drawing.Point(12, 11);
            this.lblToolList.Name = "lblToolList";
            this.lblToolList.Size = new System.Drawing.Size(103, 25);
            this.lblToolList.TabIndex = 5;
            this.lblToolList.Text = "Tool List";
            // 
            // inkAddTool
            // 
            this.inkAddTool.AutoSize = true;
            this.inkAddTool.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inkAddTool.Location = new System.Drawing.Point(13, 52);
            this.inkAddTool.Name = "inkAddTool";
            this.inkAddTool.Size = new System.Drawing.Size(144, 24);
            this.inkAddTool.TabIndex = 4;
            this.inkAddTool.TabStop = true;
            this.inkAddTool.Text = "Add New Tool";
            this.inkAddTool.Click += new System.EventHandler(this.inkAddTool_Click);
            // 
            // frmToolList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 456);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvTools);
            this.Controls.Add(this.lblToolList);
            this.Controls.Add(this.inkAddTool);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmToolList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tool List";
            this.Load += new System.EventHandler(this.frmToolList_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmMovieList_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTools)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvTools;
        private System.Windows.Forms.Label lblToolList;
        private System.Windows.Forms.LinkLabel inkAddTool;
    }
}