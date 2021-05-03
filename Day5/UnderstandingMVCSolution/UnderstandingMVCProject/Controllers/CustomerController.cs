using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnderstandingMVCProject.Models;
using UnderstandingMVCProject.Services;

namespace UnderstandingMVCProject.Controllers
{

    public class CustomerController : Controller
    {
        private ICustomerRepo<Customer> _customerRepo;
        private ILogger<CustomerController> _logger;

        public CustomerController(ICustomerRepo<Customer> customerRepo, ILogger<CustomerController> logger)
        {
            _customerRepo = customerRepo;
            _logger = logger;
            _logger.LogInformation("Logger initiated");
        }
        // GET: CustomerController
        public ActionResult Index()
        {
            List<Customer> customers = new List<Customer>() ;
            try
            {
                customers = _customerRepo.GetAll().ToList();
                return View(customers);
            }
            catch (Exception e)
            {
                ViewBag.ErrorMessage = e.Message;
                _logger.LogError(e.Message);
            }
            return View(customers);
        }

        // GET: CustomerController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CustomerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Customer customer)
        {
         
            try
            {
                _customerRepo.Add(customer);
                return RedirectToAction(nameof(Index));
            }
            catch(Exception e)
            {
                _logger.LogError(e.Message);
                return View();
            }
        }

        // GET: CustomerController/Edit/5
        public ActionResult Edit(int id)
        {
            var cust = _customerRepo.GetById(id);
            return View(cust);
        }

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Customer customer)
        {
            try
            {
                var cust = _customerRepo.EditCustomer(id, customer);
                return RedirectToAction(nameof(Index));
            }
            catch(Exception e)
            {
                _logger.LogError(e.Message);
                return View();
            }
        }

        // GET: CustomerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CustomerController/Delete/5
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
