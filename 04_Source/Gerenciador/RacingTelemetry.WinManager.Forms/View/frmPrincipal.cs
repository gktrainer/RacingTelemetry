using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Helpers;

namespace View {
	public partial class frmPrincipal : Form {
		public frmPrincipal() {
			InitializeComponent();
		}

		private void locaisToolStripMenuItem_Click(object sender, EventArgs e) {
			FormHelper.Open(typeof(frmLocation));
		}

		private void sairToolStripMenuItem_Click(object sender, EventArgs e) {
			DialogResult result = FormHelper.GenerateCloseAppMessage();

			if (result == System.Windows.Forms.DialogResult.Yes) {
				Application.Exit();
			}
		}

		private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e) {

			if (e.CloseReason != CloseReason.ApplicationExitCall) {
				DialogResult result = FormHelper.GenerateCloseAppMessage();

				e.Cancel = (result == System.Windows.Forms.DialogResult.No);
			}

		}

		private void offLineToolStripMenuItem_Click(object sender, EventArgs e) {
			FormHelper.Open(typeof(frmCaptureOffLine));
		}

		private void onLineToolStripMenuItem_Click(object sender, EventArgs e) {
			FormHelper.Open(typeof(frmDataLog));
		}

		private void visualizarToolStripMenuItem_Click(object sender, EventArgs e) {
			FormHelper.Open(typeof(frmLogDataView));
		}
	}
}
