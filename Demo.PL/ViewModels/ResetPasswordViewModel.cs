using System.ComponentModel.DataAnnotations;

namespace Demo.PL.ViewModels
{
    public class ResetPasswordViewModel
    {
        [Required(ErrorMessage ="New Password Is Required")]
        [DataType(DataType.Password)]
        public  string NewPassword { get; set; }
        [Required(ErrorMessage = "Confrim Password Is Required")]
        [DataType(DataType.Password)]
        [Compare("NewPassword",ErrorMessage ="Password Doesn't Match")]
        public string ConfirmPassword { get; set; }
    }
}
