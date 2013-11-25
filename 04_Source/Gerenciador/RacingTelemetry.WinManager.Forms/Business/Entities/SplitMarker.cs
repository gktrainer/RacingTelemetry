using Business.Entities.Enums;

namespace Business.Entities {

	public class SplitMarker {
		public double LatPointA { get; set; }
		public double LatPointB { get; set; }
		public double LongPointA { get; set; }
		public double LongPointB { get; set; }
		public SplitMarkerType Type { get; set; }
	}
}
