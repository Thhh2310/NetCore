using System.Text;

namespace Lab2_5
{
    internal class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int sum = 0;
            for(int i = 1; i <= 100; i++)
            {
                if(i % 2 == 0 && i % 3 != 0){
                    sum += i;
                }
            }
            Console.WriteLine("Tổng các số chẵn không chia hết cho 3 từ 1 - 100: " + sum);
        }
    }
}