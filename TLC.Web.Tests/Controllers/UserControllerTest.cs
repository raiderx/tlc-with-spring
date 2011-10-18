using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Moq;
using NUnit.Framework;
using TLC.Model.Entities;
using TLC.Service;
using TLC.Web.Controllers;

namespace TLC.Web.Tests.Controllers
{
	[TestFixture]
	public class UserControllerTest
	{
		private Mock<IUserService> userService;
		private UserController userContoller;

		[SetUp]
		public void SetUp()
		{
			userService = new Mock<IUserService>();
			userContoller = new UserController
			{
				UserService = userService.Object
			};
		}

		[Test]
		public void TestListAction()
		{
			IList<User> users = new Mock<IList<User>>().Object;
			userService.Setup(x => x.GetAllUsers()).Returns(users);
			ViewResult viewResult = userContoller.List();
			Assert.NotNull(viewResult);
			IList<User> result = viewResult.ViewData.Model as IList<User>;
			userService.Verify(x => x.GetAllUsers());
		}
	}
}
