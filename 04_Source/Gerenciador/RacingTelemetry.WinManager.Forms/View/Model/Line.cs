using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Model {
	public class Line {
		public int type { get; set; }
		public List<Position> position { get; set; }

		public class Position {
			public double ob { get; set; }
			public double pb { get; set; }
		}
	}
}
