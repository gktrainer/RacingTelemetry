using Business.Entities;
using Business.Repositories;
using Infra.Repositories.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories {
	public class LogDataRepository: RepositoryBase<LogData, LogDataMapper>, ILogDataRepository {
		public LogDataRepository() : base("logs") { }
	}
}
