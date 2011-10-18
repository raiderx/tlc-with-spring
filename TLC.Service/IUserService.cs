using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TLC.Model.Entities;

namespace TLC.Service
{
	public interface IUserService
	{
		User CreateUser(User user);

		IList<User> GetAllUsers();
	}
}
