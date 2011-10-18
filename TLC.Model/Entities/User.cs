using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TLC.Model.Entities
{
	public class User : Entity
	{
		public virtual string Login { get; set; }
		public virtual string Email { get; set; }
	}
}
