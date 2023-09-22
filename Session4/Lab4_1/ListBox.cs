using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_1
{
    internal class ListBox
    {
        //Khai báo trường mới 
        private string listBoxContents;
        //Phương thức khởi tạo
        public ListBox( int top, int left, string contents):base(top, left) { listBoxContents = contents; }
    }

    //Ghi đè phương thức DrawWindow
    public override void DrawWindow()
    {
        base.DrawWindow();  //Gọi phương thức lớp cơ sở
        Console.WriteLine("Write string to the listbox: {0}", listBoxContents);
    }
}
