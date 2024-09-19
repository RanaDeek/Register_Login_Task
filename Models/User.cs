using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace Register_Login_Task.Models
{
    public class User
    {
        public int Id { get; set; }
        [Display(Name = "User Name")]
        [DataType("varchar")]
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }
        [Display(Name = "User Email")]
        [DataType(DataType.EmailAddress)]
        [Required]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        [MaxLength(20)]
        [Required]
        public string Password { get; set; }
        public bool Active { get; set; }
    }
}
