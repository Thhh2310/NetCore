namespace Lab3_2
{
    internal class Program
    {
        /// <summary>
        /// tạo đối tượng và gọi phương thức để test
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Tạo đối tượng contact với contructor không tham số
            Contact ct1= new Contact();
            //Gán giá trị cho ct1
            ct1.Id = 1;
            ct1.FirstName = "Vu Thanh";
            ct1.LastName = "Thao";
            ct1.Address = "Ha Nam";
            ct1.Phone = "0934567890";
            ct1.Email = "vuthao23102003@gmail.com";
            //Tạo đối tượng contact với constructor có tham số
            Contact ct2 = new Contact(2, "Nguyen Thi", "Thanh", "Ha Nam", "0353786257", "thanh1979@gmail.com");
            //Hiển thị thông tin ct1 và ct2
            ct1.Display();
            ct2.Display();
        }
    }
}