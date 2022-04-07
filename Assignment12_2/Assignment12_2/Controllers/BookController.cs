using Microsoft.AspNetCore.Mvc;
using Assignment12_2.Models;

namespace Assignment12_2.Controllers
{
    public class BookController : Controller
    {
        private IBookRepository _bookRepository;
        public BookController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository; //dependency injection
        }
        public IActionResult Details(int? id)
        {
            var model = _bookRepository.GetBook(id);
            if (model==null)
            {
                return NotFound();
            }
            return View(model);
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Index()
        {
            IndexViewModel model = new IndexViewModel();
            model.Books = _bookRepository.InitializeData();
            return View(model);
        }
    }
}
