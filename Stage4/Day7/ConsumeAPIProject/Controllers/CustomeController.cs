using ConsumeAPIProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;


namespace ConsumeAPIProject.Controllers
{
    public class CustomeController : Controller
    {
        private ILogger<CustomeController> _logger;
        private IConfiguration _configure;
        private string apiBaseUrl;

        public CustomeController(ILogger<CustomeController> logger,IConfiguration configuration)
        {
            _logger = logger;
            _configure = configuration;
            apiBaseUrl = _configure.GetValue<string>("WebAPIBaseUrl");
        }
        // GET: CustomeController
        public ActionResult Index()
        {
            IList<Customer> customers = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiBaseUrl);
                var responseTask = client.GetAsync("Customer");
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readData = result.Content.ReadAsAsync<IList<Customer>>();
                    readData.Wait();
                    customers = readData.Result;
                }
            }

            return View(customers);
        }

        // GET: CustomeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CustomeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Customer customer)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(apiBaseUrl);
                    var responseTask = client.PostAsJsonAsync<Customer>("Customer", customer);
                    responseTask.Wait();
                    var result = responseTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        return RedirectToAction("Index");
                    }
                 }
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CustomeController/Edit/5
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

        // GET: CustomeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CustomeController/Delete/5
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
