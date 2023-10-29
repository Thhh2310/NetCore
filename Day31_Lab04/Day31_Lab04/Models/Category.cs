namespace Day31_Lab04.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public bool Status { get; set; }

        //thuộc tính quan hệ
        public ICollection<Product> Product { get; set;} = new List<Product>();
    }
}
