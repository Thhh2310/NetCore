using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_4
{
    //định nghĩa lớp nhân viên thựuc thi từ giao diện IPerson
    internal class Staff : IPerson
    {
        //thực thi các phương thức của giao diện
        public void Insert(object obj) 
        {
            Console.WriteLine("Da lưu đoi tuong: " + obj);
        }

        public void Delete(object obj)
        {
            Console.WriteLine("Da xoa doi tuong: " + obj);
        }

        public void Update(object obj)
        {
            Console.WriteLine("Da  cap nhat doi tuong: " + obj);
        }

        public void Display(object obj)
        {
            Console.WriteLine("Thong tin doi tuong: " + obj);
        }
    }
}
