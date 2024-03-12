using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Validate.Models.ViewModels
{
    public class RegisterViewModel
    {
        [DisplayName("Tên đăng nhập")]
        [Required(ErrorMessage ="ko hợp lệ")]
        [StringLength(20,MinimumLength =3,ErrorMessage ="tk từ 3-20 kí tự")]
        public string UserName { get; set; }
        public string FullName { get; set; }

        [DisplayName("Passs")]
        [Required(ErrorMessage = "hãy nhập mk")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DisplayName("rePasss")]
        [Required(ErrorMessage = "hãy nhập lại mk")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }


        [DisplayName("Email")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "hãy nhập email")]

        public string Email { get; set; }
        [DisplayName("Phone")]
        [RegularExpression(@"^0\d{9,12}$")]

        public string Phone { get; set; }
        [DisplayName("Ngày sinh")]

        public DateTime Birthday { get; set; }
    }
}
