using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StaffClient.StaffService;

namespace StaffClient.Controllers
{
    
    public class HomeController : Controller
    {
        StaffService.Service1Client service = new StaffService.Service1Client();
        public ActionResult Index()
        {
            return View();
        }


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
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            service.AddEmployyee(employee);
            return RedirectToAction("ListEmployee");

        }

        public ActionResult ListEmployee()
        {
            return View();
        }
    }
    
}