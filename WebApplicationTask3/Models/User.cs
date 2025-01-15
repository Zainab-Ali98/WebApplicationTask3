using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplicationTask3.Models.SharedProp;

namespace WebApplicationTask3.Models
{
    public class User:BaseProp
    {
        [Display(Name = "Employee ID")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Enter Name")]
        [MinLength(3, ErrorMessage = "At least 3 char")]
        public string Name { get; set; }

        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "Enter Email")]
        public  string Email { get; set; }

        [DataType(DataType.Password)]
        public int Password { get; set; }

      
        [ForeignKey("Role")]
        public int RoleId { get; set; }

        public Role? Role { get; set; }
    }
}
