using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Day31_Lab04.Models
{
    public class Category
    {
        
        public int Id { get; set; }

        [DisplayName("Tên")]
        [Required(ErrorMessage = "Bạn chưa nhập tên")]
        [StringLength(50, ErrorMessage = "Tên không được quá 50 ký tự")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Bạn phải nhập ngày tháng")]
        public DateTime CreateDate { get; set; }

        public string CreateBy { get; set; }

        [Required(ErrorMessage = "Bạn phải nhập trạng thái")]
        public bool Status { get; set; }

        //thuộc tính quan hệ
        public ICollection<Product> Product { get; set;} = new List<Product>();
    }
}
