using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Helpers {
	public static class GeoCalculatorHelper {
		public static double? ConvertLatitudeDegreesToDecimal(string value, string orientation) {
			if (string.IsNullOrWhiteSpace(value)) {
				return null;
			} else {
				double latitudeSign = orientation.Equals("S") ? -1 : 1;
				double degrees = double.Parse(value.Substring(0, 2));
				double time = double.Parse(value.Substring(2), new CultureInfo("en-US")) / 60;

				return (degrees + time) * latitudeSign;
			}
		}

		public static double? ConvertLongitudeDegreesToDecimal(string value, string orientation) {
			if (string.IsNullOrWhiteSpace(value)) {
				return null;
			} else {
				double longitudeSign = orientation.Equals("W") ? -1 : 1;
				double degrees = double.Parse(value.Substring(0, 3));
				double time = double.Parse(value.Substring(3), new CultureInfo("en-US")) / 60;

				return (degrees + time) * longitudeSign;
			}
		}
	}
}
