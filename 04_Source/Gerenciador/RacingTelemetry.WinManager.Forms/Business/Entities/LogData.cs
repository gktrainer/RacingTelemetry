using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace Business.Entities {
	public class LogData {
		public ObjectId Id { get; set; }
		public DateTime LogDate { get; set; }
		public Location Location { get; set; }
		public List<string> NMEASentence { get; set; }

		public LogData() {
			NMEASentence = new List<string>();
		}

		public class NMEA_GPRMC {
			public bool IsValid { get; set; }
			public DateTime TimeLog { get; set; }
			public double? Latitude { get; set; }
			public double? Longitude { get; set; }
			public double? SpeedInKmh { get; set; }
			public double? SpeedInKnots { get; set; }
			public char Status { get; set; }
			public double? TrackAngle { get; set; }
			public double? MagneticVariation { get; set; }
		}
	}
}
