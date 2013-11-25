namespace View {
	partial class frmSplitMakers {
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
			this.lblLocationName = new System.Windows.Forms.Label();
			this.pnlSplitMarkersEditor = new System.Windows.Forms.Panel();
			this.lblSplitMarkerType = new System.Windows.Forms.Label();
			this.wcMaps = new Awesomium.Windows.Forms.WebControl(this.components);
			this.cboSplitMarkerType = new System.Windows.Forms.ComboBox();
			this.pnlSplitMarkersViewer = new System.Windows.Forms.Panel();
			this.btnEditMarker = new System.Windows.Forms.Button();
			this.btnAddSplitMarker = new System.Windows.Forms.Button();
			this.dgvSplitMarkers = new System.Windows.Forms.DataGridView();
			this.btnClearMarkers = new System.Windows.Forms.Button();
			this.btnApplyMarker = new System.Windows.Forms.Button();
			this.btnSaveMarker = new System.Windows.Forms.Button();
			this.btnCancelOperation = new System.Windows.Forms.Button();
			this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LatPointA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LatPointB = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LongPointB = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LongPointA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pnlSplitMarkersEditor.SuspendLayout();
			this.pnlSplitMarkersViewer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvSplitMarkers)).BeginInit();
			this.SuspendLayout();
			// 
			// lblLocationName
			// 
			this.lblLocationName.AutoSize = true;
			this.lblLocationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLocationName.Location = new System.Drawing.Point(13, 13);
			this.lblLocationName.Name = "lblLocationName";
			this.lblLocationName.Size = new System.Drawing.Size(0, 20);
			this.lblLocationName.TabIndex = 0;
			// 
			// pnlSplitMarkersEditor
			// 
			this.pnlSplitMarkersEditor.Controls.Add(this.btnCancelOperation);
			this.pnlSplitMarkersEditor.Controls.Add(this.btnSaveMarker);
			this.pnlSplitMarkersEditor.Controls.Add(this.btnApplyMarker);
			this.pnlSplitMarkersEditor.Controls.Add(this.btnClearMarkers);
			this.pnlSplitMarkersEditor.Controls.Add(this.lblSplitMarkerType);
			this.pnlSplitMarkersEditor.Controls.Add(this.wcMaps);
			this.pnlSplitMarkersEditor.Controls.Add(this.cboSplitMarkerType);
			this.pnlSplitMarkersEditor.Location = new System.Drawing.Point(12, 36);
			this.pnlSplitMarkersEditor.Name = "pnlSplitMarkersEditor";
			this.pnlSplitMarkersEditor.Size = new System.Drawing.Size(1227, 562);
			this.pnlSplitMarkersEditor.TabIndex = 1;
			// 
			// lblSplitMarkerType
			// 
			this.lblSplitMarkerType.AutoSize = true;
			this.lblSplitMarkerType.Location = new System.Drawing.Point(3, 16);
			this.lblSplitMarkerType.Name = "lblSplitMarkerType";
			this.lblSplitMarkerType.Size = new System.Drawing.Size(79, 13);
			this.lblSplitMarkerType.TabIndex = 5;
			this.lblSplitMarkerType.Text = "Tipo Marcação";
			// 
			// wcMaps
			// 
			this.wcMaps.Location = new System.Drawing.Point(0, 59);
			this.wcMaps.Size = new System.Drawing.Size(1227, 503);
			this.wcMaps.TabIndex = 3;
			// 
			// cboSplitMarkerType
			// 
			this.cboSplitMarkerType.FormattingEnabled = true;
			this.cboSplitMarkerType.Location = new System.Drawing.Point(5, 32);
			this.cboSplitMarkerType.Name = "cboSplitMarkerType";
			this.cboSplitMarkerType.Size = new System.Drawing.Size(156, 21);
			this.cboSplitMarkerType.TabIndex = 2;
			// 
			// pnlSplitMarkersViewer
			// 
			this.pnlSplitMarkersViewer.Controls.Add(this.btnEditMarker);
			this.pnlSplitMarkersViewer.Controls.Add(this.btnAddSplitMarker);
			this.pnlSplitMarkersViewer.Controls.Add(this.dgvSplitMarkers);
			this.pnlSplitMarkersViewer.Location = new System.Drawing.Point(12, 45);
			this.pnlSplitMarkersViewer.Name = "pnlSplitMarkersViewer";
			this.pnlSplitMarkersViewer.Size = new System.Drawing.Size(815, 312);
			this.pnlSplitMarkersViewer.TabIndex = 3;
			// 
			// btnEditMarker
			// 
			this.btnEditMarker.Location = new System.Drawing.Point(86, 286);
			this.btnEditMarker.Name = "btnEditMarker";
			this.btnEditMarker.Size = new System.Drawing.Size(75, 23);
			this.btnEditMarker.TabIndex = 5;
			this.btnEditMarker.Text = "Editar";
			this.btnEditMarker.UseVisualStyleBackColor = true;
			this.btnEditMarker.Click += new System.EventHandler(this.btnEditMarker_Click);
			// 
			// btnAddSplitMarker
			// 
			this.btnAddSplitMarker.Location = new System.Drawing.Point(5, 286);
			this.btnAddSplitMarker.Name = "btnAddSplitMarker";
			this.btnAddSplitMarker.Size = new System.Drawing.Size(75, 23);
			this.btnAddSplitMarker.TabIndex = 3;
			this.btnAddSplitMarker.Text = "Inserir";
			this.btnAddSplitMarker.UseVisualStyleBackColor = true;
			this.btnAddSplitMarker.Click += new System.EventHandler(this.btnAddSplitMarker_Click);
			// 
			// dgvSplitMarkers
			// 
			this.dgvSplitMarkers.AllowUserToAddRows = false;
			this.dgvSplitMarkers.AllowUserToDeleteRows = false;
			this.dgvSplitMarkers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvSplitMarkers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSplitMarkers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Type,
            this.LatPointA,
            this.LatPointB,
            this.LongPointB,
            this.LongPointA});
			this.dgvSplitMarkers.Location = new System.Drawing.Point(3, 3);
			this.dgvSplitMarkers.Name = "dgvSplitMarkers";
			this.dgvSplitMarkers.ReadOnly = true;
			this.dgvSplitMarkers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvSplitMarkers.Size = new System.Drawing.Size(809, 277);
			this.dgvSplitMarkers.TabIndex = 1;
			// 
			// btnClearMarkers
			// 
			this.btnClearMarkers.Location = new System.Drawing.Point(248, 32);
			this.btnClearMarkers.Name = "btnClearMarkers";
			this.btnClearMarkers.Size = new System.Drawing.Size(110, 23);
			this.btnClearMarkers.TabIndex = 7;
			this.btnClearMarkers.Text = "Limpar Marcações";
			this.btnClearMarkers.UseVisualStyleBackColor = true;
			this.btnClearMarkers.Click += new System.EventHandler(this.btnClearMarkers_Click);
			// 
			// btnApplyMarker
			// 
			this.btnApplyMarker.Location = new System.Drawing.Point(167, 32);
			this.btnApplyMarker.Name = "btnApplyMarker";
			this.btnApplyMarker.Size = new System.Drawing.Size(75, 23);
			this.btnApplyMarker.TabIndex = 9;
			this.btnApplyMarker.Text = "Marcar";
			this.btnApplyMarker.UseVisualStyleBackColor = true;
			this.btnApplyMarker.Click += new System.EventHandler(this.btnApplyMarker_Click);
			// 
			// btnSaveMarker
			// 
			this.btnSaveMarker.Location = new System.Drawing.Point(1068, 30);
			this.btnSaveMarker.Name = "btnSaveMarker";
			this.btnSaveMarker.Size = new System.Drawing.Size(75, 23);
			this.btnSaveMarker.TabIndex = 11;
			this.btnSaveMarker.Text = "Salvar";
			this.btnSaveMarker.UseVisualStyleBackColor = true;
			this.btnSaveMarker.Click += new System.EventHandler(this.btnSaveMarker_Click);
			// 
			// btnCancelOperation
			// 
			this.btnCancelOperation.Location = new System.Drawing.Point(1149, 30);
			this.btnCancelOperation.Name = "btnCancelOperation";
			this.btnCancelOperation.Size = new System.Drawing.Size(75, 23);
			this.btnCancelOperation.TabIndex = 12;
			this.btnCancelOperation.Text = "Cancelar";
			this.btnCancelOperation.UseVisualStyleBackColor = true;
			this.btnCancelOperation.Click += new System.EventHandler(this.btnCancelOperation_Click);
			// 
			// Type
			// 
			this.Type.DataPropertyName = "Type";
			this.Type.HeaderText = "Tipo";
			this.Type.Name = "Type";
			this.Type.ReadOnly = true;
			this.Type.Width = 53;
			// 
			// LatPointA
			// 
			this.LatPointA.HeaderText = "LatPointA";
			this.LatPointA.Name = "LatPointA";
			this.LatPointA.ReadOnly = true;
			this.LatPointA.Visible = false;
			this.LatPointA.Width = 78;
			// 
			// LatPointB
			// 
			this.LatPointB.HeaderText = "LatPointB";
			this.LatPointB.Name = "LatPointB";
			this.LatPointB.ReadOnly = true;
			this.LatPointB.Visible = false;
			this.LatPointB.Width = 78;
			// 
			// LongPointB
			// 
			this.LongPointB.HeaderText = "LongPointB";
			this.LongPointB.Name = "LongPointB";
			this.LongPointB.ReadOnly = true;
			this.LongPointB.Visible = false;
			this.LongPointB.Width = 87;
			// 
			// LongPointA
			// 
			this.LongPointA.HeaderText = "LongPointA";
			this.LongPointA.Name = "LongPointA";
			this.LongPointA.ReadOnly = true;
			this.LongPointA.Visible = false;
			this.LongPointA.Width = 87;
			// 
			// frmSplitMakers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1251, 610);
			this.Controls.Add(this.lblLocationName);
			this.Controls.Add(this.pnlSplitMarkersViewer);
			this.Controls.Add(this.pnlSplitMarkersEditor);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "frmSplitMakers";
			this.Text = "..:: Marcações ::..";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSplitMakers_FormClosing);
			this.Load += new System.EventHandler(this.frmSplitMakers_Load);
			this.pnlSplitMarkersEditor.ResumeLayout(false);
			this.pnlSplitMarkersEditor.PerformLayout();
			this.pnlSplitMarkersViewer.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvSplitMarkers)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblLocationName;
		private System.Windows.Forms.Panel pnlSplitMarkersEditor;
		private System.Windows.Forms.Panel pnlSplitMarkersViewer;
		private System.Windows.Forms.Button btnAddSplitMarker;
		private System.Windows.Forms.DataGridView dgvSplitMarkers;
		private System.Windows.Forms.Button btnEditMarker;
		private System.Windows.Forms.ComboBox cboSplitMarkerType;
		private Awesomium.Windows.Forms.WebControl wcMaps;
		private System.Windows.Forms.Label lblSplitMarkerType;
		private System.Windows.Forms.Button btnApplyMarker;
		private System.Windows.Forms.Button btnClearMarkers;
		private System.Windows.Forms.Button btnCancelOperation;
		private System.Windows.Forms.Button btnSaveMarker;
		private System.Windows.Forms.DataGridViewTextBoxColumn Type;
		private System.Windows.Forms.DataGridViewTextBoxColumn LatPointA;
		private System.Windows.Forms.DataGridViewTextBoxColumn LatPointB;
		private System.Windows.Forms.DataGridViewTextBoxColumn LongPointB;
		private System.Windows.Forms.DataGridViewTextBoxColumn LongPointA;
	}
}