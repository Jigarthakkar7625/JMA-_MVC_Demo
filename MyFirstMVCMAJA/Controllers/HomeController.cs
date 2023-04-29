using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstMVCMAJA.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {

            //Session["Userid"] = 10;

            var Userid = Session["UserId"];
            var EmailId = Session["EmailId"];

            var studentid = TempData["StudentId"];

            TempData.Keep("StudentId");

            // View Result
            return View();

            //return File(Url.Content("~/CustomFiles/hello.txt"), "text/plain", "testFile.txt");

            // Partial View
            //return PartialView("_PartialView");

            // JSON Result
            //return Json(new { FirstName = "jigar", Id = 2 }, JsonRequestBehavior.AllowGet);

        }

        public JsonResult jsonResult()
        {
            // View Result
            //return View("About");

            // Partial View
            //return PartialView("_PartialView");

            // JSON Result
            //return Json(new { FirstName = "jigar", Id = 2 }, JsonRequestBehavior.AllowGet);
            var persons = new List<Person>
           {
                new Person{Id=1, FirstName="Harry", LastName="Potter"},
                new Person{Id=2, FirstName="James", LastName="Raj"}
           };
            return Json(persons, "application/json", System.Text.Encoding.UTF8, JsonRequestBehavior.AllowGet);


        }

        [HttpGet]
        public JavaScriptResult WarningMessage()
        {
            var msg = "alert('Are you sure want to Continue?');";
            return new JavaScriptResult() { Script = msg };
        }

        [HttpGet]
        public FileResult File()
        {
            //return File(Url.Content("~/Files/SimpleText.txt"), "text/plain");

            return File(Url.Content("~/DownloadFiles/hello.txt"), "text/plain", "testFile.txt");

            //byte[] fileBytes = System.IO.File.ReadAllBytes(Server.MapPath("~/Files/SimpleText.txt"));
            //return File(fileBytes, "text/plain");
        }

        public class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        public ActionResult Index1()
        {
            // View Result
            return Content("Jigar Thakkar");
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


        public ActionResult Demo()
        {
            ViewBag.Message = "Demo Application Page.";

            return View();
        }
    }
}