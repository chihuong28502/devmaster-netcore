using System.ComponentModel.DataAnnotations;

namespace Lab5.Models
{
    public class Account
    {
        [Key]
        public int Id { get; set; }
        [
            Display(Name ="Họ và Tên"),
            Required(ErrorMessage ="Họ ko được để trống"),
            MinLength(6,ErrorMessage ="ít nhất là 6 kí tự"),
            MaxLength(20,ErrorMessage ="ko được vượt 20 kí tự"),
        ]
        public string FullName { get; set; }
        [
            Display(Name = "Nhập Email"),
            Required(ErrorMessage = "Email ko được để trống"),
            DataType(DataType.EmailAddress),
            EmailAddress(ErrorMessage ="Email sai định dạng")
        ]
        public string Email { get; set; }
        [
           Display(Name = "Nhập Phone"),
           Required(ErrorMessage = "Phone ko được để trống"),
           DataType(DataType.PhoneNumber),
RegularExpression(@"/ ^(\([0 - 9]{3}\) |[0-9]{3}-)[0-9] { 3}-[0 - 9]{ 4}/$",ErrorMessage ="sdt sai  định dạng" )
        ]
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Avatar { get; set; }
        public DateTime Birthday { get; set; }
        public string Gender { get; set; }
        public string Password { get; set; }
        public string Facebook { get; set; }
    }
}
