using System.Text;

namespace Vd2._4
{
    internal class Program
    {
        /// <summary>
        /// Viết chương trinhg in ra các số mà tổng 3 ký số là chẵn từ 100 - 999
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            for (int i = 100; i <= 999; i++) 
            { 
                int t = i / 100;
                int c = (i % 100) / 10;
                int d = i % 10;
                if ((t + c + d) % 2 == 0)
                {
                    Console.WriteLine("Tổng 3 ký số chẵn là: " + i);
                }
            }
        }
    }
}