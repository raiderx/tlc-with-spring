using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TLC.Service;
using TLC.Model.Entities;

namespace TLC.Web.Controllers
{
    public class UserController : Controller
    {
		public virtual IUserService UserService { get; set; }

		//
        // GET: /User/

        public ActionResult Index()
        {
            return View();
        }

		public ViewResult List()
		{
			IList<User> users = UserService.GetAllUsers();
			return View(users);
		}
    }
}
