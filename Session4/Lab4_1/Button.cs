using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_1
{
    internal class Button: Window
    {
        // Phương thức khởi tạo
        public Button(int top, int left):base(top, left) { }

        //Ghi đè phương thức
        public override void DrawWindow()
        {
            Console.WriteLine("Drawing button at {0}, {1}",top,left);
        }
    }
}
