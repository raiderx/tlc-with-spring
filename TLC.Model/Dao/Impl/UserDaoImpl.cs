using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TLC.Model.Entities;

namespace TLC.Model.Dao.Impl
{
	public class UserDaoImpl : AbstractEntityDaoImpl<User>, IUserDao
	{
		public IList<User> GetAllUsers()
		{
			throw new NotImplementedException();
		}
	}
}
