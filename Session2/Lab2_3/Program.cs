using System.Text;

namespace Lab2_3
{
    internal class Program
    {
        /// <summary>
        /// Viết chương trình C# để giải phương trình bậc 2 (lưu ý a phải luôn !=0)
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int a;
            int b;
            int c;

            Console.WriteLine("Nhập a: ");
            a = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.WriteLine(a);
            } while (a != 0);
            Console.WriteLine();
        }
    }
}