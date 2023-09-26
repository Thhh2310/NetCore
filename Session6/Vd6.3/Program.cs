using System.Text;

namespace Vd6._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //tạo danh sách lưu trữ danh sách 10 car
            List<Car> carList = new List<Car>()
            {
                new Car{name = "car 1", color = "red"},
                new Car{name = "car 2", color = "pink"},
                new Car{name = "car 3", color = "yellow"},
                new Car{name = "car 4", color = "green"},
                new Car{name = "car 5", color = "blue"},
                new Car{name = "car 6", color = "gray"},
                new Car{name = "car 7", color = "white"},
                new Car{name = "car 8", color = "red"},
                new Car{name = "car 9", color = "black"},
                new Car{name = "car 10", color = "violet"},
            };

            //xoá car
            Console.Write("Nhập màu muốn xoá: ");
            string colorToDelete = Console.ReadLine();

            carList.RemoveAll(car => car.color.ToLower() == colorToDelete.ToLower());

            //In danh sách Car còn lại
            Console.WriteLine("\nDanh sách Car còn lại sau khi xoá: ");
            foreach (Car car in carList) 
            { 
                Console.WriteLine("Name: " + car.name + ", Color: " + car.color); 
            }
        }
    }
}