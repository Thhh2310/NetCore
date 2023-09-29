//sử dụng namespace
using Store;
namespace Lab01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tạo mới nhà phân phối cung cấp đầy đủ namespace
            Supply.Manufacturer dealer = new Supply.Manufacturer();
            //gán giá trị
            dealer.Name = "Coca";
            dealer.Email = "cola23@gmail.com";
            dealer.Phone = "84798274832";
            //in thông tin
            Console.WriteLine("Dealer information");
            Console.WriteLine("\t Name: " + dealer.Name);
            Console.WriteLine("\t Email: " + dealer.Email);
            Console.WriteLine("\t Phone: " + dealer.Phone);

            //tạo mới sản phẩm nằm trong namespace Store
            StoreItem si = new StoreItem();
            //gán giá trị
            si.ItemNo = 613508;
            si.ItemName = "Fanta";
            si.Price = 10.00M;
            //in thông tin
            Console.WriteLine("Store Inventory");
            Console.Write("\t Item #: ");
            Console.WriteLine(si.ItemNo);
            Console.Write("\t Item Name: ");
            Console.WriteLine(si.ItemName);
            Console.Write("\t Unit Price: ");
            Console.WriteLine(si.Price);

            Console.Read();
        }
    }
}