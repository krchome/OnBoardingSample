using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KeyOnboardVer_3.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetAllStores()
        {
            var list = new[] { new { Id = 1, Name = "Super Market" }, new { Id = 2, Name = "Your Local Supply" } }.ToList();
            return Json(list, JsonRequestBehavior.AllowGet);
        }
    }
}