using EmployeeTable.Models;
using EmployeeTable.Models.Entities;
using EmployeeTable.ViewModels;
using System.Linq;
using System.Web.Mvc;

namespace EmployeeTable.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmpContext _context;

        public EmployeeController()
        {
            _context = new EmpContext();
        }


        public ActionResult Index()
        {

            return View(_context.Employees.ToList());
        }

        [HttpGet]
        public ActionResult Add()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult Add(Employee e)
        {
            if (ModelState.IsValid)
            {
                _context.Employees.Add(e);
                _context.SaveChanges();
                return RedirectToAction("Index");      // return the redirected view of the Index  (table after adding)
            }



            return View();
        }

        public ActionResult InlineEdit(int id)
        {
            var empVM = new EmployeeViewModel();
            empVM.Id = id;
            empVM.Employees = _context.Employees.ToList();
            return View(empVM);
        }

       [HttpPost]
        public ActionResult InlineEdit(Employee e)
        {
            if (ModelState.IsValid)
            {
                var emp = _context.Employees.Find(e.Id);
                emp.Name = e.Name;
                emp.Age = e.Age;
                emp.Gender = e.Gender;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }


        public ActionResult Edit(int id)
        {
            //var emp = context.Employees.Where(e => e.Name == "Osama").FirstOrDefault();   // this if you want to search by NAME

            var e = _context.Employees.Find(id);
            return View(e);       // i want to render an employee edit fields, so i need to send an employee to the VIEW !
                                  // but which employee ? the one in the list whose ID matches the received id !
        }

        [HttpPost]
        public ActionResult Edit(Employee e)    // the object sent by the submit button of the edit page !
        {
            if (ModelState.IsValid)
            {
                var emp = _context.Employees.Find(e.Id);
                emp.Name = e.Name;
                emp.Age = e.Age;
                emp.Gender = e.Gender;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }

        public ActionResult Delete(int id)
        {
            var eRemoved = _context.Employees.Find(id);
            if (eRemoved != null)
                _context.Employees.Remove(eRemoved);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
