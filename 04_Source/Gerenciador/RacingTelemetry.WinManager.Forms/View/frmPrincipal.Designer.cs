namespace View {
	partial class frmPrincipal {
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
			this.mnsMenu = new System.Windows.Forms.MenuStrip();
			this.principalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.locaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.inToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.onLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.offLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.visualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mnsMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// mnsMenu
			// 
			this.mnsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.principalToolStripMenuItem,
            this.toolStripMenuItem1,
            this.sairToolStripMenuItem});
			this.mnsMenu.Location = new System.Drawing.Point(0, 0);
			this.mnsMenu.Name = "mnsMenu";
			this.mnsMenu.Size = new System.Drawing.Size(875, 24);
			this.mnsMenu.TabIndex = 1;
			this.mnsMenu.Text = "Menu";
			// 
			// principalToolStripMenuItem
			// 
			this.principalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.locaisToolStripMenuItem});
			this.principalToolStripMenuItem.Name = "principalToolStripMenuItem";
			this.principalToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
			this.principalToolStripMenuItem.Text = "Cadastros";
			// 
			// locaisToolStripMenuItem
			// 
			this.locaisToolStripMenuItem.Name = "locaisToolStripMenuItem";
			this.locaisToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
			this.locaisToolStripMenuItem.Text = "Locais";
			this.locaisToolStripMenuItem.Click += new System.EventHandler(this.locaisToolStripMenuItem_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inToolStripMenuItem,
            this.visualizarToolStripMenuItem});
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(39, 20);
			this.toolStripMenuItem1.Text = "Log";
			// 
			// inToolStripMenuItem
			// 
			this.inToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onLineToolStripMenuItem,
            this.offLineToolStripMenuItem});
			this.inToolStripMenuItem.Name = "inToolStripMenuItem";
			this.inToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.inToolStripMenuItem.Text = "Captura";
			// 
			// onLineToolStripMenuItem
			// 
			this.onLineToolStripMenuItem.Name = "onLineToolStripMenuItem";
			this.onLineToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.onLineToolStripMenuItem.Text = "On Line";
			this.onLineToolStripMenuItem.Click += new System.EventHandler(this.onLineToolStripMenuItem_Click);
			// 
			// offLineToolStripMenuItem
			// 
			this.offLineToolStripMenuItem.Name = "offLineToolStripMenuItem";
			this.offLineToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.offLineToolStripMenuItem.Text = "Off Line";
			this.offLineToolStripMenuItem.Click += new System.EventHandler(this.offLineToolStripMenuItem_Click);
			// 
			// visualizarToolStripMenuItem
			// 
			this.visualizarToolStripMenuItem.Name = "visualizarToolStripMenuItem";
			this.visualizarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.visualizarToolStripMenuItem.Text = "Visualizar";
			this.visualizarToolStripMenuItem.Click += new System.EventHandler(this.visualizarToolStripMenuItem_Click);
			// 
			// sairToolStripMenuItem
			// 
			this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
			this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
			this.sairToolStripMenuItem.Text = "Sair";
			this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
			// 
			// frmPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(875, 455);
			this.Controls.Add(this.mnsMenu);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MainMenuStrip = this.mnsMenu;
			this.MaximizeBox = false;
			this.Name = "frmPrincipal";
			this.Text = "..:: Racing Telelmetry - Windows Manager ::..";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
			this.mnsMenu.ResumeLayout(false);
			this.mnsMenu.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip mnsMenu;
		private System.Windows.Forms.ToolStripMenuItem principalToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem locaisToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem inToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem visualizarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem onLineToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem offLineToolStripMenuItem;

	}
}