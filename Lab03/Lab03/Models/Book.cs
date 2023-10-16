using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace Lab03.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public int GenreId { get; set; }
        public string Image { get; set; }
        public float Price { get; set; }
        public int TotalPage { get; set; }
        public string Sumary { get; set; }

        //danh sách các cuốn sách
        public List<Book> GetBookList()
        {
            List<Book> books = new List<Book>()
            {
                new Book()
                {
                    Id = 1,
                    Title = "Chí Phèo",
                    AuthorId = 1,
                    GenreId = 1,
                    Image = "/images/mt1.jpg",
                    Price = 500000,
                    Sumary = "",
                    TotalPage = 240,
                },
                new Book()
                {
                    Id = 2,
                    Title = "Chiếc lược ngà",
                    AuthorId = 1,
                    GenreId = 1,
                    Image = "/images/mt2.jpg",
                    Price = 400000,
                    Sumary = "",
                    TotalPage = 120,
                },
                new Book()
                {
                    Id = 3,
                    Title = "Tôi thấy hoa vàng trên cỏ xanh",
                    AuthorId = 1,
                    GenreId = 1,
                    Image = "/images/mt3.jpg",
                    Price = 300000,
                    Sumary = "",
                    TotalPage = 340,
                },
                new Book()
                {
                    Id = 4,
                    Title = "Không diệt không sanh đừng sợ hãi",
                    AuthorId = 1,
                    GenreId = 1,
                    Image = "/images/mt4.jpg",
                    Price = 200000,
                    Sumary = "",
                    TotalPage = 40,
                }
            };
            return books;
        }

        //chi tiết một cuốn sách theo id
        public Book GetBookById (int id)
        {
            Book book = this.GetBookList().FirstOrDefault(b => b.Id == id);
            return book;
        }

        //SelectListItem Authors
        public List<SelectListItem> Authors { get; } = new List<SelectListItem>
        {
            new SelectListItem {Value = "1", Text = "Nam Cao"}, 
            new SelectListItem {Value = "2", Text = "Ngô Tất Tố"}, 
            new SelectListItem {Value = "3", Text = "Adamkhoom"}, 
            new SelectListItem {Value = "4", Text = "Thiền sư Thích Nhất Hạnh"}, 
        };

        //SelectListItem Genres
        public List<SelectListItem> Genres { get; } = new List<SelectListItem>
        {
            new SelectListItem {Value = "1", Text = "Truyện tranh"},
            new SelectListItem {Value = "2", Text = "Văn học đương đại"},
            new SelectListItem {Value = "4", Text = "Phật học phổ thông"},
            new SelectListItem {Value = "3", Text = "Truyện cười"},
        };
    }
}
