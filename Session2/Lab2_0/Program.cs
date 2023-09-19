using System.Text;

namespace Lab2_0
{
    internal class Program
    {
        /// <summary>
        /// Nhập thông tin sinh viên bao gồm (Id ,
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập mã sinh viên: ");
            int Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập tên sinh viên: ");
            string name = Console.ReadLine();
            Console.WriteLine("Nhập ngày tháng năm sinh: ");
            DateTime Birthday = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Nhập điểm môn 1: ");
            int mark1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập điểm môn 2: ");
            int mark2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập điểm môn 3: ");
            int mark3 = Convert.ToInt32(Console.ReadLine());
            //Điểm trung bình
            int average = (mark1+ mark2 + mark3) / 3;

            Console.WriteLine("**********Thông tin sinh viên**********");
            Console.WriteLine("Mã sinh viên: " + Id);
            Console.WriteLine("Tên sinh viên: " + name);
            Console.WriteLine("Ngày tháng năm sinh: {0}", Birthday.ToString("dd-MM-yyy"));
            Console.WriteLine("Điểm trung bình: ({0} + {1} + {2})/3={3}", mark1, mark2, mark3, average);
        }
    }
}