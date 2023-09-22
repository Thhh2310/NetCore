using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_3
{
    internal class Circle: Shape
    {
        //phương thức nhập dữ liệu
        public void InputData()
        {
            Console.WriteLine("Nhap ban kinh:");
            radius = int.Parse(Console.ReadLine());
        }
        //ghi đè phương thức tính diện tích
        public override float Area()
        {
            return 3.14F * radius * radius;
        }
        //Ghi đè phương thức tính chu vi
        public override float Circumference()
        {
            return 2* 3.14F * radius;
        }
    }
}
