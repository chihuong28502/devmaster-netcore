using ls4.Models.DataModels;
using Microsoft.AspNetCore.Mvc;

namespace ls4.Controllers
{
    public class MemberController : Controller
    {
        public IActionResult Index()
        {
            var member = new Member()
            {

                MemberId = Guid.NewGuid().ToString(),
                Username = "Chung chung",
                FullName = "full name",
                Password = "pass",
                Email = "bigang02xz"
            };
            ViewBag.Member = member;
            return View(member);
        }
        public IActionResult GetListMember() {
            var list = new List<Member>()
            {

            };
        return View();
        }
        public IActionResult Create() {
            var model = new Member();
            return View(model);
        }
    }
}
