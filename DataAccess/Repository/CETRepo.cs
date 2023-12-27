using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class CETRepo : ICETRepo
    {
        private CETDbContext _dbContext;
        public CETRepo()
        {
            _dbContext = new CETDbContext();
        }

        public bool AddEmployee(EmployeeDetails employees)
        {
            if (employees == null)
                return false;
            try
            {
                _dbContext.EmployeeDetails.Add(employees);
                _dbContext.SaveChanges();
            }
            catch 
            {
                return false;
            }
            return true;
        }

        public bool RegisterUser(UserDetails user)
        {
            if (user == null)
                return false;
            try
            {
                _dbContext.UserDetails.Add(user);
                _dbContext.SaveChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }

       public bool DeleteEmployee(int id)
        {
            EmployeeDetails employee = null;
            try
            {
                employee = _dbContext.EmployeeDetails.Find(id);
                _dbContext.EmployeeDetails.Remove(employee);
                _dbContext.SaveChanges();
            }
            catch { return false; }
            return true;
        }

        public EmployeeDetails FindByPK(int id)
        {
            EmployeeDetails employees = null;
            try
            {
                employees = _dbContext.EmployeeDetails.Find(id);
            }
            catch
            {
                return null;
            }
            return employees;
        }

        public List<EmployeeDetails> GetEmployeeList()
        {
            return _dbContext.EmployeeDetails.ToList();
        }

        public bool UpdateEmployee(EmployeeDetails employeeinfo)
        {
            if (employeeinfo == null)
                return false;
            EmployeeDetails employees = null;
            try
            {
                employees = _dbContext.EmployeeDetails.Find(employeeinfo.EmployeeID);
                employees.EmployeeFullName = employeeinfo.EmployeeFullName;
                employees.EmployeeAddress = employeeinfo.EmployeeAddress;
                employees.EmployeePhone = employeeinfo.EmployeePhone;
                employees.EmployeeCompany = employeeinfo.EmployeeCompany;
                employees.EmployeeJoinDate = employeeinfo.EmployeeJoinDate;
                employees.EmployeeExperience = employeeinfo.EmployeeExperience;
                employees.EmployeeCareerLevel = employeeinfo.EmployeeCareerLevel;
                employees.EmployeeSkill = employeeinfo.EmployeeSkill;
                employees.OffShoreStartDate = employeeinfo.OffShoreStartDate;
                employees.OffShoreEndDate = employeeinfo.OffShoreEndDate;
                _dbContext.SaveChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }


        public UserDetails AuthenticateUser(string UserEmailId, string UserPassword)
        {
            UserDetails userDetails = null;
            try
            {
                userDetails = _dbContext.UserDetails.Where(u => u.UserEmailId == UserEmailId &&
                u.UserPassword == UserPassword).FirstOrDefault();
            }
            catch
            {
                userDetails= null;
            }
            return userDetails;
        }
    }
}
