using Lab02.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab02.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            List<Account> accounts = new List<Account>
            {
                new Account()
                {
                    Id = 1,
                    Name = "Jung Kook",
                    Email = "jk123@gmail.com",
                    Phone = "0973654727",
                    Address = "Hà Nội",
                    Avatar = Url.Content("~/Avatar/01.png"),
                    Gender = 1,
                    Bio = "My mane is JeKey",
                    Birthday = new DateTime(1997,9,1)
                },
                new Account()
                {
                    Id = 2,
                    Name = "Teahyung",
                    Email = "v234@gmail.com",
                    Phone = "0937258197",
                    Address = "Hà Nam",
                    Avatar = Url.Content("~/Avatar/02.png"),
                    Gender = 1,
                    Bio = "My mane is V",
                    Birthday = new DateTime(1995,8,5)
                },
                new Account()
                {
                    Id = 3,
                    Name = "Suga",
                    Email = "a345123@gmail.com",
                    Phone = "096486527",
                    Address = "Hà Nội",
                    Avatar = Url.Content("~/Avatar/03.png"),
                    Gender = 1,
                    Bio = "My mane is AugustD",
                    Birthday = new DateTime(1992,10,6)
                },
            };
            ViewBag.Accounts = accounts;
            return View();
        }

        //định nghĩa url và nam cho action
        [Route("ho-so-cua-toi", Name = "profile")]
        public IActionResult Profile(int id) 
        {
            //danh sách Account như trên Action Index
            List<Account> accounts = new List<Account>
            {
                new Account()
                {
                    Id = 1,
                    Name = "Jung Kook",
                    Email = "jk123@gmail.com",
                    Phone = "0973654727",
                    Address = "Hà Nội",
                    Avatar = Url.Content("~/Avatar/01.png"),
                    Gender = 1,
                    Bio = "My mane is JeKey",
                    Birthday = new DateTime(1997,9,1)
                },
                new Account()
                {
                    Id = 2,
                    Name = "Teahyung",
                    Email = "v234@gmail.com",
                    Phone = "0937258197",
                    Address = "Hà Nam",
                    Avatar = Url.Content("~/Avatar/02.png"),
                    Gender = 1,
                    Bio = "My mane is V",
                    Birthday = new DateTime(1995,8,5)
                },
                new Account()
                {
                    Id = 3,
                    Name = "Suga",
                    Email = "a345123@gmail.com",
                    Phone = "096486527",
                    Address = "Hà Nội",
                    Avatar = Url.Content("~/Avatar/03.png"),
                    Gender = 1,
                    Bio = "My mane is AugustD",
                    Birthday = new DateTime(1992,10,6)
                },
            };
            //sử dụng using System.Linq; truy xuất dữ liệu 1 đối tượng trong danh sách theo id
            Account account = accounts.FirstOrDefault(ac => ac.Id == id);
            //gửi đối tượng account qua view
            ViewBag.account = account;
            return View(); 
        }
    }
}
