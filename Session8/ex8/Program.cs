using System.Text;

namespace ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //tạo mảng 10 quyển sách
            Book[] books = new Book[]
            {
                new Book{Id = 001, Name = "Tôi thấy hoa vàng trên cỏ xanh", Author = "Nguyễn Nhật Ánh", Price = 4000, Publisher = "Nhà xuất bản Văn Học", Year = 1992},
                new Book{Id = 002, Name = "Chiếc lược ngà", Author = "Nguyễn Nhật Ánh", Price = 6000, Publisher = "Nhà xuất bản Giáo Dục", Year = 1974},
                new Book{Id = 003, Name = "Lão Hạc", Author = "Nguyễn Nhật Ánh", Price = 7000, Publisher = "Nhà xuất bản Kim Đông", Year = 1986},
                new Book{Id = 004, Name = "Thần thoại Hy Lạp", Author = "Nguyễn Nhật Ánh", Price = 3000, Publisher = "Nhà xuất bản Trẻ", Year = 2015},
                new Book{Id = 005, Name = "999 lá thư gửi cho chính mình", Author = "Nguyễn Nhật Ánh", Price = 2000, Publisher = "Nhà xuất bản Giáo Dục", Year = 2004},
                new Book{Id = 006, Name = "La Mã cổ đại", Author = "Nguyễn Nhật Ánh", Price = 4000, Publisher = "Nhà xuất bản Kim Đồng", Year = 2015},
                new Book{Id = 007, Name = "Tôi yêu em", Author = "Nguyễn Nhật Ánh", Price = 8000, Publisher = "Nhà xuất bản Văn Học", Year = 1965},
                new Book{Id = 008, Name = "Từ ấy", Author = "Nguyễn Nhật Ánh", Price = 4500, Publisher = "Nhà xuất bản Giáo Dục", Year = 1982},
                new Book{Id = 009, Name = "Cảm xúc chi phối lý trí", Author = "Nguyễn Nhật Ánh", Price = 9000, Publisher = "Nhà xuất bản Giáo Dục", Year = 2015},
                new Book{Id = 010, Name = "Lập trình", Author = "Nguyễn Nhật Ánh", Price = 7000, Publisher = "Nhà xuất bản Kim Đồng", Year = 2020},
            };

            //hiển thị tất cả các quyển sách
            Console.WriteLine("Tất cả các quyển sách: ");
            foreach (var book in books)
            {
                Console.WriteLine("Id:" + book.Id + " Name:" + book.Name + " Author:" + book.Author + " Price:" + book.Price + " Publisher:" + book.Publisher + " Year:" + book.Year);
            }

            //hiển thị những quyển sách có giá từ 1000 - 5000
            Console.WriteLine("\nNhững quyển sách có giá trị từ 1000 - 5000: ");
            var booksInRange = books.Where(book => book.Price >= 1000 && book.Price <= 5000);
            foreach (var book in booksInRange)
            {
                Console.WriteLine("Id:" + book.Id + " Name:" + book.Name + " Author:" + book.Author + " Price:" + book.Price + " Publisher:" + book.Publisher + " Year:" + book.Year);
            }

            //hiển thị những quyển sách xuất bản năm 2015
            Console.WriteLine("\nNhững quyển sách xuất bản năm 2015: ");
            var booksPublisher = books.Where(book => book.Year == 2015);
            foreach (var book in booksPublisher)
            {
                Console.WriteLine("Id:" + book.Id + " Name:" + book.Name + " Author:" + book.Author + " Price:" + book.Price + " Publisher:" + book.Publisher + " Year:" + book.Year);
            }

            //hiển thị những quyển sách có tên Lập trình
            Console.WriteLine("\nNhững quyển sách có tên Lập trình: ");
            var progammingBook = books.Where(book => book.Name == "Lập trình");
            foreach (var book in progammingBook)
            {
                Console.WriteLine("Id:" + book.Id + " Name:" + book.Name + " Author:" + book.Author + " Price:" + book.Price + " Publisher:" + book.Publisher + " Year:" + book.Year);
            }

            //Đếm các quyển sách của nhà xuất bản Giáo dục
            Console.WriteLine("\nSố sách của nhà xuất bản Giáo Dục: ");
            var numberBooks = books.Count(book => book.Publisher == "Nhà xuất bản Giáo Dục");
            Console.WriteLine(numberBooks);

        }
    }
}