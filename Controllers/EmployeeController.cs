using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCTraining.Models;
using MVCTraining.ViewModels;

namespace MVCTraining.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            var EL = new EmployeeLayer();
            Employee employee = EL.GetEmployeeDetails(EmployeeId: 101);
            return View(employee);
        }
    }
}