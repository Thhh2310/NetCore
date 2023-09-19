using System.Text;

namespace Vd2._6
{
    internal class Program
    {
        /// <summary>
        /// Viết chương trình nhập vào 3 số a,b,c
        /// Xét xem a,b,c có tạo thành độ dài 3 cạnh của 1 tam giác hay ko?
        /// Nếu a,b,c là độ dài 3 cạnh của 1 tam giác thì xét xem là tam giác gì?
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int a, b, c;

            Console.WriteLine("Nhập vào độ dài 3 cạnh của tam giác");
            Console.Write("Cạnh a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Cạnh b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Cạnh c: ");
            c = Convert.ToInt32(Console.ReadLine());

            if (a + b <= c || b + c <= a || a + c <= b)
            {
                Console.WriteLine("Không phải là ba cạnh của 1 tam giác");
            }else if (a == b || b == c || a == c)
            {
                Console.WriteLine("Đây là tam giác cân");
            }else if (a == c && a == b && b == c)
            {
                Console.WriteLine("Đây là tam giác đều");
            }else if (a*a + b*c == c*c || a*c + c*c == b*b || b*b + c*c == a*c)
            {
                Console.WriteLine("Đây là tam giác vuông");
            }else 
            {
                Console.WriteLine("Đây là tam giác thường");
            }
        }
    }
}