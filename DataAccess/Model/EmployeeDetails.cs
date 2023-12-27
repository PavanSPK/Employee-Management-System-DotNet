using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model
{
    public class EmployeeDetails
    {
        [Key]
        public int EmployeeID { get; set; }
        public string EmployeeFullName { get; set; }
        public string EmployeeAddress { get; set; }
        public long EmployeePhone { get; set; }
        public string EmployeeCompany { get; set; }
        public DateTime EmployeeJoinDate { get; set; }
        [Column(TypeName = "numeric(4,2)")]
        public decimal EmployeeExperience { get; set; }
        public string EmployeeCareerLevel { get; set; }
        public string EmployeeSkill { get; set; }
        public DateTime OffShoreStartDate { get; set; }
        public DateTime OffShoreEndDate { get; set; }
    }
}
