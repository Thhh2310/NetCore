namespace Lab8_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Khai báo chung
            int[] Numbers = { 7, 9, 3, 5, 2, 1, 0, 6, 4, 3, 1 };
            string[] Words = {
                "Chỉ", "trích", "phê", "phán", "người", "khác",
                "giống", "như", "con", "chim", "bồ", "câu", "đưa", "thư",
                "bao", "giờ", "cũng", "quay", "về", "nơi", "xuất", "phát"
            };
            List<Film> ListFilm = new List<Film>()
            {
                new Film{FilmId = "F01", FilmName = "Điệp viên 007", Price = 120000},
                new Film{FilmId = "F02", FilmName = "Tam quốc diễn nghĩa", Price = 130000},
                new Film{FilmId = "F03", FilmName = "Thiếu lâm truyền kỳ", Price = 160000},
                new Film{FilmId = "F04", FilmName = "Người nhện 2", Price = 100000},
                new Film{FilmId = "F05", FilmName = "Ngân hàng tình yêu", Price = 340000},
                new Film{FilmId = "F06", FilmName = "Người đẹp và quái vật", Price = 230000},
                new Film{FilmId = "F07", FilmName = "Biệt động Sài Gòn", Price = 190000},
            };

            //lọc các số chẵn
            IEnumerable<int> querynumber = Numbers.Where(n => n % 2 == 0);
            Console.WriteLine("Loc cac so chan: ");
            foreach(var query in querynumber)
            {
                Console.WriteLine(query);
            }

            //lọc các từ có độ dài >4
            IEnumerable<string> queryword = Words.Where(w => w.Length > 4);
            Console.WriteLine("\nLoc cac tu co do dai >4: ");
            foreach(var query in queryword)
            {
                Console.WriteLine(query);
            }

            //lọc các tư tên bắt đầu bằng t
            IEnumerable<string> queryT = Words.Where(w => w.StartsWith("t"));
            Console.WriteLine("\nLoc cac tu co ten bat dau bang chu t: ");
            foreach (var query in queryT)
            {
                Console.WriteLine(query);
            }

            //lặp các số duy nhất trong các tập số
            var uniqueNumber = Numbers.Distinct();
            Console.WriteLine("\nLoc cac so duy nhat trong tap cac so: ");
            foreach (var query in uniqueNumber)
            {
                Console.WriteLine(query);
            }

            //đếm từ ko trùng nhau
            var countDistinct = Words.Distinct().Count();
            Console.WriteLine("\nDem xem co bao nhieu tu khong trung nhau: " + countDistinct);

            //lấy 4 số đầu tiên trong dãy
            var fourNumber = Numbers.Take(4);
            Show<int>(fourNumber, "\nlay 4 so dau tien trong day: ");

            //lấy 2 từ đầu tiên trong câu
            var twoword = Words.Take(2);
            Show<string>(twoword, "\nLay 2 tu dau tien trong cau: ");

            //lấy những từ đầu tiên có chứa chữ t
            var seachword = Words.TakeWhile(w => w.Contains('t'));
            Show<string>(seachword, "\nLay chu dau tien co chua t: ");

            //sắp xếp theo đơn giá, lấy những phim đầu tiên có đơn giá <200000
            var queryfilm = ListFilm.OrderBy(f => f.Price).Select(x => new {x.FilmId, x.FilmName, x.Price}).ToList().TakeWhile(t => t.Price <200000);

            //bỏ qua 3 phần tử đầu tiên, lấy tất cả  các phần tử còn lại
            var skipNumber = Numbers.Skip(3);
            Show<int>(skipNumber, "\nBo qua 3 phan tu dau tien, lay tat ca cac phan tu con lai: ");

            //bỏ qua 4 phần từ đầu tiên lấy 3 phần tử kế tiếp
            var skipTakeNumber = Numbers.Skip(4).Take(3);
            Show<int>(skipTakeNumber, "\nBo qua 4 phan tu dau tien, lay 3 phan tu ke tiep: ");

            //bỏ 3 phim đầu tiên lấy 3 phim kế tiếp (có thể áp dụng để phân trang)
            var skipTakeFilm = ListFilm.Skip(3).Take(3);
            Show<Film>(skipTakeFilm, "\nBo qua 3 phim dau tien, lay 3 phim ke tiep: ");

            //sắp xếp giảm dần rồi sau đó lấy các phần tử <5
            var sortNumber = Numbers.OrderByDescending(x => x).SkipWhile(x => x > 5);
            Show<int>(sortNumber, "\nSap xep giam dan, sau do lay cac phan tu < 5: ");
        }
        //định nghĩa phương thức Generic hiển thị dữ liệu
        static void Show<T>(IEnumerable<T> data, string message)
        {
            Console.WriteLine(message);
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
        }
    }
}