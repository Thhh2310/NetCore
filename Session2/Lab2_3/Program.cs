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

            //Khai báo biến
            double a, b, c, delta, x1, x2;
            //Nhập a, b, c
            Console.Write("a = ");
            //a phải != 0

            do
            {
                a = Convert.ToInt32(Console.ReadLine());
            } while (a == 0);
            Console.Write("b = ");
            b= Convert.ToInt32(Console.ReadLine());
            Console.Write("c = ");
            c = Convert.ToInt32(Console.ReadLine());
            //tính delta
            delta = b * b - 4 * a * c;
            //biện luận
            if(delta < 0)
            {
                Console.Write("Phương trình vô nghiệm");
            }else if(delta == 0) 
            {
                Console.WriteLine("Phương trình có nghiệm kép");
                Console.WriteLine("x1 = x2 =  {0}", -b / 2 * a);
            }
            else
            {
                Console.WriteLine("Phương trình có 2 nghiệm");
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);   
                Console.WriteLine("x1 = {0}", x1);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("x2 = {0}", x2);
            }
        }
    }
}