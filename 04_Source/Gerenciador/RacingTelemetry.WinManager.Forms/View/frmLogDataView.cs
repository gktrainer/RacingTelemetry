using Business.Entities;
using Business.Repositories;
using Business.Services;
using Infra.Repositories;
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
	public partial class frmLogDataView : Form {
		LogDataService service = null;
		ILogDataRepository repository = null;
		List<Panel> panels = new List<Panel>();
		readonly string mapFile = "LogDataAnalisys";
		
		public frmLogDataView() {
			InitializeComponent();
		}

		private void frmLogDataView_Load(object sender, EventArgs e) {
			wcMaps.LoadHTML(MapHelper.ReadHtmlPage(mapFile));
			
			repository = new LogDataRepository();
			service = new LogDataService(repository);

			panels.Add(pnlLogDataViewer);
			panels.Add(pnlLogDataAnalysis);

			FormHelper.ShowPanel(panels, pnlLogDataViewer);
			FormHelper.ResizeFormByPanel(this, pnlLogDataViewer);

			dgvLogData.DataSource = service.ListAll();
		}

		private void btnDeleteLogData_Click(object sender, EventArgs e) {
			if (dgvLogData.SelectedRows.Count > 0) {
				DialogResult acao = MessageBox.Show("Deseja realmente apagar a captura?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (acao == System.Windows.Forms.DialogResult.Yes) {
					LogData logData = (LogData)dgvLogData.SelectedRows[0].DataBoundItem;
					service.Delete(logData);

					dgvLogData.DataSource = service.ListAll();
				}
			} else {
				MessageBox.Show("Nenhuma linha selecionada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		private void btnAnalysis_Click(object sender, EventArgs e) {
			if (dgvLogData.SelectedRows.Count > 0) {
				LogData currentLogData = (LogData)dgvLogData.SelectedRows[0].DataBoundItem;

				MapHelper.SetPosition(currentLogData.Location, wcMaps);
				while (!wcMaps.IsRendering) {}				
				MapHelper.CreatePath(currentLogData, wcMaps);

				FormHelper.ShowPanel(panels, pnlLogDataAnalysis);
				FormHelper.ResizeFormByPanel(this, pnlLogDataAnalysis);
			} else {
				MessageBox.Show("Nenhuma linha selecionada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}
	}
}
