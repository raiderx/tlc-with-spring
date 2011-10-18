using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TLC.Model.Entities;

namespace TLC.Model.Dao.Impl
{
	public abstract class AbstractEntityDaoImpl<T> : IEntityDao<T> where T: Entity
	{
		public T Create(T entity)
		{
			throw new NotImplementedException();
		}

		public T GetById(int id)
		{
			throw new NotImplementedException();
		}

		public T Update(T entity)
		{
			throw new NotImplementedException();
		}

		public bool Delete(T entity)
		{
			throw new NotImplementedException();
		}
	}
}
