using Business.Entities;
using MongoDB.Bson.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories.Mappers {
	public class LogDataMapper : MapperBase {

		private static void Mapper() {
			if (!BsonClassMap.IsClassMapRegistered(typeof(LogData))) {
				BsonClassMap.RegisterClassMap<LogData>(map => {
					map.MapIdField("Id");
					map.MapField("LogDate");
					map.MapField("Location");
					map.MapField("NMEASentence");
				});
			}
		}

		public override Action StartMapper() {
			return new Action(Mapper);
		}
	}
}
