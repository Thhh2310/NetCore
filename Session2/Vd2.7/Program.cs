namespace Vd2._7
{
    internal class Program
    {
        /// <summary>
        /// Viết chương trình CSharp để hiển thị ra hình
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = i; j <= 10; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("");
            }
        }
    }
}