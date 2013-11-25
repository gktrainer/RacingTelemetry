using Business.Entities;
using Business.Entities.Enums;
using Business.Repositories;
using Business.Services;
using Infra.Repositories;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using View.Helpers;

namespace View {
	public partial class frmSplitMakers : Form {

		List<Panel> panels = new List<Panel>();
		ILocationRepository repository = new LocationRepository();
		string entityIdEdited = string.Empty;
		private Location currentLocation = null;
		private LocationService service = null;
		private readonly string mapFile = "SplitMarkerMap";

		public frmSplitMakers(Location currentLocation, LocationService service) {
			InitializeComponent();
			this.currentLocation = currentLocation;
			this.service = service;
		}

		private void frmSplitMakers_Load(object sender, EventArgs e) {
			lblLocationName.Text = currentLocation.Name;

			panels.Add(pnlSplitMarkersViewer);
			panels.Add(pnlSplitMarkersEditor);

			FormHelper.ShowPanel(panels, pnlSplitMarkersViewer);
			FormHelper.ResizeFormByPanel(this, pnlSplitMarkersViewer, 50, 100);

			wcMaps.LoadHTML(MapHelper.ReadHtmlPage(mapFile));

			dgvSplitMarkers.DataSource = currentLocation.SplitMarkers;
		}

		private void btnAddSplitMarker_Click(object sender, EventArgs e) {
			foreach (var splitMarkerType in Enum.GetValues(typeof(SplitMarkerType))) {
				cboSplitMarkerType.Items.Add(new { Text = ((SplitMarkerType)splitMarkerType).GetDescription(), Value = splitMarkerType });
			}

			cboSplitMarkerType.DisplayMember = "Text";
			cboSplitMarkerType.ValueMember = "Value";

			MapHelper.SetPosition(currentLocation, wcMaps);

			FormHelper.ShowPanel(panels, pnlSplitMarkersEditor);
			FormHelper.ResizeFormByPanel(this, pnlSplitMarkersEditor, 50, 100);
		}

		private void btnApplyMarker_Click(object sender, EventArgs e) {
			if (cboSplitMarkerType.SelectedIndex != -1) {
				MapHelper.SetMarkerType(((dynamic)cboSplitMarkerType.SelectedItem).Value, wcMaps);
			}
		}

		private void btnClearMarkers_Click(object sender, EventArgs e) {
			DialogResult decisao = MessageBox.Show("Deseja apagar todos as marcações?", "Marcações", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (decisao == System.Windows.Forms.DialogResult.Yes) {
				MapHelper.ClearAllLines(wcMaps);
			}
		}

		private void btnSaveMarker_Click(object sender, EventArgs e) {
			this.currentLocation.SplitMarkers = MapHelper.GetLines(wcMaps);
			service.Edit(currentLocation);

			FormHelper.ShowPanel(panels, pnlSplitMarkersViewer);
			FormHelper.ResizeFormByPanel(this, pnlSplitMarkersViewer, 50, 100);

			dgvSplitMarkers.DataSource = currentLocation.SplitMarkers;
		}

		private void btnCancelOperation_Click(object sender, EventArgs e) {
			DialogResult decisao = MessageBox.Show("Deseja cancelar?", "Marcações", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (decisao == System.Windows.Forms.DialogResult.Yes) {
				FormHelper.ShowPanel(panels, pnlSplitMarkersViewer);
				FormHelper.ResizeFormByPanel(this, pnlSplitMarkersViewer, 50, 100);
			}
		}

		private void frmSplitMakers_FormClosing(object sender, FormClosingEventArgs e) {
			if (pnlSplitMarkersEditor.Visible) {
				e.Cancel = true;

				FormHelper.ShowPanel(panels, pnlSplitMarkersViewer);
				FormHelper.ResizeFormByPanel(this, pnlSplitMarkersViewer, 50, 100);
			}
		}

		private void btnEditMarker_Click(object sender, EventArgs e) {
			foreach (var splitMarkerType in Enum.GetValues(typeof(SplitMarkerType))) {
				cboSplitMarkerType.Items.Add(new { Text = ((SplitMarkerType)splitMarkerType).GetDescription(), Value = splitMarkerType });
			}

			cboSplitMarkerType.DisplayMember = "Text";
			cboSplitMarkerType.ValueMember = "Value";

			MapHelper.SetPosition(currentLocation, wcMaps);

			foreach (var marcacao in currentLocation.SplitMarkers) {
				MapHelper.CreateLine(marcacao, wcMaps);
			}

			FormHelper.ShowPanel(panels, pnlSplitMarkersEditor);
			FormHelper.ResizeFormByPanel(this, pnlSplitMarkersEditor, 50, 100);
		}
	}
}
