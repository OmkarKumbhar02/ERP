using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace P2PErpProject.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Details()
        {
            //Helolo
            //Chnaged
            return View();
        }
        public ActionResult Delete(int id)
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Edit(int id)
        {
            return View();
        }
        public ActionResult Update(int id)
        {
            return View();
        }
        public ActionResult inttt()
        {
            return View();
        }
        public string Ash()
        {
            return "ash";
        }
    }
}