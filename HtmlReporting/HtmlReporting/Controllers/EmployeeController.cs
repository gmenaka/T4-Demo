using HtmlReporting.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HtmlReporting.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            var model1 = new List<EmployeeMetadata>() {
                new EmployeeMetadata() {Id=1, FullName="Menaka", Gender="F", HireDate=DateTime.Now, Salary=1000, EmailAddress="abc@at", PersonalWebSite="df" },
                new EmployeeMetadata() {Id=1, FullName="Gregor", Gender="M", HireDate=DateTime.Now, Salary=2000, EmailAddress="bbb@at", PersonalWebSite="bb" }
            };
            return View(model1);
        }
    }
}