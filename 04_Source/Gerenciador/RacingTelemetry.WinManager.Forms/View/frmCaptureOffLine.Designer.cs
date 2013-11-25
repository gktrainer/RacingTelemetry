namespace View {
	partial class frmCaptureOffLine {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCaptureOffLine));
			this.btnImportData = new System.Windows.Forms.Button();
			this.cboLocation = new System.Windows.Forms.ComboBox();
			this.lblLocation = new System.Windows.Forms.Label();
			this.ofdLogDataFile = new System.Windows.Forms.OpenFileDialog();
			this.lblLogDataFile = new System.Windows.Forms.Label();
			this.txtLogDataFile = new System.Windows.Forms.TextBox();
			this.btnLogDataFinder = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnImportData
			// 
			this.btnImportData.Location = new System.Drawing.Point(12, 119);
			this.btnImportData.Name = "btnImportData";
			this.btnImportData.Size = new System.Drawing.Size(75, 23);
			this.btnImportData.TabIndex = 0;
			this.btnImportData.Text = "Importar";
			this.btnImportData.UseVisualStyleBackColor = true;
			this.btnImportData.Click += new System.EventHandler(this.btnImportData_Click);
			// 
			// cboLocation
			// 
			this.cboLocation.FormattingEnabled = true;
			this.cboLocation.Location = new System.Drawing.Point(12, 29);
			this.cboLocation.Name = "cboLocation";
			this.cboLocation.Size = new System.Drawing.Size(260, 21);
			this.cboLocation.TabIndex = 1;
			// 
			// lblLocation
			// 
			this.lblLocation.AutoSize = true;
			this.lblLocation.Location = new System.Drawing.Point(12, 13);
			this.lblLocation.Name = "lblLocation";
			this.lblLocation.Size = new System.Drawing.Size(33, 13);
			this.lblLocation.TabIndex = 2;
			this.lblLocation.Text = "Local";
			// 
			// ofdLogDataFile
			// 
			this.ofdLogDataFile.Filter = "GPS data|*.gps";
			// 
			// lblLogDataFile
			// 
			this.lblLogDataFile.AutoSize = true;
			this.lblLogDataFile.Location = new System.Drawing.Point(15, 57);
			this.lblLogDataFile.Name = "lblLogDataFile";
			this.lblLogDataFile.Size = new System.Drawing.Size(43, 13);
			this.lblLogDataFile.TabIndex = 3;
			this.lblLogDataFile.Text = "Arquivo";
			// 
			// txtLogDataFile
			// 
			this.txtLogDataFile.Location = new System.Drawing.Point(12, 74);
			this.txtLogDataFile.Name = "txtLogDataFile";
			this.txtLogDataFile.ReadOnly = true;
			this.txtLogDataFile.Size = new System.Drawing.Size(501, 20);
			this.txtLogDataFile.TabIndex = 4;
			// 
			// btnLogDataFinder
			// 
			this.btnLogDataFinder.Image = ((System.Drawing.Image)(resources.GetObject("btnLogDataFinder.Image")));
			this.btnLogDataFinder.Location = new System.Drawing.Point(519, 72);
			this.btnLogDataFinder.Name = "btnLogDataFinder";
			this.btnLogDataFinder.Size = new System.Drawing.Size(29, 23);
			this.btnLogDataFinder.TabIndex = 5;
			this.btnLogDataFinder.UseVisualStyleBackColor = true;
			this.btnLogDataFinder.Click += new System.EventHandler(this.btnLogDataFinder_Click);
			// 
			// frmCaptureOffLine
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(560, 174);
			this.Controls.Add(this.btnLogDataFinder);
			this.Controls.Add(this.txtLogDataFile);
			this.Controls.Add(this.lblLogDataFile);
			this.Controls.Add(this.lblLocation);
			this.Controls.Add(this.cboLocation);
			this.Controls.Add(this.btnImportData);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "frmCaptureOffLine";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "..:: Captura Off Line ::..";
			this.Load += new System.EventHandler(this.frmCaptureOffLine_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnImportData;
		private System.Windows.Forms.ComboBox cboLocation;
		private System.Windows.Forms.Label lblLocation;
		private System.Windows.Forms.OpenFileDialog ofdLogDataFile;
		private System.Windows.Forms.Label lblLogDataFile;
		private System.Windows.Forms.TextBox txtLogDataFile;
		private System.Windows.Forms.Button btnLogDataFinder;
	}
}