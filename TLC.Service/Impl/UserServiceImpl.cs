using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TLC.Model.Dao;
using TLC.Model.Entities;

namespace TLC.Service.Impl
{
	public class UserServiceImpl : IUserService
	{
		public virtual IUserDao UserDao { get; set; }

		public User CreateUser(User user)
		{
			return UserDao.Create(user);
		}

		public IList<User> GetAllUsers()
		{
			return UserDao.GetAllUsers();
		}
	}
}
