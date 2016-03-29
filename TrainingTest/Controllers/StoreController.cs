using System;
using System.Web.Mvc;

namespace TrainingTest.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Browse()
        {
            return View();
        }
        public ActionResult Details()
        {
            ViewBag.Message = "This is sent from the controller";
            return View();
        }
    }
}