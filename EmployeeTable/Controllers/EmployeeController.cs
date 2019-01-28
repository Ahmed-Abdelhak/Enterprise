using EmployeeTable.Models;
using EmployeeTable.Models.Entities;
using EmployeeTable.ViewModels;
using System.Data.Entity;
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


            return View(_context.Employees.Include(e=> e.Department).ToList());
        }

        [HttpGet]
        public ActionResult Add()
        {
            var employeeVm = new EmployeeViewModel()
            {
              Departments = _context.Departments.ToList()
            };

            
            return View(employeeVm);
        }

        [HttpPost]
        public ActionResult Add(Employee Employee)
        {
            var employeeVm = new EmployeeViewModel()
            {
                Departments = _context.Departments.ToList()
            };

            if (ModelState.IsValid)
            {
                _context.Employees.Add(Employee);
                _context.SaveChanges();
                return RedirectToAction("Index");      // return the redirected view of the Index  (table after adding)
            }



            return View(employeeVm);
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
            var employeeVm = new EmployeeViewModel()
            {
                Departments = _context.Departments.ToList(),
                Employee = _context.Employees.Find(id)
            };
            return View(employeeVm);
        }

        [HttpPost]
        public ActionResult Edit(Employee employee)    // the object sent by the submit button of the edit page !
        {
            if (ModelState.IsValid)
            {
                var emp = _context.Employees.Find(employee.Id);
                emp.Name = employee.Name;
                emp.Age = employee.Age;
                emp.Gender = employee.Gender;
                emp.Department = employee.Department;
                emp.Fk_DepartmentId = employee.Fk_DepartmentId;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            var employeeVm = new EmployeeViewModel()
            {
                Departments = _context.Departments.ToList(),

            };

            return View(employeeVm);
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
