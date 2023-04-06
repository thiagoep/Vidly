using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        public List<Customer> customers = new List<Customer>
            {
                new Customer { Id = 1, Name = "Thiago" },
                new Customer { Id = 2, Name = "Exequiel" }
            };

        // GET: Customers
        [Route("customers")]
        public ActionResult Customers()
        {
            return View(customers);
        }

        [Route("customers/details/{id}")]
        public ActionResult Details(int id)
        {
            Customer customer = customers.Find(x => x.Id == id);

            if (customer == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(customer);
            }
        }
    }
}