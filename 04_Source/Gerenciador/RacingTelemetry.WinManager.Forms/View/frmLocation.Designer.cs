namespace View {
	partial class frmLocation {
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
			this.pnlLocationViewer = new System.Windows.Forms.Panel();
			this.btnMarcacoes = new System.Windows.Forms.Button();
			this.dgvLocations = new System.Windows.Forms.DataGridView();
			this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.BtnCancel = new System.Windows.Forms.Button();
			this.BtnRecord = new System.Windows.Forms.Button();
			this.pnlLocationEditor = new System.Windows.Forms.Panel();
			this.wcMaps = new Awesomium.Windows.Forms.WebControl(this.components);
			this.btnFinderPlace = new System.Windows.Forms.Button();
			this.lstFinderResults = new System.Windows.Forms.ListBox();
			this.txtPlaceFinder = new System.Windows.Forms.TextBox();
			this.lblPlaceFinder = new System.Windows.Forms.Label();
			this.txtLocationName = new System.Windows.Forms.TextBox();
			this.lblLocationName = new System.Windows.Forms.Label();
			this.pnlLocationViewer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvLocations)).BeginInit();
			this.pnlLocationEditor.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlLocationViewer
			// 
			this.pnlLocationViewer.Controls.Add(this.btnMarcacoes);
			this.pnlLocationViewer.Controls.Add(this.dgvLocations);
			this.pnlLocationViewer.Controls.Add(this.btnAdd);
			this.pnlLocationViewer.Controls.Add(this.btnEdit);
			this.pnlLocationViewer.Location = new System.Drawing.Point(12, 12);
			this.pnlLocationViewer.Name = "pnlLocationViewer";
			this.pnlLocationViewer.Size = new System.Drawing.Size(775, 274);
			this.pnlLocationViewer.TabIndex = 0;
			// 
			// btnMarcacoes
			// 
			this.btnMarcacoes.Location = new System.Drawing.Point(697, 248);
			this.btnMarcacoes.Name = "btnMarcacoes";
			this.btnMarcacoes.Size = new System.Drawing.Size(75, 23);
			this.btnMarcacoes.TabIndex = 10;
			this.btnMarcacoes.Text = "Marcações";
			this.btnMarcacoes.UseVisualStyleBackColor = true;
			this.btnMarcacoes.Click += new System.EventHandler(this.btnMarcacoes_Click);
			// 
			// dgvLocations
			// 
			this.dgvLocations.AllowUserToAddRows = false;
			this.dgvLocations.AllowUserToDeleteRows = false;
			this.dgvLocations.AllowUserToResizeColumns = false;
			this.dgvLocations.AllowUserToResizeRows = false;
			this.dgvLocations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
			this.dgvLocations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvLocations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nome});
			this.dgvLocations.Location = new System.Drawing.Point(3, 3);
			this.dgvLocations.Name = "dgvLocations";
			this.dgvLocations.ReadOnly = true;
			this.dgvLocations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvLocations.Size = new System.Drawing.Size(769, 239);
			this.dgvLocations.TabIndex = 9;
			// 
			// Id
			// 
			this.Id.DataPropertyName = "Id";
			this.Id.HeaderText = "Id";
			this.Id.Name = "Id";
			this.Id.ReadOnly = true;
			this.Id.Width = 5;
			// 
			// Nome
			// 
			this.Nome.DataPropertyName = "Name";
			this.Nome.HeaderText = "Nome";
			this.Nome.Name = "Nome";
			this.Nome.ReadOnly = true;
			this.Nome.Width = 5;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(6, 248);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 5;
			this.btnAdd.Text = "Inserir";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.Location = new System.Drawing.Point(87, 248);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(75, 23);
			this.btnEdit.TabIndex = 4;
			this.btnEdit.Text = "Editar";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// BtnCancel
			// 
			this.BtnCancel.Location = new System.Drawing.Point(1127, 465);
			this.BtnCancel.Name = "BtnCancel";
			this.BtnCancel.Size = new System.Drawing.Size(75, 23);
			this.BtnCancel.TabIndex = 4;
			this.BtnCancel.Text = "Cancelar";
			this.BtnCancel.UseVisualStyleBackColor = true;
			this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
			// 
			// BtnRecord
			// 
			this.BtnRecord.Location = new System.Drawing.Point(1046, 465);
			this.BtnRecord.Name = "BtnRecord";
			this.BtnRecord.Size = new System.Drawing.Size(75, 23);
			this.BtnRecord.TabIndex = 5;
			this.BtnRecord.Text = "Gravar";
			this.BtnRecord.UseVisualStyleBackColor = true;
			this.BtnRecord.Click += new System.EventHandler(this.BtnRecord_Click);
			// 
			// pnlLocationEditor
			// 
			this.pnlLocationEditor.Controls.Add(this.wcMaps);
			this.pnlLocationEditor.Controls.Add(this.btnFinderPlace);
			this.pnlLocationEditor.Controls.Add(this.lstFinderResults);
			this.pnlLocationEditor.Controls.Add(this.txtPlaceFinder);
			this.pnlLocationEditor.Controls.Add(this.lblPlaceFinder);
			this.pnlLocationEditor.Controls.Add(this.txtLocationName);
			this.pnlLocationEditor.Controls.Add(this.lblLocationName);
			this.pnlLocationEditor.Controls.Add(this.BtnRecord);
			this.pnlLocationEditor.Controls.Add(this.BtnCancel);
			this.pnlLocationEditor.Location = new System.Drawing.Point(12, 12);
			this.pnlLocationEditor.Name = "pnlLocationEditor";
			this.pnlLocationEditor.Size = new System.Drawing.Size(1205, 491);
			this.pnlLocationEditor.TabIndex = 7;
			// 
			// wcMaps
			// 
			this.wcMaps.Location = new System.Drawing.Point(261, 71);
			this.wcMaps.Size = new System.Drawing.Size(941, 394);
			this.wcMaps.Source = new System.Uri("about:blank", System.UriKind.Absolute);
			this.wcMaps.TabIndex = 16;
			// 
			// btnFinderPlace
			// 
			this.btnFinderPlace.Location = new System.Drawing.Point(180, 43);
			this.btnFinderPlace.Name = "btnFinderPlace";
			this.btnFinderPlace.Size = new System.Drawing.Size(75, 23);
			this.btnFinderPlace.TabIndex = 15;
			this.btnFinderPlace.Text = "Pesquisar";
			this.btnFinderPlace.UseVisualStyleBackColor = true;
			this.btnFinderPlace.Click += new System.EventHandler(this.btnFinderPlace_Click);
			// 
			// lstFinderResults
			// 
			this.lstFinderResults.FormattingEnabled = true;
			this.lstFinderResults.Location = new System.Drawing.Point(6, 71);
			this.lstFinderResults.Name = "lstFinderResults";
			this.lstFinderResults.Size = new System.Drawing.Size(249, 394);
			this.lstFinderResults.TabIndex = 13;
			this.lstFinderResults.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstFinderResults_MouseDoubleClick);
			// 
			// txtPlaceFinder
			// 
			this.txtPlaceFinder.Location = new System.Drawing.Point(6, 45);
			this.txtPlaceFinder.Name = "txtPlaceFinder";
			this.txtPlaceFinder.Size = new System.Drawing.Size(156, 20);
			this.txtPlaceFinder.TabIndex = 11;
			// 
			// lblPlaceFinder
			// 
			this.lblPlaceFinder.AutoSize = true;
			this.lblPlaceFinder.Location = new System.Drawing.Point(3, 29);
			this.lblPlaceFinder.Name = "lblPlaceFinder";
			this.lblPlaceFinder.Size = new System.Drawing.Size(116, 13);
			this.lblPlaceFinder.TabIndex = 10;
			this.lblPlaceFinder.Text = "Pesquisa Google Maps";
			// 
			// txtLocationName
			// 
			this.txtLocationName.Location = new System.Drawing.Point(44, 3);
			this.txtLocationName.Name = "txtLocationName";
			this.txtLocationName.Size = new System.Drawing.Size(249, 20);
			this.txtLocationName.TabIndex = 8;
			// 
			// lblLocationName
			// 
			this.lblLocationName.AutoSize = true;
			this.lblLocationName.Location = new System.Drawing.Point(3, 3);
			this.lblLocationName.Name = "lblLocationName";
			this.lblLocationName.Size = new System.Drawing.Size(35, 13);
			this.lblLocationName.TabIndex = 7;
			this.lblLocationName.Text = "Nome";
			// 
			// frmLocation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1229, 515);
			this.Controls.Add(this.pnlLocationViewer);
			this.Controls.Add(this.pnlLocationEditor);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "frmLocation";
			this.Text = "..:: Racing Telelmetry - Locais ::..";
			this.Load += new System.EventHandler(this.frmLocation_Load);
			this.pnlLocationViewer.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvLocations)).EndInit();
			this.pnlLocationEditor.ResumeLayout(false);
			this.pnlLocationEditor.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlLocationViewer;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Panel pnlLocationEditor;
		private System.Windows.Forms.Label lblLocationName;
		private System.Windows.Forms.Button BtnRecord;
		private System.Windows.Forms.Button BtnCancel;
		private System.Windows.Forms.DataGridView dgvLocations;
		private System.Windows.Forms.TextBox txtLocationName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Id;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
		private System.Windows.Forms.Button btnMarcacoes;
		private System.Windows.Forms.TextBox txtPlaceFinder;
		private System.Windows.Forms.Label lblPlaceFinder;
		private System.Windows.Forms.ListBox lstFinderResults;
		private System.Windows.Forms.Button btnFinderPlace;
		private Awesomium.Windows.Forms.WebControl wcMaps;

	}
}