namespace Lab7_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tạo mới đối tượng House trong namespace Business
            //bạn có thể using ở trên đầu tệp tin để viết ngắn gọn hơn
            Business.House h = new Business.House();
            //gán thông tin
            h.HouseNo = "D294FF";
            h.Price = 100;
            //in thông tin
            Console.WriteLine("House detail");
            Console.WriteLine("\t House No:" + h.HouseNo);
            Console.WriteLine("\t Price:" + h.Price);

            //tạo mới đối tượng trong namespace Business.Dealership
            //bạn có thể using ở trên đầu tệp tin để viết ngắn gọn hơn
            Business.Dealership.Car c = new Business.Dealership.Car();
            c.CarNo = "A000999";
            c.Price= 386250.50M;
            //in thông tin
            Console.WriteLine("Car detail");
            Console.WriteLine("\t Car No:" + c.CarNo);
            Console.WriteLine("\t Price:" + c.Price);

        }
    }
}