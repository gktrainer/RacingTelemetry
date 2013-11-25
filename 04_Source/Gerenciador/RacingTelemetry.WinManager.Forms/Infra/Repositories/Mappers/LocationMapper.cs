using Business.Entities;
using MongoDB.Bson.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories.Mappers {
	public class LocationMapper : MapperBase {

		private static void Mapper() {
			if (!BsonClassMap.IsClassMapRegistered(typeof(Location))) {
				BsonClassMap.RegisterClassMap<Location>(map => {
					map.MapIdField("Id");
					map.MapField("Name");
				});
			}
		}

		public override Action StartMapper() {
			return new Action(Mapper);
		}
	}
}
