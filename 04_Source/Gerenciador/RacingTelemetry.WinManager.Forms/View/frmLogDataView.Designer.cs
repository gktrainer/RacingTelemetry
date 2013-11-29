namespace View {
	partial class frmLogDataView {
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
			this.components = new System.ComponentModel.Container();
			this.pnlLogDataViewer = new System.Windows.Forms.Panel();
			this.btnDeleteLogData = new System.Windows.Forms.Button();
			this.btnAnalysis = new System.Windows.Forms.Button();
			this.dgvLogData = new System.Windows.Forms.DataGridView();
			this.pnlLogDataAnalysis = new System.Windows.Forms.Panel();
			this.wcMaps = new Awesomium.Windows.Forms.WebControl(this.components);
			this.pnlLogDataViewer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvLogData)).BeginInit();
			this.pnlLogDataAnalysis.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlLogDataViewer
			// 
			this.pnlLogDataViewer.Controls.Add(this.btnDeleteLogData);
			this.pnlLogDataViewer.Controls.Add(this.btnAnalysis);
			this.pnlLogDataViewer.Controls.Add(this.dgvLogData);
			this.pnlLogDataViewer.Location = new System.Drawing.Point(12, 12);
			this.pnlLogDataViewer.Name = "pnlLogDataViewer";
			this.pnlLogDataViewer.Size = new System.Drawing.Size(950, 375);
			this.pnlLogDataViewer.TabIndex = 0;
			// 
			// btnDeleteLogData
			// 
			this.btnDeleteLogData.Location = new System.Drawing.Point(84, 337);
			this.btnDeleteLogData.Name = "btnDeleteLogData";
			this.btnDeleteLogData.Size = new System.Drawing.Size(75, 23);
			this.btnDeleteLogData.TabIndex = 5;
			this.btnDeleteLogData.Text = "Apagar";
			this.btnDeleteLogData.UseVisualStyleBackColor = true;
			this.btnDeleteLogData.Click += new System.EventHandler(this.btnDeleteLogData_Click);
			// 
			// btnAnalysis
			// 
			this.btnAnalysis.Location = new System.Drawing.Point(3, 337);
			this.btnAnalysis.Name = "btnAnalysis";
			this.btnAnalysis.Size = new System.Drawing.Size(75, 23);
			this.btnAnalysis.TabIndex = 3;
			this.btnAnalysis.Text = "Analisar";
			this.btnAnalysis.UseVisualStyleBackColor = true;
			this.btnAnalysis.Click += new System.EventHandler(this.btnAnalysis_Click);
			// 
			// dgvLogData
			// 
			this.dgvLogData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvLogData.Location = new System.Drawing.Point(3, 3);
			this.dgvLogData.Name = "dgvLogData";
			this.dgvLogData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvLogData.Size = new System.Drawing.Size(944, 328);
			this.dgvLogData.TabIndex = 1;
			// 
			// pnlLogDataAnalysis
			// 
			this.pnlLogDataAnalysis.Controls.Add(this.wcMaps);
			this.pnlLogDataAnalysis.Location = new System.Drawing.Point(12, 12);
			this.pnlLogDataAnalysis.Name = "pnlLogDataAnalysis";
			this.pnlLogDataAnalysis.Size = new System.Drawing.Size(1319, 610);
			this.pnlLogDataAnalysis.TabIndex = 3;
			// 
			// wcMaps
			// 
			this.wcMaps.Location = new System.Drawing.Point(200, 3);
			this.wcMaps.Size = new System.Drawing.Size(1116, 604);
			this.wcMaps.TabIndex = 1;
			// 
			// frmLogDataView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1343, 634);
			this.Controls.Add(this.pnlLogDataAnalysis);
			this.Controls.Add(this.pnlLogDataViewer);
			this.Name = "frmLogDataView";
			this.Text = "..:: Capturas ::..";
			this.Load += new System.EventHandler(this.frmLogDataView_Load);
			this.pnlLogDataViewer.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvLogData)).EndInit();
			this.pnlLogDataAnalysis.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlLogDataViewer;
		private System.Windows.Forms.Panel pnlLogDataAnalysis;
		private System.Windows.Forms.DataGridView dgvLogData;
		private System.Windows.Forms.Button btnAnalysis;
		private System.Windows.Forms.Button btnDeleteLogData;
		private Awesomium.Windows.Forms.WebControl wcMaps;
	}
}