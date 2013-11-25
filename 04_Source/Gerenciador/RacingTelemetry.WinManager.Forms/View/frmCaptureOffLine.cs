using Business.Entities;
using Business.Repositories;
using Business.Services;
using Infra.Repositories;
using System;
using System.IO;
using System.Windows.Forms;

namespace View {
	public partial class frmCaptureOffLine : Form {
		ILocationRepository locationRepository = null;
		LocationService locationService = null;

		ILogDataRepository repository = null;
		LogDataService service = null;

		public frmCaptureOffLine() {
			InitializeComponent();
		}

		private void frmCaptureOffLine_Load(object sender, EventArgs e) {
			locationRepository = new LocationRepository();
			locationService = new LocationService(locationRepository);

			repository = new LogDataRepository();
			service = new LogDataService(repository);

			cboLocation.Items.AddRange(locationService.ListAll().ToArray());
			cboLocation.DisplayMember = "Name";
			cboLocation.ValueMember = "Id";
		}

		private void btnLogDataFinder_Click(object sender, EventArgs e) {
			if (ofdLogDataFile.ShowDialog() == DialogResult.OK) {
				txtLogDataFile.Text = ofdLogDataFile.FileName;
			}
		}

		private void btnImportData_Click(object sender, EventArgs e) {
			DialogResult confirmacao = MessageBox.Show("Deseja importar arquivo?", "Importação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (confirmacao == System.Windows.Forms.DialogResult.Yes) {
				LogData logData = new LogData();
				logData.Location = cboLocation.SelectedItem as Location;

				using (StreamReader reader = new StreamReader(txtLogDataFile.Text)) {
					string linhaLog;
					do {
						linhaLog = reader.ReadLine();
						if (!string.IsNullOrWhiteSpace(linhaLog)) {
							logData.NMEASentence.Add(linhaLog);
						}
					} while (!string.IsNullOrWhiteSpace(linhaLog));
				}

				service.Add(logData);
			}
		}
	}
}
