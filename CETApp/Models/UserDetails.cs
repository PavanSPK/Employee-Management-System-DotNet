using System.ComponentModel.DataAnnotations;
namespace CETApp.Models
{
    public class UserDetails
    {
        [Required]
        public int UserID { get; set; }
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string EmailId { get; set; }
        [Required]
        [StringLength(50)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
