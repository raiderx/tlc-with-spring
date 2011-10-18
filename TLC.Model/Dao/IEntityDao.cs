using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TLC.Model.Entities;

namespace TLC.Model.Dao
{
	public interface IEntityDao<T> where T : Entity
	{
		T Create(T entity);
		T GetById(int id);
		T Update(T entity);
		bool Delete(T entity);
	}
}
