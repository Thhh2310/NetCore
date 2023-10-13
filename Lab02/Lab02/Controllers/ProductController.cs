using Lab02.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab02.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            List<Product> products = new List<Product>
            {
                new Product()
                {
                    Id = 1,
                    Name = "Bộ bàn ghế gỗ",
                    Image = Url.Content("~/Avatar/01.png"),
                    Price = 23999000,
                    SalePrice = 21999000,
                    CategoryId = 9,
                    Description = "màu trầm đậm, không thâm nước",
                    Status = "còn hàng",
                    CreatedAt = new DateTime(2020,12,10)
                },
                new Product()
                {
                    Id = 2,
                    Name = "Bộ giường gỗ",
                    Image = Url.Content("~/Avatar/02.png"),
                    Price = 23999000,
                    SalePrice = 21999000,
                    CategoryId = 9,
                    Description = "màu trầm đậm, không thâm nước",
                    Status = "còn hàng",
                    CreatedAt = new DateTime(2022,10,10)
                },
                new Product()
                {
                    Id = 3,
                    Name = "Kệ đầu giường gỗ",
                    Image = Url.Content("~/Avatar/03.png"),
                    Price = 23999000,
                    SalePrice = 21999000,
                    CategoryId = 9,
                    Description = "màu trầm đậm, không thâm nước",
                    Status = "còn hàng",
                    CreatedAt = new DateTime(2021,10,18)
                },
                new Product()
                {
                    Id = 4,
                    Name = "Bộ giường sồi",
                    Image = Url.Content("~/Avatar/04.png"),
                    Price = 23999000,
                    SalePrice = 21999000,
                    CategoryId = 9,
                    Description = "màu trầm đậm, không thâm nước",
                    Status = "còn hàng",
                    CreatedAt = new DateTime(2020,3,5)
                },
                new Product()
                {
                    Id = 5,
                    Name = "Bộ tủ gỗ",
                    Image = Url.Content("~/Avatar/05.png"),
                    Price = 23999000,
                    SalePrice = 21999000,
                    CategoryId = 9,
                    Description = "màu trầm đậm, không thâm nước",
                    Status = "còn hàng",
                    CreatedAt = new DateTime(2021,6,12)
                },
                new Product()
                {
                    Id = 6,
                    Name = "Bộ kệ để đồ gỗ",
                    Image = Url.Content("~/Avatar/01.png"),
                    Price = 23999000,
                    SalePrice = 21999000,
                    CategoryId = 9,
                    Description = "màu trầm đậm, không thâm nước",
                    Status = "còn hàng",
                    CreatedAt = new DateTime(2020,2,10)
                },
            };
            ViewBag.Products = products;
            return View();
        }

        //định nghĩa url và nam cho action
        [Route("san-pham", Name = "detail")]
        public IActionResult Detail(int id)
        {
            List<Product> products = new List<Product>
            {
                new Product()
                {
                    Id = 1,
                    Name = "Bộ bàn ghế gỗ",
                    Image = Url.Content("~/Avatar/01.png"),
                    Price = 23999000,
                    SalePrice = 21999000,
                    CategoryId = 9,
                    Description = "màu trầm đậm, không thâm nước",
                    Status = "còn hàng",
                    CreatedAt = new DateTime(2020,12,10)
                },
                new Product()
                {
                    Id = 2,
                    Name = "Bộ giường gỗ",
                    Image = Url.Content("~/Avatar/02.png"),
                    Price = 23999000,
                    SalePrice = 21999000,
                    CategoryId = 9,
                    Description = "màu trầm đậm, không thâm nước",
                    Status = "còn hàng",
                    CreatedAt = new DateTime(2022,10,10)
                },
                new Product()
                {
                    Id = 3,
                    Name = "Kệ đầu giường gỗ",
                    Image = Url.Content("~/Avatar/03.png"),
                    Price = 23999000,
                    SalePrice = 21999000,
                    CategoryId = 9,
                    Description = "màu trầm đậm, không thâm nước",
                    Status = "còn hàng",
                    CreatedAt = new DateTime(2021,10,18)
                },
                new Product()
                {
                    Id = 4,
                    Name = "Bộ giường sồi",
                    Image = Url.Content("~/Avatar/04.png"),
                    Price = 23999000,
                    SalePrice = 21999000,
                    CategoryId = 9,
                    Description = "màu trầm đậm, không thâm nước",
                    Status = "còn hàng",
                    CreatedAt = new DateTime(2020,3,5)
                },
                new Product()
                {
                    Id = 5,
                    Name = "Bộ tủ gỗ",
                    Image = Url.Content("~/Avatar/05.png"),
                    Price = 23999000,
                    SalePrice = 21999000,
                    CategoryId = 9,
                    Description = "màu trầm đậm, không thâm nước",
                    Status = "còn hàng",
                    CreatedAt = new DateTime(2021,6,12)
                },
                new Product()
                {
                    Id = 6,
                    Name = "Bộ kệ để đồ gỗ",
                    Image = Url.Content("~/Avatar/01.png"),
                    Price = 23999000,
                    SalePrice = 21999000,
                    CategoryId = 9,
                    Description = "màu trầm đậm, không thâm nước",
                    Status = "còn hàng",
                    CreatedAt = new DateTime(2020,2,10)
                },
            };
            //gửi đối tượng product qua view
            ViewBag.product = products;
            return View();
        }
    }
}
