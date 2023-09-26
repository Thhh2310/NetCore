namespace Lab5_2
{
    internal class Program
    {
        /// <summary>
        /// Chương trình minh hoạ một số thao tác trên mảng 2 chiều
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Khai báo và khởi tạo mảng
            int[,] a =
            {
                {4, 6, 9 },
                {2, 4, 5 },
                {8, 2, 6 },
                {1, 6, 3 }
            };
            //Duyệt mảng và in theo hàng cột
            Console.WriteLine("Noi dung mang: ");
            for ( int i = 0; i < a.GetUpperBound(0); i++ )
            {
                Console.WriteLine();
                for (int j = 0; j <= a.GetUpperBound(1); j++ )
                {
                    Console.Write(" {0} ", a[i, j]);
                }
                Console.WriteLine();
            }
            //tìm các phần tử có chỉ số hàng bằng chỉ số cột
            Console.Write("Cac phan tu co chi so hang bang chi so cot: ");
            for (int i = 0; i <= a.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= a.GetUpperBound(1); j++)
                {
                    if ( i == j)
                        Console.Write(" {0} ", a[i, j] );
                }
            }
            //các phần tử lớn nhất trên hàng
            Console.WriteLine("\nCac phan tu lon nhat tren hang");
            for (int i = 0; i <= a.GetUpperBound(0); i++)
            {
                int max = a[i, 0];
                for (int j = 0; j <= a.GetUpperBound(1); j++)
                {
                    if (max < a[i, j])
                        max = a[i, j];
                }
                Console.WriteLine("Hang {0}:{1}", i, max);
            }
        }
    }
}