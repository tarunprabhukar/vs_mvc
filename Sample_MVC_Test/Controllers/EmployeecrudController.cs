using Sample_MVC_Test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sample_MVC_Test.Controllers
{
    public class EmployeecrudController : Controller
    {
        // GET: Employeecrud
        public ActionResult Index()
        {
            var employees = from e in GetEmployeeList()
                            orderby e.ID
                            select e;
            return View(employees);
        }

        // GET: Employeecrud/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Employeecrud/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employeecrud/Create
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

        // GET: Employeecrud/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Employeecrud/Edit/5
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

        // GET: Employeecrud/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Employeecrud/Delete/5
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

        public List<Employee> GetEmployeeList()
        {
            return new List<Employee>
            {
                new Employee
                {
                    ID=1,
                    Age=25,
                    JoiningDate=DateTime.Parse(DateTime.Today.ToString()),
                    name="allan"
                },
                new Employee
                {
                     ID=2,
                    Age=26,
                    JoiningDate=DateTime.Parse(DateTime.Today.ToString()),
                    name="Ben"
                },
                new Employee
                {
                     ID=3,
                    Age=27,
                    JoiningDate=DateTime.Parse(DateTime.Today.ToString()),
                    name="Cannon"
                },
                new Employee
                {
                     ID=4,
                    Age=28,
                    JoiningDate=DateTime.Parse(DateTime.Today.ToString()),
                    name="Dora"
                }

            };

        }
    }
}
