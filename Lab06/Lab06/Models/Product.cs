﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab06.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên sản phẩm ko được để trống")]
        [StringLength(150, ErrorMessage = "Tên sản phẩm giới hạn 150 ký tự")]
        [Column(TypeName = "nvarchar(100)")]
        public string Name { get; set; }

        [Column(TypeName = "varchar(150)")]
        public string Image { get; set; }

        [Required(ErrorMessage = "Giá sản phẩm ko được để trống")]
        public float Price { get; set; }

        public float SalePrice { get; set; }

        public byte Status { get; set; }

        [StringLength(1000, ErrorMessage = "Nội dung có giới hạn 1000 ký tự")]
        [Column(TypeName = "ntex")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Danh mục sản phẩm ko được để trống")]
        public int CategoryId { get; set; }

        public DateTime CreateDate { get; set; }

        //Khoá ngoại
        public Category Category { get; set; }
    }
}
