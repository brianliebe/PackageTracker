namespace PackageTracker
{
    partial class Tracker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddTrackingNumber = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            this.colTrackingNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textTrackingNumber = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddTrackingNumber
            // 
            this.btnAddTrackingNumber.Location = new System.Drawing.Point(713, 413);
            this.btnAddTrackingNumber.Name = "btnAddTrackingNumber";
            this.btnAddTrackingNumber.Size = new System.Drawing.Size(75, 23);
            this.btnAddTrackingNumber.TabIndex = 0;
            this.btnAddTrackingNumber.Text = "Add";
            this.btnAddTrackingNumber.UseVisualStyleBackColor = true;
            this.btnAddTrackingNumber.Click += new System.EventHandler(this.BtnAddTrackingNumber_Click);
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AllowUserToResizeColumns = false;
            this.grid.AllowUserToResizeRows = false;
            this.grid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTrackingNum,
            this.colService,
            this.colLastLocation,
            this.colStatus});
            this.grid.EnableHeadersVisualStyles = false;
            this.grid.Location = new System.Drawing.Point(12, 12);
            this.grid.Name = "grid";
            this.grid.RowHeadersVisible = false;
            this.grid.Size = new System.Drawing.Size(776, 397);
            this.grid.TabIndex = 1;
            this.grid.SelectionChanged += new System.EventHandler(this.Grid_SelectionChanged);
            // 
            // colTrackingNum
            // 
            this.colTrackingNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTrackingNum.HeaderText = "Tracking Number";
            this.colTrackingNum.Name = "colTrackingNum";
            // 
            // colService
            // 
            this.colService.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colService.FillWeight = 40F;
            this.colService.HeaderText = "Service";
            this.colService.Name = "colService";
            // 
            // colLastLocation
            // 
            this.colLastLocation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colLastLocation.HeaderText = "Last Location";
            this.colLastLocation.Name = "colLastLocation";
            // 
            // colStatus
            // 
            this.colStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colStatus.FillWeight = 150F;
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            // 
            // textTrackingNumber
            // 
            this.textTrackingNumber.Location = new System.Drawing.Point(12, 415);
            this.textTrackingNumber.Name = "textTrackingNumber";
            this.textTrackingNumber.Size = new System.Drawing.Size(695, 20);
            this.textTrackingNumber.TabIndex = 2;
            this.textTrackingNumber.Text = "1Z58W4F50378548199";
            // 
            // Tracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textTrackingNumber);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.btnAddTrackingNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Tracker";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Package Tracker";
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddTrackingNumber;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.TextBox textTrackingNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrackingNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colService;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
    }
}

