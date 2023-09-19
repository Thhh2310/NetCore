namespace Vd1._2
{
    internal class Program
    {
        //<summary>
        //Chương trình C# (Khai báo biến, gán giá trị, hiển thị thông tin ra màn hình)
        //In ra thông tin nhân viên
        //</summary>
        //<param name="args"></param>
        static void Main(string[] args)
        {
            //Khai báo biến và gán giá trị
            int id = 1;
            string name = "Hoang Ngoc Ha";
            DateTime dateBirth = new DateTime(2003, 05, 12);
            string address = "Ha Đong";
            int phone = 0986246417;
            string email = "ngocha1205@gmail.com";
            //Hiển thị thông tin giá trị
            Console.WriteLine("Ma nhan vien: "+ id);
            Console.WriteLine("Ho va ten nhan vien: "+ name);
            Console.WriteLine("Ngay sinh: " + dateBirth.ToString("dd-MM-yyyy")) ;
            Console.WriteLine("Đia chi: "+ address);
            Console.WriteLine("Đien thoai: "+ phone);
            Console.WriteLine("Email: "+ email);
        }
    }
}