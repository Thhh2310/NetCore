namespace Lab6_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Khai báo và khởi tạo danh sách
            List<Student> list = new List<Student>()
            {
                new Student{Id = "S10",FirstName = "Nguyen Thu",LastName = "Phuong",Avg = 9.5},
                new Student{Id = "S11",FirstName = "Nguyen Thi",LastName = "Huong",Avg = 6.4},
                new Student{Id = "S12",FirstName = "Pham Thu",LastName = "Lan",Avg = 7.8},
                new Student{Id = "S13",FirstName = "Nguyen Van",LastName = "Phuong",Avg = 9.2},
                new Student{Id = "S14",FirstName = "Hoang Thi",LastName = "Phuong",Avg = 8.1},
                new Student{Id = "S15",FirstName = "Nguyen Tien",LastName = "Dat",Avg = 5.2},
            };
            //In ra danh sách sinh viên
            Console.Write("Danh sach sinh viên:");
            foreach (var st in list)
            {
                Console.Write(st);
            }
            //tìm sinh viên có điểm trung bình cao nhất
            double max = list[0].Avg;
            Student stmax = list[0];
            foreach (var st in list)
            {
                if (st.Avg > max)
                {
                    max = st.Avg;
                    stmax = st;
                }
            }
            //in kết quả
            Console.Write("\n----------Sinh vien co diem cao nhat----------");
            Console.Write(stmax);
        }
    }
}