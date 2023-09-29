namespace Lab8_1
{
    internal class Program
    {
        /// <summary>
        /// Chương trình minh hoạ việc sử dụng một số thao tác trên tập dữ liệu sử dụng câu lệnh LINQ
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Khởi tạo dữ liệu
            string[] data = { "To", "ve", " hon", "nguoi", "thi", "nguoi", "se",
            "tro", "thanh", " ke", "thu", "cua", "ta", "Chiu", "nhuong", "nguoi", " thi", "nguoi", "se", "la", "ban", "cua", "ta"};

            //truy vấn dữ liệu
            IEnumerable<string> result1 = from m in data select m;

            //Hiển thị
            Console.WriteLine("Hiển thị tất cả kết quả:");
            foreach (var item in result1)
            {
                Console.WriteLine(item + " ");
            }

            //truy vấn theo điều kiện lấy từ "nguoi"
            IEnumerable<string> result2 = from m in data where m.Equals ("nguoi")
                                          select m;

            //hiển thị kết quả
            Console.WriteLine("\nTruy vấn theo điều kiện");
            foreach (var item in result2)
            {
                Console.WriteLine(item + " ");
            }

            //sắp xếp dữ liệu
            IEnumerable<string> result3 = from m in data orderby m select m;

            //hiển thị kết quả
            Console.WriteLine("\nHiển thị tất cả kết quả sắp xếp");
            foreach (var item in result3)
            {
                Console.WriteLine(item + " ");
            }

            //lấy dữ liệu mới
            var result4 = from m in data select new { Thuong = m.ToLower(), Hoa = m.ToUpper() };

            //hiển thị kết quả
            Console.WriteLine("\nChữ thường và hoa");
            foreach (var item in result4)
            {
                Console.WriteLine(item.Thuong + ":" + item.Hoa);
            }

        }
    }
}