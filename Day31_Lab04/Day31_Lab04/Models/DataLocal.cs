namespace Day31_Lab04.Models
{
    public class DataLocal
    {
        public static List<Category> _categories = new List<Category>()
        {
            new Category()
            {
                Id = 1,
                Name = "Test",
                CreateDate = DateTime.Now,
                CreateBy = "Test",
                Status = true
            },
            new Category()
            {
                Id = 2,
                Name = "T",
                CreateDate = DateTime.Now,
                CreateBy = "Tt",
                Status = true
            },
            new Category()
            {
                Id = 3,
                Name = "Tt",
                CreateDate = DateTime.Now,
                CreateBy = "Tt",
                Status = false
            },
        };

        public static List<Product> _products = new List<Product>()
        {
            new Product(){
                Id=1,
                Name="Devmaster Academy",
                Description="Viện Công Nghệ Và Đào Tạo Devmaster - Đào tạo kỹ năng công nghệ thông",
                Price=1200,
                SalePrice=1100,
                Image="/images/products/logo.png",
                CreateDate=DateTime.Now,
                Status=true,
                CategoryId=1},
            new Product(){
                Id=2,
                Name="IPhone 15 ProMMax",
                Description="iPhone 15 Pro Max là một chiếc điện thoại thông minh cao cấp được mong đợi nhất năm 2023",
                Price=1200,
                SalePrice=1100,
                Image="/images/products/p001.jpg",
                CreateDate=DateTime.Now,
                Status=false,
                CategoryId=2},
             new Product(){
                Id=3,
                Name="Samsung Galaxy Z Fold4",
                Description="Samsung Galaxy Z Fold4 512GB được hoàn thiện với ngoại hình khá giống với một chiếc máy tính bảng, sử dụng cơ chế gập hiện đại giúp cho người dùng có thể tùy biến thay đổi Galaxy Z Fold4 thành chiếc smartphone hay tablet một cách linh hoạt tùy vào nhu cầu sử dụng",
                Price=1200,
                SalePrice=1100,
                Image="/images/products/p001.jpg",
                CreateDate=DateTime.Now,
                Status=true,
                CategoryId=3},
        };
    }
}
