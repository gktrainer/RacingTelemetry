using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.Helpers {
	public static class FormHelper {
		public static void Open(Type form, object[] args = null) {
			using (Form formToOpen = (Form)Activator.CreateInstance(form, args)) {
				formToOpen.ShowDialog();
			}
		}

		public static DialogResult GenerateCloseAppMessage() {
			return MessageBox.Show("Deseja fechar o programa?", "Fechando...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
		}

		public static void ShowPanel(List<Panel> panels, Panel panelToShow) {
			foreach (Panel panel in panels) {
				panel.Visible = (panel.Name.Equals(panelToShow.Name));
			}
		}

		public static void ResizeFormByPanel(Form form, Panel panel) {
			ResizeFormByPanel(form, panel, 50, 50);
		}

		public static void ResizeFormByPanel(Form form, Panel panel, int adjustWidth, int adjustHeight) {
			form.Width = panel.Width + adjustWidth;
			form.Height = panel.Height + adjustHeight;
			form.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - form.Width) / 2,
													(Screen.PrimaryScreen.WorkingArea.Height - form.Height) / 2);
		}

		public static string GetDescription(this Enum value) {
			FieldInfo field = value.GetType().GetField(value.ToString());
			object[] attribs = field.GetCustomAttributes(typeof(DescriptionAttribute), true);
			if (attribs.Length > 0) {
				return ((DescriptionAttribute)attribs[0]).Description;
			}
			return string.Empty;
		}
	}
}
