using HtmlReporting.Models;
using HtmlReporting.T4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace HtmlReporting.Controllers
{
    public class HomeController : Controller
    {
        
        // GET: Home
        public ActionResult Index()
        {
            var model = new List<string>() {"Menaka", "Gregor", "Pri", "Vinitha", "Daya", "Karu", "Golda" };

            var model1 = new List<EmployeeMetadata>() {
                new EmployeeMetadata() {Id=1, FullName="Menaka", Gender="F", HireDate=DateTime.Now, Salary=1000, EmailAddress="abc@at", PersonalWebSite="df" },
                new EmployeeMetadata() {Id=1, FullName="Gregor", Gender="M", HireDate=DateTime.Now, Salary=2000, EmailAddress="bbb@at", PersonalWebSite="bb" }
            };

            var model2 = new EmployeeMetadata() { Id = 1, FullName = "Menaka", Gender = "F", HireDate = DateTime.Now, Salary = 1000, EmailAddress = "abc@at", PersonalWebSite = "df" };

            // Create Html from T4 Template
            TextTemplate html = new TextTemplate();
            string pageContent = html.TransformText();

            // Test T4 with parameters
            RuntimeTextTemplate1 blogPost = new RuntimeTextTemplate1();
            blogPost.Session = new System.Collections.Generic.Dictionary<string, object>();
            blogPost.Session.Add("Title", "Demo - Generate Html From T4 Template @Runtime");
            blogPost.Session.Add("Author", "Menaka Satti");
            blogPost.Session.Add("Text", "This is only Demo to see the technical possibility.");
            blogPost.Session.Add("Date", DateTime.Now.Date);
            blogPost.Session.Add("Category", "T4");
            blogPost.Session.Add("Tags", new List<string>(){ "Menaka", "Html"});
            blogPost.Initialize(); // Sets the parameters from the session
            var innerHTML = blogPost.TransformText(); // runs the transform 

            // test T4 for using Shared Templates
            //CallSharedHeaderTemplate t1 = new CallSharedHeaderTemplate();
            //string result = t1.TransformText();

            // test : CallAbstractT4
            CallAbstractT4 t1 = new CallAbstractT4();
            string result = t1.TransformText();


            return View(model2);
        }

        public ActionResult Employee1()
        {
            var model1 = new List<EmployeeMetadata>() {
                new EmployeeMetadata() {Id=1, FullName="Menaka", Gender="F", HireDate=DateTime.Now, Salary=1000, EmailAddress="abc@at", PersonalWebSite="df" },
                new EmployeeMetadata() {Id=2, FullName="Gregor", Gender="M", HireDate=DateTime.Now, Salary=2000, EmailAddress="bbb@at", PersonalWebSite="bb" }
            };

            return View(model1);
        }
    }


}