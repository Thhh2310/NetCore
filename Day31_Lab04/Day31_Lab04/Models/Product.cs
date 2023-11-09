using Microsoft.Build.Framework;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Xunit;
using Xunit.Abstractions;
using Xunit.Sdk;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace Day31_Lab04.Models
{
    public class Product
    {
        //[Required(ErrorMessage = "Bạn phải nhập tên ID")]
        public int? Id { get; set; }

        [DisplayName("Tên")]
        [Required(ErrorMessage = "Bạn phải nhập tên sản phẩm")]
        [StringLength(150, MinimumLength =6, ErrorMessage = "Tên sản phẩm phải có ít nhất 6 ký tự và không quá 150 ký tự")]
        public string? Name { get; set; }

        [DisplayName("Mô tả")]
        [Required(ErrorMessage = "Bạn phải mô tả")]
        [StringLength(1500, ErrorMessage = "Mô tả không được vượt quá 1500 ký tự")]
        [RegularExpression(@"^(?!.*\b(die|admin|fuck|shit|cunt)\b).*$", ErrorMessage = "Mô tả không được chứa các từ nhạy cảm")]
        public string? Description { get; set; }

        [DisplayName("Giá")]
        [Required(ErrorMessage = "Bạn phải nhập giá sản phẩm")]
        [Range(100000, double.MaxValue, ErrorMessage ="Giá sản phẩm phải lớn hơn hoặc bằng 100,000" )]
        [DataType(DataType.Currency)]
        public float? Price { get; set; }

        [DisplayName("Giá khuyến mãi")]
        [Required(ErrorMessage = "Bạn phải nhập giá khuyến mãi")]
        [Range(0, 0.1, ErrorMessage = "Giá khuyến mãi phải không âm và nhỏ hơn 10% giá chuẩn")]
        public float? SalePrice { get; set; }

        [DisplayName("Hình ảnh")]
        [Required(ErrorMessage = "Bạn phải chọn hình ảnh")]
        public string? Image { get; set; }

        [DisplayName("CategoryId")]
        [Required(ErrorMessage = "Bạn phải chọn một danh mục")]
        [Range(1, int.MaxValue, ErrorMessage = "Category ko hợp lệ")]
        public int? CategoryId { get; set; }

        [Required(ErrorMessage = "Bạn phải nhập ngày tháng")]
        public DateTime? CreateDate { get; set; }

        public string? CreateBy { get; set; }

        [Required(ErrorMessage = "Bạn phải nhập trạng thái")]
        public bool? Status { get; set; }

        //tạo quan hệ ràng buộc với Category
        public virtual Category? Category { get; set; }
    }
}
