using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace lesson05.Models.ViewModels
{
    public class MemberView
    {
        public string MemberId { get; set; }

        [DisplayName("Tên đăng nhập")]
        [Required(ErrorMessage = "Tên đăng nhập không để trống")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Độ dài tên từ 3 - 20 ký tự")]
        public string UserName { get; set; }

        [DisplayName("Họ và tên")]
        [Required(ErrorMessage = "Họ và tên không để trống")]
        public string FullName { get; set; }

        [DisplayName("Mật khẩu")]
        [Required(ErrorMessage = "Hãy nhập password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DisplayName("Gõ lại mật khẩu")]
        [Required(ErrorMessage = "Hãy nhập không khớp")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        [DisplayName("Hòm thư")]
        [RegularExpression(@"[a-zA-Z0-9._+-]+@[a-z0-9._]+\.[a-z]{2,4}$", ErrorMessage = "Email không đúng định dạng")]
        [Required(ErrorMessage = "Email không để trống")]
        public string Email { get; set; }

        [DisplayName("Điện thoại")]
        [RegularExpression(@"^0\d{9,11}$", ErrorMessage = "Phải bắt đầu bằng 0 và dài từ 10 - 12 số")]
        public string Phone { get; set; }

        [DisplayName("Ngày sinh")]
        public DateTime? Birthday { get; set; }
    }
}
