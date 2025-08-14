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

        }

    }
}