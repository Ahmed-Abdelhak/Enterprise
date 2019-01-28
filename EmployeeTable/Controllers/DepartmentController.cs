using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeeTable.Models;
using EmployeeTable.Models.Entities;

namespace EmployeeTable.Controllers
{
    public class DepartmentController : Controller
    {

        private readonly EmpContext _context;

        public DepartmentController()
        {
            _context = new EmpContext();
        }

        // GET: Department
        public ActionResult Index()
        {
            return View(_context.Departments.ToList());
        }

        public ActionResult Add()
        {
            return View();

        }


        [HttpPost]
        public ActionResult Add(Department dep)
        {
            if (ModelState.IsValid)
            {
                _context.Departments.Add(dep);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();

        }

        public ActionResult Edit()
        {

            return View();
        }

          [HttpPost]
        public ActionResult Edit(Department dept)
          {
              if (ModelState.IsValid)
              {
                  var old = _context.Departments.Find(dept.Id);
                  old.Id = dept.Id;
                  old.Name = dept.Name;
                  _context.SaveChanges();
                  return RedirectToAction("Index");

              }

              return View("Index");
          }

        public ActionResult Delete(int id)
        {

            var removed = _context.Departments.Find(id);

            if (removed != null) _context.Departments.Remove(removed);

            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}