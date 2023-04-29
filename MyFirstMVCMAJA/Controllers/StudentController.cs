using MyFirstMVCMAJA.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;

namespace MyFirstMVCMAJA.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student

        //localHost/Student/Index

        [HttpGet]
        public ActionResult Index()
        {


            HttpCookie httpCookie = new HttpCookie("MyCookie");

            httpCookie.Value = "This is my Cookie " + DateTime.Now.ToShortDateString();

            this.ControllerContext.HttpContext.Response.Cookies.Add(httpCookie);


            //Session["UserId"] = 10;
            //Session["EmailId"] = "jigar@gmail.com";

            //Server side
            //ASP.NET Session / View state
            // ViewData
            // Viewbag
            // Tempdata

            //StudentModel studentModel = new StudentModel();

            MyDBJMAAEntities2 myDBJMAAEntities = new MyDBJMAAEntities2();

            //var studentlist = myDBJMAAEntities.Students.ToList(); // Method syntax


            //ViewBag.StudentId = studentlist; // Object // List // Anything you can store in View Bag

            //// Controller to View  >> Data pass karva mate
            //ViewBag.StudentId = studentlist; // Object // List // Anything you can store in View Bag // Dynamic

            //// Controller to View  >> Data pass karva mate
            //ViewData["StudentId"] = studentlist; // Type casting


            //// Controller to Controller  >> Data pass karva mate
            //TempData["StudentId"] = studentlist; // Type casting



            //return RedirectPermanent("https://www.c-sharpcorner.com/members/farhan-ahmed24");

            User studentModel = new User();

            studentModel = myDBJMAAEntities.Users.FirstOrDefault();
            studentModel.StudentSecondAddress = "Address";


            ViewBag.User = myDBJMAAEntities.Users.ToList();


            return View(studentModel);

            //return RedirectToAction("","",)

            //return Redirect("https://showit.tech/");
            //return Redirect("/home/index");

            // Partial View

            //StudentModel studentModel = new StudentModel();
            //return PartialView("_MyPartialView",mod);

            // View Result

            //return View();
            //StudentModel studentModel = new StudentModel();
            //return View("About", studentModel);

            //MyDBJMAAEntities1 myDBJMAAEntities = new MyDBJMAAEntities1();

            //var studentlist = myDBJMAAEntities.Students.ToList(); // Method syntax


            ////MyDBJMAAEntities myDBJMAAEntities = new MyDBJMAAEntities();

            ////var list = myDBJMAAEntities.Students.ToList();


            /////Database connection

            //// ADO.NET

            //string connection = System.Configuration.ConfigurationManager.ConnectionStrings["conn"].ConnectionString;

            //SqlConnection conn = new SqlConnection(connection);

            //DataSet ds = new DataSet(); // Multiple data table
            //DataTable dt = new DataTable(); // Only one table

            ////SqlCommand sqlCommand = new SqlCommand("INSERT INTO [dbo].[Student] values('Jigar33333',1)", conn); // Inline Query 

            ////SqlCommand sqlCommand = new SqlCommand("SP_GetData", conn); // Store procedure
            ////sqlCommand.CommandType = CommandType.StoredProcedure;
            ////sqlCommand.Parameters.AddWithValue("@courseId", 1);
            ////sqlCommand.Parameters.AddWithValue("@studentName", "Mehul 12345");
            ////sqlCommand.Parameters.AddWithValue("@address", "Adresss122323");

            //SqlCommand sqlCommand = new SqlCommand("GetMultipleData", conn); // Store procedure
            //sqlCommand.CommandType = CommandType.StoredProcedure;
            //sqlCommand.Parameters.AddWithValue("@studentId", 1);
            ////sqlCommand.Parameters.AddWithValue("@studentName", "Mehul 12345");
            ////sqlCommand.Parameters.AddWithValue("@address", "Adresss122323");

            //SqlDataAdapter adpt = new SqlDataAdapter();
            //adpt.SelectCommand = sqlCommand;
            //adpt.Fill(ds);


            ////conn.Open();

            ////sqlCommand.ExecuteNonQuery();

            ////conn.Close();

            ////SqlDataAdapter adpt = new SqlDataAdapter("Select * from Student", conn);
            ////adpt.Fill(dt);




            ////sqlCommand.Connection = conn;

            ////conn.Open();

            ////SqlDataReader dr = sqlCommand.ExecuteReader();

            ////while (dr.Read())
            ////{
            ////    Console.WriteLine(dr.ToString());

            ////    var a = dr["StudentId"];
            ////    // 
            ////}


            ////conn.Close();





            //StudentModel studentModel = new StudentModel();
            //studentModel.StudentId = 10;
            //studentModel.StudentName = "Jigar";

            //return View(studentModel);
        }


        [HttpGet]
        public JsonResult JOSNRender()
        {

            Customer customer = new Customer();
            customer.Username = "Jigar";
            customer.password = "fasf";
            return Json(customer, JsonRequestBehavior.AllowGet);

        }




        [HttpGet]
        public JavaScriptResult javascriptResult(int id)
        {


            //// Database >> Record from database based on ID
            //// 
            var abc = " you are not allowd to go in this page!!";

            JavaScriptResult javaScriptResult = new JavaScriptResult() { Script = abc };

            return javaScriptResult;

        }


        [HttpGet]
        public FileResult FileDownload()
        {

            return File(Server.MapPath("~/CustomFiles/Hello.txt"), "text/plain", "Hello123.txt");

        }

        public class Customer
        {
            public string Username { get; set; }
            public string password { get; set; }

        }



        [HttpPost]
        public ActionResult Index(StudentModel studentModel)
        {

            //StudentModel studentModel = new StudentModel();
            //studentModel.StudentId = 10;
            //studentModel.StudentName = "Jigar";

            return View(studentModel);
        }

        // GET: Student/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Student/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Student/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
