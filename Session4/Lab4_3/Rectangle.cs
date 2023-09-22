using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_3
{
    internal class Rectangle: Shape 
    {
        //phương thức nhập dữ liệu
        public void InputData()
        {
            Console.WriteLine("Nhap chieu dai:");
            lenghth = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap chieu rong:");
            width = int.Parse(Console.ReadLine());
        }
        //ghi đè phương thức tính diện tích
        public override float Area()
        {
            return lenghth * width;
        }
        //ghi đè phương thức tính chu vi
        public override float Circumference()
        {
            return 2 * lenghth * width;
        }
    }
}
