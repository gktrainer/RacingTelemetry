namespace View {
	partial class frmDataLog {
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
			this.lblCOMPorts = new System.Windows.Forms.Label();
			this.cboCOMPorts = new System.Windows.Forms.ComboBox();
			this.btnInitLog = new System.Windows.Forms.Button();
			this.btnStopLog = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblCOMPorts
			// 
			this.lblCOMPorts.AutoSize = true;
			this.lblCOMPorts.Location = new System.Drawing.Point(13, 13);
			this.lblCOMPorts.Name = "lblCOMPorts";
			this.lblCOMPorts.Size = new System.Drawing.Size(64, 13);
			this.lblCOMPorts.TabIndex = 0;
			this.lblCOMPorts.Text = "Portas COM";
			// 
			// cboCOMPorts
			// 
			this.cboCOMPorts.FormattingEnabled = true;
			this.cboCOMPorts.Location = new System.Drawing.Point(83, 10);
			this.cboCOMPorts.Name = "cboCOMPorts";
			this.cboCOMPorts.Size = new System.Drawing.Size(121, 21);
			this.cboCOMPorts.TabIndex = 1;
			// 
			// btnInitLog
			// 
			this.btnInitLog.Location = new System.Drawing.Point(12, 37);
			this.btnInitLog.Name = "btnInitLog";
			this.btnInitLog.Size = new System.Drawing.Size(75, 23);
			this.btnInitLog.TabIndex = 2;
			this.btnInitLog.Text = "Iniciar";
			this.btnInitLog.UseVisualStyleBackColor = true;
			// 
			// btnStopLog
			// 
			this.btnStopLog.Location = new System.Drawing.Point(93, 37);
			this.btnStopLog.Name = "btnStopLog";
			this.btnStopLog.Size = new System.Drawing.Size(75, 23);
			this.btnStopLog.TabIndex = 3;
			this.btnStopLog.Text = "Parar";
			this.btnStopLog.UseVisualStyleBackColor = true;
			// 
			// frmDataLog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(566, 325);
			this.Controls.Add(this.btnStopLog);
			this.Controls.Add(this.btnInitLog);
			this.Controls.Add(this.cboCOMPorts);
			this.Controls.Add(this.lblCOMPorts);
			this.Name = "frmDataLog";
			this.Text = "..:: Coleta de dados ::..";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblCOMPorts;
		private System.Windows.Forms.ComboBox cboCOMPorts;
		private System.Windows.Forms.Button btnInitLog;
		private System.Windows.Forms.Button btnStopLog;
	}
}