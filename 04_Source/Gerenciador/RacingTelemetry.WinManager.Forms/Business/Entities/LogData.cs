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
			public DateTime TimeLog { get; set; }

		}
	}
}
