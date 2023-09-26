using System.Collections;
using System.Text;

namespace Vd6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //tạo một Hashtable
            Hashtable weekDays = new Hashtable();

            //thêm các ngày trong tuần vào Hashtable
            weekDays.Add(1, "Monday");
            weekDays.Add(2, "Tuesday");
            weekDays.Add(3, "Wendesday");
            weekDays.Add(4, "Thursday");
            weekDays.Add(5, "Friday");
            weekDays.Add(6, "Saturday");
            weekDays.Add(7, "Sunday");

            //nhập ngày cần tìm
            Console.Write("Nhập ngày cần tìm: ");
            string dayToFind = Console.ReadLine();

            //kiểm tra xem ngày có tồn tại trong hashtable ko
            if (weekDays.ContainsValue(dayToFind))
            {
                Console.WriteLine("Ngày {0} đã đc tìm thấy", dayToFind);
            }
            else
            {
                Console.WriteLine("Không tìm thấy ngày " + dayToFind);
            }

            //in ra các ngày trong tuần bao gôm cả key và value
            Console.WriteLine("\nCác ngày trong tuần: ");
            foreach (DictionaryEntry weekDay in weekDays)
            {
                Console.WriteLine("Key: {0}, Value: {1}", weekDay.Key, weekDay.Value);
            }
        }
    }
}