using Business.Entities;
using Business.Repositories;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services {
	public class LocationService {

		ILocationRepository repository;

		public LocationService(ILocationRepository repository) {
			this.repository = repository;
		}

		public void Add(Location location) {
			repository.Save(null, location);
		}

		public void Edit(Location location) {
			repository.Save(location.Id, location);
		}

		public List<Location> ListAll() {
			return repository.ListAll();
		}

		public Location GetById(string id) {
			return repository.GetById(new ObjectId(id));
		}
	}
}
