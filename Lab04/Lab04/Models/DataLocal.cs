namespace Lab04.Models
{
    /// <summary>
    /// DataLocal: chứa dữ liệu và các phương thức thực hiện các chức năng CRUD
    /// </summary>
    public class DataLocal
    {
        public static List<People> _peoples= new List<People>()
        {
            new People()
            {
                Id = 1,
                Name = "JungKook",
                Email = "jk123@gmail.com",
                Phone = "0973652475",
                Address = "Seoul",
                Avatar = "images/avatar/jk.jpg",
                Birthday = Convert.ToDateTime("1997/09/01"),
                Bio = "Soái, nhìu...",
                Gender = 0,
            },
            new People()
            {
                Id = 2,
                Name = "Taehyung",
                Email = "tae123@gmail.com",
                Phone = "0387197634",
                Address = "Seoul",
                Avatar = "images/avatar/TaeV.jpg",
                Birthday = Convert.ToDateTime("1995/05/23"),
                Bio = "Soái, nhìu...",
                Gender = 0,
            },
            new People()
            {
                Id = 3,
                Name = "JK",
                Email = "kk333@gmail.com",
                Phone = "0386156758",
                Address = "Seoul",
                Avatar = "images/avatar/jki.jpg",
                Birthday = Convert.ToDateTime("1998/10/01"),
                Bio = "Soái, nhìu...",
                Gender = 0,
            },
            new People()
            {
                Id = 4,
                Name = "Jeikei",
                Email = "koki666@gmail.com",
                Phone = "0345679276",
                Address = "Seoul",
                Avatar = "images/avatar/jekey.jpg",
                Birthday = Convert.ToDateTime("1997/09/23"),
                Bio = "Soái, nhìu...",
                Gender = 0,
            },
            new People()
            {
                Id = 5,
                Name = "kookies",
                Email = "kki1997@gmail.com",
                Phone = "0572658476",
                Address = "Seoul",
                Avatar = "images/avatar/kooki.jpg",
                Birthday = Convert.ToDateTime("1995/09/01"),
                Bio = "Soái, nhìu...",
                Gender = 0,
            },
            new People()
            {
                Id = 6,
                Name = "corgi",
                Email = "cg123@gmail.com",
                Phone = "0387946784",
                Address = "Seoul",
                Avatar = "images/avatar/corgi.jpg",
                Birthday = Convert.ToDateTime("1992/04/04"),
                Bio = "Soái, nhìu...",
                Gender = 1,
            },
        };

        //GetPeoples: lấy danh sách dữ liệu peoples
        public static List<People> GetPeoples()
        {
            return _peoples;
        }

        //GetPeopleById: lấy đối tượng peoples theo Id
        public static People? GetPeopleById(int Id)
        {
            var people = _peoples.FirstOrDefault(x => x.Id == Id);
            return people;
        }
    }
}
