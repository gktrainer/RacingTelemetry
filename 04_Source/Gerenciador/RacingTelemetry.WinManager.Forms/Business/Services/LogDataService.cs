using Business.Entities;
using Business.Repositories;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services {
	public class LogDataService {
		ILogDataRepository repository = null;

		public LogDataService(ILogDataRepository repository) {
			this.repository = repository;
		}

		public void Add(LogData logData) {
			if (logData.NMEASentence.Any()) {
				if (logData.NMEASentence.Any(line => line.StartsWith("$GPRMC"))) {
					string firstLineValid = logData.NMEASentence.First(line => line.StartsWith("$GPRMC"));
					string hour = firstLineValid.Split(new char[] { ',' })[1];
					string date = firstLineValid.Split(new char[] { ',' })[9];
					logData.LogDate = DateTime.ParseExact(string.Format("{0} {1}", date, hour), "ddMMyy HHmmss.fff", new CultureInfo("en-US"));
				} else {
					logData.LogDate = DateTime.Now;
				}
				repository.Save(null, logData);
			}
		}

		public void Edit(LogData logData) {
			repository.Save(logData.Id, logData);
		}

		public List<LogData> ListAll() {
			return repository.ListAll();
		}

		public void Delete(LogData logData) {
			repository.Delete(logData.Id);
		}
	}
}
