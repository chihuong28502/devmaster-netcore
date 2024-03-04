using Lab03.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab03.Controllers
{
    public class BookController1 : Controller
    {
        protected Book book = new Book();
        public IActionResult Index()
        {
            ViewBag.authors = book.Authors;
            ViewBag.genres = book.Genres;
            var model= book.GetBookList();

            return View(model);// truyền data lên view qua tham số
        }
        public IActionResult Create()
        {
            ViewBag.authors = book.Authors; 
            ViewBag.genres = book.Genres;
            var model = book.GetBookList();
            return View(model);// truyền data lên view qua tham số
        }
        public IActionResult Edit(int id) {
            ViewBag.authors = book.Authors;
            ViewBag.genres = book.Genres;
            var model = book.GetBookById(id);
            return View(model);
        }
        public PartialViewResult PopularBook()
        {
            var books = book.GetBookList();
            return PartialView(books);

        }
    }
}
