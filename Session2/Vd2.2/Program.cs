using System.Text;

namespace Vd2._2
{
    internal class Program
    {
        /// <summary>
        /// Viết chương trình nhập vào năm x tháng y sau đó in ra số ngày trong tháng năm đó
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int x;
            int y;
            int days = 0;

            Console.WriteLine("Nhập số năm: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập số tháng: ");
            y = Convert.ToInt32(Console.ReadLine());

            switch (y)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    days = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    days = 30; 
                    break;
                case 2:
                    days= 29; 
                    break;
                default:
                    Console.WriteLine("Nhập sai tháng");
                    break;
            }
            Console.WriteLine("Tháng {0} năm {1} có {2} ngày", y, x, days);
        }
    }
}