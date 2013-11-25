using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using MongoDB.Bson;

namespace Business.Entities {
	public class Location {
		public ObjectId Id { get; set; }
		public string Name { get; set; }
		public double Latitude { get; set; }
		public double Longitude { get; set; }
		public List<SplitMarker> SplitMarkers { get; set; }

		public Location() {
			Id = ObjectId.GenerateNewId();
			SplitMarkers = new List<SplitMarker>(); 
		}
	}
}
