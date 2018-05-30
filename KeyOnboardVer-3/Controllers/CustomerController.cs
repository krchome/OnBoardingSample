using KeyOnboardVer_3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KeyOnboardVer_3.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {

            return View();
        }

        public JsonResult GetAllCustomer()
        {
            
            var list = new[] { new { Id = 1, Name = "Vincent", Address = "Auckland" }, new{Id =2, Name = "Paul", Address = "Papatoetoe" } }.ToList();
            return Json(list, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult SaveCustomer(CustomerViewModel model)
        {
            // Now Add or edit to your table

            return Json(new { Success = true });
        }
    }
}