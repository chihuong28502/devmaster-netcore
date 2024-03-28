using lson09.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace lson09.Controllers
{
    public class LoginController : Controller
    {

        private readonly Lesson09Context _context;

        public LoginController(Lesson09Context context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            // Lấy dữ liệu từ session -> chuyển lên giao diện và hiển thị
            var jsonCustomer = HttpContext.Session.GetString("CustomerLogin");
            if (jsonCustomer != null)
            {
                // Chuyển dữ liệu từ trong session ở dạng json sang đối tượng customer
                var CustomerModel = Newtonsoft.Json.JsonConvert.DeserializeObject<Customer>(jsonCustomer);
                return View(CustomerModel);
            }
            return RedirectToAction("Login");
        }
        [HttpGet]
        public IActionResult Login()
        {
            var modelLogin = new ModelLogin();

            return View(modelLogin);
        }
        [HttpPost]
        public IActionResult Login(ModelLogin modelLogin)
        {
            // Kiểm tra trong db xem có tài khoản, mật khẩu như trên form không?
            // Nếu có thì lưu thông tin đăng nhập vào session

            var dataLogin = _context.Customers.FirstOrDefault(x => 
            x.Username.Equals(modelLogin.UserName) 
            && 
            x.Password.Equals(modelLogin.PassWord));

            if (dataLogin != null)
            {
                ViewBag.Login = "Đăng nhập thành công";
                // Lưu session khi đăng nhập thành công
                var customerLogin = JsonSerializer.Serialize(dataLogin);
                HttpContext.Session.SetString("CustomerLogin", customerLogin);
                return RedirectToAction("Index");
            }

            ViewBag.Login = "Sai thông tin đăng nhập";
            return View(modelLogin);
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("CustomerLogin");

            return RedirectToAction("Login");
        }
    }
}
