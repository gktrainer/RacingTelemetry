using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories.Mappers {
	public abstract class MapperBase {
		public abstract Action StartMapper();
	}
}
