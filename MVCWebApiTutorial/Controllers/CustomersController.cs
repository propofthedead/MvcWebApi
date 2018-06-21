using System;
using MVCWebApiTutorial.Models;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MVCWebApiTutorial.Controllers
{
    public class CustomersController : ApiController
    {
		private MvcWebApiTutorialContext db = new MvcWebApiTutorialContext();

		[HttpGet]
		[ActionName("List")]
		public IEnumerable<Customer> List() {
			return db.Customers.ToList();
		}
		[HttpGet]
		[ActionName("Get")]
		public Customer Get(int? id)
		{
			if (id == null) {
				return null;
			}
			return db.Customers.Find(id);
		}
	}
}
