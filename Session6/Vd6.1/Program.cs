
using System.Globalization;
using System.Text;

namespace Vd6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //tạo danh sách
            List<Book> bookList = new List<Book>()
            {
                new Book{Id = 1, Title = "Số đỏ", Author = "Vũ Trọng Phụng", Publisher = "Nhà xuất bản Trẻ", Year = 1936, Price = 45000},
                new Book{Id = 2, Title = "Tắt đèn", Author = "Ngô Tất Tố", Publisher = "Nhà xuất bản Văn học", Year = 1946, Price = 50000},
                new Book{Id = 3, Title = "Chiếc Lá Cuốn Bay", Author = "Nguyễn Nhật Ánh", Publisher = "Nhà xuất bản Trẻ", Year = 1996, Price = 60000},
                new Book{Id = 4, Title = "Đất Rừng Phương Nam", Author = "Dương Thu Hương", Publisher = "Nhà xuất bản Văn Học", Year = 1988, Price = 55000},
                new Book{Id = 5, Title = "Dế Mèn Phiêu Lưu Ký", Author = "Tô Hoài", Publisher = "Nhà xuất bản Kim Đồng", Year = 1973, Price = 56000},
                new Book{Id = 6, Title = "Lão Hạc", Author = "Nam Cao", Publisher = "Nhà xuất bản Văn Học", Year = 1945, Price = 49000},
                new Book{Id = 7, Title = "Chí Phèo", Author = "Nam Cao", Publisher = "Nhà xuất bản Văn Học", Year = 1954, Price = 45000},
                new Book{Id = 8, Title = "Bên Khung Trời", Author = "Nguyễn Ngọc Thuần", Publisher = "Nhà xuất bản Trẻ", Year = 1972, Price = 67000},
                new Book{Id = 9, Title = "Mắt Biếc", Author = "Nguyễn Nhật Ánh", Publisher = "Nhà xuất bản Kim Đồng", Year = 1978, Price = 65000},
                new Book{Id = 10, Title = "Chiếc lược Ngà", Author = "", Publisher = "Nhà xuất bản Trẻ", Year = 1956, Price = 45000},
            };
            //in danh sách theo giá tăng dần
            Console.WriteLine("Danh sách các quyển sách theo giá tăng dần: ");
            List<Book> sortedByPrice = bookList.OrderBy(book => book.Price).ToList();
            foreach (var book in sortedByPrice)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Publisher: {book.Publisher}, Year: {book.Year}, Price: {book.Price}");
            }

            //tìm sách theo title
            Console.WriteLine("\nNhập title của quyển sách muốn tìm: ");
            string searchTitle = Console.ReadLine();
            Book foundBook = bookList.Find(book => string.Compare
            (book.Title, searchTitle, CultureInfo.CurrentCulture, CompareOptions.IgnoreNonSpace | System.Globalization.CompareOptions.IgnoreCase)==0);
            if (foundBook != null)
            {
                Console.WriteLine("Quyển sách đc tìm thấy: ");
                Console.WriteLine($"Title: {foundBook.Title}, Author: {foundBook.Author}, Publisher: {foundBook.Publisher}, Year: {foundBook.Year}, Price: {foundBook.Price}");
            }
            else
            {
                Console.WriteLine("Không tìm thấy quyển sách có title đc nhập");
            }


            //Đưa ra những sách xuất bản năm muốn tìm
            Console.WriteLine("\nNhập năm xuất bản muốn tìm: ");
            int searchYear = Convert.ToInt32(Console.ReadLine());
            List<Book> booksByYear = bookList.FindAll(book =>book.Year == searchYear);
            if(booksByYear.Count > 0)
            {
                Console.WriteLine($"Các quyển sách xuất bản năm {searchYear}:");
                foreach (var book in booksByYear)
                {
                    Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Publisher: {book.Publisher}, Year: {book.Year}, Price: {book.Price}");
                }
            }
            else
            {
                Console.WriteLine("Không tìm thấy quyển sách được nhập");
            }

            //Xoá những quyển sách của nhà xuất bản Kim Đồng
            Console.WriteLine("\nNhập nhà xuất bản muốn xoá: ");
            string publisherDeleted = Console.ReadLine();
            int bookRemoved = bookList.RemoveAll(book => string.Compare
            (book.Publisher, publisherDeleted, CultureInfo.CurrentCulture, CompareOptions.IgnoreNonSpace | System.Globalization.CompareOptions.IgnoreCase)==0);
            Console.WriteLine($"Đã xoá {bookRemoved} quyển sách của nhà xuất bản {publisherDeleted}");
            Console.WriteLine("Danh sách sau khi xoá: ");
            foreach (var book in bookList)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Publisher: {book.Publisher}, Year: {book.Year}, Price: {book.Price}");
            }
        }
    }
}