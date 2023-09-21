namespace Lab3_3
{
    internal class Program
    {
        /// <summary>
        /// Khơit tạo StudentModal và test trong Main
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Tạo đối tượng 
            StudentModal action= new StudentModal();
            //Gọi phương thức lấy tất cả sinh viên
            List<Student> all = action.GetStudent();
            //Hiển thị
            foreach (var item in all)
            {
                item.Display();
            }

            //Gọi phương thức lấy sinh viên theo id
            Student st = action.GetStudent(2);
            //Hiển thị
            st.Display();

            //Gọi phương thức lấy sinh viên có tuổi từ 25-30
            List<Student> age = action.GetStudent(25,30);
            //Hiển thị
            foreach (var item in age)
            {
                item.Display();
            }
        }
    }
}