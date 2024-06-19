using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filters_Project2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            try { throw new Exception("It a Exception"); }
            catch (Exception ) {
                return RedirectToAction("Index", "Error"); 
            }
            

        }
    }
}