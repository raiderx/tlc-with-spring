using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TLC.Model.Entities;

namespace TLC.Model.Dao
{
	public interface IUserDao : IEntityDao<User>
	{
		IList<User> GetAllUsers();
	}
}
