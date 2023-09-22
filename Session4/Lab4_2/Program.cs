namespace Lab4_2
{
    internal class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Khởi tạo sinh viên cao đẳng và in ra thông tin
            Console.WriteLine("Student of College:");
            StudentCollege sv1 = new StudentCollege("Hanh", 1992, 9.5, 8, 5);
            sv1.Display();
            Console.WriteLine("Average of score: {0}", sv1.Average());

            //Khởi tạo sinh viên đại học và in ra thônh tin
            Console.WriteLine("Student of University:");
            StudentCollege sv2 = new StudentUniversity("Thanh", 19999, 9, 5, 7, 5);
            sv2.Display();
            Console.WriteLine("Average of score: {0}", sv2.Average());
        }
    }
}