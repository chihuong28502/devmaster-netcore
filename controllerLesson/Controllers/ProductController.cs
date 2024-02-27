using controllerLesson.Models;
using Microsoft.AspNetCore.Mvc;

namespace controllerLesson.Controllers
{
    [Route("danh-sach-san-pham")]
    public class ProductController : Controller
    {
            [Route("index")]
        public IActionResult Index()
        {
            // dữ liệu từ controller ra view
            ViewBag.product = "dữ liệu trong view bag";
            ViewData["ProductVD"] = "dữ liệu trong viewdata";
            TempData["messageVD"] = "Thông báo dữ liệu từ temp data";
            // Trả về view trong thư mục views/products/index.cshtml
            return View();
        }
        public IActionResult GetProduct() {
            // dạng obj
            Product p = new Product()
            {
                Id = 1,
                Name = "test name"
            };
            ViewBag.product = p;
            return View();
        }
        [Route("tat-ca")] 
        
        public IActionResult GetAllProduct()
        {
            List<Product> products = new List<Product>() {
            new Product() {
            Id=1,Name="item1"
            }, new Product() {
            Id=1,Name="item1"
            }, new Product() {
            Id=1,Name="item1"
            }, new Product() {
            Id=1,Name="item1"
            }, new Product() {
            Id=1,Name="item1"
            },
            };
            ViewData["list"] = products;
            //trả về
            return View("Products");
        }
    }
}
