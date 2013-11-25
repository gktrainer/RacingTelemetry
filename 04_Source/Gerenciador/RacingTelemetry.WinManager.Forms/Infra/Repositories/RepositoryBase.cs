using Business.Repositories;
using Infra.Repositories.Mappers;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace Infra.Repositories {
	public class RepositoryBase<TEntity, TMapper> : IRepository<TEntity>
		where TEntity : class
		where TMapper : MapperBase {

		MongoServer server = new MongoClient(ConfigurationManager.AppSettings["connectionString"].ToString()).GetServer();
		MongoDatabase database = null;
		string collectionName = string.Empty;
		MongoCollection collectionData = null;

		public RepositoryBase(string collectionName) {
			TMapper mapper = Activator.CreateInstance<TMapper>();
			mapper.StartMapper();

			this.database = server.GetDatabase("RacingTelemetryDB");
			this.collectionName = collectionName;
			collectionData = database.GetCollection(this.collectionName);
		}

		public void Save(ObjectId? id, TEntity entity) {
			if (id.HasValue) {
				QueryDocument query = new QueryDocument("_id", id);
				UpdateDocument update = new UpdateDocument { entity.ToBsonDocument() };
				collectionData.Update(query, update);
			} else {
				collectionData.Insert(typeof(TEntity), entity);
			}
		}

		public TEntity GetById(ObjectId id) {
			return collectionData.FindOneByIdAs(typeof(TEntity), id) as TEntity;
		}

		public void Delete(ObjectId id) {
			QueryDocument query = new QueryDocument("Id", id);
			collectionData.Remove(query);
		}

		public List<TEntity> ListAll() {
			return collectionData.AsQueryable<TEntity>().ToList();
		}
	}
}
