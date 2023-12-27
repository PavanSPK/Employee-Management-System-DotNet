using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface ICETRepo
    {
        public UserDetails AuthenticateUser(string UserEmailId, string UserPassword);
        public bool RegisterUser(UserDetails user);
        public bool AddEmployee(EmployeeDetails employee);
        public bool UpdateEmployee(EmployeeDetails employeeinfo);
        public bool DeleteEmployee(int id);
        public List<EmployeeDetails> GetEmployeeList();
        public EmployeeDetails FindByPK(int id);
        
    }
}
