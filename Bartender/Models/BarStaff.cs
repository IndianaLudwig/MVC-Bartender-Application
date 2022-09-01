using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bartender.Models
{
    public class BarStaff
    {
        [Key]
        public int StaffID { get; set; }

        [Required(ErrorMessage = "Username is required")]
        public string StaffUsername { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [PasswordPropertyText]
        public string StaffPassword { get; set; }
    }
}
