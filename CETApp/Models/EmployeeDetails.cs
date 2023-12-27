using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace CETApp.Models
{
    public class EmployeeDetails
    {
        public int EmployeeID { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Employee Name")]
        public string EmployeeFullName { get; set; }
        [Required]
        [StringLength(200)]
        [Display(Name = "Employee Address")]
        public string EmployeeAddress { get; set; }
        [Required]
        
        [Display(Name = "Phone")]
        public long EmployeePhone { get; set; }
        [Required]
        [MaxLength(50)]
        [Display(Name = "Company")]
        public string EmployeeCompany { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name ="Join Date")]
        public DateTime EmployeeJoinDate { get; set; }
        [Required]
        [Column(TypeName = "numeric(4,2)")]
        [Display(Name = "Experience (In years)")]
        public decimal EmployeeExperience { get; set; }
        [Required]
        [MaxLength(20)]
        [Display(Name = "Career Level")]
        public string EmployeeCareerLevel { get; set; }
        [Required]
        [MaxLength(200)]
        [Display(Name = "Skills (Enter seperated by comma)")]
        public string EmployeeSkill { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Off Shore Start Date")]
        public DateTime OffShoreStartDate { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Off Shore End Date")]
        public DateTime OffShoreEndDate { get; set; }
    }
}
