using lesson05.Models.DataModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;

namespace lesson05.Controllers
{
    public class MemmberController : Controller
    {
        // GET: MemmberController
        public static List<Member> list = new List<Member>();
        public ActionResult Index()
        {
            return View(list);
        }

        // GET: MemmberController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MemmberController/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: MemmberController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Member member)
        {
            //Menual Validation
            string msg = "";
            bool validate = true;
            //kiểm tra username: 3-20
            if(member.UserName.Length <3 || member.UserName.Length > 20)
            {
                msg = "<li> UseName phải có độ dài từ 3 - 20 ký tự </li>";
                validate = false;
            }
            //kiểm tra email đúng định dạng
            string patternEmail = @"[a-zA-Z0-9._+-]+@[a-z0-9._]+\.[a-z]{2,4}$";
            if(!Regex.IsMatch(member.Email, patternEmail))
            {
                msg = "<li> Email chưa đúng định dạng (example@gmail.com) </li>";
                validate |= false;
            }
            //kiểm tra năm sinh phải đủ 18 tuổi 
            if (member.Birthday.Value.AddYears(18) > DateTime.Now)
            {
                msg += "<li> Bạn chưa đủ 18 tuổi </li>";
                validate = false;
            }
            //kiểm tra đt phải là số
            string patternPhone = @"^0\d{9,11}$";
            if(!Regex.IsMatch(member.Phone, patternPhone))
            {
                msg += "<li> Điện thoại chưa đúng </li>";
                validate = false;
            }

            if (validate == true)
            {
                member.MemberId = Guid.NewGuid().ToString();
                list.Add(member);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                ViewBag.msg = "<div class='alert alert-danger'>" + msg + "</div>";
                return View(member);
            }
        }

        // GET: MemmberController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MemmberController/Edit/5
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

        // GET: MemmberController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MemmberController/Delete/5
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
