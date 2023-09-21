namespace Lab3_1
{
    internal class Program
    {
        /// <summary>
        /// Minh hoạ việc khởi tạo đối tượng, truy cập các trường và phương thức
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Tạo đối tượng Car
            Car myCar = new Car();
            //Gán giá trị cho các trường của đối tượng
            myCar.make = "Toyota";
            myCar.model = "MR2";
            myCar.color = "black";
            myCar.year = 1997;

            //Hiển thị thông tin về đối tượng myCar
            System.Console.WriteLine("Thong tin chi tiet: ");
            System.Console.WriteLine("Make: " + myCar.make);
            System.Console.WriteLine("Model: " + myCar.model);
            System.Console.WriteLine("Color: " + myCar.color);
            System.Console.WriteLine("Year releas: " + myCar.year);
            //Gọi các phương thức
            myCar.Start();
            myCar.Stop();
        }
    }
}