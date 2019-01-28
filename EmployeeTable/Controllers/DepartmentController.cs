using EmployeeTable.Models;
using EmployeeTable.Models.Entities;
using EmployeeTable.ViewModels;
using System.Linq;
using System.Web.Mvc;

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




        public ActionResult InlineEdit(int id)
        {
            var deptVm = new DepartmentViewModel();
            deptVm.Id = id;
            
            deptVm.Departments = _context.Departments.ToList();
            return View(deptVm);
        }

        [HttpPost]
        public ActionResult InlineEdit(Department e)
        {
            if (ModelState.IsValid)
            {
                var dep = _context.Departments.Find(e.Id);
                if (dep != null) dep.Name = e.Name;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }


        public bool Delete(int id)
        {

            var removed = _context.Departments.Find(id);

            if (removed != null) _context.Departments.Remove(removed);

            int res = _context.SaveChanges();             // return will be received by the data of success function in AJAX
            //return RedirectToAction("Index");

            return res > 0;        // return a boolean to the AJAX request   if delete is success from DB, please eliminate this element from FrontEnd
        }
    }
}