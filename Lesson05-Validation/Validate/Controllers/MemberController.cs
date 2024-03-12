using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;
using Validate.Models.DataModels;

namespace Validate.Controllers
{
    public class MemberController : Controller
    {
        private static List<Member> members = new List<Member>() { 
            new Member()
            {MemberId=Guid.NewGuid().ToString(),
                UserName="dev1",Password="dev1",
                FullName="devmaster",Email="bigbang02xz@gmail.com",
                Phone="0979756291",Birthday=DateTime.Parse("2013/09/22")},
        };
        
        // GET: MemberController
        public ActionResult Index()
        {
            return View(members);
        }

        // GET: MemberController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MemberController/Create
        public ActionResult Create()
        {
            var member = new Member();

           
            return View(member);
        }

        // POST: MemberController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Member member)
        {
            //check data
            string msg = "";
            bool validate = true;
            if(member.UserName == null)
            {
                validate = false;
                msg = "<li> tk phải có độ dài trong khoảng 3 -> 10 kí tự </li>";
            }else
            if(member.UserName.Length<=3 || member.UserName.Length > 10)
            {
                validate = false;
                msg = "<li> tk phải có độ dài trong khoảng 3 -> 10 kí tự </li>";
            }

            string patterEmail = @"[a-z0-9._]+[a-z0-9_]+@[a-z0-9-_]+\.[a-z]{2,4}$";
            if(member.Email == null) {
                validate = false;
                msg = "<li>Email sai định dạng</li>";
            }
            else
            if (!Regex.IsMatch(member.Email, patterEmail))
            {
                validate=false;
                msg = "<li>Email sai định dạng</li>";
            }
            if (validate == true)
            {
                member.MemberId = Guid.NewGuid().ToString();
                members.Add(member);
                return RedirectToAction("Index");
            }
            msg = "<div class='alert alert-danger'>" + msg + "</div>";
            ViewBag.msg = msg;
                return View(member);
        }

        // GET: MemberController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MemberController/Edit/5
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

        // GET: MemberController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MemberController/Delete/5
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
