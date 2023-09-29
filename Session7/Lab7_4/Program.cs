namespace Lab7_4
{
    //định nghĩa lớp custom ngoại lệ chỉ cho nhập số nguyên dương
    public class InvalidInputNumber : Exception
    {
        public InvalidInputNumber() 
            : base("Hay nhap 1 so >0") { }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int intCnt;
            int intNum = 0;
            Console.Write("Nhap 1 so :");
            //nhập va tung ngoại lệ
            try
            {
                intNum = Convert.ToInt32(Console.ReadLine());
                if (intNum <= 0)
                {
                    throw new InvalidInputNumber();
                }
            }
            catch (InvalidInputNumber objInvalidInput)
            {
                Console.WriteLine(objInvalidInput.Message);
            }
            catch (System.FormatException objFomatException)
            {
                Console.WriteLine(objFomatException.Message);
            }
            finally
            {
                if (intNum >0 )
                {
                    //in ra số *100
                    for (intCnt = 1; intCnt <= 10; intCnt++)
                        Console.WriteLine(intCnt * intNum);
                }
            }
            Console.ReadLine();
        }
    }
}