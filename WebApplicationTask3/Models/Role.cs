using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using WebApplicationTask3.Models.SharedProp;

namespace WebApplicationTask3.Models
{
    public class Role:BaseProp
    {
        public int Id { get; set; }


        [DisplayName("User Name")]
        [Required(ErrorMessage = "Enter Name")]
        public string RoleName { get; set; }
    }
}
