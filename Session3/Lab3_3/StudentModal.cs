using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_3
{
    internal class StudentModal
    {
        //Khai báo danh tập hợp chứa các sinh viên
        List<Student> students;
        //Phương thức khởi tạo
        public StudentModal() 
        {
            //Khởi tạo danh sách sinh viên
            this.students = new List<Student>
            {
                new Student(){Id=1, Name="Dung", Age=20},
                new Student(){Id=2, Name="Hoàng", Age=22},
                new Student(){Id=3, Name="Thành", Age=26},
                new Student(){Id=4, Name="Thăng", Age=30},
                new Student(){Id=5, Name="Long", Age=18},            };
        }
        #region các phương thức overloading
        //Phương thức trả về danh sách sinh viên
        public List<Student> GetStudent()
        {
            return students;
        }
        //Phương thức trả về sinh viên theo id
        public Student GetStudent(int id)
        {
            Student st = null;
            foreach (var item in students)
            {
                if (item.Id == id)
                    st = item;
            }
            return st;
        }
        //Phương thức trả về sinh viên có tuổi từ x to y
        public List<Student> GetStudent(int x, int y)
        {
            List<Student> result = new List<Student>();
            foreach (var item in students)
            {
                if (item.Age >= x && item.Age <= y)
                    result.Add(item);
            }
            return result;
        }
        #endregion
    }
}
