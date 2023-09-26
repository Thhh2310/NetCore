using System.Collections;

namespace Lab6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tạo ArrayList
            ArrayList inv = new ArrayList();
            //thêm phần tử vào danh sách
            inv.Add(new Product("A", 5.9, 3));
            inv.Add(new Product("B", 8.4, 2));
            inv.Add(new Product("C", 6.9, 4));
            inv.Add(new Product("D", 2.3, 8));
            inv.Add(new Product("E", 3.5 , 6));
            //in ra danh sách phần tử
            Console.WriteLine("Product list: ");
            foreach (Product i in inv)
            {
                Console.WriteLine("  " + i);
            }
        }
    }
}