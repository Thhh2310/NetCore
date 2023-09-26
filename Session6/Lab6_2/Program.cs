namespace Lab6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tạo sortedlist generic
            SortedList<String, string> listEm= new SortedList<String, string>();
            //Đưa dữ liệu vào
            listEm.Add("E01", "TRAN THI THUY");
            listEm.Add("E02", "LE HAI HA");
            listEm.Add("E03", "NGUYEN VAN HUNG");
            listEm.Add("E04", "THAM THI THOM");
            listEm.Add("E05", "TRINH VAN CHIEN");
            //in ra danh sách
            Console.WriteLine("Danh sach nhan vien");
            foreach (var key in listEm.Keys)
            {
                Console.WriteLine(key + ":" + listEm[key]);
            }
            //tìm kiếm tất cả nhân viên có tên bắt đầu bằng chữ TH
            Console.WriteLine("Danh sach nhan vien bbat dau bang chu TH");
            foreach (var key in listEm.Keys)
            {
                if (listEm[key].StartsWith("TH"))
                    Console.WriteLine(key + ":" + listEm[key]);
            }
            //xoá nhân viên có mã E04
            listEm.Remove("E04");
            //Kiểm tra nếu chưa có nhân viên E06 thì thêm vào
            if (!listEm.ContainsKey("E06"))
                listEm.Add("E06", "NGUYEN HOAI LINH");
            //in ra danh sách sau khi xoa, them
            Console.WriteLine("Danh sach nhan vien sau khi them, xoa");
            foreach (var key in listEm.Keys) 
            {
                Console.WriteLine(key + ":" + listEm[key]);
            }
        }
    }
}