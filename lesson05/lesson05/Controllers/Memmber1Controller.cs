using lesson05.Models.DataModels;
using lesson05.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace lesson05.Controllers
{
    public class Memmber1Controller : Controller
    {
        // GET: Memmber1Controller
        public static List<Member> _members = new List<Member>();
        public ActionResult Index()
        {
            List<MemberView?> list = new List<MemberView?>();
            foreach (var item in _members)
            {
                var model = new MemberView()
                {
                    MemberId= item.MemberId,
                    UserName = item.UserName,
                    FullName= item.FullName,
                    Password= item.Password,
                    Email= item.Email,
                    Phone= item.Phone,
                    Birthday= item.Birthday,
                };
            }
            return View(list);
        }

        // GET: Memmber1Controller/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Memmber1Controller/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Memmber1Controller/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MemberView member)
        {
            if (ModelState.IsValid)
            {
                var model = new Member()
                {
                    MemberId= Guid.NewGuid().ToString(),
                    UserName= member.UserName,
                    FullName= member.FullName,
                    Password= member.Password,
                    Email= member.Email,
                    Phone= member.Phone,
                    Birthday= member.Birthday,
                };
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(member);
            }
            
        }

        // GET: Memmber1Controller/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Memmber1Controller/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Memmber1Controller/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Memmber1Controller/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
