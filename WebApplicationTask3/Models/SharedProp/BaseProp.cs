using System.ComponentModel;

namespace WebApplicationTask3.Models.SharedProp
{
    public class BaseProp
    {
        [DisplayName("Deleted")]
        public bool IsDeleted { get; set; }

        [DisplayName("Active")]
        public bool IsActive { get; set; }
    }
}
