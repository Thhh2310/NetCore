namespace Lab5_1
{
    internal class Program
    {
        /// <summary>
        /// Thao tác với mảng 1 chiều
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //khai báo và khởi tạo mảng 1 chiều
            int[] m = { 1, 3, 5, 7, 9 };
            //duyệt mảng và in ra dữ liệu
            Console.Write("Cac phan tu cua mang: ");
            for ( int i = 0; i < m.Length; i++)
            {
                Console.Write(" {0} ", m[i]);
            }
            //tìm phần tử lớn nhất
            int max = m[0];
            for (int i = 0; i < m.Length; i++)
            {
                if (max < m[i])
                    max = m[i];
            }
            Console.WriteLine("\nPhan tu lơn nhat: " + max);
            //Kiểm tra mảng đối xứng không?
            bool kt = true;
            for (int i = 0; i < m.Length / 2; i++)
            {
                if (m[i] != m[m.Length - 1 - i]) 
                { 
                    kt = false;
                    break;
                }
            }
            if (kt)
                Console.WriteLine("Mang doi xung");
            else
                Console.WriteLine("Mang khong doi xung");
        }
    }
}