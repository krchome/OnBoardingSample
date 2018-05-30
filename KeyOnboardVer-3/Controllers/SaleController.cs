using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KeyOnboardVer_3.Controllers
{
    public class SaleController : Controller
    {
        // GET: Sale
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetAllSales()
        {
            var list = new[] { new { Id = 1, Customer = "Vincent", CustomerId = 1 , Product = "Beers" , ProductId = 2, Store = "Super Market", StoreId = 1, DateSold = DateTime.Now},
                               new { Id = 2, Customer = "Paul", CustomerId = 2 ,Product = "Ham" , ProductId = 1, Store = "Your Local Supply", StoreId = 2, DateSold = DateTime.Now}
            }.ToList();
            return Json(list, JsonRequestBehavior.AllowGet);
        }
    }
}