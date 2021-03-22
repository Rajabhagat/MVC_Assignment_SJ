using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication_SJ.Models;

namespace WebApplication_SJ.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
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