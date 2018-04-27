using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class BloodTypesController : Controller
    {
        // GET: BloodTypes
        public ActionResult Index()
        {
            return View();
        }
    }
}