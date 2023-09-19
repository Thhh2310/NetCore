using System.Text;

namespace Vd2._1
{
    internal class Program
    {
        /// <summary>
        /// nhập vào thông tin sinh viên(Id, Name, Address, Birthday, Salary, Bonus)
        /// In ra thông tin nhân viên và thêm trường TotalSalary=Salary+Bonus
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int id;
            string name;
            string address;
            DateTime dob;
            int salary;
            int bonus;
            int TotalSalary;

            Console.WriteLine("Nhập mã sinh viên: ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập tên sinh viên: ");
            name = Console.ReadLine();
            Console.WriteLine("Nhập địa chỉ: ");
            address = Console.ReadLine();
            Console.WriteLine("Nhập ngày tháng năm sinh: ");
            dob= Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Nhập số tiền lương: ");
            salary= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập tiền thưởng: ");
            bonus= Convert.ToInt32(Console.ReadLine());

            //tiền lương + thưởng
            TotalSalary = salary + bonus;

            //In ra thông tin sinh viên
            Console.WriteLine("**********Thông tin sinh viên**********");
            Console.WriteLine("Id: " + id);
            Console.WriteLine("Tên: " + name);
            Console.WriteLine("Địa chỉ: " + address);
            Console.WriteLine("ngày tháng năm sinh: " + dob.ToString("dd-MM-yyyy"));
            Console.WriteLine("Tiền lương: " + salary);
            Console.WriteLine("Tiền thưởng: " + bonus);
            Console.WriteLine("Tiền lương + thưởng: " + TotalSalary);
        }
    }
}