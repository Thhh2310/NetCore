using System.Text;

namespace Vd2._5
{
    internal class Program
    {
        /// <summary>
        /// viết chương trình in ra các hình * $ &
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //Hình 1
            for (int i = 0; i <= 10; i++)
            {
                for (int j = 0;j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("");
            }

            //Hình 2
            for (int i = 10; i >= 0; i--)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("$ ");
                }
                Console.WriteLine("");
            }

            //Hình 3
            for (int i = 0; i <= 10; i++)
            {
                for (int j = i; j <= 20; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("");
            }
        }
    }
}