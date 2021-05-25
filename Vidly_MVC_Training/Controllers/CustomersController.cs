using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly_MVC_Training.Models;
using System.Data.Entity;
using Vidly_MVC_Training.ViewModels;

namespace Vidly_MVC_Training.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }



        // GET: Customers
        public ActionResult Index()
        {
            var customers = _context.Customers
                                .Include(c => c.MemberShipType).ToList();

            return View(customers);
        }

        [Route("Customers/Details/{id}")]
        public ActionResult Details(int id)
        {
            var customer = _context.Customers.Find(id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }


        [Route("Customers/New")]
        public ActionResult New()
        {
            var membershipTypes = _context.MemberShipTypes.ToList();
            var viewModel = new NewCustomerViewModel
            {
                Customer = new Customer(),
                MemberShipTypes = membershipTypes,
            };

            return View(viewModel);
        }

        

        public ActionResult Edit(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return HttpNotFound();

            var viewModel = new NewCustomerViewModel
            {
                Customer = customer,
                MemberShipTypes = _context.MemberShipTypes.ToList()
            };

            return View("CustomerForm",viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Customer customer)
        {
            if (customer.Id == 0)
                _context.Customers.Add(customer);
            else
            {
                var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == customer.Id);
                customerInDb.Name = customer.Name;
                customerInDb.BirthDate = customer.BirthDate;
                customerInDb.IsSubscribedToNewLetter = customer.IsSubscribedToNewLetter;
                customerInDb.MemberShipTypeId = customer.MemberShipTypeId;

            }


            _context.SaveChanges();

            return RedirectToAction("Index", "Customers");
        }

       
    }
}