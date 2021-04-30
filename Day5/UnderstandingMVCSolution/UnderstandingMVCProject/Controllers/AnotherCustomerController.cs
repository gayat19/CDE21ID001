using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnderstandingMVCProject.Models;

namespace UnderstandingMVCProject.Controllers
{
    public class AnotherCustomerController : Controller
    {
        private CustomerContext _customerContext;

        public AnotherCustomerController(CustomerContext customerContext)
        {
            _customerContext = customerContext;
        }
        public List<Customer> GetCustomers()
        {
            var customers = _customerContext.Customers.ToList();
            return customers;
        }
        // GET: AnotherCustomerController
        public ActionResult Index()
        {
           
            return View(GetCustomers());
        }

        // GET: AnotherCustomerController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AnotherCustomerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AnotherCustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AnotherCustomerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AnotherCustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AnotherCustomerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AnotherCustomerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
