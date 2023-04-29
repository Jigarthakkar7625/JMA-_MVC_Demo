using MyFirstMVCMAJA.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstMVCMAJA.Controllers
{
    public class EmployeeController : Controller
    {
        MyDBJMAAEntities2 MyDBJMAAEntities2 = new MyDBJMAAEntities2();
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(EmployeeModel employeeModel)
        {

            Employee employee = new Employee();
            employee.EmployeeName = employeeModel.EmployeeName;
            employee.Code = "RDTT78";

            MyDBJMAAEntities2.Employees.Add(employee);
            MyDBJMAAEntities2.SaveChanges();

            return View();
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
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

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            EmployeeModel employeeModel = new EmployeeModel();
            employeeModel.EmployeeId = id;

            var employee = MyDBJMAAEntities2.Employees.Where(x => x.EmployeeID == id).FirstOrDefault();
            var employee1 = MyDBJMAAEntities2.Employees.Find(id);

            employeeModel.EmployeeName = employee.EmployeeName;
            return View(employeeModel);
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, EmployeeModel employeeModel)
        {
            try
            {
                var employee = MyDBJMAAEntities2.Employees.Where(x => x.EmployeeID == id).FirstOrDefault();
                employee.EmployeeName = employeeModel.EmployeeName;
                MyDBJMAAEntities2.SaveChanges();

                if (!ModelState.IsValid)
                {

                }

                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Employee/Delete/5
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
