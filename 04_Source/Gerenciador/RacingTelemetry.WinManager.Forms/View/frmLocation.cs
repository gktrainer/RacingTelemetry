using Business.Entities;
using Business.Repositories;
using Business.Services;
using GoogleMapsApi.Entities.Geocoding.Response;
using Infra.Repositories;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using View.Helpers;

namespace View {
	public partial class frmLocation : Form {

		List<Panel> panels = new List<Panel>();
		ILocationRepository repository = new LocationRepository();
		LocationService service = null;
		string entityIdEdited = string.Empty;
		private readonly string mapFile = "LocationMap";

		public frmLocation() {
			InitializeComponent();
		}

		private void btnAdd_Click(object sender, EventArgs e) {
			txtLocationName.Clear();

			FormHelper.ShowPanel(panels, pnlLocationEditor);
			FormHelper.ResizeFormByPanel(this, pnlLocationEditor);
		}

		private void frmLocation_Load(object sender, EventArgs e) {
			service = new LocationService(repository);

			panels.Add(pnlLocationViewer);
			panels.Add(pnlLocationEditor);

			FormHelper.ShowPanel(panels, pnlLocationViewer);
			FormHelper.ResizeFormByPanel(this, pnlLocationViewer);

			wcMaps.LoadHTML(MapHelper.ReadHtmlPage(mapFile));

			dgvLocations.DataSource = service.ListAll();
		}

		private void btnEdit_Click(object sender, EventArgs e) {
			if (dgvLocations.SelectedRows.Count > 0) {

				entityIdEdited = dgvLocations.SelectedRows[0].Cells[0].Value.ToString();
				Location location = service.GetById(entityIdEdited);

				txtLocationName.Text = location.Name;
				Result position = new Result() {
					Geometry = new Geometry(),
				};
				position.Geometry.Location = new GoogleMapsApi.Entities.Common.Location(location.Latitude, location.Longitude);
				MapHelper.SetMarkerLocation(position, wcMaps);

				FormHelper.ShowPanel(panels, pnlLocationEditor);
				FormHelper.ResizeFormByPanel(this, pnlLocationEditor);
			}
		}

		private void BtnRecord_Click(object sender, EventArgs e) {
			Location location = null;

			double? latitude = MapHelper.GetMarkerLatitude(wcMaps);
			double? longitude = MapHelper.GetMarkerLongitude(wcMaps);

			if (string.IsNullOrEmpty(txtLocationName.Text)) {
				MessageBox.Show("Nome vazio", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (!latitude.HasValue && !longitude.HasValue) {
				MessageBox.Show("Não existe nenhuma marcação de local", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (!string.IsNullOrWhiteSpace(entityIdEdited)) {
				location = service.GetById(dgvLocations.SelectedRows[0].Cells[0].Value.ToString());
				location.Name = txtLocationName.Text;
				location.Latitude = latitude.Value;
				location.Longitude = longitude.Value;
				service.Edit(location);
			} else {
				location = new Location();
				location.Name = txtLocationName.Text;
				location.Latitude = latitude.Value;
				location.Longitude = longitude.Value;
				service.Add(location);
			}

			entityIdEdited = string.Empty;

			dgvLocations.DataSource = service.ListAll();

			FormHelper.ShowPanel(panels, pnlLocationViewer);
			FormHelper.ResizeFormByPanel(this, pnlLocationViewer);
		}

		private void BtnCancel_Click(object sender, EventArgs e) {
			FormHelper.ShowPanel(panels, pnlLocationViewer);
			FormHelper.ResizeFormByPanel(this, pnlLocationViewer);
		}

		private void btnMarcacoes_Click(object sender, EventArgs e) {
			if (dgvLocations.SelectedRows.Count > 0) {

				entityIdEdited = dgvLocations.SelectedRows[0].Cells[0].Value.ToString();
				Location location = service.GetById(entityIdEdited);
				FormHelper.Open(typeof(frmSplitMakers), new object[] { location, service });
			}

		}

		private void btnFinderPlace_Click(object sender, EventArgs e) {
			if (string.IsNullOrWhiteSpace(txtPlaceFinder.Text)) {
				MessageBox.Show("Campo de pesquisa vazio", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			} else {
				lstFinderResults.DataSource = MapHelper.FindPlaces(txtPlaceFinder.Text).Results;
				lstFinderResults.DisplayMember = "FormattedAddress";
			}
		}

		private void lstFinderResults_MouseDoubleClick(object sender, MouseEventArgs e) {
			MapHelper.SetMarkerLocation((Result)lstFinderResults.SelectedItem, wcMaps);
		}
	}
}
