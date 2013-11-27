using Business.Entities;
using Business.Helpers;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Converters {
	public static class NMEAConverter {
		public static LogData.NMEA_GPRMC ToGPRMC(this string NMEASentence) {

			LogData.NMEA_GPRMC gprmc = new LogData.NMEA_GPRMC();
			gprmc.IsValid = NMEASentence.StartsWith("$GPRMC");

			if (gprmc.IsValid) {

				string[] sentenceData = NMEASentence.Split(new char[] { ',' });

				gprmc.Latitude = GeoCalculatorHelper.ConvertLatitudeDegreesToDecimal(sentenceData[3], sentenceData[4]);
				gprmc.Longitude = GeoCalculatorHelper.ConvertLongitudeDegreesToDecimal(sentenceData[5], sentenceData[6]);

				string hour = sentenceData[1];
				string date = sentenceData[9];
				gprmc.TimeLog = DateTime.ParseExact(string.Format("{0} {1}", date, hour), "ddMMyy HHmmss.fff", new CultureInfo("en-US"));

				gprmc.SpeedInKnots = ConvertValue(sentenceData[7]);
				gprmc.SpeedInKmh = gprmc.SpeedInKnots.HasValue ? gprmc.SpeedInKnots / 0.539956803456 : (double?)null;

				gprmc.Status = sentenceData[2].ToCharArray()[0];

				gprmc.TrackAngle = ConvertValue(sentenceData[8]);

				gprmc.MagneticVariation = ConvertValue(sentenceData[10], sentenceData[11]);
			}

			return gprmc;
		}

		public static double? ConvertValue(string value, string position = "") {
			double valueDouble = 0;
			double? result = null;

			if (double.TryParse(value, NumberStyles.Any, new CultureInfo("en-US"), out valueDouble)) {
				if (position.Equals("S") || position.Equals("W")) {
					valueDouble = 0 - valueDouble;
				}
				result = valueDouble;
			}

			return result;
		}
	}
}
