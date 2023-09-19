using System.Text;

namespace Lab2_4
{
    internal class Program
    {
        /// <summary>
        /// Chương trình in ra các số nguyên tố từ 2 - 100
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            bool check_i;

            Console.WriteLine("Danh sách các số từ 2 - 100: ");

            for (int i = 2; i <= 100; i++)
            {
                check_i = true;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        check_i = false;
                        Console.WriteLine("không phải số nguyên tố: " + i);
                        break;
                    }
                }
                if (check_i)
                {
                    Console.WriteLine("Số nguyên tố: "+ i);
                }
            }
        }
    }
}