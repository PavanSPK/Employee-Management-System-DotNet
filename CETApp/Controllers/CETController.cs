using CETApp.Models;
using DataAccess.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CETApp.Controllers
{
    public class CETController : Controller
    {
        private static ICETRepo _repo;
        public CETController(ICETRepo repo)
        {
            _repo = repo;
        }


        [HttpGet]
        public ActionResult AddEmployee()
        {
            if (HttpContext.Session.GetString("emailid") == null)
            {
                return RedirectToAction("Index", "User");
            }
            return View();
        }

        [HttpPost]
        public ActionResult AddEmployee(EmployeeDetails employees)
        {
            if (HttpContext.Session.GetString("emailid") == null)
            {
                return RedirectToAction("Index", "User");
            }

            if (ModelState.IsValid)
            {
                DataAccess.Model.EmployeeDetails temp = new DataAccess.Model.EmployeeDetails();
                temp.EmployeeID = employees.EmployeeID;
                temp.EmployeeFullName = employees.EmployeeFullName;
                temp.EmployeeAddress = employees.EmployeeAddress;
                temp.EmployeePhone = employees.EmployeePhone;
                temp.EmployeeCompany = employees.EmployeeCompany;
                temp.EmployeeJoinDate = employees.EmployeeJoinDate;
                temp.EmployeeExperience = employees.EmployeeExperience;
                temp.EmployeeCareerLevel = employees.EmployeeCareerLevel;
                temp.EmployeeSkill = employees.EmployeeSkill;
                temp.OffShoreStartDate = employees.OffShoreStartDate;
                temp.OffShoreEndDate = employees.OffShoreEndDate;

                bool result = _repo.AddEmployee(temp);
                if (!result)
                    View("Error");
            }
            return RedirectToAction("ListAllEmployee");
        }

        public ActionResult ListAllEmployee()
        {
            if (HttpContext.Session.GetString("emailid") == null)
            {
                return RedirectToAction("Index", "User");
            }
            List<DataAccess.Model.EmployeeDetails> entityemployees = _repo.GetEmployeeList();
            List<CETApp.Models.EmployeeDetails> employees = new List<CETApp.Models.EmployeeDetails>();
            foreach (var item in entityemployees)
            {
                CETApp.Models.EmployeeDetails temp = new CETApp.Models.EmployeeDetails();
                temp.EmployeeID = item.EmployeeID;
                temp.EmployeeFullName = item.EmployeeFullName;
                temp.EmployeeAddress = item.EmployeeAddress;
                temp.EmployeePhone = item.EmployeePhone;
                temp.EmployeeCompany = item.EmployeeCompany;
                temp.EmployeeJoinDate = item.EmployeeJoinDate;
                temp.EmployeeExperience = item.EmployeeExperience;
                temp.EmployeeCareerLevel = item.EmployeeCareerLevel;
                temp.EmployeeSkill = item.EmployeeSkill;
                temp.OffShoreStartDate = item.OffShoreStartDate;
                temp.OffShoreEndDate = item.OffShoreEndDate;
                employees.Add(temp);
            }
            return View(employees);
        }

        [HttpGet]
        public ActionResult UpdateEmployee(int id)
        {
            if (HttpContext.Session.GetString("emailid") == null)
            {
                return RedirectToAction("Index", "User");
            }
            DataAccess.Model.EmployeeDetails find = _repo.FindByPK(id);

            CETApp.Models.EmployeeDetails temp = new CETApp.Models.EmployeeDetails();
            if (find != null)
            {
                temp.EmployeeID = find.EmployeeID;
                temp.EmployeeFullName = find.EmployeeFullName;
                temp.EmployeeAddress = find.EmployeeAddress;
                temp.EmployeePhone = find.EmployeePhone;
                temp.EmployeeCompany = find.EmployeeCompany;
                temp.EmployeeJoinDate = find.EmployeeJoinDate;
                temp.EmployeeExperience = find.EmployeeExperience;
                temp.EmployeeCareerLevel = find.EmployeeCareerLevel;
                temp.EmployeeSkill = find.EmployeeSkill;
                temp.OffShoreStartDate = find.OffShoreStartDate;
                temp.OffShoreEndDate = find.OffShoreEndDate;
            }
            else
                return View("Error");
            return View(temp);
        }

        [HttpPost]
        public ActionResult UpdateEmployee(EmployeeDetails employees)
        {
            if (HttpContext.Session.GetString("emailid") == null)
            {
                return RedirectToAction("Index", "User");
            }
            DataAccess.Model.EmployeeDetails temp = new DataAccess.Model.EmployeeDetails();

            temp.EmployeeID = employees.EmployeeID;
            temp.EmployeeFullName = employees.EmployeeFullName;
            temp.EmployeeAddress = employees.EmployeeAddress;
            temp.EmployeePhone = employees.EmployeePhone;
            temp.EmployeeCompany = employees.EmployeeCompany;
            temp.EmployeeJoinDate = employees.EmployeeJoinDate;
            temp.EmployeeExperience = employees.EmployeeExperience;
            temp.EmployeeCareerLevel = employees.EmployeeCareerLevel;
            temp.EmployeeSkill = employees.EmployeeSkill;
            temp.OffShoreStartDate = employees.OffShoreStartDate;
            temp.OffShoreEndDate = employees.OffShoreEndDate;

            bool result = _repo.UpdateEmployee(temp);
            if (!result)
                View("Error");
            return RedirectToAction("ListAllEmployee");
        }


        [HttpGet]
        public ActionResult DetailsEmployee(int id) 
        {
            if (HttpContext.Session.GetString("emailid") == null)
            {
                return RedirectToAction("Index", "User");
            }

            DataAccess.Model.EmployeeDetails find = _repo.FindByPK(id);

            CETApp.Models.EmployeeDetails temp = new CETApp.Models.EmployeeDetails();
            if (find != null)
            {
                temp.EmployeeID = find.EmployeeID;
                temp.EmployeeFullName = find.EmployeeFullName;
                temp.EmployeeAddress = find.EmployeeAddress;
                temp.EmployeePhone = find.EmployeePhone;
                temp.EmployeeCompany = find.EmployeeCompany;
                temp.EmployeeJoinDate = find.EmployeeJoinDate;
                temp.EmployeeExperience = find.EmployeeExperience;
                temp.EmployeeCareerLevel = find.EmployeeCareerLevel;
                temp.EmployeeSkill = find.EmployeeSkill;
                temp.OffShoreStartDate = find.OffShoreStartDate;
                temp.OffShoreEndDate = find.OffShoreEndDate;
            }
            else
                return View("Error");
            return View(temp);
        }


        [HttpGet]
        public ActionResult Delete(int id)
        {
            if (HttpContext.Session.GetString("emailid")==null)
            {
                return RedirectToAction("Index", "User");
            }
            DataAccess.Model.EmployeeDetails find = _repo.FindByPK(id);
            CETApp.Models.EmployeeDetails temp = new CETApp.Models.EmployeeDetails();
            if (find != null)
            {
                temp.EmployeeID = find.EmployeeID;
                temp.EmployeeFullName = find.EmployeeFullName;
                temp.EmployeeAddress = find.EmployeeAddress;
                temp.EmployeePhone = find.EmployeePhone;
                temp.EmployeeCompany = find.EmployeeCompany;
                temp.EmployeeJoinDate = find.EmployeeJoinDate;
                temp.EmployeeExperience = find.EmployeeExperience;
                temp.EmployeeCareerLevel = find.EmployeeCareerLevel;
                temp.EmployeeSkill = find.EmployeeSkill;
                temp.OffShoreStartDate = find.OffShoreStartDate;
                temp.OffShoreEndDate = find.OffShoreEndDate;
            }
            else
                return View("Error");
            return View(temp);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirm(int id)
        {
            if (HttpContext.Session.GetString("emailid")==null)
            {
                return RedirectToAction("Index", "User");
            }
            bool result = _repo.DeleteEmployee(id);
            if (!result)
                return View("Error");
            return RedirectToAction("ListAllEmployee");
        }

    }
}
