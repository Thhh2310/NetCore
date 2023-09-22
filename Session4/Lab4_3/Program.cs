namespace Lab4_3
{
    internal class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Khởi tạo hình chữ nhật
            Rectangle rec = new Rectangle();
            //nhập dữ liệu
            rec.InputData();
            //in thông tin
            Console.WriteLine("Dien tich hinh chu nhat la: {0:N}", rec.Area());
            Console.WriteLine("Chu vi hinh chu nhat la: {0:N}", rec.Circumference());
            //khởi tạo hình tròn
            Circle circle= new Circle();
            //nhập dữ liệu
            circle.InputData();
            //in thông tin
            Console.WriteLine("Dien tich hinh tron la: {0:N}", circle.Area());
            Console.WriteLine("Chu vi hinh tron la: {0:N}", circle.Circumference());
        }
    }
}