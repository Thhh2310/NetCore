using System.Text;

namespace Lab2_2
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

            char letter;
            Console.WriteLine("Nhập chữ cái: ");
            letter = Convert.ToChar(Console.ReadLine());

            switch (letter)
            {

                case 'u':
                case 'e':
                case 'o':
                case 'a':
                case 'i':
                    Console.WriteLine("Nguyên âm");
                    break;
                default: Console.WriteLine("Phụ âm");
                    break;
            }
        }
    }
}