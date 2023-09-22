namespace Ex4._1
{
    internal class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("___________Account Manager_______");

            //Nhập số tiền ban đầu
            Console.WriteLine("Enter Intial Balance: ");
            double initalBalance = Convert.ToDouble(Console.ReadLine());

            //tạo tài khoản
            Account account = new Account(initalBalance);

            //gửi tiền
            Console.WriteLine("Enter des");
            double depositAccount = Convert.ToDouble(Console.ReadLine());
            account.WithDraw(depositAccount);

            //rút tiền 
            Console.WriteLine("Enter des");
            double withdrawAccount = Convert.ToDouble(Console.ReadLine());
            
        }
    }
}