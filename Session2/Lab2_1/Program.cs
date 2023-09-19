using System.Text;

namespace Lab2_1
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

            Console.WriteLine("Nhập tên thuê bao: ");
            string name = Console.ReadLine();
            Console.WriteLine("Nhập số điện trên công tơ: ");
            int number = Convert.ToInt32(Console.ReadLine());

            double money = 0;
            //Tính số tiền điện 
            if (number <= 30)
            {
                money = 30;
            }else if (number > 30 && number <= 50) 
            {
                money = 30 + (number - 30) * 1.2;
            } else if (number > 50)
            {
                money = 30 + 20 * 1.2 + (number - 50) * 1.5;
            }

            //in thông tin
            Console.WriteLine("****Thông tin****");
            Console.WriteLine("Họ và tên: " + name);
            Console.WriteLine("Số điện sử dụng: " + number);
            Console.WriteLine("Số tiền điện sử dụng: " + money);
        }
    }
}