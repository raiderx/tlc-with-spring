using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Moq;
using NUnit.Framework;
using TLC.Model.Dao;
using TLC.Model.Entities;
using TLC.Service.Impl;

namespace TLC.Service.Tests.Impl
{
	[TestFixture]
	public class UserServiceImplTest
	{
		private Mock<IUserDao> userDao;
		private IUserService userService;

		[SetUp]
		public void SetUp()
		{
			userDao = new Mock<IUserDao>();
			userService = new UserServiceImpl { UserDao = userDao.Object };
		}

		[Test]
		public void TestCreateUser()
		{
			User user = new Mock<User>().Object;
			userDao.Setup(x => x.Create(user)).Returns(user);
			User result = userService.CreateUser(user);
			Assert.NotNull(result);
			userDao.Verify(x => x.Create(user));
		}
	}
}
