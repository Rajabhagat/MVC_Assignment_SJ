using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication_SJ.Models;

namespace WebApplication_SJ.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [Route("Home/About")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [Route ("Home/Student_info")]
        public ActionResult Student_info() 
        {
            ViewBag.Message = "this is student page.";
            var stud = new Students();

            return View(stud);
        }
        [HttpPost]

        public ActionResult Student_info(Students std) 
        {
            if (!ModelState.IsValid)
            {
                return View(std);
            }
            else 
            {
                return RedirectToAction("Student_info", "Home");
            }
        
        }
    }
}