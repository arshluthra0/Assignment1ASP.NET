using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage ="Please enter username")]
        public string UserName {  get; set;}

        [Required(ErrorMessage ="Please enter password")]
        [StringLength(6, ErrorMessage ="Password length is not correct")]
        public string Password {  get; set;}    
    }
}
