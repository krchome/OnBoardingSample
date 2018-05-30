using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KeyOnboardVer_3.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetAllProducts()
        {
            var list = new[] { new {Id = 1, Name = "Ham"}, new { Id = 2, Name = "Beers" } }.ToList();
            return Json(list, JsonRequestBehavior.AllowGet);
        }
    }
}