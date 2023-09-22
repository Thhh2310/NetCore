namespace Lab4_4
{
    internal class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //tạo 1 nhân viên
            IPerson staff = new Staff();
            object data = "Bach Khoa Aptech";
            //gọi các hành động
            staff.Insert(data);
            staff.Delete(data);
            staff.Update(data);
            staff.Dispaly(data);
            //tạo sinh viên
            IPerson student = new Student() 
            { 
                Id = "S10",
                Name = "Test",
                Age= 16,
            };
            //hiển thị dữ liệu
            student.Dispaly(student);
        }
    }
}