using Business.Entities;
using Business.Repositories;
using Infra.Repositories.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories {
	public class LocationRepository : RepositoryBase<Location, LocationMapper>, ILocationRepository {
		public LocationRepository() : base("locations") { }
	}
}
