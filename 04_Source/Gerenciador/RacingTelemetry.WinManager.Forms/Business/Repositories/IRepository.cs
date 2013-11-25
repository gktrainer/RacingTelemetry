using Business.Entities;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repositories {
	public interface IRepository<TEntity>  {
		void Save(ObjectId? id, TEntity entity);
		TEntity GetById(ObjectId id);
		void Delete(ObjectId id);
		List<TEntity> ListAll();
	}
}
